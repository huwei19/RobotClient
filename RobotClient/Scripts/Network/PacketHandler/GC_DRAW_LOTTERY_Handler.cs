using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_DRAW_LOTTERY)]
public class GC_DRAW_LOTTERY_Handler : MessageHandler<GC_DRAW_LOTTERY>
{
    protected override void Execute(Robot curRobot, GC_DRAW_LOTTERY message)
    {
        
    }
}
