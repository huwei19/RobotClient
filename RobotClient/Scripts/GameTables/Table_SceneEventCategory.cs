//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_SceneEventCategory
{ private const string TAB_FILE_DATA = "Table/SceneEventCategory.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_CATEGORY=2,
ID_ASSOCATTR,
ID_NAME,
ID_ICON,
ID_ACTIONICON,
ID_BG,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private string m_ActionIcon;
 public string ActionIcon { get{ return m_ActionIcon;}}

private string m_AssocAttr;
 public string AssocAttr { get{ return m_AssocAttr;}}

private string m_Bg;
 public string Bg { get{ return m_Bg;}}

private string m_Category;
 public string Category { get{ return m_Category;}}

private string m_Icon;
 public string Icon { get{ return m_Icon;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

public static bool LoadTable(Dictionary<int, List<Tab_SceneEventCategory> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_SceneEventCategory SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_SceneEventCategory _values = new Tab_SceneEventCategory();
 _values.m_ActionIcon =  valuesList[(int)_ID.ID_ACTIONICON] as string;
_values.m_AssocAttr =  valuesList[(int)_ID.ID_ASSOCATTR] as string;
_values.m_Bg =  valuesList[(int)_ID.ID_BG] as string;
_values.m_Category =  valuesList[(int)_ID.ID_CATEGORY] as string;
_values.m_Icon =  valuesList[(int)_ID.ID_ICON] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;

 return _values; }


}
}

