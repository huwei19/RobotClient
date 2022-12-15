using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_DRESSUP)]
public class GC_DRESSUP_Handler : MessageHandler<GC_DRESSUP>
{
    protected override void Execute(Robot curRobot, GC_DRESSUP message)
    {
        curRobot.TransEnd(TransEvent.DressUp, RESULT.SUCCESS);
        string HangingIds = "";
        for (int i = 0; i< message.DressInfo.HangingIds.Count; ++i)
        {
            HangingIds += message.DressInfo.HangingIds[i];
            HangingIds += ",";
        }
        //curRobot.LogFormat("Dress Up FateLineId:{0} SkinId:{1} HangingIds:{2}", message.FateLineId, message.DressInfo.SkinId, HangingIds);
    }
}
