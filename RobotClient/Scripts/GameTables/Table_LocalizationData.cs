//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_LocalizationData
{ private const string TAB_FILE_DATA = "Table/LocalizationData.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NAME=2,
ID_XMLPATH,
ID_UIPACKAGENAME,
ID_TRANLATEDICTIONARYNAME,
ID_SEAT,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private int m_Seat;
 public int Seat { get{ return m_Seat;}}

private string m_TranlateDictionaryName;
 public string TranlateDictionaryName { get{ return m_TranlateDictionaryName;}}

private string m_UIPackageName;
 public string UIPackageName { get{ return m_UIPackageName;}}

private string m_XMLPath;
 public string XMLPath { get{ return m_XMLPath;}}

public static bool LoadTable(Dictionary<int, List<Tab_LocalizationData> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_LocalizationData SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_LocalizationData _values = new Tab_LocalizationData();
 _values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_Seat =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SEAT] as string);
_values.m_TranlateDictionaryName =  valuesList[(int)_ID.ID_TRANLATEDICTIONARYNAME] as string;
_values.m_UIPackageName =  valuesList[(int)_ID.ID_UIPACKAGENAME] as string;
_values.m_XMLPath =  valuesList[(int)_ID.ID_XMLPATH] as string;

 return _values; }


}
}

