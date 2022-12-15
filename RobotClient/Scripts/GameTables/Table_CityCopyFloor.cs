//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_CityCopyFloor
{ private const string TAB_FILE_DATA = "Table/CityCopyFloor.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_INDEX=2,
ID_ENTERACTION,
ID_ENDACTION,
ID_ISSPECIAL,
ID_SPECIALDROPID,
ID_DESCRIPTIONFLAG,
ID_HOOKITEMID_0,
ID_HOOKITEMTYPE_0,
ID_HOOKITEMNUM_0,
ID_HOOKITEMID_1,
ID_HOOKITEMTYPE_1,
ID_HOOKITEMNUM_1,
ID_HOOKITEMID_2,
ID_HOOKITEMTYPE_2,
ID_HOOKITEMNUM_2,
ID_HOOKITEMID_3,
ID_HOOKITEMTYPE_3,
ID_HOOKITEMNUM_3,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_DescriptionFlag;
 public int DescriptionFlag { get{ return m_DescriptionFlag;}}

private int m_EndAction;
 public int EndAction { get{ return m_EndAction;}}

private int m_EnterAction;
 public int EnterAction { get{ return m_EnterAction;}}

public int getHookItemIdCount() { return 4; } 
 private int[] m_HookItemId = new int[4];
 public int GetHookItemIdbyIndex(int idx) {
 if(idx>=0 && idx<4) {
 return m_HookItemId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> HookItemIds { get {
  
return Array.AsReadOnly(m_HookItemId);
}} 

public int getHookItemNumCount() { return 4; } 
 private int[] m_HookItemNum = new int[4];
 public int GetHookItemNumbyIndex(int idx) {
 if(idx>=0 && idx<4) {
 return m_HookItemNum[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> HookItemNums { get {
  
return Array.AsReadOnly(m_HookItemNum);
}} 

public int getHookItemTypeCount() { return 4; } 
 private int[] m_HookItemType = new int[4];
 public int GetHookItemTypebyIndex(int idx) {
 if(idx>=0 && idx<4) {
 return m_HookItemType[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> HookItemTypes { get {
  
return Array.AsReadOnly(m_HookItemType);
}} 

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_Index;
 public int Index { get{ return m_Index;}}

private int m_IsSpecial;
 public int IsSpecial { get{ return m_IsSpecial;}}

private int m_SpecialDropId;
 public int SpecialDropId { get{ return m_SpecialDropId;}}

public static bool LoadTable(Dictionary<int, List<Tab_CityCopyFloor> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_CityCopyFloor SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_CityCopyFloor _values = new Tab_CityCopyFloor();
 _values.m_DescriptionFlag =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DESCRIPTIONFLAG] as string);
_values.m_EndAction =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ENDACTION] as string);
_values.m_EnterAction =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ENTERACTION] as string);
_values.m_HookItemId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HOOKITEMID_0] as string);
_values.m_HookItemId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HOOKITEMID_1] as string);
_values.m_HookItemId [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HOOKITEMID_2] as string);
_values.m_HookItemId [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HOOKITEMID_3] as string);
_values.m_HookItemNum [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HOOKITEMNUM_0] as string);
_values.m_HookItemNum [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HOOKITEMNUM_1] as string);
_values.m_HookItemNum [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HOOKITEMNUM_2] as string);
_values.m_HookItemNum [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HOOKITEMNUM_3] as string);
_values.m_HookItemType [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HOOKITEMTYPE_0] as string);
_values.m_HookItemType [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HOOKITEMTYPE_1] as string);
_values.m_HookItemType [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HOOKITEMTYPE_2] as string);
_values.m_HookItemType [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HOOKITEMTYPE_3] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Index =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_INDEX] as string);
_values.m_IsSpecial =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISSPECIAL] as string);
_values.m_SpecialDropId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SPECIALDROPID] as string);

 return _values; }


}
}

