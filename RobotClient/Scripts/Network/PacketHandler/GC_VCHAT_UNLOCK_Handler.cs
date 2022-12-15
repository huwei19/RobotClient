using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_VCHAT_UNLOCK)]
public class GC_VCHAT_UNLOCK_Handler : MessageHandler<GC_VCHAT_UNLOCK>
{
    protected override void Execute(Robot curRobot, GC_VCHAT_UNLOCK message)
    {
        
    }
}
