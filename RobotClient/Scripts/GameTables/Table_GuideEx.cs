//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_GuideEx
{ private const string TAB_FILE_DATA = "Table/GuideEx.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_DATATYPE=2,
ID_DATANUM,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_DataNum;
 public int DataNum { get{ return m_DataNum;}}

private int m_DataType;
 public int DataType { get{ return m_DataType;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

public static bool LoadTable(Dictionary<int, List<Tab_GuideEx> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_GuideEx SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_GuideEx _values = new Tab_GuideEx();
 _values.m_DataNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DATANUM] as string);
_values.m_DataType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DATATYPE] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);

 return _values; }


}
}

