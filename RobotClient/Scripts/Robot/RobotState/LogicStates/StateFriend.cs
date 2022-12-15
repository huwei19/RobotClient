using System.Collections;
using System.Collections.Generic;
using ProtobufPacket;
using System;
using Games.Table;
using System.Linq;


/// <summary>
/// 好友测试的时候，需要同时生成机器人10个以上，这样static的Robot.m_search 才会有明显效果
/// </summary>
public class StateFriend : FSMState<Robot>
{
    Random rd = new Random();

    public override string getName()
    {
        return "Friend";
    }


    public override void onEnter(Robot entity)
    {
        if (!string.IsNullOrEmpty(entity.mainPlayer.Name) && !Robot.m_search.ContainsKey(entity.mainPlayer.Name)) {
            Robot.m_search.Add(entity.mainPlayer.Name, entity.mainPlayer.Guid);
        }
    }

    /// <summary>
    /// 增加好友
    /// </summary>
    /// <param name="entity"></param>
    void addFriend(Robot entity)
    {
        entity.Log("--------添加好友的位置：" + entity.m_frend_add_pos + " 搜索到的次数：" + Robot.m_search.Count);
        if (entity.m_frend_add_pos >= Robot.m_search.Count)
        {
            entity.m_frend_add_pos = 0;
        }
        if (Robot.m_search.ElementAt(entity.m_frend_add_pos).Value == entity.mainPlayer.Guid)
        {
            ++entity.m_frend_add_pos;
            return;
        }

        entity.Log("---- 一次增加好友: " + Robot.m_search.ElementAt(entity.m_frend_add_pos).Value);

        CG_SEARCH_ADD_FRIEND packet = new CG_SEARCH_ADD_FRIEND();
        packet.FriendId = (long)Robot.m_search.ElementAt(entity.m_frend_add_pos).Value;
        //entity.NetManager.SendMsg(packet);
        entity.SendMsg(packet);
    }

    ////同意好友申请
    void acceptFriend(Robot entity)
    {
        if (entity.m_apply.Count > 0)
        {
            CG_ACCEPT_FRIEND packet = new CG_ACCEPT_FRIEND();
            int val = rd.Next(0, entity.m_apply.Count);
            packet.FriendId = entity.m_apply.ElementAt(val).Key;
            //entity.NetManager.SendMsg(packet);
            entity.SendMsg(packet);
            entity.m_apply.Remove(packet.FriendId);
        }
    }


    ////拒绝好友申请
    void refuseFriend(Robot entity)
    {
        if (entity.m_apply.Count > 0)
        {
            CG_REFUSE_FRIEND packet = new CG_REFUSE_FRIEND();
            int val = rd.Next(0, entity.m_apply.Count);
            packet.FriendId = entity.m_apply.ElementAt(val).Key;
            //entity.NetManager.SendMsg(packet);
            entity.SendMsg(packet);
            entity.m_apply.Remove(packet.FriendId);
        }
    }
    ////删除好友
    void delFriend(Robot entity)
    {
        if (entity.m_friend.Count > 0)
        {
            CG_DEL_FRIEND packet = new CG_DEL_FRIEND();
            int val = rd.Next(0, entity.m_friend.Count);
            packet.FriendId = entity.m_friend.ElementAt(val).Key;
            //entity.NetManager.SendMsg(packet);
            entity.SendMsg(packet);
            entity.TransStart(TransEvent.FriendDel);
        }
    }
    //搜索好友
    void searchFriend(Robot entity)
    {
        CG_SEARCH_FRIEND packet = new CG_SEARCH_FRIEND();
        
        Random r = new Random();
        //0 到 Robot.m_FriendCreatUserName.Length 之间
        int i = r.Next(Robot.m_FriendCreatUserName.Length);
        entity.Log("查询角色名称 " + Robot.m_FriendCreatUserName[i]);
        packet.name = Robot.m_FriendCreatUserName[i];
        entity.SendMsg(packet);

        entity.TransStart(TransEvent.FriendSearch);
    }

    /// <summary>
    /// 好友赠礼
    /// </summary>
    /// <param name="friendId"></param>
    /// <param name="isOne"></param>
    public void SendGive(Robot entity)
    {
        CG_GIVE_FRIEND message = new CG_GIVE_FRIEND();

        entity.Log("---SendGive: 申请好友的个数：" + entity.m_apply.Count + " #好友个数:" + entity.m_friend.Count);
        if (entity.m_friend.Count > 0)
        {
            int val = rd.Next(0, entity.m_friend.Count);
            long long_temp = entity.m_friend.ElementAt(val).Key;
            message.friendId.Add(entity.m_friend.ElementAt(val).Key);
            message.isOne = false;  //是否一键赠送
            entity.SendMsg(message);
            entity.TransStart(TransEvent.FriendGive);
        }
    }


    int m_num = 0;

    public override void onExecute(Robot entity)
    {
        //时间冷却
        if (!isRun())
        {
            return;
        }
        //entity.Log("-----2###" + m_num);
        switch (m_num % 6)
        {
            case 0:
                {
                    //添加好友
                    addFriend(entity);
                }
                break;
            case 1:
                {
                    ////同意好友申请
                    acceptFriend(entity);
                }
                break;
            case 2:
                {
                    ////拒绝好友申请
                    refuseFriend(entity);
                }
                break;
            case 3:
            //{
            //    ////删除好友
            //    delFriend(entity);
            //    setInterval(10 * 1000);
            //}
            //break;
            case 4:
                {
                    //搜索好友
                    searchFriend(entity);
                }
                break;

            case 5: //好友赠礼
                {
                    SendGive(entity);
                }
                break;
        }

        ++m_num;
        return;
    }
}