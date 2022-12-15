using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SYNC_STORY)]
public class GC_SYNC_STORY_Handler : MessageHandler<GC_SYNC_STORY>
{
    protected override void Execute(Robot curRobot, GC_SYNC_STORY message)
    {
        //同步章节信息到本地
        curRobot.OnReceiveMessage(message);
    }
}
