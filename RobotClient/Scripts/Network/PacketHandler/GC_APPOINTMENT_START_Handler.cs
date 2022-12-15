using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_APPOINTMENT_START)]
public class GC_APPOINTMENT_START_Handler : MessageHandler<GC_APPOINTMENT_START>
{
    protected override void Execute(Robot curRobot, GC_APPOINTMENT_START message)
    {
        
    }
}
