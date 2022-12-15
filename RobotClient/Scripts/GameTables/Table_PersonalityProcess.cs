//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_PersonalityProcess
{ private const string TAB_FILE_DATA = "Table/PersonalityProcess.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_INDEX=2,
ID_SHAPEAWARD,
ID_STORYAWARDASSET,
ID_STORYAWARDID,
ID_MONOLOGUEAWARD,
ID_CONSUMEID,
ID_CONSUMENUM,
ID_ADD,
ID_QUESTION_0,
ID_QUESTION_1,
ID_QUESTION_2,
ID_CONDITIONID_0,
ID_CONDITIONDESC_0,
ID_CONDITIONICON_0,
ID_CONDITIONID_1,
ID_CONDITIONDESC_1,
ID_CONDITIONICON_1,
ID_CONDITIONID_2,
ID_CONDITIONDESC_2,
ID_CONDITIONICON_2,
ID_CONDITIONID_3,
ID_CONDITIONDESC_3,
ID_CONDITIONICON_3,
ID_CONDITIONID_4,
ID_CONDITIONDESC_4,
ID_CONDITIONICON_4,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Add;
 public int Add { get{ return m_Add;}}

public int getConditionDescCount() { return 5; } 
 private string[] m_ConditionDesc = new string[5];
 public string GetConditionDescbyIndex(int idx) {
 if(idx>=0 && idx<5) {
 return m_ConditionDesc[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> ConditionDescs { get {
  
return Array.AsReadOnly(m_ConditionDesc);
}} 

public int getConditionIconCount() { return 5; } 
 private string[] m_ConditionIcon = new string[5];
 public string GetConditionIconbyIndex(int idx) {
 if(idx>=0 && idx<5) {
 return m_ConditionIcon[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> ConditionIcons { get {
  
return Array.AsReadOnly(m_ConditionIcon);
}} 

public int getConditionIdCount() { return 5; } 
 private string[] m_ConditionId = new string[5];
 public string GetConditionIdbyIndex(int idx) {
 if(idx>=0 && idx<5) {
 return m_ConditionId[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> ConditionIds { get {
  
return Array.AsReadOnly(m_ConditionId);
}} 

private int m_ConsumeId;
 public int ConsumeId { get{ return m_ConsumeId;}}

private int m_ConsumeNum;
 public int ConsumeNum { get{ return m_ConsumeNum;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_Index;
 public int Index { get{ return m_Index;}}

private int m_MonologueAward;
 public int MonologueAward { get{ return m_MonologueAward;}}

public int getQuestionCount() { return 3; } 
 private int[] m_Question = new int[3];
 public int GetQuestionbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_Question[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> Questions { get {
  
return Array.AsReadOnly(m_Question);
}} 

private int m_ShapeAward;
 public int ShapeAward { get{ return m_ShapeAward;}}

private string m_StoryAwardAsset;
 public string StoryAwardAsset { get{ return m_StoryAwardAsset;}}

private string m_StoryAwardId;
 public string StoryAwardId { get{ return m_StoryAwardId;}}

public static bool LoadTable(Dictionary<int, List<Tab_PersonalityProcess> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_PersonalityProcess SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_PersonalityProcess _values = new Tab_PersonalityProcess();
 _values.m_Add =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ADD] as string);
_values.m_ConditionDesc [ 0 ] =  valuesList[(int)_ID.ID_CONDITIONDESC_0] as string;
_values.m_ConditionDesc [ 1 ] =  valuesList[(int)_ID.ID_CONDITIONDESC_1] as string;
_values.m_ConditionDesc [ 2 ] =  valuesList[(int)_ID.ID_CONDITIONDESC_2] as string;
_values.m_ConditionDesc [ 3 ] =  valuesList[(int)_ID.ID_CONDITIONDESC_3] as string;
_values.m_ConditionDesc [ 4 ] =  valuesList[(int)_ID.ID_CONDITIONDESC_4] as string;
_values.m_ConditionIcon [ 0 ] =  valuesList[(int)_ID.ID_CONDITIONICON_0] as string;
_values.m_ConditionIcon [ 1 ] =  valuesList[(int)_ID.ID_CONDITIONICON_1] as string;
_values.m_ConditionIcon [ 2 ] =  valuesList[(int)_ID.ID_CONDITIONICON_2] as string;
_values.m_ConditionIcon [ 3 ] =  valuesList[(int)_ID.ID_CONDITIONICON_3] as string;
_values.m_ConditionIcon [ 4 ] =  valuesList[(int)_ID.ID_CONDITIONICON_4] as string;
_values.m_ConditionId [ 0 ] =  valuesList[(int)_ID.ID_CONDITIONID_0] as string;
_values.m_ConditionId [ 1 ] =  valuesList[(int)_ID.ID_CONDITIONID_1] as string;
_values.m_ConditionId [ 2 ] =  valuesList[(int)_ID.ID_CONDITIONID_2] as string;
_values.m_ConditionId [ 3 ] =  valuesList[(int)_ID.ID_CONDITIONID_3] as string;
_values.m_ConditionId [ 4 ] =  valuesList[(int)_ID.ID_CONDITIONID_4] as string;
_values.m_ConsumeId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CONSUMEID] as string);
_values.m_ConsumeNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CONSUMENUM] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Index =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_INDEX] as string);
_values.m_MonologueAward =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MONOLOGUEAWARD] as string);
_values.m_Question [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_QUESTION_0] as string);
_values.m_Question [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_QUESTION_1] as string);
_values.m_Question [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_QUESTION_2] as string);
_values.m_ShapeAward =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SHAPEAWARD] as string);
_values.m_StoryAwardAsset =  valuesList[(int)_ID.ID_STORYAWARDASSET] as string;
_values.m_StoryAwardId =  valuesList[(int)_ID.ID_STORYAWARDID] as string;

 return _values; }


}
}

