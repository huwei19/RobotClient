using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SECRET_GET_AWARD)]
public class GC_SECRET_GET_AWARD_Handler : MessageHandler<GC_SECRET_GET_AWARD>
{
    protected override void Execute(Robot curRobot, GC_SECRET_GET_AWARD message)
    {
        
    }
}
