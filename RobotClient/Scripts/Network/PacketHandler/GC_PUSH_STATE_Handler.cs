using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_PUSH_STATE)]
public class GC_PUSH_STATE_Handler : MessageHandler<GC_PUSH_STATE>
{
    protected override void Execute(Robot curRobot, GC_PUSH_STATE message)
    {
        
    }
}
