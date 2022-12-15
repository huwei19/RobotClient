using LiteNet;
using UnityEngine;
using ProtobufPacket;
using System.Collections.Generic;
using Games.Table;

[MessageHandler(MessageID.GC_DRESS_UNLOCK)]
public class GC_DRESS_UNLOCK_Handler : MessageHandler<GC_DRESS_UNLOCK>
{
    protected override void Execute(Robot curRobot, GC_DRESS_UNLOCK message)
    {
        curRobot.TransEnd(TransEvent.DressUnlock, RESULT.SUCCESS);
        Dictionary<int, List<Tab_Dressup>> tabDressup = TableManager.GetDressup();
        if (tabDressup.ContainsKey(message.DressId))
        {
            if (!curRobot.dressId.ContainsKey(message.DressId))
            {
                Tab_Dressup tab = tabDressup[message.DressId][0];
                curRobot.dressId.Add(message.DressId, tab);
                //curRobot.LogFormat("Dress Unlock DressId:{0}", message.DressId);
            }
        }

    }
}
