//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_HelpTips
{ private const string TAB_FILE_DATA = "Table/HelpTips.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_TITLE=2,
ID_CONTENT,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private string m_Content;
 public string Content { get{ return m_Content;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_Title;
 public string Title { get{ return m_Title;}}

public static bool LoadTable(Dictionary<int, List<Tab_HelpTips> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_HelpTips SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_HelpTips _values = new Tab_HelpTips();
 _values.m_Content =  valuesList[(int)_ID.ID_CONTENT] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Title =  valuesList[(int)_ID.ID_TITLE] as string;

 return _values; }


}
}

