//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_SystemMail
{ private const string TAB_FILE_DATA = "Table/SystemMail.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_SENDERID=2,
ID_TITLE,
ID_CONTENT,
ID_IMPORTANCE,
ID_ITEMTYPE_0,
ID_ITEMID_0,
ID_ITEMNUM_0,
ID_ITEMTYPE_1,
ID_ITEMID_1,
ID_ITEMNUM_1,
ID_ITEMTYPE_2,
ID_ITEMID_2,
ID_ITEMNUM_2,
ID_ITEMTYPE_3,
ID_ITEMID_3,
ID_ITEMNUM_3,
ID_ITEMTYPE_4,
ID_ITEMID_4,
ID_ITEMNUM_4,
ID_OVERDUETIME,
ID_NODEL,
ID_ISUSEOVERDUETIME,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private string m_Content;
 public string Content { get{ return m_Content;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_Importance;
 public int Importance { get{ return m_Importance;}}

private int m_IsUseOverdueTime;
 public int IsUseOverdueTime { get{ return m_IsUseOverdueTime;}}

public int getItemIdCount() { return 5; } 
 private int[] m_ItemId = new int[5];
 public int GetItemIdbyIndex(int idx) {
 if(idx>=0 && idx<5) {
 return m_ItemId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> ItemIds { get {
  
return Array.AsReadOnly(m_ItemId);
}} 

public int getItemNumCount() { return 5; } 
 private int[] m_ItemNum = new int[5];
 public int GetItemNumbyIndex(int idx) {
 if(idx>=0 && idx<5) {
 return m_ItemNum[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> ItemNums { get {
  
return Array.AsReadOnly(m_ItemNum);
}} 

public int getItemTypeCount() { return 5; } 
 private int[] m_ItemType = new int[5];
 public int GetItemTypebyIndex(int idx) {
 if(idx>=0 && idx<5) {
 return m_ItemType[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> ItemTypes { get {
  
return Array.AsReadOnly(m_ItemType);
}} 

private int m_NoDel;
 public int NoDel { get{ return m_NoDel;}}

private int m_OverdueTime;
 public int OverdueTime { get{ return m_OverdueTime;}}

private int m_SenderId;
 public int SenderId { get{ return m_SenderId;}}

private string m_Title;
 public string Title { get{ return m_Title;}}

public static bool LoadTable(Dictionary<int, List<Tab_SystemMail> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_SystemMail SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_SystemMail _values = new Tab_SystemMail();
 _values.m_Content =  valuesList[(int)_ID.ID_CONTENT] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Importance =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_IMPORTANCE] as string);
_values.m_IsUseOverdueTime =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISUSEOVERDUETIME] as string);
_values.m_ItemId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMID_0] as string);
_values.m_ItemId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMID_1] as string);
_values.m_ItemId [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMID_2] as string);
_values.m_ItemId [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMID_3] as string);
_values.m_ItemId [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMID_4] as string);
_values.m_ItemNum [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMNUM_0] as string);
_values.m_ItemNum [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMNUM_1] as string);
_values.m_ItemNum [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMNUM_2] as string);
_values.m_ItemNum [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMNUM_3] as string);
_values.m_ItemNum [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMNUM_4] as string);
_values.m_ItemType [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMTYPE_0] as string);
_values.m_ItemType [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMTYPE_1] as string);
_values.m_ItemType [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMTYPE_2] as string);
_values.m_ItemType [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMTYPE_3] as string);
_values.m_ItemType [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMTYPE_4] as string);
_values.m_NoDel =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NODEL] as string);
_values.m_OverdueTime =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_OVERDUETIME] as string);
_values.m_SenderId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SENDERID] as string);
_values.m_Title =  valuesList[(int)_ID.ID_TITLE] as string;

 return _values; }


}
}

