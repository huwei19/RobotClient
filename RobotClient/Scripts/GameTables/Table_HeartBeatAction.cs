//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_HeartBeatAction
{ private const string TAB_FILE_DATA = "Table/HeartBeatAction.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_MOQIDULV=2,
ID_FATEID,
ID_POSID,
ID_SORT,
ID_BEGTIME,
ID_ENDTIME,
ID_ACTION1,
ID_ACTION2,
ID_ACTION3,
ID_DIALOGACTION,
ID_HEARTBEATDIALOG1,
ID_HEARTBEATDIALOG2,
ID_HEARTBEATDIALOG3,
ID_ENDACTION1,
ID_ENDACTION2,
ID_ENDACTION3,
ID_ENDACTIONNOT,
ID_MOQIDU,
ID_MOQIDUNOT,
ID_DROPID,
ID_DROPIDNOT,
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

private string m_BegTime;
 public string BegTime { get{ return m_BegTime;}}

private int m_DialogAction;
 public int DialogAction { get{ return m_DialogAction;}}

private int m_Dropid;
 public int Dropid { get{ return m_Dropid;}}

private int m_DropidNot;
 public int DropidNot { get{ return m_DropidNot;}}

public int getEndActionCount() { return 3; } 
 private int[] m_EndAction = new int[3];
 public int GetEndActionbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_EndAction[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> EndActions { get {
  
return Array.AsReadOnly(m_EndAction);
}} 

private int m_EndActionNot;
 public int EndActionNot { get{ return m_EndActionNot;}}

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

private int m_Moqidu;
 public int Moqidu { get{ return m_Moqidu;}}

private int m_MoqiduLv;
 public int MoqiduLv { get{ return m_MoqiduLv;}}

private int m_MoqiduNot;
 public int MoqiduNot { get{ return m_MoqiduNot;}}

private int m_PosId;
 public int PosId { get{ return m_PosId;}}

private int m_Sort;
 public int Sort { get{ return m_Sort;}}

public static bool LoadTable(Dictionary<int, List<Tab_HeartBeatAction> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_HeartBeatAction SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_HeartBeatAction _values = new Tab_HeartBeatAction();
 _values.m_Action [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTION1] as string);
_values.m_Action [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTION2] as string);
_values.m_Action [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTION3] as string);
_values.m_BegTime =  valuesList[(int)_ID.ID_BEGTIME] as string;
_values.m_DialogAction =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DIALOGACTION] as string);
_values.m_Dropid =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPID] as string);
_values.m_DropidNot =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPIDNOT] as string);
_values.m_EndAction [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ENDACTION1] as string);
_values.m_EndAction [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ENDACTION2] as string);
_values.m_EndAction [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ENDACTION3] as string);
_values.m_EndActionNot =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ENDACTIONNOT] as string);
_values.m_EndTime =  valuesList[(int)_ID.ID_ENDTIME] as string;
_values.m_FateId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FATEID] as string);
_values.m_HeartBeatDialog [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HEARTBEATDIALOG1] as string);
_values.m_HeartBeatDialog [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HEARTBEATDIALOG2] as string);
_values.m_HeartBeatDialog [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HEARTBEATDIALOG3] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Moqidu =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MOQIDU] as string);
_values.m_MoqiduLv =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MOQIDULV] as string);
_values.m_MoqiduNot =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MOQIDUNOT] as string);
_values.m_PosId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_POSID] as string);
_values.m_Sort =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SORT] as string);

 return _values; }


}
}

