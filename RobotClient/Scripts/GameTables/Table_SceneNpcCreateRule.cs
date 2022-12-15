//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_SceneNpcCreateRule
{ private const string TAB_FILE_DATA = "Table/SceneNpcCreateRule.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_STORYFLAGID=2,
ID_STORYLINEID,
ID_ENVID,
ID_HASCARDID,
ID_HIDEFLAGID,
ID_HIDELINEID,
ID_FUNCTIONUNLOCK,
ID_HEROID_0,
ID_HEROID_1,
ID_HEROID_2,
ID_HEROID_3,
ID_REQTUTORIALID,
ID_WEEKDAY,
ID_WEEKBEGIN,
ID_WEEKEND,
ID_YARDLVMIN,
ID_YARDLVMAX,
ID_ISCARDTHEMENPC,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_EnvID;
 public int EnvID { get{ return m_EnvID;}}

private int m_FunctionUnlock;
 public int FunctionUnlock { get{ return m_FunctionUnlock;}}

private int m_HasCardID;
 public int HasCardID { get{ return m_HasCardID;}}

public int getHeroIDCount() { return 4; } 
 private int[] m_HeroID = new int[4];
 public int GetHeroIDbyIndex(int idx) {
 if(idx>=0 && idx<4) {
 return m_HeroID[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> HeroIDs { get {
  
return Array.AsReadOnly(m_HeroID);
}} 

private int m_HideFlagID;
 public int HideFlagID { get{ return m_HideFlagID;}}

private int m_HideLineID;
 public int HideLineID { get{ return m_HideLineID;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_IsCardThemeNpc;
 public int IsCardThemeNpc { get{ return m_IsCardThemeNpc;}}

private int m_ReqTutorialID;
 public int ReqTutorialID { get{ return m_ReqTutorialID;}}

private int m_StoryFlagID;
 public int StoryFlagID { get{ return m_StoryFlagID;}}

private int m_StoryLineID;
 public int StoryLineID { get{ return m_StoryLineID;}}

private int m_WeekBegin;
 public int WeekBegin { get{ return m_WeekBegin;}}

private int m_WeekDay;
 public int WeekDay { get{ return m_WeekDay;}}

private int m_WeekEnd;
 public int WeekEnd { get{ return m_WeekEnd;}}

private int m_YardLvMax;
 public int YardLvMax { get{ return m_YardLvMax;}}

private int m_YardLvMin;
 public int YardLvMin { get{ return m_YardLvMin;}}

public static bool LoadTable(Dictionary<int, List<Tab_SceneNpcCreateRule> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_SceneNpcCreateRule SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_SceneNpcCreateRule _values = new Tab_SceneNpcCreateRule();
 _values.m_EnvID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ENVID] as string);
_values.m_FunctionUnlock =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FUNCTIONUNLOCK] as string);
_values.m_HasCardID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HASCARDID] as string);
_values.m_HeroID [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HEROID_0] as string);
_values.m_HeroID [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HEROID_1] as string);
_values.m_HeroID [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HEROID_2] as string);
_values.m_HeroID [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HEROID_3] as string);
_values.m_HideFlagID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HIDEFLAGID] as string);
_values.m_HideLineID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HIDELINEID] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_IsCardThemeNpc =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISCARDTHEMENPC] as string);
_values.m_ReqTutorialID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REQTUTORIALID] as string);
_values.m_StoryFlagID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_STORYFLAGID] as string);
_values.m_StoryLineID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_STORYLINEID] as string);
_values.m_WeekBegin =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_WEEKBEGIN] as string);
_values.m_WeekDay =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_WEEKDAY] as string);
_values.m_WeekEnd =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_WEEKEND] as string);
_values.m_YardLvMax =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_YARDLVMAX] as string);
_values.m_YardLvMin =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_YARDLVMIN] as string);

 return _values; }


}
}

