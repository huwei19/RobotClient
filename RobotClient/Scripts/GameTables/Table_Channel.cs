//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_Channel
{ private const string TAB_FILE_DATA = "Table/Channel.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_CHANNELID=2,
ID_GROUPID,
ID_UPDATEADDRESS,
ID_TENCENTMAPKEY,
ID_PRODUCTGROUPID,
ID_SUBCHANNELID,
ID_CHANNELNAME,
ID_NEEDIDENTIFICATION,
ID_ISFACEBOOK,
ID_ISVK,
ID_ISINSTAGRAM,
ID_ISWECHATSESSION,
ID_ISWECHATTIMELINE,
ID_ISSHOWQQSHARE,
ID_ISSHOWWECATSHARE,
ID_ISSHOWBLOG,
ID_ISSHOWWECHATMOMENTS,
ID_ISCONTACTSERVICE,
ID_ISDELETEROLE,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private string m_ChannelId;
 public string ChannelId { get{ return m_ChannelId;}}

private string m_ChannelName;
 public string ChannelName { get{ return m_ChannelName;}}

private int m_GroupId;
 public int GroupId { get{ return m_GroupId;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_IsContactService;
 public int IsContactService { get{ return m_IsContactService;}}

private int m_IsDeleteRole;
 public int IsDeleteRole { get{ return m_IsDeleteRole;}}

private int m_IsFacebook;
 public int IsFacebook { get{ return m_IsFacebook;}}

private int m_IsInstagram;
 public int IsInstagram { get{ return m_IsInstagram;}}

private int m_IsShowBlog;
 public int IsShowBlog { get{ return m_IsShowBlog;}}

private int m_IsShowQQShare;
 public int IsShowQQShare { get{ return m_IsShowQQShare;}}

private int m_IsShowWecatShare;
 public int IsShowWecatShare { get{ return m_IsShowWecatShare;}}

private int m_IsShowWechatMoments;
 public int IsShowWechatMoments { get{ return m_IsShowWechatMoments;}}

private int m_IsVK;
 public int IsVK { get{ return m_IsVK;}}

private int m_IsWeChatSession;
 public int IsWeChatSession { get{ return m_IsWeChatSession;}}

private int m_IsWeChatTimeLine;
 public int IsWeChatTimeLine { get{ return m_IsWeChatTimeLine;}}

private int m_NeedIdentification;
 public int NeedIdentification { get{ return m_NeedIdentification;}}

private int m_ProductGroupID;
 public int ProductGroupID { get{ return m_ProductGroupID;}}

private int m_SubChannelId;
 public int SubChannelId { get{ return m_SubChannelId;}}

private string m_TencentMapKey;
 public string TencentMapKey { get{ return m_TencentMapKey;}}

private string m_UpdateAddress;
 public string UpdateAddress { get{ return m_UpdateAddress;}}

public static bool LoadTable(Dictionary<int, List<Tab_Channel> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_Channel SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_Channel _values = new Tab_Channel();
 _values.m_ChannelId =  valuesList[(int)_ID.ID_CHANNELID] as string;
_values.m_ChannelName =  valuesList[(int)_ID.ID_CHANNELNAME] as string;
_values.m_GroupId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GROUPID] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_IsContactService =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISCONTACTSERVICE] as string);
_values.m_IsDeleteRole =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISDELETEROLE] as string);
_values.m_IsFacebook =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISFACEBOOK] as string);
_values.m_IsInstagram =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISINSTAGRAM] as string);
_values.m_IsShowBlog =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISSHOWBLOG] as string);
_values.m_IsShowQQShare =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISSHOWQQSHARE] as string);
_values.m_IsShowWecatShare =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISSHOWWECATSHARE] as string);
_values.m_IsShowWechatMoments =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISSHOWWECHATMOMENTS] as string);
_values.m_IsVK =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISVK] as string);
_values.m_IsWeChatSession =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISWECHATSESSION] as string);
_values.m_IsWeChatTimeLine =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISWECHATTIMELINE] as string);
_values.m_NeedIdentification =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NEEDIDENTIFICATION] as string);
_values.m_ProductGroupID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PRODUCTGROUPID] as string);
_values.m_SubChannelId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SUBCHANNELID] as string);
_values.m_TencentMapKey =  valuesList[(int)_ID.ID_TENCENTMAPKEY] as string;
_values.m_UpdateAddress =  valuesList[(int)_ID.ID_UPDATEADDRESS] as string;

 return _values; }


}
}

