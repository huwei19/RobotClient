using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SAVE_THEMEPALETTE)]
public class GC_SAVE_THEMEPALETTE_Handler : MessageHandler<GC_SAVE_THEMEPALETTE>
{
    protected override void Execute(Robot curRobot, GC_SAVE_THEMEPALETTE message)
    {
        
    }
}
