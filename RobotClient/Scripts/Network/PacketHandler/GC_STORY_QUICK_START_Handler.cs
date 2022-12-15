using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_STORY_QUICK_START)]
public class GC_STORY_QUICK_START_Handler : MessageHandler<GC_STORY_QUICK_START>
{
    protected override void Execute(Robot curRobot, GC_STORY_QUICK_START message)
    {
        
    }
}
