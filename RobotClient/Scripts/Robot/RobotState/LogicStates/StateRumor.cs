/********************************************************************
	purpose:	传闻关卡
*********************************************************************/
using System.Collections;
using System.Collections.Generic;
using ProtobufPacket;
using System;
using LiteNet;
using System.IO;
using Games.Table;
using System.Linq;

public class StateRumor : FSMState<Robot>
{
    /// 传闻调查
    /// 
    investigation m_investigation = new investigation();
    public override string getName()
    {
        return "Rumor 传闻调查";
    }


    public override void onEnter(Robot entity)
    {
        //#传闻----------------> 70001-80000
        int[] a = {
                70101,70103,70105,70107,70109,70110,
                71101,71103,71104,71105,71106,71107,71109,71110,
                73101,73102,73103,73104,73105,73109,73110,
                72101,72102,72103,72104,72105,72106,72109,72110
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