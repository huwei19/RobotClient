//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_CardResolve
{ private const string TAB_FILE_DATA = "Table/CardResolve.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_ITEMID_0=2,
ID_ITEMCOUNT_0,
ID_ITEMID_1,
ID_ITEMCOUNT_1,
ID_ITEMID_2,
ID_ITEMCOUNT_2,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Id;
 public int Id { get{ return m_Id;}}

public int getItemCountCount() { return 3; } 
 private int[] m_ItemCount = new int[3];
 public int GetItemCountbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_ItemCount[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> ItemCounts { get {
  
return Array.AsReadOnly(m_ItemCount);
}} 

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

public static bool LoadTable(Dictionary<int, List<Tab_CardResolve> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_CardResolve SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_CardResolve _values = new Tab_CardResolve();
 _values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_ItemCount [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMCOUNT_0] as string);
_values.m_ItemCount [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMCOUNT_1] as string);
_values.m_ItemCount [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMCOUNT_2] as string);
_values.m_ItemId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMID_0] as string);
_values.m_ItemId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMID_1] as string);
_values.m_ItemId [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMID_2] as string);

 return _values; }


}
}

