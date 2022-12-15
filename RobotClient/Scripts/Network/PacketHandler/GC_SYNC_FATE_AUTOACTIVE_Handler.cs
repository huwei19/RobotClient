using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SYNC_FATE_AUTOACTIVE)]
public class GC_SYNC_FATE_AUTOACTIVE_Handler : MessageHandler<GC_SYNC_FATE_AUTOACTIVE>
{
    protected override void Execute(Robot curRobot, GC_SYNC_FATE_AUTOACTIVE message)
    {
        
    }
}
