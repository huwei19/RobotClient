using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_STORY_LEVEL_START)]
public class GC_STORY_LEVEL_START_Handler : MessageHandler<GC_STORY_LEVEL_START>
{
    protected override void Execute(Robot curRobot, GC_STORY_LEVEL_START message)
    {
        if (curRobot == null || message == null)
            return;

        curRobot.OnReceiveMessage(message);
    }
}
