//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_ShopCommon
{ private const string TAB_FILE_DATA = "Table/ShopCommon.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_SHOPTYPE=2,
ID_SUBTYPE,
ID_ITEMID,
ID_DROPPERVIEWID,
ID_ITEMNUM,
ID_PRIORITY,
ID_LIMITTYPE,
ID_LIMITNUM,
ID_PRICETYPE,
ID_PRICE,
ID_PRICEORIGINAL ,
ID_MONTHCARDDISCOUNT,
ID_TAG,
ID_ISHIDE,
ID_ISHAVEBEGINDATE,
ID_BEGINDATE,
ID_BEGINTIME,
ID_ENDDATE,
ID_ENDTIME,
ID_TIMELIMIT,
ID_NEEDLEVEL,
ID_NEEDCHAPTERID,
ID_NEEDENDING,
ID_NEEDCUSTONSID,
ID_DRAWCARDCOUNT,
ID_TENDRAWCARDCOUNT,
ID_ISSUE,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_BeginDate;
 public int BeginDate { get{ return m_BeginDate;}}

private int m_BeginTime;
 public int BeginTime { get{ return m_BeginTime;}}

private int m_DrawCardCount;
 public int DrawCardCount { get{ return m_DrawCardCount;}}

private int m_DropPerviewId;
 public int DropPerviewId { get{ return m_DropPerviewId;}}

private int m_EndDate;
 public int EndDate { get{ return m_EndDate;}}

private int m_EndTime;
 public int EndTime { get{ return m_EndTime;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_IsHaveBeginDate;
 public int IsHaveBeginDate { get{ return m_IsHaveBeginDate;}}

private int m_IsHide;
 public int IsHide { get{ return m_IsHide;}}

private int m_Issue;
 public int Issue { get{ return m_Issue;}}

private int m_ItemId;
 public int ItemId { get{ return m_ItemId;}}

private int m_ItemNum;
 public int ItemNum { get{ return m_ItemNum;}}

private int m_LimitNum;
 public int LimitNum { get{ return m_LimitNum;}}

private int m_LimitType;
 public int LimitType { get{ return m_LimitType;}}

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

private int m_Price;
 public int Price { get{ return m_Price;}}

private int m_PriceOriginal ;
 public int PriceOriginal  { get{ return m_PriceOriginal ;}}

private int m_PriceType;
 public int PriceType { get{ return m_PriceType;}}

private int m_Priority;
 public int Priority { get{ return m_Priority;}}

private int m_ShopType;
 public int ShopType { get{ return m_ShopType;}}

private int m_SubType;
 public int SubType { get{ return m_SubType;}}

private int m_Tag;
 public int Tag { get{ return m_Tag;}}

private int m_TenDrawCardCount;
 public int TenDrawCardCount { get{ return m_TenDrawCardCount;}}

private int m_TimeLimit;
 public int TimeLimit { get{ return m_TimeLimit;}}

public static bool LoadTable(Dictionary<int, List<Tab_ShopCommon> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_ShopCommon SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_ShopCommon _values = new Tab_ShopCommon();
 _values.m_BeginDate =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_BEGINDATE] as string);
_values.m_BeginTime =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_BEGINTIME] as string);
_values.m_DrawCardCount =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DRAWCARDCOUNT] as string);
_values.m_DropPerviewId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPERVIEWID] as string);
_values.m_EndDate =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ENDDATE] as string);
_values.m_EndTime =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ENDTIME] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_IsHaveBeginDate =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISHAVEBEGINDATE] as string);
_values.m_IsHide =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISHIDE] as string);
_values.m_Issue =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISSUE] as string);
_values.m_ItemId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMID] as string);
_values.m_ItemNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMNUM] as string);
_values.m_LimitNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LIMITNUM] as string);
_values.m_LimitType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LIMITTYPE] as string);
_values.m_MonthCardDiscount =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MONTHCARDDISCOUNT] as string);
_values.m_NeedChapterId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NEEDCHAPTERID] as string);
_values.m_NeedCustonsId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NEEDCUSTONSID] as string);
_values.m_NeedEnding =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NEEDENDING] as string);
_values.m_NeedLevel =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NEEDLEVEL] as string);
_values.m_Price =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PRICE] as string);
_values.m_PriceOriginal  =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PRICEORIGINAL ] as string);
_values.m_PriceType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PRICETYPE] as string);
_values.m_Priority =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PRIORITY] as string);
_values.m_ShopType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SHOPTYPE] as string);
_values.m_SubType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SUBTYPE] as string);
_values.m_Tag =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TAG] as string);
_values.m_TenDrawCardCount =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TENDRAWCARDCOUNT] as string);
_values.m_TimeLimit =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TIMELIMIT] as string);

 return _values; }


}
}

