/**********************************************************
* 说明：模拟关卡过程，生成_STORY_SECTION 
* 调查过程行为：
* 1 启动模拟，初始化数据,根据levelid，查找所有场景事件ChapterLevelSceneEvent
* 2 激活启动段落（sectionid 1），执行段落的action
* 3 依次激活场景事件对应的段落（一个tick激活一个段落）
* 4 所有场景事件都激并执行完毕, 激活结束段落 （BeforeLevelFinish）
* 5 模拟过程完毕，等待提交服务器
* 
* 如果是推理关卡，启动时执行推理 DoPuzzle
* 1 随机选一组关键思路 填充推理需要的数据 LevelData.PuzzleBranchIndex 
* 2 随机选一个结论选项 LevelData.PuzzleConclusionIndex
* 3 如果有隐藏思路，随机一个隐藏思路对应的结论选项
* 4 模拟过程完毕，等待提交服务器验证
* 
* 段落执行说明：
* 1 顺序执行段落对应的Action
* 2 遇到CODE_END 结束, 结束段落
* 3 遇到CODE_JUMP 跳转action，概率跳转（但大概率有益跳转）
* 4 遇到CODE_GOTOSECTION 跳转section, 跳转对应段落（递归）
* 5 遇到CODE_BEHAVIORCALC 行为， 挑一个对应行为的卡，数据记录到行为列表
* 6 遇到CODE_FATEDIALOG 命运对话， 随机一个对应问题的选项

* *********************************************************/
using System.Collections;
using System.Collections.Generic;
using Games.Table;
using ProtobufPacket;
using System.Linq;
using System;

using NodeAction = ProtobufPacket._STORY_ACTION;

public enum EJump
{
    JUMP_NONE = 0,
    JUMP_FALSE = 1,
    JUMP_TRUE = 2,
}


public class NodeSection
{
    public int NextActionId = -1;
    public _STORY_SECTION SyncData = null;

    public bool IsActive { get; set; }

    public Tab_Node LastTestNode { get; set; }

}

public class StoryLogic
{
    public enum EState
    {
        NONE = 0,
        RUNNING = 1,
        FINISH = 2,
    }

    private Robot m_Owner;
    private EState m_State = EState.NONE;

    private _STORY_INST m_StoryInst = new _STORY_INST();
    private Tab_StoryChapterLevel m_tLevel;

    private _StoryLevel m_LevelData = new _StoryLevel();

    //action
    private Dictionary<int, _STORY_ACTION> m_Actions = new Dictionary<int, _STORY_ACTION>();
    private Dictionary<int, NodeSection> m_Sections = new Dictionary<int, NodeSection>();
    private Queue<Tab_StoryChapterLevelSceneEvent> m_SceneEvents = new Queue<Tab_StoryChapterLevelSceneEvent>();
    private Dictionary<int, int> m_Section2Event = new Dictionary<int, int>(); //<sectionid, scenentid>
    private Dictionary<int, NodeSection> Sections { get { return m_Sections; } }

    //推理
    public int PuzzleBranchIndex { get; set; }
    public EState SState { get { return m_State; } set { m_State = value; } }
    public int LevelId { get { return m_tLevel != null ? m_tLevel.Id : -1; } }
    public _STORY_INST SyncData { get { return m_StoryInst; } }
    public _StoryLevel LevelData { get { return m_LevelData; } }
    public bool IsRunning() { return m_State == EState.RUNNING; }
    public bool IsFinish() { return m_State == EState.FINISH; }
    public int GetSectionEventId(int nSectionId) { return m_Section2Event.ContainsKey(nSectionId) ? m_Section2Event[nSectionId] : -1; }

    public bool StartLevel(Robot entity, int nLevel)
    {
        m_Owner = entity;
        var tLevel = TableManager.GetStoryChapterLevelByID(nLevel);
        if (tLevel == null)
        {
            entity.LogFormat("tLevel is null. levelid: {0}", nLevel);
            return false;
        }
            
        if(m_tLevel != tLevel && !InitData(tLevel))
            return false;

        SState = EState.NONE;
        
        m_StoryInst.SectionList.Clear();
        m_StoryInst.StoryId = m_tLevel.Id;

        m_Actions.Clear();
        m_Sections.Clear();

        m_LevelData.Id = nLevel;
        m_LevelData.LevelType = tLevel.LevelType;
        m_LevelData.Result = (int)_StoryEnum.LevelResult.Succ;
        m_LevelData.BranchName = ""; //todo

        //启动
        Start();
        return true;
    }

    public bool InitData(Tab_StoryChapterLevel tLevel)
    {
        m_SceneEvents.Clear();
        m_Section2Event.Clear();

        m_tLevel = tLevel;

        if (tLevel == null)
            return false;

        if (string.IsNullOrEmpty(tLevel.StoryFile))
            return true;

        var tNode = TableManagerEx.GetNode(tLevel.StoryFile);
        if (tNode == null)
        {
            m_Owner.LogFormat("tNode is null. levelid: {0}, storyfile:{1}", tLevel.Id, tLevel.StoryFile);
            return false;
        }

        //配置的场景事件
        foreach (var v in TableManager.GetStoryChapterLevelSceneEvent())
        {
            if (v.Value[0].StoryChapterLevelId != tLevel.Id)
                continue;
            m_SceneEvents.Enqueue(v.Value[0]);
            m_Section2Event[v.Value[0].SectionId] = v.Value[0].Id;
        }

        return true;
    }

    //推理
    void DoPuzzle()
    {
        if (m_tLevel.LevelType != (int)_StoryEnum.LevelType.Puzzle) //推理分支 构建推理数据
            return;

        var tPuzzle = TableManager.GetPuzzleLevelDataByID(m_tLevel.Id);
        if (tPuzzle == null)
            return;

        m_LevelData.PuzzleBranchIndex = 0; //todo

        //普通思路 目前不校验，不用传了

        //关键思路
        int nCirticalCount = 0;
        for(int i=0; i<tPuzzle.getCriticalIdCount(); i++)
        {
            if (tPuzzle.GetCriticalIdbyIndex(i) <= -1)
                break;

            nCirticalCount++;
        }

        //随机选一组关键思路
        int nCriticalIdx = new Random().Next(0, nCirticalCount);
       
        m_LevelData.PuzzleBranchIndex = nCriticalIdx;
        m_LevelData.PuzzleBranch = tPuzzle.GetCriticalBranchNamebyIndex(nCriticalIdx);
        m_LevelData.PuzzleConclusionIndex = GetConclusionIdx(tPuzzle.GetCriticalIdbyIndex(nCriticalIdx));

        //隐藏思路随机一个结论
        m_LevelData.HiddenConclusionIndex = GetConclusionIdx(tPuzzle.GetCriticalHiddenIdbyIndex(nCriticalIdx));

        //对应段落

        //结束
        Finish();
    }

    //思路组随机一个结论
    private int GetConclusionIdx(int nThoughtSetId)
    {
        var tPuzzleThoughSet = TableManager.GetPuzzleThoughtSetByID(nThoughtSetId);
        if (tPuzzleThoughSet == null)
            return -1;

        //随机一组结论
        int nCountConclusion = 0;
        for (int i = 0; i < tPuzzleThoughSet.getConclusionCount(); i++)
        {
            if (string.IsNullOrEmpty(tPuzzleThoughSet.GetConclusionbyIndex(i)))
                break;
            nCountConclusion++;
        }

        if (nCountConclusion <= 0)
            return -1;

        return new Random().Next(0, nCountConclusion);
    }
    public void Clear()
    {
        m_Actions.Clear();
        m_Sections.Clear();
        m_SceneEvents.Clear();
        m_Section2Event.Clear();
    }
    public void Tick()
    {
        if (!IsRunning())
            return;

        if(m_SceneEvents.Count <=0)
        {
            //结束
            BeforeLevelFinish();
            return;
        }
        var tEvent = m_SceneEvents.Dequeue();
        if (tEvent == null)
            return;

        Event(tEvent.SectionId);

    }
    public void Start()
    {
        SState = EState.RUNNING;
        // 起始段落
        _ActiveSection((int)NodeActionCode.CODE_ONSTART);

        //如果是推理
        DoPuzzle();
    }

    public void PrepareToFinish()
    {
        SState = EState.FINISH;
    }

    public void Break()
    {
        _ActiveSection(NodeActionCode.CODE_ONBREAK);
    }
    public void Finish()
    {
        _ActiveSection(NodeActionCode.CODE_ONFINISH);

        SState = EState.FINISH;
    }

    public void BeforeLevelFinish() //都按成功走
    {
        _ActiveSection(NodeActionCode.CODE_ONBEFORELEVELFINISH);

        SState = EState.FINISH;
    }

    public void Event(int nSectionId)
    {
        _ActiveSection(nSectionId);
    }

    public void GoToSection(int nSection)
    {
        _ActiveSection(nSection);
    }

    //忽略各种条件 执行完
    public void DoSection(NodeSection rSection)
    {
        if (rSection == null)
            return;

        while(true)
        {
            if (rSection.NextActionId <= -1)
                break;
            var rAction = _ActiveAction(rSection.NextActionId, rSection);
            if (rAction == null)
                break;

            rSection.NextActionId++; //放在DoAction之前 DoAction可能修改它
            DoAction(rSection, rAction);
        }
    }

    public void DoAction(NodeSection rSection, NodeAction rAction)
    {
        if (rAction == null)
            return;
        if (rSection == null)
            return;
        var tNode = TableManagerEx.GetNodeByID(m_tLevel.StoryFile, rAction.ActionId);
        if (tNode == null)
            return;
        switch (rAction.ActionCode)
        {
            case NodeActionCode.CODE_END:
                {
                    rSection.NextActionId = -1; //结束当前段落
                }
                break;
            case NodeActionCode.CODE_JUMP:
                {
                    bool bJump = false;
                    if(tNode.GetParamIntbyIndex(0) == (int)EJump.JUMP_NONE)
                    {
                        //无条件跳转
                        bJump = true;
                    }
                    else if(tNode.GetParamIntbyIndex(0) == (int)EJump.JUMP_FALSE)
                    {
                        //判断不通过而跳转  大概率让通过(不跳转)
                        bJump = false; //!RandomSimple(900, 1000);
                    }
                    else
                    {
                        //概率跳转 
                        bJump = true;//RandomSimple(900, 1000);
                    }
                    if(bJump)
                        rSection.NextActionId = tNode.GetParamIntbyIndex(1);
                }
                break;

            case NodeActionCode.CODE_GOTOSECTION:
                {
                    //递归
                    GoToSection(tNode.GetParamIntbyIndex(0));
                }
                break;
            case NodeActionCode.CODE_BREAK:
                Break();
                break;
            case NodeActionCode.CODE_SETBEHAVIORRESULT:
                break;
            case NodeActionCode.CODE_BEHAVIORCALC:
                {
                    //需要选卡  
                    int nCardId = m_Owner.GetCardIdByBehavior(tNode.GetParamIntbyIndex(0));
                    rAction.intParams.Add(nCardId);
                }
                break;
            case NodeActionCode.CODE_FATEDIALOG:
                {
                    //命运对话答题
                    var nFateId = tNode.GetParamIntbyIndex(0);
                    var tFateDialog = TableManager.GetFateDialogByID(nFateId);
                    if(tFateDialog!=null)
                    {
                        rAction.intParams.Add(tFateDialog.QuestionId);
                        rAction.intParams.Add(0); //选项， 可以随机
                    }
                    else
                    {
                        rAction.intParams.Add(-1);
                        rAction.intParams.Add(-1); 
                    }
                }
                break;
            default:
                break;
        }
    }

    public NodeSection _ActiveSection(int sectionId)
    {
        int nEventId = GetSectionEventId(sectionId);
        var rData = AddSection(sectionId, nEventId);
        if (rData == null)
            return null;
        NodeSection section = new NodeSection();
        section.SyncData = rData;
        section.NextActionId = sectionId * 1000;
        DoSection(section);
        return section;
    }

    public NodeAction _ActiveAction(int nActionId, NodeSection rSection)
    {
        if (rSection == null)
            return null;
        var tNode = TableManagerEx.GetNodeByID(m_tLevel.StoryFile, nActionId);
        if (tNode == null)
            return null;

        var data = AddAction(rSection.SyncData, nActionId, tNode.Code);
        //DoAction(rSection, data);
        return data;
    }
    public _STORY_SECTION AddSection(int sectionId, int eventId)
    {
        var data = new _STORY_SECTION();
        data.SectionId = sectionId;
        data.EventId = eventId;

        m_StoryInst.SectionList.Add(data);
        return data;
    }

    public _STORY_ACTION AddAction(_STORY_SECTION rSection, int nActionId, int nCodeId)
    {
        if (rSection == null)
            return null;

        var data = new _STORY_ACTION();
        data.ActionId = nActionId;
        data.ActionCode = nCodeId;

        rSection.ActionList.Add(data);
        return data;
    }

    private bool RandomSimple(int nPercent, int nMax)
    {
        if (nMax <= 0)
            return false;
        int nSimple = new Random().Next(0, nMax);
        if (nSimple < nPercent)
            return true;
        return false;
    }
}
