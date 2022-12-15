using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_PERSONALITY_ADD)]
public class GC_PERSONALITY_ADD_Handler : MessageHandler<GC_PERSONALITY_ADD>
{
    protected override void Execute(Robot curRobot, GC_PERSONALITY_ADD message)
    {
        
    }
}
