//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_OptItem
{ private const string TAB_FILE_DATA = "Table/OptItem.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_SELECTMAXIMUM=2,
ID_ITEMMAXIMUM,
ID_ITEMID0,
ID_ITEMNUM0,
ID_ITEMID1,
ID_ITEMNUM1,
ID_ITEMID2,
ID_ITEMNUM2,
ID_ITEMID3,
ID_ITEMNUM3,
ID_ITEMID4,
ID_ITEMNUM4,
ID_ITEMID5,
ID_ITEMNUM5,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Id;
 public int Id { get{ return m_Id;}}

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

private int m_ItemMaximum;
 public int ItemMaximum { get{ return m_ItemMaximum;}}

public int getItemNumCount() { return 6; } 
 private int[] m_ItemNum = new int[6];
 public int GetItemNumbyIndex(int idx) {
 if(idx>=0 && idx<6) {
 return m_ItemNum[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> ItemNums { get {
  
return Array.AsReadOnly(m_ItemNum);
}} 

private int m_SelectMaximum;
 public int SelectMaximum { get{ return m_SelectMaximum;}}

public static bool LoadTable(Dictionary<int, List<Tab_OptItem> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_OptItem SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_OptItem _values = new Tab_OptItem();
 _values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_ItemId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMID0] as string);
_values.m_ItemId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMID1] as string);
_values.m_ItemId [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMID2] as string);
_values.m_ItemId [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMID3] as string);
_values.m_ItemId [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMID4] as string);
_values.m_ItemId [ 5 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMID5] as string);
_values.m_ItemMaximum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMMAXIMUM] as string);
_values.m_ItemNum [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMNUM0] as string);
_values.m_ItemNum [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMNUM1] as string);
_values.m_ItemNum [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMNUM2] as string);
_values.m_ItemNum [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMNUM3] as string);
_values.m_ItemNum [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMNUM4] as string);
_values.m_ItemNum [ 5 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMNUM5] as string);
_values.m_SelectMaximum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SELECTMAXIMUM] as string);

 return _values; }


}
}

