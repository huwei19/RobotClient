using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_APPLY_FRIEND)]
public class GC_APPLY_FRIEND_Handler : MessageHandler<GC_APPLY_FRIEND>
{
    protected override void Execute(Robot curRobot, GC_APPLY_FRIEND message)
    {///申请加我好友  
        foreach (var item in message.Friend)
        {
            if (!curRobot.m_apply.ContainsKey(item.FriendId))
            {
                curRobot.m_apply.Add(item.FriendId, 0);
            }
            //curRobot.LogFormat("{0}:{1}:Apply Friend", curRobot.Name, item.Name);
        }

        {
            FriendManagerComponent friendMgr = curRobot.mFriendData;
            for (int i = 0; i < message.Friend.Count; i++)
            {
                string id = message.Friend[i].FriendId.ToString();
                Friend friend = friendMgr.AddApply(id);
                friend.Sync(message.Friend[i]);
            }
        }
    }
}
