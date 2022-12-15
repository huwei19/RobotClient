using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_UPDATE_VCHAT)]
public class GC_UPDATE_VCHAT_Handler : MessageHandler<GC_UPDATE_VCHAT>
{
    protected override void Execute(Robot curRobot, GC_UPDATE_VCHAT message)
    {
        
    }
}
