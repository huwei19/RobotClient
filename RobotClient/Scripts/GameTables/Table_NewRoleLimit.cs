//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_NewRoleLimit
{ private const string TAB_FILE_DATA = "table/NewRoleLimit.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_SERVERID=2,
ID_DATE,
ID_START,
ID_END,
ID_COUNT,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Count;
 public int Count { get{ return m_Count;}}

private int m_Date;
 public int Date { get{ return m_Date;}}

private int m_End;
 public int End { get{ return m_End;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_ServerId;
 public int ServerId { get{ return m_ServerId;}}

private int m_Start;
 public int Start { get{ return m_Start;}}

public static bool LoadTable(Dictionary<int, List<Tab_NewRoleLimit> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_NewRoleLimit SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_NewRoleLimit _values = new Tab_NewRoleLimit();
 _values.m_Count =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_COUNT] as string);
_values.m_Date =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DATE] as string);
_values.m_End =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_END] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_ServerId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SERVERID] as string);
_values.m_Start =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_START] as string);

 return _values; }


}
}

