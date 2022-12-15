//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_Gift
{ private const string TAB_FILE_DATA = "Table/Gift.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_EXCLUSIVEINTIMACY=2,
ID_NOTEXCLUSIVEINTIMACY,
ID_FATEID_0,
ID_ACTIONLIKEID_0,
ID_FATEID_1,
ID_ACTIONLIKEID_1,
ID_FATEID_2,
ID_ACTIONLIKEID_2,
ID_FATEID_3,
ID_ACTIONLIKEID_3,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

public int getActionLikeIdCount() { return 4; } 
 private int[] m_ActionLikeId = new int[4];
 public int GetActionLikeIdbyIndex(int idx) {
 if(idx>=0 && idx<4) {
 return m_ActionLikeId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> ActionLikeIds { get {
  
return Array.AsReadOnly(m_ActionLikeId);
}} 

private int m_ExclusiveIntimacy;
 public int ExclusiveIntimacy { get{ return m_ExclusiveIntimacy;}}

public int getFateIdCount() { return 4; } 
 private int[] m_FateId = new int[4];
 public int GetFateIdbyIndex(int idx) {
 if(idx>=0 && idx<4) {
 return m_FateId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> FateIds { get {
  
return Array.AsReadOnly(m_FateId);
}} 

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_NotExclusiveIntimacy;
 public int NotExclusiveIntimacy { get{ return m_NotExclusiveIntimacy;}}

public static bool LoadTable(Dictionary<int, List<Tab_Gift> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_Gift SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_Gift _values = new Tab_Gift();
 _values.m_ActionLikeId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIONLIKEID_0] as string);
_values.m_ActionLikeId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIONLIKEID_1] as string);
_values.m_ActionLikeId [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIONLIKEID_2] as string);
_values.m_ActionLikeId [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIONLIKEID_3] as string);
_values.m_ExclusiveIntimacy =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_EXCLUSIVEINTIMACY] as string);
_values.m_FateId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FATEID_0] as string);
_values.m_FateId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FATEID_1] as string);
_values.m_FateId [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FATEID_2] as string);
_values.m_FateId [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FATEID_3] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_NotExclusiveIntimacy =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NOTEXCLUSIVEINTIMACY] as string);

 return _values; }


}
}

