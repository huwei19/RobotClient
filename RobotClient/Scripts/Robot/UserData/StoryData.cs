using System.Collections;
using System.Collections.Generic;
using System;
using Games.GlobeDefine;
using Games.Table;
using ProtobufPacket;
using System.Linq;

using StoryChapter = ProtobufPacket._StoryChapter;
using StoryLevel = ProtobufPacket._StoryLevel;
using ChapterStatus = ProtobufPacket._StoryEnum.ChapterStatus;
using LevelType = ProtobufPacket._StoryEnum.LevelType;
using ChapterRank = ProtobufPacket._StoryEnum.ChapterRank;

namespace ProtobufPacket
{
    public partial class _StoryChapter
    {
        public List<int> LevelRoots { get { return levelRoots; } }
        private List<int> levelRoots = new List<int>();
        public Tab_StoryChapter tableData
        {
            get
            {
                var tChatper = TableManager.GetStoryChapterByID(Id);
                return tChatper;
            }
        }

        public _StoryChapterEnding Ending { get { return (ChapterRank)Rank != ChapterRank.N ? Endings.Find(e => e.Rank == Rank) : null; } }

        public List<int> FinishLevels { get; private set; } = new List<int>();

        public void Init()
        {
            BuildLevelBranch();
            SyncLevelAchievement(this);
        }

        //可能的全部关卡
        public List<int> BuildLevelBranch()
        {
            levelRoots.Clear();
            List<int> levelList = new List<int>();
            int startLevel = tableData.StartLevels[0];
            if (startLevel < 0)
                return levelList;

            levelRoots.Add(startLevel);
            BuildBranch(startLevel, levelRoots);
            return levelList;
        }


        void BuildBranch(int startLevel, List<int> levels)
        {
            var d = TableManager.GetStoryChapterLevelByID(startLevel, 0);
            if (d == null)
                return;

            for (int i = 0; i < d.getBranchLevelIdCount(); i++)
            {
                if (string.IsNullOrEmpty(d.GetBranchLevelIdbyIndex(i)))
                    break;
                if (string.IsNullOrEmpty(d.GetBranchNamebyIndex(i)) || d.GetBranchNamebyIndex(i) == "null")
                    break;

                string branchName = d.GetBranchNamebyIndex(i).Contains("default")
                    ? GlobeVar.Default
                    : d.GetBranchNamebyIndex(i);


                int[] branchIds = Array.ConvertAll(d.GetBranchLevelIdbyIndex(i).Split(';'), v => int.Parse(v));
                if (branchIds.Length == 0)
                    return;

                levels.Add(branchIds[0]);
                BuildBranch(branchIds[0], levels);
            }
        }

        //IsLevelFinish  当前进度已打过的不能打
        //关卡是否结束
        public bool IsLevelFinish(int nLevelId)
        {
            if(Status == (int)ChapterStatus.Finished)
            {
                return FinishLevels.Contains(nLevelId);
            }
            else
            {
                return ProgressIds.Contains(nLevelId);
            }
        }

        public bool IsAllEndingFinish()
        {
            int allEndingCount = 0;
            int count = tableData.getEndingCount();
            for (int i = 0; i < count; i++)
            {
                int endingId = tableData.GetEndingbyIndex(i);
                if (endingId <= 0)
                    continue;

                allEndingCount++;
            }

            return allEndingCount == Endings.Count;
        }

        public void Sync(_StoryChapter rData)
        {
            if (rData == null)
                return;

            Id = rData.Id;
            if (rData.Has_Status)
                Status = rData.Status;
            if (rData.Has_Rank)
                Rank = rData.Rank;
            if (rData.IsUnlock)
                IsUnlock = rData.IsUnlock;

            ProgressIds = rData.ProgressIds;
            foreach (var v in rData.Endings)
            {
                var end = GetEnding(v.Rank);
                if (end == null)
                {
                    Endings.Add(v);
                }
            }

            SyncLevelAchievement(rData);
            //其他数据暂不关心
        }

        void SyncLevelAchievement(_StoryChapter rData)
        {
            for (int i = 0; i < rData.LevelAchievements.Count; i++)
            {
                if (rData.LevelAchievements[i].passState <= 0)
                    continue;

                if (rData.LevelAchievements[i].Has_passState)
                {
                    if (!FinishLevels.Contains(rData.LevelAchievements[i].LevelId))
                        FinishLevels.Add(rData.LevelAchievements[i].LevelId);
                }
            }
        }

        public _StoryChapterEnding GetEnding(int nRank)
        {
            if (nRank != (int)_StoryEnum.ChapterRank.N)
            {
                return Endings.Find(e => e.Rank == nRank);
            }
            return null;
        }
    }
}
public class StoryData
{
    public StoryData()
    {
        var data = Games.Table.TableManager.GetStoryChapterLevelSceneEvent();
        var e = data.GetEnumerator();
        while(e.MoveNext())
        {
            var current = e.Current;
            var tableData = current.Value[0];

            if(LevelToSavepointIds.ContainsKey(tableData.StoryChapterLevelId))
            {
                continue;
            }

            LevelToSavepointIds.Add(tableData.StoryChapterLevelId, tableData.Id);
        }
    }

    public Dictionary<int, int> LevelToSavepointIds = new Dictionary<int, int>();

    private Dictionary<int, StoryChapter> m_Chapters = new Dictionary<int, StoryChapter>();

    public StoryChapter GetChapter(int nChapterId) { return m_Chapters.ContainsKey(nChapterId) ? m_Chapters[nChapterId] : null; }


    public bool IsChapterGetAllEnding(int nChapterId)
    {
        var chapter = GetChapter(nChapterId);
        if (chapter == null)
        {
            return false;
        }

        return chapter.IsAllEndingFinish();
    }

    public int GetLastChapterId(List<int> chapterIds)
    {
        for (int i = 0; i < chapterIds.Count; i++)
        {
            if (!IsChapterGetAllEnding(chapterIds[i]))
            {
                return chapterIds[i];
            }
        }

        return 1;

    }

    public int GetNextLevelId(int nChapterId)
    {
        var tChatper = TableManager.GetStoryChapterByID(nChapterId);
        if (tChatper == null)
            return -1;

        var chapter = GetChapter(nChapterId);
        if (chapter == null)
        {
            chapter = new StoryChapter();
            chapter.Id = nChapterId;
            m_Chapters[nChapterId] = chapter;
            chapter.Init();
        }

        for (int i = 0; i < chapter.LevelRoots.Count; i++)
        {
            if (!chapter.IsLevelFinish(chapter.LevelRoots[i]))
                return chapter.LevelRoots[i];
        }

        return -1;
    }

    public int GetSavepointId(int levelId)
    {
        LevelToSavepointIds.TryGetValue(levelId, out int spId);
        return spId;
    }

    public int GetChapterState(int nChapterId)
    {
        var chapter = GetChapter(nChapterId);
        if (chapter == null)
            return (int)_StoryEnum.ChapterStatus.Ready;

        return chapter.Status;
    }
    public void OnReceiveMessage(GC_SYNC_STORY message)
    {
        if (message == null)
            return;
        if (message.Story == null)
            return;

        foreach (var v in message.Story.StoryLines)
        {
            foreach (var chapter in v.Chapters)
            {
                if (!m_Chapters.ContainsKey(chapter.Id))
                {
                    m_Chapters[chapter.Id] = chapter;
                    chapter.Init();
                }
                else
                {
                    m_Chapters[chapter.Id].Sync(chapter);
                }

            }
        }
    }
}

