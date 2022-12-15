using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using GCGame.Table;
using Games.Table;

public class RobotAI_SceneClass: RobotAIBase
{
    public RobotAI_SceneClass(Robot curRobot)
        : base(curRobot)
    {
        m_lastChangeTimer = (float)Utils.GetTimeStamp();
        InitSenceList();
        CurState = AIState.EnterCopyScence;
    }

    private float m_lastChangeTimer = 0;

    private int m_curSenceId = -1;     // 当前副本id

    private float m_nextChangeTime = 100.0f;
    private List<Tab_SceneClass> m_allSenceList = new List<Tab_SceneClass>();

    public override string getName()
    {
        return "SceneClass";
    }

    public override void update()
    {
        if ((float)Utils.GetTimeStamp() - m_lastChangeTimer > m_nextChangeTime)
        {
            RandomCurCopyScene();
            if (m_curCopySceneItem != null)
            {
                //m_curRobot.SendEnterCopySence(m_curCopySceneItem.CopySceneID, 1, 1);
                //m_curRobot.Log("SendEnterCopySence:change SceneID ================= " + m_curCopySceneItem.CopySceneID);
            }
            m_lastChangeTimer = (float)Utils.GetTimeStamp();
            m_nextChangeTime = UnityEngine.Random.Range(180, 240);
        }
    }

    private void InitSenceList()
    {
        m_curRobot.SendCMD("cancopy,0");
        m_curRobot.SendCMD("inclevel,100");
        m_allSenceList.Clear();

        foreach (int key in TableManager.GetSceneClass().Keys)
        {
            Tab_SceneClass item = TableManager.GetSceneClassByID(key, 0);
            if (item == null)
            {
                continue;
            }

            m_allSenceList.Add(item);
        }
    }

    private Tab_SceneClass m_curCopySceneItem = null;

    private void RandomCurCopyScene()
    {
        int randItemId = m_curSenceId;

        while (randItemId == m_curSenceId)
        {
            randItemId = m_curRobot.mainPlayer.SceneClass;
            m_curCopySceneItem = GetOneRandomItem();

            if (m_curCopySceneItem != null)
            {
                //m_curSenceId = m_curCopySceneItem.CopySceneID;
            }

            if (m_curCopySceneItem == null)
                break;

            if (m_curSenceId == -1)
                randItemId = -1;
                continue;
        }
    }

    private Tab_SceneClass GetOneRandomItem()
    {
        int listCount = m_allSenceList.Count;

        if(listCount <= 1)
        {
            return null;
        }

        System.Random ran = new System.Random();

        return m_allSenceList[ran.Next(0, listCount - 1)];
    }

}
