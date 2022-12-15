using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_STORY_CHAPTER_RESOLVE_ENDING)]
public class GC_STORY_CHAPTER_RESOLVE_ENDING_Handler : MessageHandler<GC_STORY_CHAPTER_RESOLVE_ENDING>
{
    protected override void Execute(Robot curRobot, GC_STORY_CHAPTER_RESOLVE_ENDING message)
    {
        curRobot.OnReceiveMessage(message);
    }
}
