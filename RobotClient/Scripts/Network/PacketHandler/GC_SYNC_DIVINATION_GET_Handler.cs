using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SYNC_DIVINATION_GET)]
public class GC_SYNC_DIVINATION_GET_Handler : MessageHandler<GC_SYNC_DIVINATION_GET>
{
    protected override void Execute(Robot curRobot, GC_SYNC_DIVINATION_GET message)
    {
        
    }
}
