using LiteNet;
using UnityEngine;
using ProtobufPacket;
using System.Collections.Generic;
using Games.Table;

[MessageHandler(MessageID.GC_SKIN_UNLOCK)]
public class GC_SKIN_UNLOCK_Handler : MessageHandler<GC_SKIN_UNLOCK>
{
    protected override void Execute(Robot curRobot, GC_SKIN_UNLOCK message)
    {
        Dictionary<int, List<Tab_SkinData>> tabSkinData = TableManager.GetSkinData();
        if (tabSkinData.ContainsKey(message.SkinId))
        {
            if (!curRobot.skindId.ContainsKey(message.SkinId))
            {
                Tab_SkinData tab = tabSkinData[message.SkinId][0];
                curRobot.skindId.Add(message.SkinId, tab);
                //curRobot.LogFormat("Skin Unlock SkinId:{0}", message.SkinId);
            }
        }
    }
}
