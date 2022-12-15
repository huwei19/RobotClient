using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_APPOINTMENT_OPEN)]
public class GC_APPOINTMENT_OPEN_Handler : MessageHandler<GC_APPOINTMENT_OPEN>
{
    protected override void Execute(Robot curRobot, GC_APPOINTMENT_OPEN message)
    {
        
    }
}
