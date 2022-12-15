//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_CityWork
{ private const string TAB_FILE_DATA = "Table/CityWork.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NAME=2,
ID_CITYNPCID,
ID_LEVEL,
ID_ACTIVITYID,
ID_LOGICTYPE,
ID_LOGICPARAM,
ID_CHAPTERID,
ID_OTHER_0,
ID_OTHER_1,
ID_TOUCHHEART,
ID_HEARTBEAT,
ID_GET,
ID_NOT,
ID_PROGRESS,
ID_TASKDIALOG,
ID_NOTASKDIALOG,
ID_RUMORNUM,
ID_RUMORID_0,
ID_RUMORID_1,
ID_RUMORID_2,
ID_RUMORID_3,
ID_RUMORID_4,
ID_RUMORID_5,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_ActivityId;
 public int ActivityId { get{ return m_ActivityId;}}

private int m_CityNpcId;
 public int CityNpcId { get{ return m_CityNpcId;}}

private string m_Get;
 public string Get { get{ return m_Get;}}

private string m_Heartbeat;
 public string Heartbeat { get{ return m_Heartbeat;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_Level;
 public int Level { get{ return m_Level;}}

private int m_LogicParam;
 public int LogicParam { get{ return m_LogicParam;}}

private int m_LogicType;
 public int LogicType { get{ return m_LogicType;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private string m_NoTaskDialog;
 public string NoTaskDialog { get{ return m_NoTaskDialog;}}

private string m_Not;
 public string Not { get{ return m_Not;}}

public int getOtherCount() { return 2; } 
 private string[] m_Other = new string[2];
 public string GetOtherbyIndex(int idx) {
 if(idx>=0 && idx<2) {
 return m_Other[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> Others { get {
  
return Array.AsReadOnly(m_Other);
}} 

private string m_Progress;
 public string Progress { get{ return m_Progress;}}

public int getRumorIdCount() { return 6; } 
 private int[] m_RumorId = new int[6];
 public int GetRumorIdbyIndex(int idx) {
 if(idx>=0 && idx<6) {
 return m_RumorId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> RumorIds { get {
  
return Array.AsReadOnly(m_RumorId);
}} 

private string m_TaskDialog;
 public string TaskDialog { get{ return m_TaskDialog;}}

private string m_TouchHeart;
 public string TouchHeart { get{ return m_TouchHeart;}}

private int m_ChapterId;
 public int ChapterId { get{ return m_ChapterId;}}

private int m_RumorNum;
 public int RumorNum { get{ return m_RumorNum;}}

public static bool LoadTable(Dictionary<int, List<Tab_CityWork> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_CityWork SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_CityWork _values = new Tab_CityWork();
 _values.m_ActivityId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIVITYID] as string);
_values.m_CityNpcId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CITYNPCID] as string);
_values.m_Get =  valuesList[(int)_ID.ID_GET] as string;
_values.m_Heartbeat =  valuesList[(int)_ID.ID_HEARTBEAT] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Level =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LEVEL] as string);
_values.m_LogicParam =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LOGICPARAM] as string);
_values.m_LogicType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LOGICTYPE] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_NoTaskDialog =  valuesList[(int)_ID.ID_NOTASKDIALOG] as string;
_values.m_Not =  valuesList[(int)_ID.ID_NOT] as string;
_values.m_Other [ 0 ] =  valuesList[(int)_ID.ID_OTHER_0] as string;
_values.m_Other [ 1 ] =  valuesList[(int)_ID.ID_OTHER_1] as string;
_values.m_Progress =  valuesList[(int)_ID.ID_PROGRESS] as string;
_values.m_RumorId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_RUMORID_0] as string);
_values.m_RumorId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_RUMORID_1] as string);
_values.m_RumorId [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_RUMORID_2] as string);
_values.m_RumorId [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_RUMORID_3] as string);
_values.m_RumorId [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_RUMORID_4] as string);
_values.m_RumorId [ 5 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_RUMORID_5] as string);
_values.m_TaskDialog =  valuesList[(int)_ID.ID_TASKDIALOG] as string;
_values.m_TouchHeart =  valuesList[(int)_ID.ID_TOUCHHEART] as string;
_values.m_ChapterId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHAPTERID] as string);
_values.m_RumorNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_RUMORNUM] as string);

 return _values; }


}
}

