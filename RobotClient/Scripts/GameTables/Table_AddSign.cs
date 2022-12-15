//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_AddSign
{ private const string TAB_FILE_DATA = "Table/AddSign.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_TYPE=2,
ID_ICON,
ID_IMG,
ID_BG,
ID_FUNCTIONUNLOCK,
ID_OPENTIME,
ID_CLOSETIME,
ID_CARDID,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private string m_Bg;
 public string Bg { get{ return m_Bg;}}

private int m_CardId;
 public int CardId { get{ return m_CardId;}}

private string m_Closetime;
 public string Closetime { get{ return m_Closetime;}}

private int m_Functionunlock;
 public int Functionunlock { get{ return m_Functionunlock;}}

private string m_Icon;
 public string Icon { get{ return m_Icon;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_Img;
 public string Img { get{ return m_Img;}}

private string m_Opentime;
 public string Opentime { get{ return m_Opentime;}}

private int m_Type;
 public int Type { get{ return m_Type;}}

public static bool LoadTable(Dictionary<int, List<Tab_AddSign> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_AddSign SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_AddSign _values = new Tab_AddSign();
 _values.m_Bg =  valuesList[(int)_ID.ID_BG] as string;
_values.m_CardId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CARDID] as string);
_values.m_Closetime =  valuesList[(int)_ID.ID_CLOSETIME] as string;
_values.m_Functionunlock =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FUNCTIONUNLOCK] as string);
_values.m_Icon =  valuesList[(int)_ID.ID_ICON] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Img =  valuesList[(int)_ID.ID_IMG] as string;
_values.m_Opentime =  valuesList[(int)_ID.ID_OPENTIME] as string;
_values.m_Type =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TYPE] as string);

 return _values; }


}
}

