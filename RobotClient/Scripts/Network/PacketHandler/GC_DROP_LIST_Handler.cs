using LiteNet;
using UnityEngine;
using ProtobufPacket;
using Games.GlobeDefine;

[MessageHandler(MessageID.GC_DROP_LIST)]
public class GC_DROP_LIST_Handler : MessageHandler<GC_DROP_LIST>
{
    protected override void Execute(Robot curRobot, GC_DROP_LIST message)
    {
        switch(message.dropchannel)
        {
            case (int)DROP_CHANNEL.DROP_CHANNEL_FRIEND_GIVE:
                curRobot.TransEnd(TransEvent.FriendGive, RESULT.SUCCESS);
                break;
            case (int)DROP_CHANNEL.DROP_CHANNEL_FRIEND_GIVE_ONE:
                curRobot.TransEnd(TransEvent.FriendGiveOneKey, RESULT.SUCCESS);
                break;
        }
    }
}
