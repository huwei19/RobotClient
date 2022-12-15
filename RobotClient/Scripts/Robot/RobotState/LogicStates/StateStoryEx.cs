/**********************************************************
 * 说明：模拟调查过程，行为如下
 * 1 随机一章（如果已解出结局，先回溯）
 * 2 获取当前章的当前关卡
 * 3 请求开始调查 startlevel
 * 4 成功开始调查，自己模拟调查过程，产生sectionlist等数据 （LEVEL_RUNNING，模拟过程见 StoryLogic.cs）
 * 5 关卡模拟完成，请求结算 finishlevel
 * 6 结算成功，回到2，继续打后续关卡
 * 7 整章打完到Ending关后，请求解迷结局
 * 8 无论结局解成功还是失败，都回到1
 * 
 * *********************************************************/

using System.Collections;
using System.Collections.Generic;
using Games.Table;
using ProtobufPacket;
using LiteNet;
using System;

public class StateStoryEx : FSMState<Robot>
{
    public const float INTERVAL_TIMEOUT = 1.6f;          //网络超时
    public const float INTERVAL_STEP = 1f;              //进行下一步之前，等待时间
    public const int LEVEL_FINISH_FAILED_LIMIT = 5;    //finishlevel 失败超过此次数，重新随机章

    public enum STEP
    {
        NONE,
        BEGIN,              //初始
        PREPARE,            //准备
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

    private STEP m_nPreStep = STEP.NONE;
    private STEP m_nCurStep = STEP.NONE;
    private int m_nCurStepTick = 0;
    private Double m_fStepStartTime = 0;
    public int ChapterId { get; set; }
    public int LevelId { get; set; }
    public RESULT Result { get; set; }
    public List<int> CardIds = new List<int> { 1, 11, 19, 28, 5 }; //阵容 暂时固定， 有需要可以自动上阵

    private List<int> ChapterIds = new List<int>();
    private int FailedCount { get; set; } //一章中levelfinish失败的次数  超过一定值重新随机章
    public float m_fIntervalStep { get; set; }
    public void SetStep(Robot entity, STEP nStep)
    {
        Double fCostTime =Utils.GetTimeStamp() - m_fStepStartTime;
        m_nPreStep = m_nCurStep;
        m_nCurStep = nStep;
        m_nCurStepTick = 0;
        m_fStepStartTime = Utils.GetTimeStamp();

        entity.LogFormat("state:{0} step: {1}-->{2} cost:{3:F3}, chapter:{4} levelid:{5} failcount:{6}", getName(), m_nPreStep, m_nCurStep, fCostTime, ChapterId, LevelId, FailedCount);
    }

    //准备
    public void PrepareSuper(Robot entity)
    {
        ChapterIds.Clear();
        // 1 解锁所有章 
        foreach (var v in TableManager.GetStoryChapter())
        {
            var tLine = TableManager.GetStoryLineByID(v.Value[0].StoryLineId);
            if (tLine == null)
                continue;

            //只打主线和暗线-------------->  tabStoryChapter表id的  1-60
            if (tLine.Type != 0 && tLine.Type != 1)
                continue;

            entity.SendCMD("storyu," + v.Value[0].Id);

            ChapterIds.Add(v.Value[0].Id);
        }
        // 2 准备卡
        entity.SendCMD("card,1,1,80,6");
        entity.SendCMD("card,11,1,80,6");
        entity.SendCMD("card,19,1,80,6");
        entity.SendCMD("card,28,1,80,6");
        entity.SendCMD("card,5,1,80,6");

        entity.SendCMD("cards,1,80,6");
        entity.SendCMD("cards,11,80,6");
        entity.SendCMD("cards,19,80,6");
        entity.SendCMD("cards,28,80,6");
        entity.SendCMD("cards,5,80,6");

        //  加点体力
        entity.SendCMD("item,3,100");
    }

    public void Prepare(Robot entity)
    {
        //  加点体力
        entity.SendCMD("item,3,500");
    }

    public void RandomChapter(Robot entity)
    {
        if (ChapterIds.Count <= 0)
        {
            ChapterId = 1;
            return;
        }
        int nOldChapter = ChapterId;
        int nOldLevelId = LevelId;
        Random r = new Random();
        //0 到 ChapterIds.Count 之间
        int idx = r.Next(ChapterIds.Count);
        ChapterId = ChapterIds[idx];
        LevelId = entity.mStoryData.GetNextLevelId(ChapterId);
        entity.LogFormat("random: chapter:{0}-->{1}, level:{2}-->{3} failedcount:{4} state:{5}", nOldChapter, ChapterId, nOldLevelId, LevelId, FailedCount, entity.mStoryData.GetChapterState(ChapterId));

        FailedCount = 0;
    }

    /// <summary>
    /// 收到服务器回调，就更新当前状态
    /// </summary>
    /// <param name="entity"></param>
    /// <param name="packet"></param>
    public void OnReceiveMessage(Robot entity, GC_STORY_LEVEL_START packet)
    {
        entity.Log("--- 开始调查收到回包---" + packet.Result);
        //请求开始调查 返回
        entity.LogFormat("level start respons: level:{0}, ret:{1}", packet.Id, packet.Result);
        Result = packet.Result;

        var tLevel = TableManager.GetStoryChapterLevelByID(packet.Id);
        if (tLevel != null && tLevel.LevelType == (int)_StoryEnum.LevelType.Ending)
        {
            entity.Log("--- 整章打完，解结局---");
            entity.ResolveEnding(ChapterId);
            SetStep(entity, STEP.RESOLVEEND);
        }
        else
        {
            SetStep(entity, packet.Result == RESULT.SUCCESS ? STEP.LEVEL_START_OK : STEP.LEVEL_START_FAIL);
        }
    }

    //结算回包
    public void OnReceiveMessage(Robot entity, GC_STORY_LEVEL_FINISH packet)
    {
        entity.Log("--- 结算收到回包--- " + packet.Result);
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
    /// 保存点 回包
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

    public override string getName()
    {
        return "StoryEx 自动调查";
    }

    public override void onEnter(Robot entity)
    {
        //entity.Log("Enter State StoryEx");

        //参数设置
        m_fIntervalStep = INTERVAL_STEP;
        entity.LogFormat("Enter State StoryEx m_fIntervalStep:{0}", m_fIntervalStep);
        PrepareSuper(entity);
        //随机打一章
        RandomChapter(entity);
        SetStep(entity, STEP.BEGIN);
    }

    public override void onExecute(Robot entity)
    {
        //时间冷却
        if (!isRun())
        {
            return;
        }

        if ((float)Utils.GetTimeStamp() - m_fStepStartTime < m_fIntervalStep) //每步之间间隔一定时间  （同步中不用）
            return;
        switch (m_nCurStep)
        {
            case STEP.BEGIN:
                {
                    if (FailedCount > LEVEL_FINISH_FAILED_LIMIT)
                    {
                        RandomChapter(entity);
                    }

                    if (Result == RESULT.PUZZLE_LEVEL_NO_STAMINA || Result == RESULT.LEVEL_START_NO_STAMINA)
                    {
                        Prepare(entity);
                    }

                    if (entity.mStoryData.GetChapterState(ChapterId) == (int)_StoryEnum.ChapterStatus.Finished)
                    {
                        //已经打完了 回溯到最开始
                        entity.RewindFirst(ChapterId);
                        SetStep(entity, STEP.REWIND);
                    }
                    else
                    {
                        SetStep(entity, STEP.PREPARE);
                    }
                }
                break;
            case STEP.PREPARE:
                {
                    if ((float)Utils.GetTimeStamp() - m_fStepStartTime < 1) //两次StartLevel至少间隔1S 服务器强验
                    {
                        break;
                    }
                    LevelId = entity.mStoryData.GetNextLevelId(ChapterId);
                    //发送了服务器请求，后面会接收服务器的回调，然后进入下一阶段
                    entity.StartLevel(LevelId, CardIds);
                    SetStep(entity, STEP.LEVEL_START);
                }
                break;
            case STEP.LEVEL_START:
                {
                    //等服务器回包
                    if ((float)Utils.GetTimeStamp() - m_fStepStartTime > INTERVAL_TIMEOUT)
                    {
                        //10s还没回包??  1.6秒没有回包??
                        SetStep(entity, STEP.LEVEL_START_FAIL);
                    }
                }
                break;
            case STEP.LEVEL_START_OK:
                {
                    //收到服务器回包，成功开始调查, 开始模拟调查过程
                    entity.mStoryLogic.StartLevel(entity, LevelId);

                    SetStep(entity, STEP.SAVEPOINT); //成功开始调查，首先保存下点
                }
                break;
            case STEP.LEVEL_START_FAIL:
                {
                    FailedCount++;
                    SetStep(entity, STEP.BEGIN);
                }
                break;
            case STEP.LEVEL_RUNNING:
                {
                    if (entity.mStoryLogic.IsRunning())
                    {
                        //entity.Log(string.Format("<color=red>{0}</color>", "一次running Tick" ));
                        entity.mStoryLogic.Tick();
                    }
                    else if (entity.mStoryLogic.IsFinish())
                    {
                        //调查模拟完成， 发结束包，请求结算
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
                    entity.SavePoint(LevelId);     //向服务器调用一次保存事件

                    SetStep(entity, STEP.LEVEL_FINISH);  //发保存点不用等回包，下一秒直接finishLevel
                }
                break;
            case STEP.SAVEPOINT_OK:  // 保存点 成功
                {
                    SetStep(entity, STEP.LEVEL_RUNNING);  //直接后面走running就可以
                }
                break;

            case STEP.SAVEPOINT_FAIL:
            case STEP.LEVEL_RUNNING_ERROR:
                {
                    //不明原因失败了，退出关卡
                    entity.FinishLevel(LevelId, _StoryEnum.LevelResult.Quit);
                }
                break;

            case STEP.LEVEL_FINISH: //等待结算回包
            case STEP.REWIND:       //等待回溯回包
            case STEP.SAVEPOINT_ING: //等待保存点回包
            case STEP.RESOLVEEND:   //等待解谜回包
                {
                    if ((float)Utils.GetTimeStamp() - m_fStepStartTime > INTERVAL_TIMEOUT)
                    {
                        //10s还没回包 失败
                        SetStep(entity, m_nCurStep + 2);
                    }
                }
                break;
            case STEP.LEVEL_FINISH_OK:
                {
                    //收到服务器结束回包  完成一个关卡 继续下一关
                    LevelId = entity.mStoryData.GetNextLevelId(ChapterId);
                    SetStep(entity, STEP.PREPARE);
                }
                break;
            case STEP.LEVEL_FINISH_FAIL:
                {
                    FailedCount++;
                    //失败了,可能上关没拿够线索 回溯
                    entity.RewinLast(ChapterId);
                    SetStep(entity, STEP.REWIND);
                }
                break;
            case STEP.REWIND_OK:
            case STEP.REWIND_FAIL:
                {
                    if (m_nCurStep == STEP.REWIND_FAIL) FailedCount++;
                    SetStep(entity, STEP.BEGIN);
                }
                break;
            case STEP.RESOLVEEND_FAIL:
            case STEP.RESOLVEEND_OK:
                {
                    if (m_nCurStep == STEP.RESOLVEEND_FAIL) FailedCount++;
                    //章解完结局了
                    //随机一章 继续打
                    RandomChapter(entity);
                    SetStep(entity, STEP.BEGIN);
                }
                break;
        }
    }
}