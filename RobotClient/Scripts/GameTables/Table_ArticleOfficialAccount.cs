//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_ArticleOfficialAccount
{ private const string TAB_FILE_DATA = "Table/ArticleOfficialAccount.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NAME=2,
ID_ICON,
ID_DESCRIPTION,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private string m_Description;
 public string Description { get{ return m_Description;}}

private string m_Icon;
 public string Icon { get{ return m_Icon;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

public static bool LoadTable(Dictionary<int, List<Tab_ArticleOfficialAccount> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_ArticleOfficialAccount SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_ArticleOfficialAccount _values = new Tab_ArticleOfficialAccount();
 _values.m_Description =  valuesList[(int)_ID.ID_DESCRIPTION] as string;
_values.m_Icon =  valuesList[(int)_ID.ID_ICON] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;

 return _values; }


}
}

