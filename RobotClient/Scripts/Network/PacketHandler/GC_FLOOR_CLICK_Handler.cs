using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_FLOOR_CLICK)]
public class GC_FLOOR_CLICK_Handler : MessageHandler<GC_FLOOR_CLICK>
{
    protected override void Execute(Robot curRobot, GC_FLOOR_CLICK message)
    {
        
    }
}
