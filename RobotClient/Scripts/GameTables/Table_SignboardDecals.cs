//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_SignboardDecals
{ private const string TAB_FILE_DATA = "Table/SignboardDecals.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NAME=2,
ID_MSG,
ID_THEMEID,
ID_ICON,
ID_IMG,
ID_TEXTUREWIDTH,
ID_TEXTUREHEIGHT,
ID_PRIORITY,
ID_DEFAULTX,
ID_DEFAULTY,
ID_DEFAULTBGX,
ID_DEFAULTBGY,
ID_GETWAY,
ID_GETWAYDEC,
ID_AWARD,
ID_ISDEFAULTADD,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Award;
 public int Award { get{ return m_Award;}}

private int m_DefaultBgX;
 public int DefaultBgX { get{ return m_DefaultBgX;}}

private int m_DefaultBgY;
 public int DefaultBgY { get{ return m_DefaultBgY;}}

private int m_DefaultX;
 public int DefaultX { get{ return m_DefaultX;}}

private int m_DefaultY;
 public int DefaultY { get{ return m_DefaultY;}}

private int m_Getway;
 public int Getway { get{ return m_Getway;}}

private string m_Getwaydec;
 public string Getwaydec { get{ return m_Getwaydec;}}

private string m_Icon;
 public string Icon { get{ return m_Icon;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_Img;
 public string Img { get{ return m_Img;}}

private int m_IsDefaultAdd;
 public int IsDefaultAdd { get{ return m_IsDefaultAdd;}}

private string m_Msg;
 public string Msg { get{ return m_Msg;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private int m_Priority;
 public int Priority { get{ return m_Priority;}}

private int m_TextureHeight;
 public int TextureHeight { get{ return m_TextureHeight;}}

private int m_TextureWidth;
 public int TextureWidth { get{ return m_TextureWidth;}}

private int m_ThemeId;
 public int ThemeId { get{ return m_ThemeId;}}

public static bool LoadTable(Dictionary<int, List<Tab_SignboardDecals> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_SignboardDecals SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_SignboardDecals _values = new Tab_SignboardDecals();
 _values.m_Award =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AWARD] as string);
_values.m_DefaultBgX =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DEFAULTBGX] as string);
_values.m_DefaultBgY =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DEFAULTBGY] as string);
_values.m_DefaultX =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DEFAULTX] as string);
_values.m_DefaultY =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DEFAULTY] as string);
_values.m_Getway =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GETWAY] as string);
_values.m_Getwaydec =  valuesList[(int)_ID.ID_GETWAYDEC] as string;
_values.m_Icon =  valuesList[(int)_ID.ID_ICON] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Img =  valuesList[(int)_ID.ID_IMG] as string;
_values.m_IsDefaultAdd =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISDEFAULTADD] as string);
_values.m_Msg =  valuesList[(int)_ID.ID_MSG] as string;
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_Priority =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PRIORITY] as string);
_values.m_TextureHeight =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TEXTUREHEIGHT] as string);
_values.m_TextureWidth =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TEXTUREWIDTH] as string);
_values.m_ThemeId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_THEMEID] as string);

 return _values; }


}
}

