//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_CardStarItem
{ private const string TAB_FILE_DATA = "Table/CardStarItem.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_ITEMID_0=2,
ID_ITEMNUM_0,
ID_ITEMID_1,
ID_ITEMNUM_1,
ID_ITEMID_2,
ID_ITEMNUM_2,
ID_GOLDCOST,
ID_INTIMACY,
ID_ALBUMEXPITEMNUM,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_AlbumExpItemNum;
 public int AlbumExpItemNum { get{ return m_AlbumExpItemNum;}}

private int m_GoldCost;
 public int GoldCost { get{ return m_GoldCost;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_Intimacy;
 public int Intimacy { get{ return m_Intimacy;}}

public int getItemIdCount() { return 3; } 
 private int[] m_ItemId = new int[3];
 public int GetItemIdbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_ItemId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> ItemIds { get {
  
return Array.AsReadOnly(m_ItemId);
}} 

public int getItemNumCount() { return 3; } 
 private int[] m_ItemNum = new int[3];
 public int GetItemNumbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_ItemNum[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> ItemNums { get {
  
return Array.AsReadOnly(m_ItemNum);
}} 

public static bool LoadTable(Dictionary<int, List<Tab_CardStarItem> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_CardStarItem SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_CardStarItem _values = new Tab_CardStarItem();
 _values.m_AlbumExpItemNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ALBUMEXPITEMNUM] as string);
_values.m_GoldCost =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GOLDCOST] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Intimacy =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_INTIMACY] as string);
_values.m_ItemId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMID_0] as string);
_values.m_ItemId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMID_1] as string);
_values.m_ItemId [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMID_2] as string);
_values.m_ItemNum [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMNUM_0] as string);
_values.m_ItemNum [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMNUM_1] as string);
_values.m_ItemNum [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMNUM_2] as string);

 return _values; }


}
}

