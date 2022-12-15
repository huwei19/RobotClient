//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_Item
{ private const string TAB_FILE_DATA = "Table/Item.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NAME=2,
ID_CLASSNAME,
ID_ATLAS,
ID_ICON,
ID_ICONMINI,
ID_TIPS,
ID_CLASSID,
ID_SUBCLASSID,
ID_PACKTYPE,
ID_PAGETYPE,
ID_COLOR,
ID_MINLEVELREQUIRE,
ID_MAXLEVELREQUIRE,
ID_CANUSE,
ID_CANBATCHUSE,
ID_ITEMTITLETYPE,
ID_MAXSTACKSIZE,
ID_MAXSTORAGE,
ID_ISAUTOUSE,
ID_ISSTACKUSE,
ID_ISCANCOMPOSE,
ID_USEGOTOID,
ID_SELLPRICE,
ID_LIMITTIME,
ID_FINALTIME,
ID_PARAM_0,
ID_PARAM_1,
ID_GAINID_0,
ID_GAINID_1,
ID_GAINID_2,
ID_GAINID_3,
ID_GAINID_4,
ID_GAINID_5,
ID_GAINID_6,
ID_GAINID_7,
ID_GAINID_8,
ID_GAINID_9,
ID_GAINID_10,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private string m_Atlas;
 public string Atlas { get{ return m_Atlas;}}

private int m_CanBatchUse;
 public int CanBatchUse { get{ return m_CanBatchUse;}}

private int m_CanUse;
 public int CanUse { get{ return m_CanUse;}}

private int m_ClassID;
 public int ClassID { get{ return m_ClassID;}}

private string m_ClassName;
 public string ClassName { get{ return m_ClassName;}}

private int m_Color;
 public int Color { get{ return m_Color;}}

private string m_FinalTime;
 public string FinalTime { get{ return m_FinalTime;}}

public int getGainIdCount() { return 11; } 
 private int[] m_GainId = new int[11];
 public int GetGainIdbyIndex(int idx) {
 if(idx>=0 && idx<11) {
 return m_GainId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> GainIds { get {
  
return Array.AsReadOnly(m_GainId);
}} 

private string m_Icon;
 public string Icon { get{ return m_Icon;}}

private string m_IconMini;
 public string IconMini { get{ return m_IconMini;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_IsAutoUse;
 public int IsAutoUse { get{ return m_IsAutoUse;}}

private int m_IsCanCompose;
 public int IsCanCompose { get{ return m_IsCanCompose;}}

private int m_IsStackUse;
 public int IsStackUse { get{ return m_IsStackUse;}}

private int m_ItemTitleType;
 public int ItemTitleType { get{ return m_ItemTitleType;}}

private int m_LimitTime;
 public int LimitTime { get{ return m_LimitTime;}}

private int m_MaxLevelRequire;
 public int MaxLevelRequire { get{ return m_MaxLevelRequire;}}

private int m_MaxStackSize;
 public int MaxStackSize { get{ return m_MaxStackSize;}}

private int m_MaxStorage;
 public int MaxStorage { get{ return m_MaxStorage;}}

private int m_MinLevelRequire;
 public int MinLevelRequire { get{ return m_MinLevelRequire;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private int m_PackType;
 public int PackType { get{ return m_PackType;}}

private int m_PageType;
 public int PageType { get{ return m_PageType;}}

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

private int m_SellPrice;
 public int SellPrice { get{ return m_SellPrice;}}

private int m_SubClassID;
 public int SubClassID { get{ return m_SubClassID;}}

private string m_Tips;
 public string Tips { get{ return m_Tips;}}

private int m_UseGotoId;
 public int UseGotoId { get{ return m_UseGotoId;}}

public static bool LoadTable(Dictionary<int, List<Tab_Item> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_Item SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_Item _values = new Tab_Item();
 _values.m_Atlas =  valuesList[(int)_ID.ID_ATLAS] as string;
_values.m_CanBatchUse =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CANBATCHUSE] as string);
_values.m_CanUse =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CANUSE] as string);
_values.m_ClassID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CLASSID] as string);
_values.m_ClassName =  valuesList[(int)_ID.ID_CLASSNAME] as string;
_values.m_Color =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_COLOR] as string);
_values.m_FinalTime =  valuesList[(int)_ID.ID_FINALTIME] as string;
_values.m_GainId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GAINID_0] as string);
_values.m_GainId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GAINID_1] as string);
_values.m_GainId [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GAINID_2] as string);
_values.m_GainId [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GAINID_3] as string);
_values.m_GainId [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GAINID_4] as string);
_values.m_GainId [ 5 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GAINID_5] as string);
_values.m_GainId [ 6 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GAINID_6] as string);
_values.m_GainId [ 7 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GAINID_7] as string);
_values.m_GainId [ 8 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GAINID_8] as string);
_values.m_GainId [ 9 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GAINID_9] as string);
_values.m_GainId [ 10 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GAINID_10] as string);
_values.m_Icon =  valuesList[(int)_ID.ID_ICON] as string;
_values.m_IconMini =  valuesList[(int)_ID.ID_ICONMINI] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_IsAutoUse =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISAUTOUSE] as string);
_values.m_IsCanCompose =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISCANCOMPOSE] as string);
_values.m_IsStackUse =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISSTACKUSE] as string);
_values.m_ItemTitleType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMTITLETYPE] as string);
_values.m_LimitTime =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LIMITTIME] as string);
_values.m_MaxLevelRequire =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MAXLEVELREQUIRE] as string);
_values.m_MaxStackSize =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MAXSTACKSIZE] as string);
_values.m_MaxStorage =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MAXSTORAGE] as string);
_values.m_MinLevelRequire =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MINLEVELREQUIRE] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_PackType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PACKTYPE] as string);
_values.m_PageType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PAGETYPE] as string);
_values.m_Param [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PARAM_0] as string);
_values.m_Param [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PARAM_1] as string);
_values.m_SellPrice =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SELLPRICE] as string);
_values.m_SubClassID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SUBCLASSID] as string);
_values.m_Tips =  valuesList[(int)_ID.ID_TIPS] as string;
_values.m_UseGotoId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_USEGOTOID] as string);

 return _values; }


}
}

