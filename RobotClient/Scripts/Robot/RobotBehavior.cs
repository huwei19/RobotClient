using ProtobufPacket;
using System;
using UnityEngine;
using System.Collections.Generic;
using Games.Table;
using Games.GlobeDefine;
public partial class Robot
{

    public void SendChangeScene(int nSceneClassID)
    {
    }

    public void SendCMD(string strCMD)
    {
        CG_GMCMDSTR packet = new CG_GMCMDSTR();
        packet.cmdstr = strCMD;
        NetManager.SendMsg(packet);
    }

    public bool SendRandomMsg()
    {
        return true;
    }

    public void SendRandomBytes()
    {
    }

    public void SendEnterCopySence(int m_nCopySceneId, int m_nCopySceneSingle, int m_nCopySceneDifficult)
    {
    }

    //开始调查
    public void StartLevel(int nLevelId, List<int> cardIds)
    {
        CG_STORY_LEVEL_START packet = new CG_STORY_LEVEL_START();
        packet.Id = nLevelId;
        packet.SavePointId = -1;
        for (int i = 0; i < cardIds.Count; i++)
            packet.CardIds.Add(cardIds[i]);

        NetManager.SendMsg(packet);
        TransStart(TransEvent.StartLevel);
    }

    /// <summary>
    ///  保存 保存点
    /// </summary>
    /// <param name="nLevelId"></param>
    public void SavePoint(int levelId)
    {
        CG_SAVEPOINT msg = new CG_SAVEPOINT();
        msg.SavePointInfo = new _SavePoint();

        int spointId = mStoryData.GetSavepointId(levelId);
        if(spointId <= 0)
        {
            LogFormat("missing savepoint, levelId:{0}", levelId);
            return;
        }

        msg.SavePointInfo.Id = mStoryData.GetSavepointId(levelId);  //savePoint唯一标识，id等于行为sceneEvent的id

        _SavePointSceneEvent ev = GetNew_SavePointSceneEvent(levelId);     //行为记录
        List<_SavePointSceneEvent> l_evs = new List<_SavePointSceneEvent>();
        l_evs.Add(ev);
        msg.SavePointInfo.SceneEvents = l_evs;      //行为记录
        msg.SavePointInfo.RuntimeData = GetNew_SavePointInvRuntimeData();       //运行数据
        msg.SavePointInfo.RandCount = 1;

        List<int> l_sectionList = new List<int>();
        l_sectionList.Add(1);
        msg.SavePointInfo.SectionList = l_sectionList;       //执行的段落id，恢复的时候先根据行为恢复，再根据此列表记录id回复
        
        //发送数据
        NetManager.SendMsg(msg);
        TransStart(TransEvent.SavePoint);
    }

    /// <summary>
    /// 生成一个默认的 _SavePointSceneEvent
    /// </summary>
    /// <returns></returns>
    public _SavePointSceneEvent GetNew_SavePointSceneEvent(int levelId)
    {
        _SavePointSceneEvent ev = new _SavePointSceneEvent();
        ev.Id = mStoryData.GetSavepointId(levelId);
        ev.StartTime = -1;
        ev.TimeLeft = -1;
        ev.StateFlag = -1;
        return ev;
    }

    /// <summary>
    /// 生成一个默认的 _SavePointInvRuntimeData
    /// </summary>
    /// <returns></returns>
    public _SavePointInvRuntimeData GetNew_SavePointInvRuntimeData()
    {
        _SavePointInvRuntimeData data = new _SavePointInvRuntimeData();
        data.ClueNum = 1;       //报告数量
        data.ForwardMinutes = 1;    //推进时间
        data.ConfidenceDelta = 1;       //信心值剩余

        _NpcStatus npcStatus = new _NpcStatus();     //npc状态
        npcStatus.Id = 1;
        npcStatus.Status = 1;
        List<_NpcStatus> l_npcStatus = new List<_NpcStatus>();
        l_npcStatus.Add(npcStatus);
        data.NpcStatus = l_npcStatus;

        _StoryChapterCheckpoint checkpoint = new _StoryChapterCheckpoint();     //检查点
        checkpoint.Id = 1;
        List<int> l_unlockIds = new List<int>();
        l_unlockIds.Add(1);
        checkpoint.UnlockIds = l_unlockIds;
        List<_StoryChapterCheckpoint> l_checkpoints = new List<_StoryChapterCheckpoint>();
        l_checkpoints.Add(checkpoint);


        List<_SpecialClue> l_specialClues = new List<_SpecialClue>();       //线索
        _SpecialClue specialClue = new _SpecialClue();
        specialClue.Id = 1;
        specialClue.Used = false;
        specialClue.ExtraInfo = "";
        data.SpecialClues = l_specialClues;

        data.HideAwardCount = 1;        //隐藏奖励数量
        data.HideAwardCountHugeSucc = 1;        //隐藏大成功奖励数量
        data.BehaviorHugeSuccCount = 1;     //大成功奖励次数
        data.ActionPoint = 1;           //回合行动点
        data.PerceptionUsedCount = 1;   //本次

        return data;
    }


    public void FinishLevel(int nLevelId, _StoryEnum.LevelResult result)
    {
        var tLevel = TableManager.GetStoryChapterLevelByID(nLevelId);
        if (tLevel == null)
            return;
        CG_STORY_LEVEL_FINISH Request = new CG_STORY_LEVEL_FINISH();
        Request.Id = nLevelId;
        Request.LevelResult = (int)result;

        if (result == _StoryEnum.LevelResult.Succ || result == _StoryEnum.LevelResult.Fail)
        {
            if (nLevelId == mStoryLogic.LevelId && mStoryLogic.IsFinish())
            {
                Request.StoryData = mStoryLogic.SyncData;
                Request.LevelData = mStoryLogic.LevelData;
                Request.LevelData.Result = (int)result;
            }

        }
        if (Request.LevelData == null)
        {
            var levelData = new _StoryLevel();
            levelData.Id = nLevelId;
            levelData.LevelType = tLevel.LevelType;
            levelData.Result = (int)result;
            levelData.BranchName = "";
            Request.LevelData = levelData;
        }

        NetManager.SendMsg(Request);
        TransStart(TransEvent.FinishLevel);
    }

    //整章打完 解结局
    public void ResolveEnding(int nChapterId)
    {
        CG_STORY_CHAPTER_RESOLVE_ENDING message = new CG_STORY_CHAPTER_RESOLVE_ENDING();
        message.ChapterId = nChapterId;
        NetManager.SendMsg(message);

        LogFormat("resolveending: chapter:{0}", nChapterId);
    }

    public void Rewind(int nChapterId, int nLevelId)
    {
        CG_STORY_CHAPTER_REWIND message = new CG_STORY_CHAPTER_REWIND();
        message.ChapterId = nChapterId;
        message.RewindToLevelId = nLevelId;
        NetManager.SendMsg(message);

        LogFormat("rewind: chapter:{0} level:{1}", nChapterId, nLevelId);
    }

    public void RewindFirst(int nChapterId)
    {
        int nRewindLevel = -1;
        var chapter = mStoryData.GetChapter(nChapterId);
        if (chapter == null)
        {
            LogFormat("rewindfirst chapter error. chapter is null. chapter:{0}", nChapterId);
            return;
        }

        if (chapter.LevelRoots.Count <= 0)
        {
            return;
        }

        Rewind(nChapterId, chapter.LevelRoots[0]);
    }

    public void RewinLast(int nChapterId)
    {
        var chapter = mStoryData.GetChapter(nChapterId);
        if (chapter == null || chapter.ProgressIds.Count <= 0)
        {
            return;
        }
        Rewind(nChapterId, chapter.ProgressIds[chapter.ProgressIds.Count - 1]);
    }

    //找一个行为合适的卡
    public int GetCardIdByBehavior(int nBehaviorCalcNumId)
    {
        var tBehavior = TableManager.GetBehaviorCalcNumByID(nBehaviorCalcNumId);
        if (tBehavior == null)
            return 1;

        switch (tBehavior.AttrType)
        {
            case (int)AttrType.Obs:
                return 28;
            case (int)AttrType.Com:
                return 19;
            case (int)AttrType.Res:
                return 1;
            case (int)AttrType.Cbt:
                return 11;
        }
        return 1;
    }

    public void OnReceiveMessage(GC_STORY_LEVEL_START packet)
    {
        TransEnd(TransEvent.StartLevel, packet.Result);
        //var state = FSM.CurState() as StateStoryEx;
        //if (state != null)
        //{
        //    state.OnReceiveMessage(this, packet);
        //}
        var state_chapter = FSM.CurState() as StateChapter;
        if (state_chapter != null)
        {
            state_chapter.OnReceiveMessage(this, packet);
        }
    }

    public void OnReceiveMessage(GC_STORY_CHAPTER_RESOLVE_ENDING packet)
    {
        var state_chapter = FSM.CurState() as StateChapter;
        if (state_chapter != null)
        {
            state_chapter.OnReceiveMessage(this, packet);
        }
    }
    
    public void OnReceiveMessage(GC_STORY_LEVEL_FINISH packet)
    {
        TransEnd(TransEvent.FinishLevel, packet.Result);
        //var state = FSM.CurState() as StateStoryEx;
        //if (state != null)
        //{
        //    state.OnReceiveMessage(this, packet);
        //}
        var state_chapter = FSM.CurState() as StateChapter;
        if (state_chapter != null)
        {
            state_chapter.OnReceiveMessage(this, packet);
        }
    }

    public void OnReceiveMessage(GC_SYNC_STORY message)
    {
        mStoryData.OnReceiveMessage(message);
    }

    public void SendGive(long friendId, bool isOne)
    {
        if (isOne)
        {
            CG_GIVE_FRIEND message = new CG_GIVE_FRIEND();
            for (int i = 0; i < mFriendData.Friends.Count; i++)
            {
                if (mFriendData.Friends[i].IsGive && mFriendData.Friends[i].IsGet)
                {
                    continue;
                }
                message.friendId.Add(mFriendData.Friends[i].LFID);
            }
            message.isOne = isOne; //一键操作 @ @
            NetManager.SendMsg(message);
            TransStart(TransEvent.FriendGiveOneKey);
        }
        else
        {
            CG_GIVE_FRIEND message = new CG_GIVE_FRIEND();
            message.friendId.Add(friendId);
            message.isOne = isOne;
            NetManager.SendMsg(message);
            TransStart(TransEvent.FriendGive);
        }
    }

    public void FriendOp(long id, EFriendOpType type)
    {
        switch (type)
        {
            case EFriendOpType.Del_Friend:
                {
                    CG_DEL_FRIEND message = new CG_DEL_FRIEND();
                    message.FriendId = id;
                    NetManager.SendMsg(message);
                }
                break;
            case EFriendOpType.Par_Friend:
                {
                    CG_PARTICULARS_FRIEND message = new CG_PARTICULARS_FRIEND();
                    message.FriendId = id;
                    NetManager.SendMsg(message);
                }
                break;
            case EFriendOpType.Ref_Friend:
                {
                    CG_REFUSE_FRIEND message = new CG_REFUSE_FRIEND();
                    message.FriendId = id;
                    NetManager.SendMsg(message);
                }
                break;
            case EFriendOpType.Acc_Friend:
                {
                    CG_ACCEPT_FRIEND message = new CG_ACCEPT_FRIEND();
                    message.FriendId = id;
                    NetManager.SendMsg(message);
                }
                break;
            case EFriendOpType.Add_Friend:
                {
                    CG_SEARCH_ADD_FRIEND message = new CG_SEARCH_ADD_FRIEND();
                    message.FriendId = id;
                    NetManager.SendMsg(message);
                }
                break;
        }
    }

    public void RecommendFriend()
    {
        CG_RECMMEND_UPDATA_FRIEND message = new CG_RECMMEND_UPDATA_FRIEND();
        NetManager.SendMsg(message);
    }

    //加卡
    public void GMAddCard()
    {
        foreach (var v in TableManager.GetCard())
        {
            SendCMD(string.Format("card,{0},10,80,6", v.Value[0].Id));
        }
    }

    //加碎片
    public void GMAddCardPiece()
    {
        foreach (var v in TableManager.GetCard())
        {
            SendCMD(string.Format("cpiece,{0},1", v.Value[0].Id));
        }
    }

}
