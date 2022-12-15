using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_RECMMEND_FRIEND)]
public class GC_RECMMEND_FRIEND_Handler : MessageHandler<GC_RECMMEND_FRIEND>
{
    protected override void Execute(Robot curRobot, GC_RECMMEND_FRIEND message)
    {
        FriendManagerComponent friendMgr = curRobot.mFriendData;
        friendMgr.SyncRecmmendData(message.Friend);

        //推荐朋友  加入搜索列表中
        //curRobot.LogFormat("{0}:Recmmend Friend", curRobot.Name);
        //string lname = "";
        //foreach (_DBFriend item in message.Friend)
        //{
        //    if (curRobot.m_friendsearch.ContainsKey(item.FriendId))
        //    {
        //        lname += item.Name;
        //        lname += ",";
        //        curRobot.m_friendsearch.Add(item.FriendId,0);
        //    }
        //}
        //if (lname != "")
        //{
        //    curRobot.LogFormat("{0}:curRobot.m_friendsearch [{1}]", curRobot.Name, lname);
        //}
    }
}
