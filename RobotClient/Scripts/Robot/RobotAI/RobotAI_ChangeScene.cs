using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Games.Table;
using ProtobufPacket;

public class RobotAI_ChangeScene : RobotAIBase
{
    private float m_lastChangeTimer = 0;
    private List<int> m_sceneIDList = new List<int>();
    public RobotAI_ChangeScene(Robot curRobot)
        : base(curRobot)
    {
        m_sceneIDList.Clear();
        foreach(var tabScene in TableManager.GetSceneClass())
        {
            if(tabScene.Value[0].Type == 1)
            {
                m_sceneIDList.Add(tabScene.Key);
            }
        }
        m_lastChangeTimer = (float)Utils.GetTimeStamp();
    }

   

    public override void update()
    {
        if ((float)Utils.GetTimeStamp() - m_lastChangeTimer > 2.0f)
        {
            int nextScene = m_sceneIDList[Random.Range(0, m_sceneIDList.Count - 1)];
            if(nextScene != m_curRobot.mainPlayer.SceneClass)
            {
                m_curRobot.SendCMD("cs," + nextScene.ToString());
                //m_curRobot.SendChangeScene(nextScene);
                m_lastChangeTimer = (float)Utils.GetTimeStamp();
            }
        }
    }

    public override string getName()
    {
        return "ChangeScene";
    }

    public override string getSubName()
    {
        return "InSceneID:" + m_curRobot.mainPlayer.SceneClass.ToString();
    }
}
