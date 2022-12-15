//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_CardPoolType
{ private const string TAB_FILE_DATA = "Table/CardPoolType.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NAME=2,
ID_NAMEICON,
ID_TYPEICON,
ID_SWITCHMOD,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private string m_NameIcon;
 public string NameIcon { get{ return m_NameIcon;}}

private int m_SwitchMod;
 public int SwitchMod { get{ return m_SwitchMod;}}

private string m_TypeIcon;
 public string TypeIcon { get{ return m_TypeIcon;}}

public static bool LoadTable(Dictionary<int, List<Tab_CardPoolType> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_CardPoolType SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_CardPoolType _values = new Tab_CardPoolType();
 _values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_NameIcon =  valuesList[(int)_ID.ID_NAMEICON] as string;
_values.m_SwitchMod =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SWITCHMOD] as string);
_values.m_TypeIcon =  valuesList[(int)_ID.ID_TYPEICON] as string;

 return _values; }


}
}

