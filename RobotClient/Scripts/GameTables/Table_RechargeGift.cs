//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_RechargeGift
{ private const string TAB_FILE_DATA = "Table/RechargeGift.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_ITEMID=2,
ID_ITEMCOUNT,
ID_DROPPERVIEWID,
ID_SUBTABINDEX,
ID_TAG,
ID_PRIORITY,
ID_ISHIDE,
ID_ISFASTBUY,
ID_ISHAVEBEGINDATE,
ID_MONTHCARDDISCOUNT,
ID_BEGINPUTAWAYDATE,
ID_BEGINPUTAWAYTIME,
ID_ENDPUTAWAYDATE,
ID_ENDPUTAWAYTIME,
ID_TIMELIMIT,
ID_NEEDLEVEL,
ID_NEEDCHAPTERID,
ID_NEEDENDING,
ID_NEEDCUSTONSID,
ID_DRAWCARDCOUNT,
ID_TENDRAWCARDCOUNT,
ID_DRAWSSRCOUNT,
ID_FIRSTDRAWCARDID,
ID_LOGINCOUNT,
ID_ISSUE,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_BeginPutawayDate;
 public int BeginPutawayDate { get{ return m_BeginPutawayDate;}}

private int m_BeginPutawayTime;
 public int BeginPutawayTime { get{ return m_BeginPutawayTime;}}

private int m_DrawCardCount;
 public int DrawCardCount { get{ return m_DrawCardCount;}}

private int m_DrawSSRCount;
 public int DrawSSRCount { get{ return m_DrawSSRCount;}}

private int m_DropPerviewId;
 public int DropPerviewId { get{ return m_DropPerviewId;}}

private int m_EndPutawayDate;
 public int EndPutawayDate { get{ return m_EndPutawayDate;}}

private int m_EndPutawayTime;
 public int EndPutawayTime { get{ return m_EndPutawayTime;}}

private int m_FirstDrawCardId;
 public int FirstDrawCardId { get{ return m_FirstDrawCardId;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_IsFastBuy;
 public int IsFastBuy { get{ return m_IsFastBuy;}}

private int m_IsHaveBeginDate;
 public int IsHaveBeginDate { get{ return m_IsHaveBeginDate;}}

private int m_IsHide;
 public int IsHide { get{ return m_IsHide;}}

private int m_Issue;
 public int Issue { get{ return m_Issue;}}

private int m_ItemCount;
 public int ItemCount { get{ return m_ItemCount;}}

private int m_ItemId;
 public int ItemId { get{ return m_ItemId;}}

private int m_LoginCount;
 public int LoginCount { get{ return m_LoginCount;}}

private int m_MonthCardDiscount;
 public int MonthCardDiscount { get{ return m_MonthCardDiscount;}}

private int m_NeedChapterId;
 public int NeedChapterId { get{ return m_NeedChapterId;}}

private int m_NeedCustonsId;
 public int NeedCustonsId { get{ return m_NeedCustonsId;}}

private int m_NeedEnding;
 public int NeedEnding { get{ return m_NeedEnding;}}

private int m_NeedLevel;
 public int NeedLevel { get{ return m_NeedLevel;}}

private int m_Priority;
 public int Priority { get{ return m_Priority;}}

private int m_SubTabIndex;
 public int SubTabIndex { get{ return m_SubTabIndex;}}

private int m_Tag;
 public int Tag { get{ return m_Tag;}}

private int m_TenDrawCardCount;
 public int TenDrawCardCount { get{ return m_TenDrawCardCount;}}

private int m_TimeLimit;
 public int TimeLimit { get{ return m_TimeLimit;}}

public static bool LoadTable(Dictionary<int, List<Tab_RechargeGift> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_RechargeGift SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_RechargeGift _values = new Tab_RechargeGift();
 _values.m_BeginPutawayDate =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_BEGINPUTAWAYDATE] as string);
_values.m_BeginPutawayTime =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_BEGINPUTAWAYTIME] as string);
_values.m_DrawCardCount =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DRAWCARDCOUNT] as string);
_values.m_DrawSSRCount =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DRAWSSRCOUNT] as string);
_values.m_DropPerviewId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPERVIEWID] as string);
_values.m_EndPutawayDate =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ENDPUTAWAYDATE] as string);
_values.m_EndPutawayTime =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ENDPUTAWAYTIME] as string);
_values.m_FirstDrawCardId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FIRSTDRAWCARDID] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_IsFastBuy =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISFASTBUY] as string);
_values.m_IsHaveBeginDate =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISHAVEBEGINDATE] as string);
_values.m_IsHide =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISHIDE] as string);
_values.m_Issue =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISSUE] as string);
_values.m_ItemCount =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMCOUNT] as string);
_values.m_ItemId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMID] as string);
_values.m_LoginCount =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LOGINCOUNT] as string);
_values.m_MonthCardDiscount =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MONTHCARDDISCOUNT] as string);
_values.m_NeedChapterId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NEEDCHAPTERID] as string);
_values.m_NeedCustonsId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NEEDCUSTONSID] as string);
_values.m_NeedEnding =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NEEDENDING] as string);
_values.m_NeedLevel =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NEEDLEVEL] as string);
_values.m_Priority =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PRIORITY] as string);
_values.m_SubTabIndex =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SUBTABINDEX] as string);
_values.m_Tag =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TAG] as string);
_values.m_TenDrawCardCount =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TENDRAWCARDCOUNT] as string);
_values.m_TimeLimit =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TIMELIMIT] as string);

 return _values; }


}
}

