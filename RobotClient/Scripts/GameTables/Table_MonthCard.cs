//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_MonthCard
{ private const string TAB_FILE_DATA = "Table/MonthCard.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NAME=2,
ID_TEXTRUE,
ID_DURATION,
ID_ITEMID_0,
ID_ITEMCOUNT_0,
ID_ITEMID_1,
ID_ITEMCOUNT_1,
ID_PHYSICALSTRENGTH,
ID_BUYMAX,
ID_MAXREWARD,
ID_DISCOUNTSHOPID,
ID_RECHARGEGIFTID,
ID_ISXINDONG,
ID_ACTIONID,
ID_CHARACTERID,
ID_SHOWINDEX,
ID_EXPIREDAY,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_ActionId;
 public int ActionId { get{ return m_ActionId;}}

private int m_BuyMax;
 public int BuyMax { get{ return m_BuyMax;}}

private int m_CharacterId;
 public int CharacterId { get{ return m_CharacterId;}}

private int m_DiscountShopId;
 public int DiscountShopId { get{ return m_DiscountShopId;}}

private int m_Duration;
 public int Duration { get{ return m_Duration;}}

private int m_ExpireDay;
 public int ExpireDay { get{ return m_ExpireDay;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_IsXinDong;
 public int IsXinDong { get{ return m_IsXinDong;}}

public int getItemCountCount() { return 2; } 
 private int[] m_ItemCount = new int[2];
 public int GetItemCountbyIndex(int idx) {
 if(idx>=0 && idx<2) {
 return m_ItemCount[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> ItemCounts { get {
  
return Array.AsReadOnly(m_ItemCount);
}} 

public int getItemIdCount() { return 2; } 
 private int[] m_ItemId = new int[2];
 public int GetItemIdbyIndex(int idx) {
 if(idx>=0 && idx<2) {
 return m_ItemId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> ItemIds { get {
  
return Array.AsReadOnly(m_ItemId);
}} 

private int m_MaxReward;
 public int MaxReward { get{ return m_MaxReward;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private int m_PhysicalStrength;
 public int PhysicalStrength { get{ return m_PhysicalStrength;}}

private int m_RechargeGiftId;
 public int RechargeGiftId { get{ return m_RechargeGiftId;}}

private int m_ShowIndex;
 public int ShowIndex { get{ return m_ShowIndex;}}

private string m_Textrue;
 public string Textrue { get{ return m_Textrue;}}

public static bool LoadTable(Dictionary<int, List<Tab_MonthCard> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_MonthCard SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_MonthCard _values = new Tab_MonthCard();
 _values.m_ActionId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIONID] as string);
_values.m_BuyMax =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_BUYMAX] as string);
_values.m_CharacterId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHARACTERID] as string);
_values.m_DiscountShopId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DISCOUNTSHOPID] as string);
_values.m_Duration =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DURATION] as string);
_values.m_ExpireDay =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_EXPIREDAY] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_IsXinDong =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISXINDONG] as string);
_values.m_ItemCount [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMCOUNT_0] as string);
_values.m_ItemCount [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMCOUNT_1] as string);
_values.m_ItemId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMID_0] as string);
_values.m_ItemId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMID_1] as string);
_values.m_MaxReward =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MAXREWARD] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_PhysicalStrength =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PHYSICALSTRENGTH] as string);
_values.m_RechargeGiftId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_RECHARGEGIFTID] as string);
_values.m_ShowIndex =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SHOWINDEX] as string);
_values.m_Textrue =  valuesList[(int)_ID.ID_TEXTRUE] as string;

 return _values; }


}
}

