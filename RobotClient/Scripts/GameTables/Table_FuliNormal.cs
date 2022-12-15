//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_FuliNormal
{ private const string TAB_FILE_DATA = "Table/FuliNormal.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_GO_TYPE=2,
ID_GO_PARAM,
ID_ACT_BG_IMG,
ID_ACT_THEME,
ID_ACT_THUMB_IMG_0,
ID_ACT_DETAIL_INFO_0,
ID_ACT_THUMB_IMG_1,
ID_ACT_DETAIL_INFO_1,
ID_ACT_THUMB_IMG_2,
ID_ACT_DETAIL_INFO_2,
ID_ACT_THUMB_IMG_3,
ID_ACT_DETAIL_INFO_3,
ID_ACT_THUMB_IMG_4,
ID_ACT_DETAIL_INFO_4,
ID_ENABLE,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private string m_ActBgImg;
 public string ActBgImg { get{ return m_ActBgImg;}}

public int getActDetailInfoCount() { return 5; } 
 private string[] m_ActDetailInfo = new string[5];
 public string GetActDetailInfobyIndex(int idx) {
 if(idx>=0 && idx<5) {
 return m_ActDetailInfo[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> ActDetailInfos { get {
  
return Array.AsReadOnly(m_ActDetailInfo);
}} 

private string m_ActTheme;
 public string ActTheme { get{ return m_ActTheme;}}

public int getActThumbImgCount() { return 5; } 
 private string[] m_ActThumbImg = new string[5];
 public string GetActThumbImgbyIndex(int idx) {
 if(idx>=0 && idx<5) {
 return m_ActThumbImg[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> ActThumbImgs { get {
  
return Array.AsReadOnly(m_ActThumbImg);
}} 

private int m_Enable;
 public int Enable { get{ return m_Enable;}}

private string m_GoParam;
 public string GoParam { get{ return m_GoParam;}}

private int m_GoType;
 public int GoType { get{ return m_GoType;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

public static bool LoadTable(Dictionary<int, List<Tab_FuliNormal> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_FuliNormal SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_FuliNormal _values = new Tab_FuliNormal();
 _values.m_ActBgImg =  valuesList[(int)_ID.ID_ACT_BG_IMG] as string;
_values.m_ActDetailInfo [ 0 ] =  valuesList[(int)_ID.ID_ACT_DETAIL_INFO_0] as string;
_values.m_ActDetailInfo [ 1 ] =  valuesList[(int)_ID.ID_ACT_DETAIL_INFO_1] as string;
_values.m_ActDetailInfo [ 2 ] =  valuesList[(int)_ID.ID_ACT_DETAIL_INFO_2] as string;
_values.m_ActDetailInfo [ 3 ] =  valuesList[(int)_ID.ID_ACT_DETAIL_INFO_3] as string;
_values.m_ActDetailInfo [ 4 ] =  valuesList[(int)_ID.ID_ACT_DETAIL_INFO_4] as string;
_values.m_ActTheme =  valuesList[(int)_ID.ID_ACT_THEME] as string;
_values.m_ActThumbImg [ 0 ] =  valuesList[(int)_ID.ID_ACT_THUMB_IMG_0] as string;
_values.m_ActThumbImg [ 1 ] =  valuesList[(int)_ID.ID_ACT_THUMB_IMG_1] as string;
_values.m_ActThumbImg [ 2 ] =  valuesList[(int)_ID.ID_ACT_THUMB_IMG_2] as string;
_values.m_ActThumbImg [ 3 ] =  valuesList[(int)_ID.ID_ACT_THUMB_IMG_3] as string;
_values.m_ActThumbImg [ 4 ] =  valuesList[(int)_ID.ID_ACT_THUMB_IMG_4] as string;
_values.m_Enable =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ENABLE] as string);
_values.m_GoParam =  valuesList[(int)_ID.ID_GO_PARAM] as string;
_values.m_GoType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GO_TYPE] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);

 return _values; }


}
}

