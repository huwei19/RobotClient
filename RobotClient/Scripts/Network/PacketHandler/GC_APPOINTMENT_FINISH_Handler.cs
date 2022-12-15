using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_APPOINTMENT_FINISH)]
public class GC_APPOINTMENT_FINISH_Handler : MessageHandler<GC_APPOINTMENT_FINISH>
{
    protected override void Execute(Robot curRobot, GC_APPOINTMENT_FINISH message)
    {
        
    }
}
