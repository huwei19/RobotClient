//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_Personality
{ private const string TAB_FILE_DATA = "Table/Personality.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_ITEMID=2,
ID_NAME,
ID_DESC,
ID_ICON,
ID_COLOR,
ID_SECONDCOLOR,
ID_POS,
ID_MAX,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private string m_Color;
 public string Color { get{ return m_Color;}}

private string m_Desc;
 public string Desc { get{ return m_Desc;}}

private string m_Icon;
 public string Icon { get{ return m_Icon;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_ItemId;
 public int ItemId { get{ return m_ItemId;}}

private int m_Max;
 public int Max { get{ return m_Max;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private int m_Pos;
 public int Pos { get{ return m_Pos;}}

private string m_SecondColor;
 public string SecondColor { get{ return m_SecondColor;}}

public static bool LoadTable(Dictionary<int, List<Tab_Personality> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_Personality SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_Personality _values = new Tab_Personality();
 _values.m_Color =  valuesList[(int)_ID.ID_COLOR] as string;
_values.m_Desc =  valuesList[(int)_ID.ID_DESC] as string;
_values.m_Icon =  valuesList[(int)_ID.ID_ICON] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_ItemId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMID] as string);
_values.m_Max =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MAX] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_Pos =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_POS] as string);
_values.m_SecondColor =  valuesList[(int)_ID.ID_SECONDCOLOR] as string;

 return _values; }


}
}

