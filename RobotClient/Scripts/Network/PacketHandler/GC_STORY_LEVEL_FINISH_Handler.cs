using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_STORY_LEVEL_FINISH)]
public class GC_STORY_LEVEL_FINISH_Handler : MessageHandler<GC_STORY_LEVEL_FINISH>
{
    protected override void Execute(Robot curRobot, GC_STORY_LEVEL_FINISH message)
    {
        curRobot.Log("GC_STORY_LEVEL_FINISH [" + message.Id + "][" + message.Result + "]" + "]\n");
        if (curRobot == null || message == null)
            return;

        curRobot.OnReceiveMessage(message);
    }
}
