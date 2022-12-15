using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_STORY_CHAPTER_REWIND)]
public class GC_STORY_CHAPTER_REWIND_Handler : MessageHandler<GC_STORY_CHAPTER_REWIND>
{
    protected override void Execute(Robot curRobot, GC_STORY_CHAPTER_REWIND message)
    {
        curRobot.Log("GC_STORY_CHAPTER_REWIND [" + message.Result + "]" + "]\n");

        var state = curRobot.FSM.CurState() as StateStoryEx;
        if (state != null)
        {
            state.OnReceiveMessage(curRobot, message);
        }
        var state_chapter = curRobot.FSM.CurState() as StateChapter;
        if (state_chapter != null)
        {
            state_chapter.OnReceiveMessage(curRobot, message);
        }
    }
}
