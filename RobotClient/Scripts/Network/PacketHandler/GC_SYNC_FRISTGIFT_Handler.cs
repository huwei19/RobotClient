using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SYNC_FRISTGIFT)]
public class GC_SYNC_FRISTGIFT_Handler : MessageHandler<GC_SYNC_FRISTGIFT>
{
    protected override void Execute(Robot curRobot, GC_SYNC_FRISTGIFT message)
    {
        
    }
}
