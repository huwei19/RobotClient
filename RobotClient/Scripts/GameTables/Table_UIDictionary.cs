//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_UIDictionary
{ private const string TAB_FILE_DATA = "Table/UIDictionary.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_STRDICTIONARY=2,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_StrDictionary;
 public string StrDictionary { get{ return m_StrDictionary;}}

public static bool LoadTable(Dictionary<int, List<Tab_UIDictionary> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_UIDictionary SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_UIDictionary _values = new Tab_UIDictionary();
 _values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_StrDictionary =  valuesList[(int)_ID.ID_STRDICTIONARY] as string;

 return _values; }


}
}

