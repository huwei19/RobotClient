//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_FuliLottery
{ private const string TAB_FILE_DATA = "Table/FuliLottery.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_VERSIONNUM=2,
ID_ACTIVITYTID,
ID_INTROACTIONID,
ID_USEITEMID,
ID_RARETYPE_0,
ID_TITLE_0,
ID_RARENAME_0,
ID_RAREDESC_0,
ID_RARESMALLBG_0,
ID_RAREBG_0,
ID_PARAM_0,
ID_RARETYPE_1,
ID_TITLE_1,
ID_RARENAME_1,
ID_RAREDESC_1,
ID_RARESMALLBG_1,
ID_RAREBG_1,
ID_PARAM_1,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_ActivitytId;
 public int ActivitytId { get{ return m_ActivitytId;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_IntroActionId;
 public int IntroActionId { get{ return m_IntroActionId;}}

public int getParamCount() { return 2; } 
 private int[] m_Param = new int[2];
 public int GetParambyIndex(int idx) {
 if(idx>=0 && idx<2) {
 return m_Param[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> Params { get {
  
return Array.AsReadOnly(m_Param);
}} 

public int getRareBgCount() { return 2; } 
 private string[] m_RareBg = new string[2];
 public string GetRareBgbyIndex(int idx) {
 if(idx>=0 && idx<2) {
 return m_RareBg[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> RareBgs { get {
  
return Array.AsReadOnly(m_RareBg);
}} 

public int getRareDescCount() { return 2; } 
 private string[] m_RareDesc = new string[2];
 public string GetRareDescbyIndex(int idx) {
 if(idx>=0 && idx<2) {
 return m_RareDesc[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> RareDescs { get {
  
return Array.AsReadOnly(m_RareDesc);
}} 

public int getRareNameCount() { return 2; } 
 private string[] m_RareName = new string[2];
 public string GetRareNamebyIndex(int idx) {
 if(idx>=0 && idx<2) {
 return m_RareName[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> RareNames { get {
  
return Array.AsReadOnly(m_RareName);
}} 

public int getRareSmallBgCount() { return 2; } 
 private string[] m_RareSmallBg = new string[2];
 public string GetRareSmallBgbyIndex(int idx) {
 if(idx>=0 && idx<2) {
 return m_RareSmallBg[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> RareSmallBgs { get {
  
return Array.AsReadOnly(m_RareSmallBg);
}} 

public int getRareTypeCount() { return 2; } 
 private int[] m_RareType = new int[2];
 public int GetRareTypebyIndex(int idx) {
 if(idx>=0 && idx<2) {
 return m_RareType[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> RareTypes { get {
  
return Array.AsReadOnly(m_RareType);
}} 

public int getTitleCount() { return 2; } 
 private string[] m_Title = new string[2];
 public string GetTitlebyIndex(int idx) {
 if(idx>=0 && idx<2) {
 return m_Title[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> Titles { get {
  
return Array.AsReadOnly(m_Title);
}} 

private int m_UseItemId;
 public int UseItemId { get{ return m_UseItemId;}}

private int m_VersionNum;
 public int VersionNum { get{ return m_VersionNum;}}

public static bool LoadTable(Dictionary<int, List<Tab_FuliLottery> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_FuliLottery SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_FuliLottery _values = new Tab_FuliLottery();
 _values.m_ActivitytId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIVITYTID] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_IntroActionId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_INTROACTIONID] as string);
_values.m_Param [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PARAM_0] as string);
_values.m_Param [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PARAM_1] as string);
_values.m_RareBg [ 0 ] =  valuesList[(int)_ID.ID_RAREBG_0] as string;
_values.m_RareBg [ 1 ] =  valuesList[(int)_ID.ID_RAREBG_1] as string;
_values.m_RareDesc [ 0 ] =  valuesList[(int)_ID.ID_RAREDESC_0] as string;
_values.m_RareDesc [ 1 ] =  valuesList[(int)_ID.ID_RAREDESC_1] as string;
_values.m_RareName [ 0 ] =  valuesList[(int)_ID.ID_RARENAME_0] as string;
_values.m_RareName [ 1 ] =  valuesList[(int)_ID.ID_RARENAME_1] as string;
_values.m_RareSmallBg [ 0 ] =  valuesList[(int)_ID.ID_RARESMALLBG_0] as string;
_values.m_RareSmallBg [ 1 ] =  valuesList[(int)_ID.ID_RARESMALLBG_1] as string;
_values.m_RareType [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_RARETYPE_0] as string);
_values.m_RareType [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_RARETYPE_1] as string);
_values.m_Title [ 0 ] =  valuesList[(int)_ID.ID_TITLE_0] as string;
_values.m_Title [ 1 ] =  valuesList[(int)_ID.ID_TITLE_1] as string;
_values.m_UseItemId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_USEITEMID] as string);
_values.m_VersionNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_VERSIONNUM] as string);

 return _values; }


}
}

