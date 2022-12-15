//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_TagData
{ private const string TAB_FILE_DATA = "Table/TagData.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_TAG=2,
ID_COLORSTYLE,
ID_BGSTYLE,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_BgStyle;
 public int BgStyle { get{ return m_BgStyle;}}

private int m_ColorStyle;
 public int ColorStyle { get{ return m_ColorStyle;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_Tag;
 public string Tag { get{ return m_Tag;}}

public static bool LoadTable(Dictionary<int, List<Tab_TagData> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_TagData SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_TagData _values = new Tab_TagData();
 _values.m_BgStyle =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_BGSTYLE] as string);
_values.m_ColorStyle =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_COLORSTYLE] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Tag =  valuesList[(int)_ID.ID_TAG] as string;

 return _values; }


}
}

