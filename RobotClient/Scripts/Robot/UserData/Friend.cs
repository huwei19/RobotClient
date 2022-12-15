using System.Collections;
using System.Collections.Generic;
using System;
using ProtobufPacket;
[SLua.CustomLuaClass]
public class Friend
{
    private string friendId = "";
    private int level = 0;
    private int headId = 0;
    private long upTime = 0;
    private string name = "";
    private string appellation = "";
    private long outTiem = 0;
    private bool isApply = false;
    private bool isadvanceface = false;
    private int star = 0;
    private int titleId = -1;
    private TimeSpan ts = new TimeSpan(0);
    private bool isGive = false;
    private bool isGet = false;
    private bool isGetGift = false;
    private int friendPrice = 0;
    private long fId = 0;
    public string FriendID { get { return friendId; } }
    internal long LFID { get { return fId; } }
    public int Level { get { return level; } }
    public int HeadId { get { return headId; } }
    public long UpTime { get { return upTime; } }
    public string Name { get { return name; } }
    public string Appellation { get { return appellation; } }
    public long OutTime { get { return outTiem; } }
    public bool IsApply { get { return isApply; } set { isApply = value; } }
    public bool IsAdvanceface { get { return isadvanceface; } }
    public int Star { get { return star; } }
    public int Days { get { return ts.Days; } }
    public int Hours { get { return ts.Hours; } }
    public int IsOnline { get; set; }
    public int TitleId { get { return titleId; } }
    public bool IsGive { get { return isGive; } }
    public bool IsGet { get { return isGet; } }
    public bool IsGetGift { get { return isGetGift; } }
    public int FriendPrice { get { return friendPrice; } }
    public void Sync(_DBFriend data)
    {
        if (data.Has_FriendId)
        {
            friendId = data.FriendId.ToString();
            fId = data.FriendId;
        }

        if (data.Has_Level)
            level = data.Level;

        if (data.Has_HeadId)
            headId = data.HeadId;

        if (data.Has_UpTime)
            upTime = data.UpTime;

        if (data.Has_outTime)
        {
            outTiem = data.outTime;
        }
        if (data.Has_IsAdvanceFace)
        {
            isadvanceface = data.IsAdvanceFace;
        }
        if (data.Has_CardStar)
        {
            star = data.CardStar;
        }
        if (upTime < outTiem)
        {
            IsOnline = 0;
            ts = new TimeSpan((ServerTime.ServerAnsTime() - outTiem) * 10000000L);
        }
        else
        {
            IsOnline = 1;
            ts = new TimeSpan(0);
        }

        name = data.Name;
        appellation = data.appellation;
        titleId = data.TitleId;
    }
    internal void SetFriend(bool isgive,bool isget,bool isGGift,int fp)
    {
        isGive = isgive;
        isGet = isget;
        isGetGift = isGGift;
        friendPrice = fp;
    }
}
public class FriendInfo
{
    public int level;
    public string name;
    public string signature;
    public int Characters;
    public int cards;
    public long createTime;
    public int cardId;
    public int events;
    public int chaptersId;
    public bool isface;
    public int cardstar;
    public int darkevents;
    public int darkchaptersId;
    public int titleId;
    public void Clear()
    {
        level = 1;
        name = "";
        signature = "";
        cards = 0;
        Characters = 0;
        createTime = 0;
        cardId = 0;
        events = 0;
        chaptersId = 0;
        isface = false;
        cardstar = 0;
        darkevents = 0;
        darkchaptersId = 0;
        titleId = -1;
    }
}