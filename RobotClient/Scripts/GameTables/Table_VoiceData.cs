//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_VoiceData
{ private const string TAB_FILE_DATA = "Table/VoiceData.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NAME=2,
ID_INFO,
ID_PATHSUFFIX,
ID_ISSHOW,
ID_ISBASE,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_Info;
 public string Info { get{ return m_Info;}}

private int m_IsBase;
 public int IsBase { get{ return m_IsBase;}}

private int m_IsShow;
 public int IsShow { get{ return m_IsShow;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private string m_PathSuffix;
 public string PathSuffix { get{ return m_PathSuffix;}}

public static bool LoadTable(Dictionary<int, List<Tab_VoiceData> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_VoiceData SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_VoiceData _values = new Tab_VoiceData();
 _values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Info =  valuesList[(int)_ID.ID_INFO] as string;
_values.m_IsBase =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISBASE] as string);
_values.m_IsShow =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISSHOW] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_PathSuffix =  valuesList[(int)_ID.ID_PATHSUFFIX] as string;

 return _values; }


}
}

