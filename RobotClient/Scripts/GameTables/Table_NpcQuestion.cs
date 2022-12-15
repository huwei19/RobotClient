//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_NpcQuestion
{ private const string TAB_FILE_DATA = "Table/NpcQuestion.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_GROUDID=2,
ID_QUESTIONID,
ID_ANSWER,
ID_STARTACTIONID,
ID_RIGHTACTIONID,
ID_WRONGACTIONID,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Answer;
 public int Answer { get{ return m_Answer;}}

private int m_GroudId;
 public int GroudId { get{ return m_GroudId;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_QuestionID;
 public int QuestionID { get{ return m_QuestionID;}}

private int m_RightActionID;
 public int RightActionID { get{ return m_RightActionID;}}

private int m_StartActionID;
 public int StartActionID { get{ return m_StartActionID;}}

private int m_WrongActionID;
 public int WrongActionID { get{ return m_WrongActionID;}}

public static bool LoadTable(Dictionary<int, List<Tab_NpcQuestion> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_NpcQuestion SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_NpcQuestion _values = new Tab_NpcQuestion();
 _values.m_Answer =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ANSWER] as string);
_values.m_GroudId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GROUDID] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_QuestionID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_QUESTIONID] as string);
_values.m_RightActionID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_RIGHTACTIONID] as string);
_values.m_StartActionID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_STARTACTIONID] as string);
_values.m_WrongActionID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_WRONGACTIONID] as string);

 return _values; }


}
}

