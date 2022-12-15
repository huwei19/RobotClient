using System.Collections;
using System.Collections.Generic;
using ProtobufPacket;
using System;
using LiteNet;
using System.IO;
using Games.Table;
using System.Linq;

public class StateChapter : FSMState<Robot>
{
    public enum STEP
    {
        NONE,
        BEGIN,              //初始

        LEVEL_START,        //等待开始返回 
        LEVEL_START_OK,     //收到服务器回包startlevel ok
        LEVEL_START_FAIL,   //超时 or 失败

        LEVEL_RUNNING,      //模拟调查过程
        LEVEL_RUNNING_ERROR,//模拟过程出错

        LEVEL_FINISH,       //等待结算返回
        LEVEL_FINISH_OK,    //成功结算
        LEVEL_FINISH_FAIL,  //结算失败

        RESOLVEEND,         //一章打完，解谜结局 等待服务器返回
        RESOLVEEND_OK,      //解结局成功
        RESOLVEEND_FAIL,    //解结局失败

        REWIND,             //回溯 等待服务器返回
        REWIND_OK,          //回溯成功
        REWIND_FAIL,        //回溯失败

        SAVEPOINT,        //保存点------>传递保存点 数据， 没有回调，只需要传递服务器一次就可以
        SAVEPOINT_ING,     //保存点 等待服务器回调中
        SAVEPOINT_OK,        //保存点 成功接收服务器信息 
        SAVEPOINT_FAIL,        //保存点 失败

        IDLE,
    }

    public const int LEVEL_FINISH_FAILED_LIMIT = 5;    //finishlevel 失败超过此次数，重新随机章

    private STEP m_nPreStep = STEP.NONE;
    private STEP m_nCurStep = STEP.NONE;
    private int FailedCount { get; set; } //一章中levelfinish失败的次数  超过一定值重新随机章

    public RESULT Result { get; set; }
    private List<int> ChapterIds = new List<int>();

    public int ChapterId { get; set; }
    public int LevelId { get; set; }

    //卡牌先固定
    public List<int> CardIds = new List<int> { 1, 11, 19, 28, 3 };

    public const int INTERVAL_TIMEOUT = 3;          //网络超时

    DateTime m_fStepStartTime = new DateTime();

    int m_WaitMilliseconds = 0;
    DateTime m_WaitStartTime = DateTime.Now;
    bool m_IsWaiting = false;

    public override string getName()
    {
        return "(章节/主线、暗线) Chapter";
    }

    public override void onEnter(Robot entity)
    {
        ChapterIds.Clear();
        // 1 解锁所有章 
        foreach (var v in TableManager.GetStoryChapter())
        {
            var tLine = TableManager.GetStoryLineByID(v.Value[0].StoryLineId);
            if (tLine == null)
                continue;

            //只打主线和暗线-------------->  tabStoryChapter表id的  1-60
            if (tLine.Type != 0 && tLine.Type != 1 && tLine.Type != 3)
                continue;

            entity.SendCMD("storyu," + v.Value[0].Id);
            ChapterIds.Add(v.Value[0].Id);
        }

        // 2.体力
        entity.SendCMD("item,3,10000000000");
        entity.SendCMD("item,4,10000000000");
        if (investigation.m_npcstate.Count <= 0)
        {
            investigation.m_npcstate.Add(NPCState.NPCS_NONE);
            investigation.m_npcstate.Add(NPCState.NPCS_DEAD);
            investigation.m_npcstate.Add(NPCState.NPCS_CRAZY);
            investigation.m_npcstate.Add(NPCState.NPCS_DIZZY);
            investigation.m_npcstate.Add(NPCState.NPCS_MIND);
            investigation.m_npcstate.Add(NPCState.NPCS_RELEASE);
        }

        //卡牌解锁
        Dictionary<int, List<Tab_Card>> tabCard = TableManager.GetCard();
        foreach (var item in tabCard)
        {
            if (item.Value[0].StarMax == 6)
            {
                entity.SendCMD("card," + item.Value[0].Id + ",1,80,6");
            }
        }

        //进入 begin阶段
        SetStep(entity, STEP.BEGIN);
    }

    //准备
    public void PrepareSuper(Robot entity)
    {
        //  加点体力
        entity.SendCMD("item,3,500");
    }

    public void NextChapter(Robot entity)
    {
        if (ChapterIds.Count <= 0)
        {
            ChapterId = 1;
            return;
        }
        int nOldChapter = ChapterId;
        int nOldLevelId = LevelId;
        int index = ChapterIds.IndexOf(nOldChapter);
        if (index < 0)
        {
            return;
        }

        if (index >= ChapterIds.Count - 1)
        {
            ChapterId = 1;
            return;
        }

        index++;
        ChapterId = ChapterIds[index];
        LevelId = entity.mStoryData.GetNextLevelId(ChapterId);

        entity.LogFormat("nextChapter: chapter:{0}-->{1}, level:{2}-->{3} failedcount:{4} state:{5}", nOldChapter, ChapterId, nOldLevelId, LevelId, FailedCount, entity.mStoryData.GetChapterState(ChapterId));
        FailedCount = 0;
    }

    public override void onExecute(Robot entity)
    {
        //时间冷却
        if (!isRun())
        {
            return;
        }
        if (m_IsWaiting && (DateTime.Now - m_WaitStartTime).TotalMilliseconds < m_WaitMilliseconds)
        {
            return;
        }
        m_IsWaiting = false;
        
        switch (m_nCurStep)
        {
            case STEP.BEGIN:
                {
                    if (FailedCount > LEVEL_FINISH_FAILED_LIMIT)
                    {
                        NextChapter(entity);
                    }

                    if (Result == RESULT.PUZZLE_LEVEL_NO_STAMINA || Result == RESULT.LEVEL_START_NO_STAMINA)
                    {
                        //加体力
                        PrepareSuper(entity);
                    }

                    //判定章节是否完成，完成就回溯
                    if (entity.mStoryData.GetChapterState(ChapterId) == (int)_StoryEnum.ChapterStatus.Finished)
                    {
                        //已经打完了 回溯到最开始  -----> OnReceiveMessage CG_STORY_CHAPTER_REWIND 的回包处理
                        entity.RewindFirst(ChapterId);
                        SetStep(entity, STEP.REWIND);
                    }
                    else
                    {
                        //最先开始的为第一章
                        if (ChapterId <= 0)
                        {
                            ChapterId = entity.mStoryData.GetLastChapterId(ChapterIds);
                        }
                        LevelId = entity.mStoryData.GetNextLevelId(ChapterId);
                        if (LevelId == -1)
                        {
                            entity.LogFormat("get next level error.");
                            FailedCount++;
                            return;
                        }

                        //进入下一关 发送了服务器请求，后面会接收服务器的回调，然后进入下一阶段  ---->OnReceiveMessage CG_STORY_LEVEL_START 的回包处理
                        entity.StartLevel(LevelId, CardIds);
                        SetStep(entity, STEP.LEVEL_START);
                    }
                }
                break;
            case STEP.LEVEL_START_OK:
                {
                    //收到服务器回包，成功开始调查, 开始模拟调查过程  --->模拟调查过程最后 会将mStoryLogic的 IsFinish 置为true
                    entity.mStoryLogic.StartLevel(entity, LevelId);

                    var tLevel = TableManager.GetStoryChapterLevelByID(LevelId);
                    if (tLevel != null && tLevel.LevelType == (int)_StoryEnum.LevelType.Ending)
                    {
                        entity.ResolveEnding(ChapterId); //发结算包
                        SetStep(entity, STEP.RESOLVEEND);
                    }
                    else
                    {
                        SetStep(entity, STEP.SAVEPOINT); //成功开始调查，首先保存下点
                    }
                }
                break;
            case STEP.LEVEL_START_FAIL:
                {
                    FailedCount++;
                    //SetStep(entity, STEP.BEGIN);
                }
                break;
            case STEP.LEVEL_RUNNING:
                {
                    //if (entity.mStoryLogic.IsRunning())
                    //{
                    //    entity.mStoryLogic.Tick();
                    //}
                    if (entity.mStoryLogic.IsFinish())
                    {
                        //调查模拟完成， 发结束包，请求结算 --------> 请求关卡结算的回包处理 OnReceiveMessage CG_STORY_LEVEL_FINISH
                        entity.FinishLevel(LevelId, _StoryEnum.LevelResult.Succ);
                        SetStep(entity, STEP.LEVEL_FINISH);
                    }
                    else
                    {
                        entity.LogFormat("storylogic error. state:{0}", entity.mStoryLogic.SState);
                        //不明原因失败了，退出关卡
                        entity.FinishLevel(LevelId, _StoryEnum.LevelResult.Quit);
                        SetStep(entity, STEP.LEVEL_FINISH);
                    }
                }
                break;

            case STEP.SAVEPOINT:  //进入开始 保存点操作
                {
                    var pData = Games.Table.TableManager.GetStoryChapterLevelByID(LevelId);
                    if (pData != null)
                    {
                        var pChapter = Games.Table.TableManager.GetStoryChapterByID(pData.StoryChapterId);
                        if (pChapter != null)
                        {
                            var tLine = TableManager.GetStoryLineByID(pChapter.StoryLineId);
                            if (tLine != null && (tLine.Type == 0 || tLine.Type == 1))
                                entity.SavePoint(LevelId);     //向服务器调用一次保存事件
                        }
                    }

                    entity.mStoryLogic.PrepareToFinish();
                    SetStep(entity, STEP.LEVEL_RUNNING);  //等待回包
                }
                break;
            case STEP.SAVEPOINT_OK:  // 保存点 成功
            case STEP.SAVEPOINT_FAIL:
            case STEP.LEVEL_RUNNING_ERROR:
                {
                    //不明原因失败了，退出关卡
                    entity.FinishLevel(LevelId, _StoryEnum.LevelResult.Quit);
                }
                break;

            case STEP.LEVEL_START: //等待开启关卡
            case STEP.LEVEL_FINISH: //等待结算回包
            case STEP.REWIND:       //等待回溯回包
            case STEP.SAVEPOINT_ING: //等待保存点回包
            case STEP.RESOLVEEND:   //等待解谜回包
                {
                    //int timeDiff = GetTimeDiffSecnds(DateTime.Now, m_fStepStartTime);
                    ////等服务器回包
                    //if (timeDiff > INTERVAL_TIMEOUT)
                    //{
                    //    //10s还没回包 失败
                    //    SetStep(entity, m_nCurStep + 2);
                    //}
                }
                break;
            case STEP.LEVEL_FINISH_OK:
                {
                    //start后，1-5分钟(随机)后发送finish
                    m_IsWaiting = true;
                    m_WaitMilliseconds = new Random().Next(1 * 60 * 1000, 5 * 60 * 1000);
                    m_WaitStartTime = DateTime.Now;
                    entity.LogFormat("finish level wait time {0} s:", m_WaitMilliseconds / 1000);

                    //收到服务器结束回包  完成一个关卡 进入下一个关卡 
                    var levelData = Games.Table.TableManager.GetStoryChapterLevelByID(LevelId);
                    if (levelData == null)
                    {
                        FailedCount++;
                        SetStep(entity, STEP.BEGIN);
                        return;
                    }

                    if (levelData.LevelType == (int)_StoryEnum.LevelType.Ending && entity.mStoryData.IsChapterGetAllEnding(ChapterId))
                    {
                        NextChapter(entity);
                        SetStep(entity, STEP.BEGIN);
                    }
                    else
                    {
                        if (entity.mStoryData.GetChapterState(ChapterId) == (int)_StoryEnum.ChapterStatus.Finished)
                        {
                            //已经打完了 回溯到最开始  -----> OnReceiveMessage CG_STORY_CHAPTER_REWIND 的回包处理
                            entity.RewindFirst(ChapterId);
                            SetStep(entity, STEP.REWIND);
                        }
                        else
                        {
                            LevelId = entity.mStoryData.GetNextLevelId(ChapterId);
                            SetStep(entity, STEP.BEGIN);
                        }
                    }
                }
                break;
            case STEP.LEVEL_FINISH_FAIL:
                {
                    FailedCount++;
                    //失败了,可能上关没拿够线索 回溯
                    //entity.RewinLast(ChapterId);
                    //SetStep(entity, STEP.BEGIN);
                }
                break;
            case STEP.REWIND_OK:
                SetStep(entity, STEP.BEGIN);
                break;
            case STEP.REWIND_FAIL:
                {
                    if (m_nCurStep == STEP.REWIND_FAIL) FailedCount++;
                    //SetStep(entity, STEP.BEGIN);
                }
                break;
            case STEP.RESOLVEEND_FAIL:
                {
                    FailedCount++;
                    //entity.RewinLast(ChapterId);
                    //SetStep(entity, STEP.BEGIN);
                }
                break;
            case STEP.RESOLVEEND_OK:
                {
                    //章解完结局了
                    //随机下一章 继续打
                    entity.mStoryLogic.PrepareToFinish();
                    entity.FinishLevel(LevelId, _StoryEnum.LevelResult.Succ);
                    SetStep(entity, STEP.LEVEL_FINISH);
                }
                break;
        }
        return;
    }

    /// <summary>
    /// 收到 startlevel 服务器回调，就更新当前状态
    /// </summary>
    /// <param name="entity"></param>
    /// <param name="packet"></param>
    public void OnReceiveMessage(Robot entity, GC_STORY_LEVEL_START packet)
    {
        entity.Log("--- 开始调查收到回包--- " + packet.Result);
        //请求开始调查 返回
        entity.LogFormat("level start respons: level:{0}, ret:{1}", packet.Id, packet.Result);
        Result = packet.Result;
        SetStep(entity, packet.Result == RESULT.SUCCESS ? STEP.LEVEL_START_OK : STEP.LEVEL_START_FAIL);
    }


    public void OnReceiveMessage(Robot entity, GC_STORY_CHAPTER_RESOLVE_ENDING packet)
    {
        entity.Log("--- RESOLVE_ENDING 关卡结局结算 收到回包--- " + packet.Result);

        //请求开始调查 返回
        entity.LogFormat("resolve_ending respons: ChapterId:{0}, ret:{1}", packet.ChapterId, packet.Result);
        Result = packet.Result;

        //关卡结局结算成功后 不管是否成功 都需要重新进入 BEGIN
        SetStep(entity, packet.Result == (int)ProtobufPacket.RESULT.SUCCESS ? STEP.RESOLVEEND_OK : STEP.RESOLVEEND_FAIL);
    }

    //结算回包
    public void OnReceiveMessage(Robot entity, GC_STORY_LEVEL_FINISH packet)
    {
        entity.Log("--- 关卡结算收到回包--- " + packet.Result);
        entity.LogFormat("level finish respons: level:{0}, ret:{1}", packet.Id, packet.Result);
        Result = packet.Result;

        if (packet.Result == RESULT.SUCCESS)
        {
            SetStep(entity, STEP.LEVEL_FINISH_OK);
        }
        else
        {
            SetStep(entity, STEP.LEVEL_FINISH_FAIL);
        }
    }

    //回溯回包
    public void OnReceiveMessage(Robot entity, GC_STORY_CHAPTER_REWIND packet)
    {
        entity.Log("--- 回溯收到回包--- " + packet.Result);
        entity.LogFormat("level rewind respons: level:{0}, ret:{1}", packet.LevelId, packet.Result);
        Result = packet.Result;
        if (packet.Result == RESULT.SUCCESS)
        {
            SetStep(entity, STEP.REWIND_OK);
        }
        else
        {
            SetStep(entity, STEP.REWIND_FAIL);
        }
    }

    /// <summary>
    /// 保存点 回包 保存点的回包不需处理
    /// </summary>
    /// <param name="entity"></param>
    /// <param name="packet"></param>
    public void OnReceiveMessage(Robot entity, GC_SAVEPOINT packet)
    {
        //entity.Log("--- 保存点 收到回包--- " + Result);
        //Result = packet.Result;
        //if (packet.Result == RESULT.SUCCESS)
        //{
        //    SetStep(entity, STEP.SAVEPOINT_OK);
        //}
        //else
        //{
        //    SetStep(entity, STEP.SAVEPOINT_FAIL);
        //}
    }

    public void SetStep(Robot entity, STEP nStep)
    {
        int fCostTime = Utils.GetTimeDiffSecnds(DateTime.Now, m_fStepStartTime);

        //更新当前状态
        m_nPreStep = m_nCurStep;
        m_nCurStep = nStep;
        m_fStepStartTime = DateTime.Now;

        entity.LogFormat("state:{0} step: {1}-->{2} cost:{3}, chapter:{4} levelid:{5} failcount:{6}", getName(), m_nPreStep, m_nCurStep, fCostTime, ChapterId, LevelId, FailedCount);
    }
}