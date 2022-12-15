using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_STORY_CHAPTER_SELECT_ENDING)]
public class GC_STORY_CHAPTER_SELECT_ENDING_Handler : MessageHandler<GC_STORY_CHAPTER_SELECT_ENDING>
{
    protected override void Execute(Robot curRobot, GC_STORY_CHAPTER_SELECT_ENDING message)
    {
        
    }
}
