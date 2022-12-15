using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_UPDATE_CHARACTER)]
public class GC_UPDATE_CHARACTER_Handler : MessageHandler<GC_UPDATE_CHARACTER>
{
    protected override void Execute(Robot curRobot, GC_UPDATE_CHARACTER message)
    {
        
    }
}
