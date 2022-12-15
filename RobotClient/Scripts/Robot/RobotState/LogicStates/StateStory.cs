/********************************************************************
	purpose:	个人故事
*********************************************************************/
using System.Collections;
using System.Collections.Generic;
using ProtobufPacket;
using System;
using Games.Table;
using System.Linq;

public class StateStory : FSMState<Robot>
{
    public override string getName()
    {
        return "(个人故事) Story";
    }
    investigation m_investigation = new investigation();
    public override void onEnter(Robot entity)
    {
        //-------------------> #80001-90000个人故事
        int[] a = {
            81101,81102,81103,81107,82101,82102,82103,82107,83101,83102,83103,83107,84101,84102,84103,84107
        };
        m_investigation.init(entity, new List<int>(a));
    }

    Random rd = new Random();
    public override void onExecute(Robot entity)
    {
        //时间冷却
        if (!isRun())
        {
            return;
        }

        if (m_investigation.over())
        {
            entity.m_IsValid = true;
            return;
        }
        else
        {
            if (m_investigation.m_start)
            {
                m_investigation.start(entity);
                //start后，5-15分钟(随机)后发送finish
                setInterval(rd.Next(5 * 60 * 1000, 15 * 60 * 1000));
            }
            else
            {
                m_investigation.finish(entity);
                //5s后执行下一关卡
                setInterval(5000);
            }
        }
        return;
    }
}