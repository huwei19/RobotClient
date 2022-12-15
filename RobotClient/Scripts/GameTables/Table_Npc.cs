//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_Npc
{ private const string TAB_FILE_DATA = "Table/Npc.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_PROFESSION=2,
ID_INTRODUCTION,
ID_INITUNLOCK,
ID_INITIALSTATE,
ID_STORYCHAPTERID,
ID_AVATARID_0,
ID_AVATARID_1,
ID_AVATARID_2,
ID_AVATARID_3,
ID_AVATARID_4,
ID_AVATARID_5,
ID_AVATARID_6,
ID_ACTIONID_0,
ID_ACTIONID_1,
ID_ACTIONID_2,
ID_ACTIONID_3,
ID_ACTIONID_4,
ID_ACTIONID_5,
ID_ACTIONID_6,
ID_ALLSTATE,
ID_DROPID,
ID_ISSHOW,
ID_CITYORDER,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

public int getActionIDCount() { return 7; } 
 private int[] m_ActionID = new int[7];
 public int GetActionIDbyIndex(int idx) {
 if(idx>=0 && idx<7) {
 return m_ActionID[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> ActionIDs { get {
  
return Array.AsReadOnly(m_ActionID);
}} 

private int m_AllState;
 public int AllState { get{ return m_AllState;}}

public int getAvatarIdCount() { return 7; } 
 private int[] m_AvatarId = new int[7];
 public int GetAvatarIdbyIndex(int idx) {
 if(idx>=0 && idx<7) {
 return m_AvatarId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> AvatarIds { get {
  
return Array.AsReadOnly(m_AvatarId);
}} 

private int m_CityOrder;
 public int CityOrder { get{ return m_CityOrder;}}

private int m_DropID;
 public int DropID { get{ return m_DropID;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_InitUnlock;
 public int InitUnlock { get{ return m_InitUnlock;}}

private int m_InitialState;
 public int InitialState { get{ return m_InitialState;}}

private string m_Introduction;
 public string Introduction { get{ return m_Introduction;}}

private int m_IsShow;
 public int IsShow { get{ return m_IsShow;}}

private string m_Profession;
 public string Profession { get{ return m_Profession;}}

private int m_StoryChapterId;
 public int StoryChapterId { get{ return m_StoryChapterId;}}

public static bool LoadTable(Dictionary<int, List<Tab_Npc> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_Npc SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_Npc _values = new Tab_Npc();
 _values.m_ActionID [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIONID_0] as string);
_values.m_ActionID [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIONID_1] as string);
_values.m_ActionID [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIONID_2] as string);
_values.m_ActionID [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIONID_3] as string);
_values.m_ActionID [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIONID_4] as string);
_values.m_ActionID [ 5 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIONID_5] as string);
_values.m_ActionID [ 6 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIONID_6] as string);
_values.m_AllState =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ALLSTATE] as string);
_values.m_AvatarId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AVATARID_0] as string);
_values.m_AvatarId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AVATARID_1] as string);
_values.m_AvatarId [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AVATARID_2] as string);
_values.m_AvatarId [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AVATARID_3] as string);
_values.m_AvatarId [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AVATARID_4] as string);
_values.m_AvatarId [ 5 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AVATARID_5] as string);
_values.m_AvatarId [ 6 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AVATARID_6] as string);
_values.m_CityOrder =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CITYORDER] as string);
_values.m_DropID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPID] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_InitUnlock =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_INITUNLOCK] as string);
_values.m_InitialState =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_INITIALSTATE] as string);
_values.m_Introduction =  valuesList[(int)_ID.ID_INTRODUCTION] as string;
_values.m_IsShow =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISSHOW] as string);
_values.m_Profession =  valuesList[(int)_ID.ID_PROFESSION] as string;
_values.m_StoryChapterId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_STORYCHAPTERID] as string);

 return _values; }


}
}

