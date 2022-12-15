using System.Collections;
using System.Collections.Generic;
using ProtobufPacket;
using System;
using LiteNet;
using System.IO;
using Games.Table;
using System.Linq;


class investigation
{
    public static List<int> m_card = new List<int>();
    public static List<NPCState> m_npcstate = new List<NPCState>();

    public static Random rd = new Random();
    public static List<Tab_StoryChapterLevel> tabStoryChapterLevel = new List<Tab_StoryChapterLevel>();
    /// <summary>
    /// finish一个就+1 ，直到所有的tabStoryChapterLevel 都被finish，就结束章节
    /// </summary>
    public int m_num = 0;
    public bool m_start = true;


    /// <summary>
    ///  l_storyChapterLevelId 是这次章节所包含的 levelID
    /// </summary>
    /// <param name="entity"></param>
    /// <param name="a"></param>
    public void init(Robot entity, List<int> l_storyChapterLevelId)
    {
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

        //这里会查找客户端的StoryChapterLevel表， 将不同类型所对应的关卡取出来进行 start 和 finish操作 
        if (investigation.tabStoryChapterLevel.Count <= 0)
        {
            foreach (int item in l_storyChapterLevelId)
            {
                Dictionary<int, List<Tab_StoryChapterLevel>> tab = TableManager.GetStoryChapterLevel();
                foreach (var item2 in tab)
                {
                    if (item2.Value[0].Id == item)
                    {
                        investigation.tabStoryChapterLevel.Add(item2.Value[0]);
                    }
                }
            }
        }

        Dictionary<int, List<Tab_Card>> tabCard = TableManager.GetCard();
        foreach (var item in tabCard)
        {
            if (item.Value[0].StarMax == 6)
            {
                entity.SendCMD("card," + item.Value[0].Id + ",1,80,6");
                investigation.m_card.Add(item.Value[0].Id);
            }
            if (investigation.m_card.Count >= 5)
            {
                break;
            }
        }
    }

    /// <summary>
    /// 时间回溯、调查、章节、个人故事 会调用startLevel
    /// </summary>
    /// <param name="entity"></param>
    public void start(Robot entity)
    {
        m_start = false;
        entity.Log("------- [" + m_num + "]---------\n");
        Tab_StoryChapterLevel tab = tabStoryChapterLevel[m_num % tabStoryChapterLevel.Count];
        CG_STORY_LEVEL_START packet = new CG_STORY_LEVEL_START();
        packet.Id = tab.Id;
        packet.CardIds = m_card;
        //entity.NetManager.SendMsg(packet);
        entity.SendMsg(packet);
        entity.TransStart(TransEvent.StartLevel);
    }

    public void finish(Robot entity)
    {
        m_start = true;
        Tab_StoryChapterLevel tab = tabStoryChapterLevel[m_num % tabStoryChapterLevel.Count];
        Tab_StoryChapter tabStoryChapter = null;
        if (tab.StoryChapterId > 0)
        {
            tabStoryChapter = TableManager.GetStoryChapterByID(tab.StoryChapterId);
        }

        //CG_STORY_LEVEL_FINISH
        CG_STORY_LEVEL_FINISH packet = new CG_STORY_LEVEL_FINISH();
        packet.Id = tab.Id;
        packet.LevelResult = (int)_StoryEnum.LevelResult.Succ;


        packet.LevelData = new _StoryLevel();
        packet.LevelData.Id = tab.Id;
        packet.LevelData.LevelType = tab.LevelType;
        packet.LevelData.Result = (int)_StoryEnum.LevelResult.Succ;
        packet.LevelData.Clues = tab.ClueNum;
        //packet.LevelData.UsedCardIds.AddRange(controller.SelectedCards.Select(v => v.Id));
        //
        packet.LevelData.ImportantEventsTriggered = tab.ImportantEventNum;

        if (tabStoryChapter != null)
        {
            for (int i = 0; i < tabStoryChapter.getCheckpointCount(); ++i)
            {
                int lid = tabStoryChapter.GetCheckpointbyIndex(i);
                if (lid > 0)
                {
                    _StoryChapterCheckpoint lcheckpoint = new _StoryChapterCheckpoint();
                    lcheckpoint.Id = tabStoryChapter.GetCheckpointbyIndex(i);
                    Tab_StoryChapterCheckpoint tabCheckpoint = TableManager.GetStoryChapterCheckpointByID(lcheckpoint.Id);
                    for (int j = 0; j < tabCheckpoint.getCheckpointIdCount(); ++j)
                    {
                        lcheckpoint.UnlockIds.Add(tabCheckpoint.GetCheckpointIdbyIndex(j));
                    }
                    packet.LevelData.Checkpoints.Add(lcheckpoint);
                }
            }
        }

        if (tab.SpecialClues.Contains('|'))
            packet.LevelData.SpecialClues = tab.SpecialClues.Split('|').Select(v => new _SpecialClue() { Id = int.Parse(v), ExtraInfo = "" }).ToList();
        else
            packet.LevelData.SpecialClues = new List<_SpecialClue>();

        packet.LevelData.BranchName = tab.GetBranchNamebyIndex(0);
        if (packet.LevelData.BranchName.Contains("default"))
            packet.LevelData.BranchName = string.Empty;

        ///---
        ///



        if (tabStoryChapter != null)
        {
            for (int i = 0; i < tabStoryChapter.getNpcCount(); ++i)
            {
                _NpcStatus lns = new _NpcStatus();
                lns.Id = tabStoryChapter.GetCheckpointbyIndex(i);
                if (lns.Id > 0)
                {
                    lns.Status = (int)m_npcstate[rd.Next(0, m_npcstate.Count)];
                    packet.LevelData.NpcStatus.Add(lns);
                }
            }
        }

        if (packet.LevelData.LevelType == (int)_StoryEnum.LevelType.Investigate)
        {
            var eventDatas = TableManager.GetStoryChapterLevelSceneEvent()
            .Where(v => v.Value[0].StoryChapterLevelId == packet.LevelData.Id).Select((v) => v.Value[0]);
            foreach (var ed in eventDatas)
            {
                packet.LevelData.KnownSceneEvents.Add(ed.Id.ToString());
                packet.LevelData.KnownSceneEventIds.Add(ed.Id);
            }

            packet.LevelData.FinishedSceneEvents = new List<string>(packet.LevelData.KnownSceneEvents);
            packet.LevelData.FinishedSceneEventIds.AddRange(new List<int>(packet.LevelData.KnownSceneEventIds));

        }
        else if (packet.LevelData.LevelType == (int)_StoryEnum.LevelType.Puzzle)
        {
            var puzzleLevelData = TableManager.GetPuzzleLevelDataByID(packet.LevelData.Id);
            Action<int> processThoughtId = v =>
            {
                if (v >= 0)
                {
                    packet.LevelData.UnlockedPuzzleThoughtIds.Add(v);
                    packet.LevelData.UsedSClueIds.AddRange(TableManager.GetPuzzleThoughtByID(v).Sclues.Where(k => k >= 0));
                }
            };

            foreach (var v in puzzleLevelData.Normals)
                processThoughtId(v);

            packet.LevelData.PuzzleBranch = puzzleLevelData.GetCriticalBranchNamebyIndex(0);
            packet.LevelData.PuzzleConclusionIndex = 0;

            var tThoughtSet = TableManager.GetPuzzleThoughtSetByID(puzzleLevelData.GetCriticalIdbyIndex(0), 0);
            if (tThoughtSet == null)
            {
                //GameLog.LogErrorFormat("level: finish failed: levelid={0}, cirticalId={1}", levelRuntime.Id, puzzleLevelData.GetCriticalIdbyIndex(0));
                return;
            }
            foreach (var v in tThoughtSet.Thoughts)
                processThoughtId(v);
        }

        //entity.NetManager.SendMsg(packet);
        entity.SendMsg(packet);
        ++m_num;

        entity.TransStart(TransEvent.FinishLevel);
    }

    public void savepoint(Robot entity)
    {
        if (m_start)
            return;

        Tab_StoryChapterLevel tab = tabStoryChapterLevel[m_num % tabStoryChapterLevel.Count];
        //只有调查关卡可能存在保存点
        if (tab.LevelType != 0)
            return;

        CG_SAVEPOINT msg = new CG_SAVEPOINT();
        msg.SavePointInfo = new _SavePoint();

        var sceneEventDatas = TableManager.GetStoryChapterLevelSceneEvent()
           .Where(v => v.Value[0].StoryChapterLevelId == tab.Id).Select((v) => v.Value[0]).ToList();

        Tab_StoryChapterLevelSceneEvent targetSeData = null;
        for (int i = 0; i < sceneEventDatas.Count; i++)
        {
            if(sceneEventDatas[i].SavePoint > 0)
            {
                targetSeData = sceneEventDatas[i];
                break;
            }
        }

        //说明没有保存点数据
        if (targetSeData == null)
            return;


        msg.SavePointInfo.Id = targetSeData.Id;  //savePoint唯一标识，id等于行为sceneEvent的id

        //塞入行为数据
        for (int i = 0; i < sceneEventDatas.Count; i++)
        {
            _SavePointSceneEvent s = new _SavePointSceneEvent();
            s.Id = sceneEventDatas[i].Id;
            s.StartTime = -1;
            s.TimeLeft = 0;
            s.StateFlag = 20;
            msg.SavePointInfo.SceneEvents.Add(s);
        }

        msg.SavePointInfo.RuntimeData = new _SavePointInvRuntimeData();
        msg.SavePointInfo.RuntimeData.ClueNum = tab.ClueNum;
        msg.SavePointInfo.RuntimeData.ForwardMinutes = 0;
        msg.SavePointInfo.RuntimeData.ConfidenceDelta = 5;

        //构建npc数据和检查点数据
        var chapterData = TableManager.GetStoryChapterByID(tab.StoryChapterId);
        if(chapterData != null)
        {
            //npc
            List<_NpcStatus> npcStatus = new List<_NpcStatus>();
            for (int i = 0; i < chapterData.getNpcCount(); i++)
            {
                int npcId = chapterData.GetNpcbyIndex(i);
                if (npcId <= 0)
                    continue;

                var npcData = TableManager.GetNpcByID(npcId);
                if (npcData == null)
                    continue;

                _NpcStatus status = new _NpcStatus();
                status.Id = npcId;
                status.Status = npcData.InitialState;
                npcStatus.Add(status);
            }
            msg.SavePointInfo.RuntimeData.NpcStatus = npcStatus;

            //检查点
            List<_StoryChapterCheckpoint> cpList = new List<_StoryChapterCheckpoint>();
            for (int i = 0; i < chapterData.getCheckpointCount(); i++)
            {
                int checkpointId = chapterData.GetCheckpointbyIndex(i);
                if (checkpointId <= 0)
                    continue;

                var checkpointData = TableManager.GetStoryChapterCheckpointByID(checkpointId);
                if (checkpointData == null)
                    continue;

                _StoryChapterCheckpoint cp = new _StoryChapterCheckpoint();
                cp.Id = checkpointId;
                cpList.Add(cp);
            }

            msg.SavePointInfo.RuntimeData.Checkpoints = cpList;
        }

        //线索数据
        string[] clues = tab.SpecialClues.Split('|');
        if (clues != null)
        {
            List<_SpecialClue> cpList = new List<_SpecialClue>();
            for (int i = 0; i < clues.Length; i++)
            {
                if(!int.TryParse(clues[i], out int sclueNum))
                {
                    continue;
                }

                _SpecialClue sclueData = new _SpecialClue();
                sclueData.Id = sclueNum;
                cpList.Add(sclueData);
            }

            msg.SavePointInfo.RuntimeData.SpecialClues = cpList;
        }

        List<int> l_sectionList = new List<int>();
        l_sectionList.Add(targetSeData.SectionId);
        msg.SavePointInfo.SectionList = l_sectionList;       //执行的段落id，恢复的时候先根据行为恢复，再根据此列表记录id回复

        //发送数据
        entity.SendMsg(msg);
    }


    public bool over()
    {
        return m_num % tabStoryChapterLevel.Count == 0 && m_num != 0;
    }
}


