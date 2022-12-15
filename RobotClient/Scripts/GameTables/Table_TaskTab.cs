//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_TaskTab
{ private const string TAB_FILE_DATA = "Table/TaskTab.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_TIMELIMITORDER=2,
ID_TABNAME,
ID_TABTYPE,
ID_TABSUBTYPE,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_TabName;
 public string TabName { get{ return m_TabName;}}

private int m_TabSubType;
 public int TabSubType { get{ return m_TabSubType;}}

private int m_TabType;
 public int TabType { get{ return m_TabType;}}

private int m_TimeLimitOrder;
 public int TimeLimitOrder { get{ return m_TimeLimitOrder;}}

public static bool LoadTable(Dictionary<int, List<Tab_TaskTab> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_TaskTab SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_TaskTab _values = new Tab_TaskTab();
 _values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_TabName =  valuesList[(int)_ID.ID_TABNAME] as string;
_values.m_TabSubType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TABSUBTYPE] as string);
_values.m_TabType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TABTYPE] as string);
_values.m_TimeLimitOrder =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TIMELIMITORDER] as string);

 return _values; }


}
}

