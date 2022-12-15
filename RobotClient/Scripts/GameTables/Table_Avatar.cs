//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_Avatar
{ private const string TAB_FILE_DATA = "Table/Avatar.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_PREFAB=2,
ID_ANIM_0,
ID_ANIMTABLEID_0,
ID_ANIM_1,
ID_ANIMTABLEID_1,
ID_ANIM_2,
ID_ANIMTABLEID_2,
ID_ANIM_3,
ID_ANIMTABLEID_3,
ID_ANIM_4,
ID_ANIMTABLEID_4,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

public int getAnimTableIdCount() { return 5; } 
 private int[] m_AnimTableId = new int[5];
 public int GetAnimTableIdbyIndex(int idx) {
 if(idx>=0 && idx<5) {
 return m_AnimTableId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> AnimTableIds { get {
  
return Array.AsReadOnly(m_AnimTableId);
}} 

public int getAnimCount() { return 5; } 
 private string[] m_Anim = new string[5];
 public string GetAnimbyIndex(int idx) {
 if(idx>=0 && idx<5) {
 return m_Anim[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> Anims { get {
  
return Array.AsReadOnly(m_Anim);
}} 

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_Prefab;
 public string Prefab { get{ return m_Prefab;}}

public static bool LoadTable(Dictionary<int, List<Tab_Avatar> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_Avatar SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_Avatar _values = new Tab_Avatar();
 _values.m_AnimTableId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ANIMTABLEID_0] as string);
_values.m_AnimTableId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ANIMTABLEID_1] as string);
_values.m_AnimTableId [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ANIMTABLEID_2] as string);
_values.m_AnimTableId [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ANIMTABLEID_3] as string);
_values.m_AnimTableId [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ANIMTABLEID_4] as string);
_values.m_Anim [ 0 ] =  valuesList[(int)_ID.ID_ANIM_0] as string;
_values.m_Anim [ 1 ] =  valuesList[(int)_ID.ID_ANIM_1] as string;
_values.m_Anim [ 2 ] =  valuesList[(int)_ID.ID_ANIM_2] as string;
_values.m_Anim [ 3 ] =  valuesList[(int)_ID.ID_ANIM_3] as string;
_values.m_Anim [ 4 ] =  valuesList[(int)_ID.ID_ANIM_4] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Prefab =  valuesList[(int)_ID.ID_PREFAB] as string;

 return _values; }


}
}

