using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_MAINCITY_INTERACTIVE)]
public class GC_MAINCITY_INTERACTIVE_Handler : MessageHandler<GC_MAINCITY_INTERACTIVE>
{
    protected override void Execute(Robot curRobot, GC_MAINCITY_INTERACTIVE message)
    {
        
    }
}
