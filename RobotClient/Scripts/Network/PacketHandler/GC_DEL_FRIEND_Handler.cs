using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_DEL_FRIEND)]
public class GC_DEL_FRIEND_Handler : MessageHandler<GC_DEL_FRIEND>
{
    protected override void Execute(Robot curRobot, GC_DEL_FRIEND message)
    {
        curRobot.TransEnd(TransEvent.FriendDel, RESULT.SUCCESS);
        if (curRobot.m_friend.ContainsKey(message.FriendId))
        {
            //curRobot.LogFormat("{0}:Del Friend:{1}", curRobot.Name, curRobot.m_friend[message.FriendId]);
            curRobot.m_friend.Remove(message.FriendId);
        }
    }
}
