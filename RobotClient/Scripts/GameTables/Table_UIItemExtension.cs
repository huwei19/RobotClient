//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_UIItemExtension
{ private const string TAB_FILE_DATA = "Table/UIItemExtension.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NAME=2,
ID_PACKAGE,
ID_LUATYPE,
ID_PATHNAME,
ID_USETYPE,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_LuaType;
 public string LuaType { get{ return m_LuaType;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private string m_Package;
 public string Package { get{ return m_Package;}}

private string m_PathName;
 public string PathName { get{ return m_PathName;}}

private int m_UseType;
 public int UseType { get{ return m_UseType;}}

public static bool LoadTable(Dictionary<int, List<Tab_UIItemExtension> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_UIItemExtension SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_UIItemExtension _values = new Tab_UIItemExtension();
 _values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_LuaType =  valuesList[(int)_ID.ID_LUATYPE] as string;
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_Package =  valuesList[(int)_ID.ID_PACKAGE] as string;
_values.m_PathName =  valuesList[(int)_ID.ID_PATHNAME] as string;
_values.m_UseType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_USETYPE] as string);

 return _values; }


}
}

