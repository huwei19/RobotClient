using UnityEngine;
using System.Collections;

public class RobotAIBase
{
    public enum AIState
    {
        NONE,
        EnterCopyScence,
    }
    protected Robot m_curRobot;

    public virtual void update() { }
    public virtual string getName() { return "unknown";}
    public virtual string getSubName() { return "none"; }
    public AIState CurState = AIState.NONE;

    public RobotAIBase(Robot robot)
    {
        m_curRobot = robot;
        CurState = AIState.NONE;
    }
}
