//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_HeartBeatQuestion
{ private const string TAB_FILE_DATA = "Table/HeartBeatQuestion.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_FATEID=2,
ID_POSID,
ID_BEGTIME,
ID_ENDTIME,
ID_QUESTIONID,
ID_ACTION0,
ID_HEARTBEATDIALOG0,
ID_ACTION1,
ID_HEARTBEATDIALOG1,
ID_ACTION2,
ID_HEARTBEATDIALOG2,
ID_ACTIONBEGIN,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

public int getActionCount() { return 3; } 
 private int[] m_Action = new int[3];
 public int GetActionbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_Action[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> Actions { get {
  
return Array.AsReadOnly(m_Action);
}} 

private int m_ActionBegin;
 public int ActionBegin { get{ return m_ActionBegin;}}

private string m_BegTime;
 public string BegTime { get{ return m_BegTime;}}

private string m_EndTime;
 public string EndTime { get{ return m_EndTime;}}

private int m_FateId;
 public int FateId { get{ return m_FateId;}}

public int getHeartBeatDialogCount() { return 3; } 
 private int[] m_HeartBeatDialog = new int[3];
 public int GetHeartBeatDialogbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_HeartBeatDialog[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> HeartBeatDialogs { get {
  
return Array.AsReadOnly(m_HeartBeatDialog);
}} 

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_PosId;
 public int PosId { get{ return m_PosId;}}

private int m_QuestionId;
 public int QuestionId { get{ return m_QuestionId;}}

public static bool LoadTable(Dictionary<int, List<Tab_HeartBeatQuestion> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_HeartBeatQuestion SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_HeartBeatQuestion _values = new Tab_HeartBeatQuestion();
 _values.m_Action [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTION0] as string);
_values.m_Action [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTION1] as string);
_values.m_Action [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTION2] as string);
_values.m_ActionBegin =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIONBEGIN] as string);
_values.m_BegTime =  valuesList[(int)_ID.ID_BEGTIME] as string;
_values.m_EndTime =  valuesList[(int)_ID.ID_ENDTIME] as string;
_values.m_FateId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FATEID] as string);
_values.m_HeartBeatDialog [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HEARTBEATDIALOG0] as string);
_values.m_HeartBeatDialog [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HEARTBEATDIALOG1] as string);
_values.m_HeartBeatDialog [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HEARTBEATDIALOG2] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_PosId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_POSID] as string);
_values.m_QuestionId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_QUESTIONID] as string);

 return _values; }


}
}

