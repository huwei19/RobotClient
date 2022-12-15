using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_ADD_CHARACTER)]
public class GC_ADD_CHARACTER_Handler : MessageHandler<GC_ADD_CHARACTER>
{
    protected override void Execute(Robot curRobot, GC_ADD_CHARACTER message)
    {
        
    }
}
