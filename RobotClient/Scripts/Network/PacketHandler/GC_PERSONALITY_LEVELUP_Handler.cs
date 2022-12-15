using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_PERSONALITY_LEVELUP)]
public class GC_PERSONALITY_LEVELUP_Handler : MessageHandler<GC_PERSONALITY_LEVELUP>
{
    protected override void Execute(Robot curRobot, GC_PERSONALITY_LEVELUP message)
    {
        
    }
}
