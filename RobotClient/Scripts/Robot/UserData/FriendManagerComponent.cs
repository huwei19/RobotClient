using System.Collections;
using System.Collections.Generic;
using ProtobufPacket;
using LiteNet;
using System;
using System.Linq;
using Games.GlobeDefine;
[SLua.CustomLuaClass]
public class FriendManagerComponent
{
    private Dictionary<string, Friend> friendDic = new Dictionary<string, Friend>();//好友
    private List<Friend> friendList = new List<Friend>();
    //申请
    private Dictionary<string, Friend> friendApplyDic = new Dictionary<string, Friend>();
    private List<Friend> friendApplyList = new List<Friend>();
    //添加
    private Dictionary<string, Friend> friendRecmmendDic = new Dictionary<string, Friend>();
    private Dictionary<string, Friend> friendSearchAddDic = new Dictionary<string, Friend>();

    private List<long> givelist = new List<long>(); //赠送的id
    private List<long> getlist = new List<long>(); //领取的id
    private List<long> fgList = new List<long>();//赠送未领取

    private DateTime oldRecmmendTime = DateTime.Now;
    private DateTime oldSearchTime = DateTime.Now;
    private DateTime oldOpendTime = DateTime.Now;
    private FriendInfo friendInfo = new FriendInfo();
    private bool isApplyNew = false;
    private bool isFirstEnter = true;
    
    public FriendInfo GetFriendInfo { get { return friendInfo; } }
    public bool IsApplyNew { get { return isApplyNew; } }
    public bool IsFirstEnter { get { return isFirstEnter; } }
    public int GetNum { get; set; }
    public int GiveNum { get; set; }
    public List<Friend> Friends { get { return friendList; } }
    public List<Friend> Applys  = new List<Friend>();
    public List<_DBFriend> Recmmends = new List<_DBFriend>();
    public FriendManagerComponent()
    {
        oldOpendTime = DateTime.Now;
        oldRecmmendTime = DateTime.Now;
        oldSearchTime = DateTime.Now;
        GetNum = 0;
        GiveNum = 0;
        openGetNum = 0;
        oldOpenGetNum = 0;
    }
    public void Clear()
    {
        friendDic.Clear();
        friendList.Clear();
        friendApplyDic.Clear();
        friendApplyList.Clear();
        friendRecmmendDic.Clear();
        friendSearchAddDic.Clear();
        GetNum = 0;
        GiveNum = 0;
        openGetNum = 0;
        oldOpenGetNum = 0;
        IsOpenFriend = false;
    }
    public int OpenFriend(int seconds)
    {
        TimeSpan ts = oldOpendTime - DateTime.Now;
        if (ts.Seconds <= 0)
        {
            oldOpendTime = DateTime.Now.AddSeconds(seconds);
            return ts.Seconds;
        }
        return ts.Seconds;
    }
    public int Recmmend(int seconds)
    {
        TimeSpan ts = oldRecmmendTime - DateTime.Now;
        if (ts.Seconds <= 0)
        {
            oldRecmmendTime = DateTime.Now.AddSeconds(seconds);
            return ts.Seconds;
        }
        return ts.Seconds;
    }
    public int Search(int seconds)
    {
        TimeSpan ts = oldSearchTime - DateTime.Now;
        if (ts.Seconds <= 0)
        {
            oldSearchTime = DateTime.Now.AddSeconds(seconds);
            return ts.Seconds;
        }
        return ts.Seconds;
    }
    public List<Friend> GetApplyFriend()
    {
        if (friendApplyList.Count > 0)
        {
            isApplyNew = true;
            return friendApplyList;
        }
        isApplyNew = false;
        return null;
    }
    public List<Friend> GetRecmmendFriend()
    {
        if (friendRecmmendDic.Count > 0)
        {
            List<Friend> fl = new List<Friend>();
            foreach (Friend fd in friendRecmmendDic.Values)
            {
                fl.Add(fd);
            }
            return fl;
        }
        return null;
    }
    public List<Friend> GetSearchFriend()
    {
        if (friendSearchAddDic.Count > 0)
        {
            List<Friend> fl = new List<Friend>();
            foreach (Friend fd in friendSearchAddDic.Values)
            {
                fl.Add(fd);
            }
            return fl;
        }
        return null;
    }
    public bool IsFriend(string id)
    {
        return friendDic.ContainsKey(id);
    }

    public Friend AddApply(string id)
    {
        Friend friend = null;
        if (!friendApplyDic.TryGetValue(id, out friend)) {
            friend = new Friend();
            friendApplyDic.Add(id, friend);
            friendApplyList.Insert(0, friend);
            Applys.Add(friend);
        }
        return friend;
    }

    public void RemoveApply(string id)
    {
        if (friendApplyDic.TryGetValue(id, out Friend friend))
        {
            friendApplyDic.Remove(id);
            friendApplyList.Remove(friend);
            var item = Applys.Find((obj) => {return string.Equals(obj.FriendID,id); });
            if(item != null)
                Applys.Remove(item);
        }
        //GameEvent.Instance.Fire(GameEvent.UpdateApplyFriend);
    }

    public void CheckApplyMax()
    {
        if (GlobeVar.FriendApplyMax < friendApplyList.Count) {
            DelApplyData(friendApplyList[friendApplyList.Count - 1].FriendID);
        }
        if (friendApplyDic.Count > 0) {
            isApplyNew = true;
        } else {
            isApplyNew = false;
        }
    }

    internal Friend AddFriend(string id)
    {
        Friend friend = null;
        if (!friendDic.TryGetValue(id, out friend)) {
            friend = new Friend();
            friendDic.Add(id, friend);
            friendList.Add(friend);
        }
        return friend;
    }
    internal void FriendGiveInfoList(List<long> giveid, List<long> getid, List<long> gitfid)
    {
        givelist.Clear();
        getlist.Clear();
        fgList.Clear();
        if (giveid != null)
        {
            for (int i = 0;i < giveid.Count;i++)
            {
                givelist.Add(giveid[i]);
            }
        }
        if (getid != null)
        {
            for (int i = 0; i < getid.Count; i++)
            {
                getlist.Add(getid[i]);
            }
        }
        if (gitfid != null)
        {
            for (int i = 0; i < gitfid.Count; i++)
            {
                fgList.Add(gitfid[i]);
            }
        }
    }
    //修改类型
    internal void ModificationFrindPrice()
    {
        openGetNum = 0;
        bool isgive = false;
        bool isget = false;
        bool isGGift = false;
        for (int i = 0; i < friendList.Count;i++)
        {
            if (!givelist.Contains(friendList[i].LFID))
            {
                isgive = false;
            }else
            {
                isgive = true;
            }
            if (fgList.Contains(friendList[i].LFID))
            {
                if (getlist.Contains(friendList[i].LFID))
                {
                    isGGift = true;
                    isget = true;
                }
                else
                {
                    isGGift = true;
                    isget = false;
                    openGetNum++;
                }
            }
            else
            {
                if (getlist.Contains(friendList[i].LFID))
                {
                    isGGift = true;
                    isget = true;
                }
                else
                {
                    isGGift = false;
                    isget = false;
                }
            }
            friendList[i].SetFriend(isgive, isget, isGGift, 0);
        }
        if (openGetNum != oldOpenGetNum)
        {
            IsOpenFriend = false;
            oldOpenGetNum = openGetNum;
        }
    }
    internal void DelApplyData(string id)
    {
        RemoveApply(id);
        if (friendApplyDic.Count > 0)
        {
            isApplyNew = true;
        }
        else
        {
            isApplyNew = false;
        }
    }

    internal void DelFriend(long id)
    {
        string friendId = id.ToString();
        if (friendDic.ContainsKey(friendId))
        {
            friendDic.Remove(friendId);
            for (int i = 0; i < Friends.Count; i++)
            {
                if (Friends[i].FriendID == friendId)
                {
                    Friends.Remove(Friends[i]);
                    break;
                }
            }
        }
        //GameEvent.Instance.Fire(GameEvent.UpdateFriend);
    }    

    internal void SyncRecmmendData(List<_DBFriend> friends)
    {
        friendRecmmendDic.Clear();
        for (int i = 0; i < friends.Count; i++)
        {
            string id = friends[i].FriendId.ToString();
            if (!friendRecmmendDic.TryGetValue(id, out Friend friend))
            {
                friend = new Friend();
                friendRecmmendDic.Add(id, friend);
            }
            friend.Sync(friends[i]);
        }
        isFirstEnter = false;

        Recmmends = friends;
        //GameEvent.Instance.Fire(GameEvent.UpdateApplyFriend, 0);
    }

    internal void SyncSearchData(IList<_DBFriend> friends)
    {
        friendSearchAddDic.Clear();
        for (int i = 0; i < friends.Count; i++)
        {
            string id = friends[i].FriendId.ToString();
            if (!friendSearchAddDic.TryGetValue(id, out Friend friend))
            {
                friend = new Friend();
                friendSearchAddDic.Add(id, friend);
            }
            friend.Sync(friends[i]);
        }

        //GameEvent.Instance.Fire(GameEvent.UpdateApplyFriend, 1);
    }

    internal void SetFriendInfo(FriendInfo info)
    {
        friendInfo = info;
    }
   
    #region Red
    public bool IsOpenFriend = false;
    private int openGetNum = 0;
    private int oldOpenGetNum = 0;
    public bool IsFriendRed()
    {
        if (GetNum < GlobeVar.FriendGetNum && !IsOpenFriend)
        {
            for (int i = 0; i < friendList.Count; i++)
            {
                if (!friendList[i].IsGet && friendList[i].IsGetGift)
                {
                    return true;
                }
            }
        }        
        return friendApplyList.Count > 0;
    }
    #endregion

}
