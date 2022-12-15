//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_FateDialog
{ private const string TAB_FILE_DATA = "Table/FateDialog.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_PREID=2,
ID_POSTID,
ID_QUESTIONID,
ID_QUESTIONDIALOG_0,
ID_QUESTIONDIALOG_1,
ID_QUESTIONDIALOG_2,
ID_CHARACTERID,
ID_MOTIONINDEX,
ID_EXPINDEX,
ID_TITLEINFO,
ID_LEVELNAME,
ID_FATELINEID,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_CharacterId;
 public int CharacterId { get{ return m_CharacterId;}}

private int m_ExpIndex;
 public int ExpIndex { get{ return m_ExpIndex;}}

private int m_FateLineId;
 public int FateLineId { get{ return m_FateLineId;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_LevelName;
 public string LevelName { get{ return m_LevelName;}}

private int m_MotionIndex;
 public int MotionIndex { get{ return m_MotionIndex;}}

private int m_PostId;
 public int PostId { get{ return m_PostId;}}

private int m_PreId;
 public int PreId { get{ return m_PreId;}}

public int getQuestionDialogCount() { return 3; } 
 private int[] m_QuestionDialog = new int[3];
 public int GetQuestionDialogbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_QuestionDialog[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> QuestionDialogs { get {
  
return Array.AsReadOnly(m_QuestionDialog);
}} 

private int m_QuestionId;
 public int QuestionId { get{ return m_QuestionId;}}

private string m_TitleInfo;
 public string TitleInfo { get{ return m_TitleInfo;}}

public static bool LoadTable(Dictionary<int, List<Tab_FateDialog> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_FateDialog SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_FateDialog _values = new Tab_FateDialog();
 _values.m_CharacterId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHARACTERID] as string);
_values.m_ExpIndex =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_EXPINDEX] as string);
_values.m_FateLineId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FATELINEID] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_LevelName =  valuesList[(int)_ID.ID_LEVELNAME] as string;
_values.m_MotionIndex =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MOTIONINDEX] as string);
_values.m_PostId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_POSTID] as string);
_values.m_PreId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PREID] as string);
_values.m_QuestionDialog [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_QUESTIONDIALOG_0] as string);
_values.m_QuestionDialog [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_QUESTIONDIALOG_1] as string);
_values.m_QuestionDialog [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_QUESTIONDIALOG_2] as string);
_values.m_QuestionId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_QUESTIONID] as string);
_values.m_TitleInfo =  valuesList[(int)_ID.ID_TITLEINFO] as string;

 return _values; }


}
}

