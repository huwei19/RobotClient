using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_RUMOR_REDUCE)]
public class GC_RUMOR_REDUCE_Handler : MessageHandler<GC_RUMOR_REDUCE>
{
    protected override void Execute(Robot curRobot, GC_RUMOR_REDUCE message)
    {
        
    }
}
