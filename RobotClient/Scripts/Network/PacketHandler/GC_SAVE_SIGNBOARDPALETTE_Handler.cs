using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SAVE_SIGNBOARDPALETTE)]
public class GC_SAVE_SIGNBOARDPALETTE_Handler : MessageHandler<GC_SAVE_SIGNBOARDPALETTE>
{
    protected override void Execute(Robot curRobot, GC_SAVE_SIGNBOARDPALETTE message)
    {
        
    }
}
