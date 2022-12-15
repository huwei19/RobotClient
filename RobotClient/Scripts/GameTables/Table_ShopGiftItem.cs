//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_ShopGiftItem
{ private const string TAB_FILE_DATA = "Table/ShopGiftItem.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_GIFTTYPE=2,
ID_ITEMID_0,
ID_ITEMCOUNT_0,
ID_ITEMID_1,
ID_ITEMCOUNT_1,
ID_ITEMID_2,
ID_ITEMCOUNT_2,
ID_ITEMID_3,
ID_ITEMCOUNT_3,
ID_ITEMID_4,
ID_ITEMCOUNT_4,
ID_ITEMID_5,
ID_ITEMCOUNT_5,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_GiftType;
 public int GiftType { get{ return m_GiftType;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

public int getItemCountCount() { return 6; } 
 private int[] m_ItemCount = new int[6];
 public int GetItemCountbyIndex(int idx) {
 if(idx>=0 && idx<6) {
 return m_ItemCount[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> ItemCounts { get {
  
return Array.AsReadOnly(m_ItemCount);
}} 

public int getItemIdCount() { return 6; } 
 private int[] m_ItemId = new int[6];
 public int GetItemIdbyIndex(int idx) {
 if(idx>=0 && idx<6) {
 return m_ItemId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> ItemIds { get {
  
return Array.AsReadOnly(m_ItemId);
}} 

public static bool LoadTable(Dictionary<int, List<Tab_ShopGiftItem> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_ShopGiftItem SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_ShopGiftItem _values = new Tab_ShopGiftItem();
 _values.m_GiftType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GIFTTYPE] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_ItemCount [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMCOUNT_0] as string);
_values.m_ItemCount [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMCOUNT_1] as string);
_values.m_ItemCount [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMCOUNT_2] as string);
_values.m_ItemCount [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMCOUNT_3] as string);
_values.m_ItemCount [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMCOUNT_4] as string);
_values.m_ItemCount [ 5 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMCOUNT_5] as string);
_values.m_ItemId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMID_0] as string);
_values.m_ItemId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMID_1] as string);
_values.m_ItemId [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMID_2] as string);
_values.m_ItemId [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMID_3] as string);
_values.m_ItemId [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMID_4] as string);
_values.m_ItemId [ 5 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMID_5] as string);

 return _values; }


}
}

