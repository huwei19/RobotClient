using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SYNC_VCHAT)]
public class GC_SYNC_VCHAT_Handler : MessageHandler<GC_SYNC_VCHAT>
{
    protected override void Execute(Robot curRobot, GC_SYNC_VCHAT message)
    {
        
    }
}
