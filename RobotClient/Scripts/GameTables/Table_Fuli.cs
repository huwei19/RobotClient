//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_Fuli
{ private const string TAB_FILE_DATA = "Table/Fuli.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NAME=2,
ID_TYPE,
ID_FUNCTIONID,
ID_TAGICON,
ID_PRIORITY,
ID_ADDSIGN,
ID_ACT_TYPE,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_ActType;
 public int ActType { get{ return m_ActType;}}

private int m_AddSign;
 public int AddSign { get{ return m_AddSign;}}

private int m_FunctionId;
 public int FunctionId { get{ return m_FunctionId;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private int m_Priority;
 public int Priority { get{ return m_Priority;}}

private string m_TagIcon;
 public string TagIcon { get{ return m_TagIcon;}}

private int m_Type;
 public int Type { get{ return m_Type;}}

public static bool LoadTable(Dictionary<int, List<Tab_Fuli> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_Fuli SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_Fuli _values = new Tab_Fuli();
 _values.m_ActType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACT_TYPE] as string);
_values.m_AddSign =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ADDSIGN] as string);
_values.m_FunctionId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FUNCTIONID] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_Priority =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PRIORITY] as string);
_values.m_TagIcon =  valuesList[(int)_ID.ID_TAGICON] as string;
_values.m_Type =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TYPE] as string);

 return _values; }


}
}

