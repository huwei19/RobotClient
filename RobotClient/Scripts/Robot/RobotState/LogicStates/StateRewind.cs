/********************************************************************
	purpose:	调查
*********************************************************************/

using System.Collections;
using System.Collections.Generic;
using ProtobufPacket;
using System;
using LiteNet;
using System.IO;
using Games.Table;
using System.Linq;

public class StateRewind: FSMState<Robot>
{
    investigation m_investigation = new investigation();
    public override string getName()
    {
        return "Rewind";
    }

    public override void onEnter(Robot entity)
    {
        entity.Log("Rewind: ");
        int[] a = {
                1001, 1101, 1003, 1103, 1007, 1105, 1201,
                2001, 2101, 2003, 2103, 2007, 2105, 2015, 2107, 2201,
                3001, 3101, 3003, 3102, 3007, 3104, 3015, 3106, 3019, 3107, 3201,
                31001,31101,31003,31103,31007,31105,31201,
                32001,32101,32003,32103,32007,32105,32015,32107,32201
            };
        m_investigation.init(entity, new List<int>(a));
    }

    public override void onExecute(Robot entity)
    {
        //时间冷却
        if (!isRun())
        {
            return;
        }
        
        m_investigation.start(entity);
        m_investigation.finish(entity);
        {
            CG_STORY_CHAPTER_REWIND packet = new CG_STORY_CHAPTER_REWIND();
            packet.ChapterId = 1;
            packet.RewindToLevelId = 1001;
            //entity.NetManager.SendMsg(packet);
            entity.SendMsg(packet);
        }
        m_investigation.m_num = 0;
        return;
    }
}