//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_CardFrame
{ private const string TAB_FILE_DATA = "Table/CardFrame.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NAME=2,
ID_DESC,
ID_TYPE,
ID_ICON,
ID_MINIICON,
ID_ISSHOW,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private string m_Desc;
 public string Desc { get{ return m_Desc;}}

private string m_Icon;
 public string Icon { get{ return m_Icon;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_IsShow;
 public int IsShow { get{ return m_IsShow;}}

private string m_MiniIcon;
 public string MiniIcon { get{ return m_MiniIcon;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private int m_Type;
 public int Type { get{ return m_Type;}}

public static bool LoadTable(Dictionary<int, List<Tab_CardFrame> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_CardFrame SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_CardFrame _values = new Tab_CardFrame();
 _values.m_Desc =  valuesList[(int)_ID.ID_DESC] as string;
_values.m_Icon =  valuesList[(int)_ID.ID_ICON] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_IsShow =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISSHOW] as string);
_values.m_MiniIcon =  valuesList[(int)_ID.ID_MINIICON] as string;
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_Type =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TYPE] as string);

 return _values; }


}
}

