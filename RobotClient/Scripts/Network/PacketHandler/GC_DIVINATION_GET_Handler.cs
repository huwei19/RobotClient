using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_DIVINATION_GET)]
public class GC_DIVINATION_GET_Handler : MessageHandler<GC_DIVINATION_GET>
{
    protected override void Execute(Robot curRobot, GC_DIVINATION_GET message)
    {
        
    }
}
