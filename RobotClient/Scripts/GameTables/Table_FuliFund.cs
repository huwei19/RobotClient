//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_FuliFund
{ private const string TAB_FILE_DATA = "Table/FuliFund.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NEEDPLAYERLEVEL=2,
ID_DIAMOND,
ID_COLORTYPE,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_ColorType;
 public int ColorType { get{ return m_ColorType;}}

private int m_Diamond;
 public int Diamond { get{ return m_Diamond;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_NeedPlayerLevel;
 public int NeedPlayerLevel { get{ return m_NeedPlayerLevel;}}

public static bool LoadTable(Dictionary<int, List<Tab_FuliFund> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_FuliFund SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_FuliFund _values = new Tab_FuliFund();
 _values.m_ColorType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_COLORTYPE] as string);
_values.m_Diamond =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DIAMOND] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_NeedPlayerLevel =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NEEDPLAYERLEVEL] as string);

 return _values; }


}
}

