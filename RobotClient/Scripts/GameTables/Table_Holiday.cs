//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_Holiday
{ private const string TAB_FILE_DATA = "table/Holiday.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_STARTUTC=2,
ID_ENDUTC,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_EndUtc;
 public int EndUtc { get{ return m_EndUtc;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_StartUtc;
 public int StartUtc { get{ return m_StartUtc;}}

public static bool LoadTable(Dictionary<int, List<Tab_Holiday> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_Holiday SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_Holiday _values = new Tab_Holiday();
 _values.m_EndUtc =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ENDUTC] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_StartUtc =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_STARTUTC] as string);

 return _values; }


}
}

