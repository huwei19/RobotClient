//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_SceneNpcReplace
{ private const string TAB_FILE_DATA = "Table/SceneNpcReplace.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NEXTREPLACETIME=2,
ID_REPLACENPCID_0,
ID_REPLACECHANCE_0,
ID_REPLACENPCID_1,
ID_REPLACECHANCE_1,
ID_REPLACENPCID_2,
ID_REPLACECHANCE_2,
ID_REPLACENPCID_3,
ID_REPLACECHANCE_3,
ID_REPLACENPCID_4,
ID_REPLACECHANCE_4,
ID_REPLACENPCID_5,
ID_REPLACECHANCE_5,
ID_REPLACENPCID_6,
ID_REPLACECHANCE_6,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_NextReplaceTime;
 public int NextReplaceTime { get{ return m_NextReplaceTime;}}

public int getReplaceChanceCount() { return 7; } 
 private int[] m_ReplaceChance = new int[7];
 public int GetReplaceChancebyIndex(int idx) {
 if(idx>=0 && idx<7) {
 return m_ReplaceChance[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> ReplaceChances { get {
  
return Array.AsReadOnly(m_ReplaceChance);
}} 

public int getReplaceNpcIdCount() { return 7; } 
 private int[] m_ReplaceNpcId = new int[7];
 public int GetReplaceNpcIdbyIndex(int idx) {
 if(idx>=0 && idx<7) {
 return m_ReplaceNpcId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> ReplaceNpcIds { get {
  
return Array.AsReadOnly(m_ReplaceNpcId);
}} 

public static bool LoadTable(Dictionary<int, List<Tab_SceneNpcReplace> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_SceneNpcReplace SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_SceneNpcReplace _values = new Tab_SceneNpcReplace();
 _values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_NextReplaceTime =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NEXTREPLACETIME] as string);
_values.m_ReplaceChance [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REPLACECHANCE_0] as string);
_values.m_ReplaceChance [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REPLACECHANCE_1] as string);
_values.m_ReplaceChance [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REPLACECHANCE_2] as string);
_values.m_ReplaceChance [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REPLACECHANCE_3] as string);
_values.m_ReplaceChance [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REPLACECHANCE_4] as string);
_values.m_ReplaceChance [ 5 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REPLACECHANCE_5] as string);
_values.m_ReplaceChance [ 6 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REPLACECHANCE_6] as string);
_values.m_ReplaceNpcId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REPLACENPCID_0] as string);
_values.m_ReplaceNpcId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REPLACENPCID_1] as string);
_values.m_ReplaceNpcId [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REPLACENPCID_2] as string);
_values.m_ReplaceNpcId [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REPLACENPCID_3] as string);
_values.m_ReplaceNpcId [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REPLACENPCID_4] as string);
_values.m_ReplaceNpcId [ 5 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REPLACENPCID_5] as string);
_values.m_ReplaceNpcId [ 6 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REPLACENPCID_6] as string);

 return _values; }


}
}

