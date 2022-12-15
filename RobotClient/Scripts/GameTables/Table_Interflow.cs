//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_Interflow
{ private const string TAB_FILE_DATA = "Table/Interflow.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_ACTIONDISLIKE=2,
ID_MOTION,
ID_FACIAL,
ID_CV,
ID_CONTENT,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_ActionDislike;
 public int ActionDislike { get{ return m_ActionDislike;}}

private int m_CV;
 public int CV { get{ return m_CV;}}

private string m_Content;
 public string Content { get{ return m_Content;}}

private int m_Facial;
 public int Facial { get{ return m_Facial;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_Motion;
 public int Motion { get{ return m_Motion;}}

public static bool LoadTable(Dictionary<int, List<Tab_Interflow> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_Interflow SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_Interflow _values = new Tab_Interflow();
 _values.m_ActionDislike =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIONDISLIKE] as string);
_values.m_CV =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CV] as string);
_values.m_Content =  valuesList[(int)_ID.ID_CONTENT] as string;
_values.m_Facial =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FACIAL] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Motion =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MOTION] as string);

 return _values; }


}
}

