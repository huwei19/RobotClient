using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_ITEM_UPDATE)]
public class GC_ITEM_UPDATE_Handler : MessageHandler<GC_ITEM_UPDATE>
{
    protected override void Execute(Robot curRobot, GC_ITEM_UPDATE message)
    {
        curRobot.TransEnd(TransEvent.AddItem, RESULT.SUCCESS);
    }
}
