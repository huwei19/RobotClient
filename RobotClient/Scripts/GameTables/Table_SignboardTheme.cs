//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_SignboardTheme
{ private const string TAB_FILE_DATA = "Table/SignboardTheme.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NAME=2,
ID_GETWAYDEC,
ID_ISDEFAULTSHOW,
ID_ISDEFAULT,
ID_PRIORITY,
ID_AWARDIMG,
ID_THEMEBG,
ID_AWARDBTNID,
ID_AWARDTEXTUREWIDTH,
ID_AWARDTEXTUREHEIGHT,
ID_AWARDX,
ID_AWARDY,
ID_AWARD,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Award;
 public int Award { get{ return m_Award;}}

private int m_AwardBtnId;
 public int AwardBtnId { get{ return m_AwardBtnId;}}

private string m_AwardImg;
 public string AwardImg { get{ return m_AwardImg;}}

private int m_AwardTextureHeight;
 public int AwardTextureHeight { get{ return m_AwardTextureHeight;}}

private int m_AwardTextureWidth;
 public int AwardTextureWidth { get{ return m_AwardTextureWidth;}}

private int m_AwardX;
 public int AwardX { get{ return m_AwardX;}}

private int m_AwardY;
 public int AwardY { get{ return m_AwardY;}}

private string m_GetwayDec;
 public string GetwayDec { get{ return m_GetwayDec;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_IsDefault;
 public int IsDefault { get{ return m_IsDefault;}}

private int m_IsDefaultShow;
 public int IsDefaultShow { get{ return m_IsDefaultShow;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private int m_Priority;
 public int Priority { get{ return m_Priority;}}

private string m_ThemeBg;
 public string ThemeBg { get{ return m_ThemeBg;}}

public static bool LoadTable(Dictionary<int, List<Tab_SignboardTheme> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_SignboardTheme SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_SignboardTheme _values = new Tab_SignboardTheme();
 _values.m_Award =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AWARD] as string);
_values.m_AwardBtnId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AWARDBTNID] as string);
_values.m_AwardImg =  valuesList[(int)_ID.ID_AWARDIMG] as string;
_values.m_AwardTextureHeight =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AWARDTEXTUREHEIGHT] as string);
_values.m_AwardTextureWidth =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AWARDTEXTUREWIDTH] as string);
_values.m_AwardX =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AWARDX] as string);
_values.m_AwardY =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AWARDY] as string);
_values.m_GetwayDec =  valuesList[(int)_ID.ID_GETWAYDEC] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_IsDefault =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISDEFAULT] as string);
_values.m_IsDefaultShow =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISDEFAULTSHOW] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_Priority =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PRIORITY] as string);
_values.m_ThemeBg =  valuesList[(int)_ID.ID_THEMEBG] as string;

 return _values; }


}
}

