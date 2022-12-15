using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_FRISTGIFT_RECEIVEREWARD)]
public class GC_FRISTGIFT_RECEIVEREWARD_Handler : MessageHandler<GC_FRISTGIFT_RECEIVEREWARD>
{
    protected override void Execute(Robot curRobot, GC_FRISTGIFT_RECEIVEREWARD message)
    {
        
    }
}
