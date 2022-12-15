using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_FUN_OPEN)]
public class GC_FUN_OPEN_Handler : MessageHandler<GC_FUN_OPEN>
{
    protected override void Execute(Robot curRobot, GC_FUN_OPEN message)
    {
        
    }
}
