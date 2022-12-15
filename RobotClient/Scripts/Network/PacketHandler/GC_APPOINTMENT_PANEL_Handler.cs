using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_APPOINTMENT_PANEL)]
public class GC_APPOINTMENT_PANEL_Handler : MessageHandler<GC_APPOINTMENT_PANEL>
{
    protected override void Execute(Robot curRobot, GC_APPOINTMENT_PANEL message)
    {
        
    }
}
