using UnityEngine;
using System.Collections;
using ProtobufPacket;
using LiteNet;

public class RobotAI_RandomCG : RobotAIBase
{

    private float m_sendTimer = 0;
    private string m_curPackID;
    private int m_type = 0;
    public RobotAI_RandomCG(Robot curRobot, int type)
        : base(curRobot)
    {
        m_type = type;
    }

    public override string getName()
    {
        return "send random packet";
    }

    public override string getSubName()
    {
        return m_curPackID;
    }

    public override void update()
    {
        if((float)Utils.GetTimeStamp() - m_sendTimer < 1)
        {
            return;
        }

        if(m_type == 0)
        {
            int packetID = Random.Range(30, (int)MessageID.Max- 1);
            if (m_curRobot.SendRandomPacket(packetID))
            {
                m_sendTimer = (float)Utils.GetTimeStamp();
                m_curPackID = ((MessageID)packetID).ToString();
            }
        }
        else if(m_type == 1)
        {
            m_curRobot.SendRandomMsg();
        }
        else if(m_type == 2)
        {
            m_curRobot.SendRandomBytes();
        }
        
    }
}
