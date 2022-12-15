//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_Appointment
{ private const string TAB_FILE_DATA = "Table/Appointment.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NAME=2,
ID_CARDICONPATH,
ID_BGPATHTYPE,
ID_BGPATH,
ID_FATELINEID,
ID_BEGINACTIONID,
ID_QUESTIONID,
ID_ENDACTIONID,
ID_SELECTIONCONDITION_0,
ID_SELECTIONACTION_0,
ID_SELECTIONCONDITION_1,
ID_SELECTIONACTION_1,
ID_SELECTIONCONDITION_2,
ID_SELECTIONACTION_2,
ID_SORTID,
ID_STATE,
ID_SECRETKEYWORDID_0,
ID_SECRETKEYWORDID_1,
ID_CONSUMEITEMID,
ID_CONSUMEITEMNUM,
ID_DROPREWARD,
ID_INTIMACYREWARD,
ID_OPENINGCONDITION,
ID_ACQUISITIONCONDITION,
ID_MUSICID,
ID_SOUNDID,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_AcquisitionCondition;
 public int AcquisitionCondition { get{ return m_AcquisitionCondition;}}

private int m_BeginActionId;
 public int BeginActionId { get{ return m_BeginActionId;}}

private string m_BgPath;
 public string BgPath { get{ return m_BgPath;}}

private int m_BgPathType;
 public int BgPathType { get{ return m_BgPathType;}}

private string m_CardIconPath;
 public string CardIconPath { get{ return m_CardIconPath;}}

private int m_ConsumeItemId;
 public int ConsumeItemId { get{ return m_ConsumeItemId;}}

private int m_ConsumeItemNum;
 public int ConsumeItemNum { get{ return m_ConsumeItemNum;}}

private int m_DropReward;
 public int DropReward { get{ return m_DropReward;}}

private int m_EndActionId;
 public int EndActionId { get{ return m_EndActionId;}}

private int m_FatelineId;
 public int FatelineId { get{ return m_FatelineId;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_IntimacyReward;
 public int IntimacyReward { get{ return m_IntimacyReward;}}

private int m_MusicId;
 public int MusicId { get{ return m_MusicId;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private int m_OpeningCondition;
 public int OpeningCondition { get{ return m_OpeningCondition;}}

private int m_QuestionId;
 public int QuestionId { get{ return m_QuestionId;}}

public int getSecretKeywordIdCount() { return 2; } 
 private int[] m_SecretKeywordId = new int[2];
 public int GetSecretKeywordIdbyIndex(int idx) {
 if(idx>=0 && idx<2) {
 return m_SecretKeywordId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> SecretKeywordIds { get {
  
return Array.AsReadOnly(m_SecretKeywordId);
}} 

public int getSelectionActionCount() { return 3; } 
 private int[] m_SelectionAction = new int[3];
 public int GetSelectionActionbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_SelectionAction[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> SelectionActions { get {
  
return Array.AsReadOnly(m_SelectionAction);
}} 

public int getSelectionConditionCount() { return 3; } 
 private int[] m_SelectionCondition = new int[3];
 public int GetSelectionConditionbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_SelectionCondition[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> SelectionConditions { get {
  
return Array.AsReadOnly(m_SelectionCondition);
}} 

private int m_SortId;
 public int SortId { get{ return m_SortId;}}

private int m_SoundId;
 public int SoundId { get{ return m_SoundId;}}

private int m_State;
 public int State { get{ return m_State;}}

public static bool LoadTable(Dictionary<int, List<Tab_Appointment> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_Appointment SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_Appointment _values = new Tab_Appointment();
 _values.m_AcquisitionCondition =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACQUISITIONCONDITION] as string);
_values.m_BeginActionId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_BEGINACTIONID] as string);
_values.m_BgPath =  valuesList[(int)_ID.ID_BGPATH] as string;
_values.m_BgPathType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_BGPATHTYPE] as string);
_values.m_CardIconPath =  valuesList[(int)_ID.ID_CARDICONPATH] as string;
_values.m_ConsumeItemId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CONSUMEITEMID] as string);
_values.m_ConsumeItemNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CONSUMEITEMNUM] as string);
_values.m_DropReward =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPREWARD] as string);
_values.m_EndActionId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ENDACTIONID] as string);
_values.m_FatelineId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FATELINEID] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_IntimacyReward =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_INTIMACYREWARD] as string);
_values.m_MusicId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MUSICID] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_OpeningCondition =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_OPENINGCONDITION] as string);
_values.m_QuestionId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_QUESTIONID] as string);
_values.m_SecretKeywordId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SECRETKEYWORDID_0] as string);
_values.m_SecretKeywordId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SECRETKEYWORDID_1] as string);
_values.m_SelectionAction [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SELECTIONACTION_0] as string);
_values.m_SelectionAction [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SELECTIONACTION_1] as string);
_values.m_SelectionAction [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SELECTIONACTION_2] as string);
_values.m_SelectionCondition [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SELECTIONCONDITION_0] as string);
_values.m_SelectionCondition [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SELECTIONCONDITION_1] as string);
_values.m_SelectionCondition [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SELECTIONCONDITION_2] as string);
_values.m_SortId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SORTID] as string);
_values.m_SoundId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SOUNDID] as string);
_values.m_State =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_STATE] as string);

 return _values; }


}
}

