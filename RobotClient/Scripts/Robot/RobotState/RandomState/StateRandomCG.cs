using System.Collections;
using System.Collections.Generic;
using ProtobufPacket;
using System;
using Games.Table;
using System.Linq;

public class StateRandomCG : FSMState<Robot>
{
    RobotAI_RandomCG m_random = null;
    public override string getName()
    {
        return "RandomCG";
    }

    public override void onEnter(Robot entity)
    {
        m_random = new RobotAI_RandomCG(entity, 0);
    }

    public override void onExecute(Robot entity)
    {
        if (!isRun())
        {
            return;
        }

        m_random.update();
        return;
    }
}