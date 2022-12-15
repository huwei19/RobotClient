//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_Task
{ private const string TAB_FILE_DATA = "Table/Task.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NAME=2,
ID_REFRESHTYPE,
ID_TASKGROUPID,
ID_TIMELIMITORDER,
ID_ADDVALUE,
ID_TYPE,
ID_SUBTYPE,
ID_GROUPTYPE,
ID_NEXTID,
ID_LEVEL,
ID_CHAPTERID,
ID_DESCRIBE,
ID_NEEDPARAM_0,
ID_NEEDPARAM_1,
ID_COMPLETECONDITIONS_0,
ID_COMPLETECONDITIONS_1,
ID_DROPID,
ID_DROPPREVIEW,
ID_FUNLCOKID,
ID_JUMPID,
ID_ISSHOW,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_AddValue;
 public int AddValue { get{ return m_AddValue;}}

private int m_ChapterId;
 public int ChapterId { get{ return m_ChapterId;}}

public int getCompleteConditionsCount() { return 2; } 
 private int[] m_CompleteConditions = new int[2];
 public int GetCompleteConditionsbyIndex(int idx) {
 if(idx>=0 && idx<2) {
 return m_CompleteConditions[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> CompleteConditionss { get {
  
return Array.AsReadOnly(m_CompleteConditions);
}} 

private string m_Describe;
 public string Describe { get{ return m_Describe;}}

private int m_DropId;
 public int DropId { get{ return m_DropId;}}

private int m_DropPreview;
 public int DropPreview { get{ return m_DropPreview;}}

private int m_FunlcokID;
 public int FunlcokID { get{ return m_FunlcokID;}}

private int m_GroupType;
 public int GroupType { get{ return m_GroupType;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_IsShow;
 public int IsShow { get{ return m_IsShow;}}

private int m_JumpID;
 public int JumpID { get{ return m_JumpID;}}

private int m_Level;
 public int Level { get{ return m_Level;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

public int getNeedParamCount() { return 2; } 
 private int[] m_NeedParam = new int[2];
 public int GetNeedParambyIndex(int idx) {
 if(idx>=0 && idx<2) {
 return m_NeedParam[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> NeedParams { get {
  
return Array.AsReadOnly(m_NeedParam);
}} 

private int m_NextId;
 public int NextId { get{ return m_NextId;}}

private int m_RefreshType;
 public int RefreshType { get{ return m_RefreshType;}}

private int m_SubType;
 public int SubType { get{ return m_SubType;}}

private int m_TaskGroupId;
 public int TaskGroupId { get{ return m_TaskGroupId;}}

private int m_TimeLimitOrder;
 public int TimeLimitOrder { get{ return m_TimeLimitOrder;}}

private int m_Type;
 public int Type { get{ return m_Type;}}

public static bool LoadTable(Dictionary<int, List<Tab_Task> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_Task SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_Task _values = new Tab_Task();
 _values.m_AddValue =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ADDVALUE] as string);
_values.m_ChapterId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHAPTERID] as string);
_values.m_CompleteConditions [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_COMPLETECONDITIONS_0] as string);
_values.m_CompleteConditions [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_COMPLETECONDITIONS_1] as string);
_values.m_Describe =  valuesList[(int)_ID.ID_DESCRIBE] as string;
_values.m_DropId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPID] as string);
_values.m_DropPreview =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPREVIEW] as string);
_values.m_FunlcokID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FUNLCOKID] as string);
_values.m_GroupType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GROUPTYPE] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_IsShow =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISSHOW] as string);
_values.m_JumpID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_JUMPID] as string);
_values.m_Level =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LEVEL] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_NeedParam [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NEEDPARAM_0] as string);
_values.m_NeedParam [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NEEDPARAM_1] as string);
_values.m_NextId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NEXTID] as string);
_values.m_RefreshType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REFRESHTYPE] as string);
_values.m_SubType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SUBTYPE] as string);
_values.m_TaskGroupId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TASKGROUPID] as string);
_values.m_TimeLimitOrder =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TIMELIMITORDER] as string);
_values.m_Type =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TYPE] as string);

 return _values; }


}
}

