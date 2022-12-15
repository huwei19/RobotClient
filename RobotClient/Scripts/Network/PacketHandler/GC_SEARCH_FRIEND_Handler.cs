using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SEARCH_FRIEND)]
public class GC_SEARCH_FRIEND_Handler : MessageHandler<GC_SEARCH_FRIEND>
{
    protected override void Execute(Robot curRobot, GC_SEARCH_FRIEND message)
    {
        curRobot.TransEnd(TransEvent.FriendSearch, RESULT.SUCCESS);
    }
}
