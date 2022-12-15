//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_Role
{ private const string TAB_FILE_DATA = "Table/Role.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_TYPE=2,
ID_NAME,
ID_ENGLISHNAME,
ID_SEX,
ID_AGE,
ID_AGESTR,
ID_HEIGHT,
ID_CVNAME,
ID_DESC,
ID_TITLE,
ID_TITLEBG,
ID_CARDNAMECOLOR,
ID_CARDNAMEBG,
ID_HEADICON,
ID_NPCIMAGE,
ID_TONGXUNLUNAME,
ID_AVATARID,
ID_GIFTACTIONID,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Age;
 public int Age { get{ return m_Age;}}

private string m_AgeStr;
 public string AgeStr { get{ return m_AgeStr;}}

private int m_AvatarId;
 public int AvatarId { get{ return m_AvatarId;}}

private string m_CardNameBg;
 public string CardNameBg { get{ return m_CardNameBg;}}

private string m_CardNameColor;
 public string CardNameColor { get{ return m_CardNameColor;}}

private string m_CvName;
 public string CvName { get{ return m_CvName;}}

private string m_Desc;
 public string Desc { get{ return m_Desc;}}

private string m_EnglishName;
 public string EnglishName { get{ return m_EnglishName;}}

private int m_GiftActionId;
 public int GiftActionId { get{ return m_GiftActionId;}}

private string m_HeadIcon;
 public string HeadIcon { get{ return m_HeadIcon;}}

private int m_Height;
 public int Height { get{ return m_Height;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_NPCImage;
 public string NPCImage { get{ return m_NPCImage;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private int m_Sex;
 public int Sex { get{ return m_Sex;}}

private string m_Title;
 public string Title { get{ return m_Title;}}

private string m_TitleBg;
 public string TitleBg { get{ return m_TitleBg;}}

private string m_TongxunluName;
 public string TongxunluName { get{ return m_TongxunluName;}}

private int m_Type;
 public int Type { get{ return m_Type;}}

public static bool LoadTable(Dictionary<int, List<Tab_Role> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_Role SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_Role _values = new Tab_Role();
 _values.m_Age =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AGE] as string);
_values.m_AgeStr =  valuesList[(int)_ID.ID_AGESTR] as string;
_values.m_AvatarId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AVATARID] as string);
_values.m_CardNameBg =  valuesList[(int)_ID.ID_CARDNAMEBG] as string;
_values.m_CardNameColor =  valuesList[(int)_ID.ID_CARDNAMECOLOR] as string;
_values.m_CvName =  valuesList[(int)_ID.ID_CVNAME] as string;
_values.m_Desc =  valuesList[(int)_ID.ID_DESC] as string;
_values.m_EnglishName =  valuesList[(int)_ID.ID_ENGLISHNAME] as string;
_values.m_GiftActionId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GIFTACTIONID] as string);
_values.m_HeadIcon =  valuesList[(int)_ID.ID_HEADICON] as string;
_values.m_Height =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HEIGHT] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_NPCImage =  valuesList[(int)_ID.ID_NPCIMAGE] as string;
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_Sex =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SEX] as string);
_values.m_Title =  valuesList[(int)_ID.ID_TITLE] as string;
_values.m_TitleBg =  valuesList[(int)_ID.ID_TITLEBG] as string;
_values.m_TongxunluName =  valuesList[(int)_ID.ID_TONGXUNLUNAME] as string;
_values.m_Type =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TYPE] as string);

 return _values; }


}
}

