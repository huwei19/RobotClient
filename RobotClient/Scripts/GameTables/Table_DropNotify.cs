//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_DropNotify
{ private const string TAB_FILE_DATA = "table/DropNotify.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NOTICETTYPE=2,
ID_CONTENT,
ID_NOTICERATE,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private string m_Content;
 public string Content { get{ return m_Content;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private float m_NoticeRate;
 public float NoticeRate { get{ return m_NoticeRate;}}

private int m_NoticetType;
 public int NoticetType { get{ return m_NoticetType;}}

public static bool LoadTable(Dictionary<int, List<Tab_DropNotify> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_DropNotify SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_DropNotify _values = new Tab_DropNotify();
 _values.m_Content =  valuesList[(int)_ID.ID_CONTENT] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_NoticeRate =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_NOTICERATE] as string );
_values.m_NoticetType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NOTICETTYPE] as string);

 return _values; }


}
}

