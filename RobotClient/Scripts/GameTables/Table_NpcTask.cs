//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_NpcTask
{ private const string TAB_FILE_DATA = "Table/NpcTask.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_PRIORITY=2,
ID_TITLE,
ID_NPCID,
ID_FRESHTYPE,
ID_FUNCTIONID,
ID_ACTIVITYID,
ID_SHOWCONDITIONID_0,
ID_SHOWCONDITIONID_1,
ID_RUMORID,
ID_TYPE,
ID_TYPEPARAM,
ID_TYPEGROUDNUM,
ID_TYPENUM,
ID_STARTACTION,
ID_FAILACTION,
ID_SUCACTION,
ID_DROPID,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_ActivityID;
 public int ActivityID { get{ return m_ActivityID;}}

private int m_DropId;
 public int DropId { get{ return m_DropId;}}

private int m_FailAction;
 public int FailAction { get{ return m_FailAction;}}

private int m_FreshType;
 public int FreshType { get{ return m_FreshType;}}

private int m_FunctionID;
 public int FunctionID { get{ return m_FunctionID;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_NPCID;
 public int NPCID { get{ return m_NPCID;}}

private int m_Priority;
 public int Priority { get{ return m_Priority;}}

private int m_RumorID;
 public int RumorID { get{ return m_RumorID;}}

public int getShowConditionIdCount() { return 2; } 
 private int[] m_ShowConditionId = new int[2];
 public int GetShowConditionIdbyIndex(int idx) {
 if(idx>=0 && idx<2) {
 return m_ShowConditionId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> ShowConditionIds { get {
  
return Array.AsReadOnly(m_ShowConditionId);
}} 

private int m_StartAction;
 public int StartAction { get{ return m_StartAction;}}

private int m_SucAction;
 public int SucAction { get{ return m_SucAction;}}

private string m_Title;
 public string Title { get{ return m_Title;}}

private int m_Type;
 public int Type { get{ return m_Type;}}

private int m_TypeGroudNum;
 public int TypeGroudNum { get{ return m_TypeGroudNum;}}

private int m_TypeNum;
 public int TypeNum { get{ return m_TypeNum;}}

private int m_TypeParam;
 public int TypeParam { get{ return m_TypeParam;}}

public static bool LoadTable(Dictionary<int, List<Tab_NpcTask> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_NpcTask SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_NpcTask _values = new Tab_NpcTask();
 _values.m_ActivityID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIVITYID] as string);
_values.m_DropId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPID] as string);
_values.m_FailAction =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FAILACTION] as string);
_values.m_FreshType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FRESHTYPE] as string);
_values.m_FunctionID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FUNCTIONID] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_NPCID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NPCID] as string);
_values.m_Priority =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PRIORITY] as string);
_values.m_RumorID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_RUMORID] as string);
_values.m_ShowConditionId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SHOWCONDITIONID_0] as string);
_values.m_ShowConditionId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SHOWCONDITIONID_1] as string);
_values.m_StartAction =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_STARTACTION] as string);
_values.m_SucAction =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SUCACTION] as string);
_values.m_Title =  valuesList[(int)_ID.ID_TITLE] as string;
_values.m_Type =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TYPE] as string);
_values.m_TypeGroudNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TYPEGROUDNUM] as string);
_values.m_TypeNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TYPENUM] as string);
_values.m_TypeParam =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TYPEPARAM] as string);

 return _values; }


}
}

