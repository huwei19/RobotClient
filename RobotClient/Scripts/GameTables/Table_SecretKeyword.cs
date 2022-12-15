//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_SecretKeyword
{ private const string TAB_FILE_DATA = "Table/SecretKeyword.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_SKETCH=2,
ID_DETAIL,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private string m_Detail;
 public string Detail { get{ return m_Detail;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_Sketch;
 public string Sketch { get{ return m_Sketch;}}

public static bool LoadTable(Dictionary<int, List<Tab_SecretKeyword> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_SecretKeyword SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_SecretKeyword _values = new Tab_SecretKeyword();
 _values.m_Detail =  valuesList[(int)_ID.ID_DETAIL] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Sketch =  valuesList[(int)_ID.ID_SKETCH] as string;

 return _values; }


}
}

