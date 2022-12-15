using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SYNC_FRIEND)]
public class GC_SYNC_FRIEND_Handler : MessageHandler<GC_SYNC_FRIEND>
{
    protected override void Execute(Robot curRobot, GC_SYNC_FRIEND message)
    {
        foreach (var item in message.Friend)
        {
            //curRobot.LogFormat("{0}:{1}:Sync Friend", curRobot.Name, item.Name);
            if (!curRobot.m_friend.ContainsKey(item.FriendId))
            {
                curRobot.Log("-----------！！！！ 好友添加成功！！！！--------");
                curRobot.m_friend.Add(item.FriendId, item.Name);
            }
        }
        {
            FriendManagerComponent friendMgr = curRobot.mFriendData;
            if (friendMgr == null)
            {
                return;
            }
            for (int i = 0; i < message.Friend.Count; i++)
            {
                string id = message.Friend[i].FriendId.ToString();
                Friend friend = friendMgr.AddFriend(id);
                friend.Sync(message.Friend[i]);
                friendMgr.DelApplyData(id);
            }
            if (message.Has_GetNum)
            {
                friendMgr.GetNum = message.GetNum;
            }

            if (message.Has_GiveNum)
            {
                friendMgr.GiveNum = message.GiveNum;
            }
        }
    }
}
