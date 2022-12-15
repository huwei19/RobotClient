//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_ReloadList
{ private const string TAB_FILE_DATA = "table/ReloadList.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_TABLENAME0=2,
ID_TABLENAME1,
ID_TABLENAME2,
ID_TABLENAME3,
ID_TABLENAME4,
ID_TABLENAME5,
ID_TABLENAME6,
ID_TABLENAME7,
ID_TABLENAME8,
ID_TABLENAME9,
ID_TABLENAME10,
ID_TABLENAME11,
ID_TABLENAME12,
ID_TABLENAME13,
ID_TABLENAME14,
ID_TABLENAME15,
ID_TABLENAME16,
ID_UNUSE,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Id;
 public int Id { get{ return m_Id;}}

public int getTableNameCount() { return 17; } 
 private string[] m_TableName = new string[17];
 public string GetTableNamebyIndex(int idx) {
 if(idx>=0 && idx<17) return m_TableName[idx];
 return "";
 }
 public ReadOnlyCollection <string> TableNames { get { return Array.AsReadOnly(m_TableName);}} 

private int m_Unuse;
 public int Unuse { get{ return m_Unuse;}}

public static bool LoadTable(Dictionary<int, List<Tab_ReloadList> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_ReloadList SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_ReloadList _values = new Tab_ReloadList();
 _values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_TableName [ 0 ] =  valuesList[(int)_ID.ID_TABLENAME0] as string;
_values.m_TableName [ 1 ] =  valuesList[(int)_ID.ID_TABLENAME1] as string;
_values.m_TableName [ 2 ] =  valuesList[(int)_ID.ID_TABLENAME2] as string;
_values.m_TableName [ 3 ] =  valuesList[(int)_ID.ID_TABLENAME3] as string;
_values.m_TableName [ 4 ] =  valuesList[(int)_ID.ID_TABLENAME4] as string;
_values.m_TableName [ 5 ] =  valuesList[(int)_ID.ID_TABLENAME5] as string;
_values.m_TableName [ 6 ] =  valuesList[(int)_ID.ID_TABLENAME6] as string;
_values.m_TableName [ 7 ] =  valuesList[(int)_ID.ID_TABLENAME7] as string;
_values.m_TableName [ 8 ] =  valuesList[(int)_ID.ID_TABLENAME8] as string;
_values.m_TableName [ 9 ] =  valuesList[(int)_ID.ID_TABLENAME9] as string;
_values.m_TableName [ 10 ] =  valuesList[(int)_ID.ID_TABLENAME10] as string;
_values.m_TableName [ 11 ] =  valuesList[(int)_ID.ID_TABLENAME11] as string;
_values.m_TableName [ 12 ] =  valuesList[(int)_ID.ID_TABLENAME12] as string;
_values.m_TableName [ 13 ] =  valuesList[(int)_ID.ID_TABLENAME13] as string;
_values.m_TableName [ 14 ] =  valuesList[(int)_ID.ID_TABLENAME14] as string;
_values.m_TableName [ 15 ] =  valuesList[(int)_ID.ID_TABLENAME15] as string;
_values.m_TableName [ 16 ] =  valuesList[(int)_ID.ID_TABLENAME16] as string;
_values.m_Unuse =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_UNUSE] as string);

 return _values; }


}
}

