//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_SkinData
{ private const string TAB_FILE_DATA = "Table/SkinData.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_FATELINEID=2,
ID_THEME,
ID_NAME,
ID_DESCRIPTION,
ID_ICON,
ID_ITEMICON,
ID_PRIORITY,
ID_ISSHOWTAB,
ID_SOURCETEXT,
ID_LOCKID,
ID_LOCKPARAM_0,
ID_LOCKPARAM_1,
ID_LOCKPRICE,
ID_PERSONALITYID,
ID_PERSONALITYLEVEL,
ID_HANGING_0,
ID_HANGING_1,
ID_HANGING_2,
ID_HANGING_3,
ID_HANGING_4,
ID_HANGING_5,
ID_HANGING_6,
ID_HANGING_7,
ID_SPECANIM_0,
ID_SPECANIM_1,
ID_SPECANIM_2,
ID_AWARDPERSONALITYID_0,
ID_AWARDPERSONALITYVALUE_0,
ID_AWARDPERSONALITYID_1,
ID_AWARDPERSONALITYVALUE_1,
ID_AWARDPERSONALITYID_2,
ID_AWARDPERSONALITYVALUE_2,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

public int getAwardPersonalityIdCount() { return 3; } 
 private int[] m_AwardPersonalityId = new int[3];
 public int GetAwardPersonalityIdbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_AwardPersonalityId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> AwardPersonalityIds { get {
  
return Array.AsReadOnly(m_AwardPersonalityId);
}} 

public int getAwardPersonalityValueCount() { return 3; } 
 private int[] m_AwardPersonalityValue = new int[3];
 public int GetAwardPersonalityValuebyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_AwardPersonalityValue[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> AwardPersonalityValues { get {
  
return Array.AsReadOnly(m_AwardPersonalityValue);
}} 

private string m_Description;
 public string Description { get{ return m_Description;}}

private int m_FateLineId;
 public int FateLineId { get{ return m_FateLineId;}}

public int getHangingCount() { return 8; } 
 private int[] m_Hanging = new int[8];
 public int GetHangingbyIndex(int idx) {
 if(idx>=0 && idx<8) {
 return m_Hanging[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> Hangings { get {
  
return Array.AsReadOnly(m_Hanging);
}} 

private string m_Icon;
 public string Icon { get{ return m_Icon;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_IsShowTab;
 public int IsShowTab { get{ return m_IsShowTab;}}

private string m_ItemIcon;
 public string ItemIcon { get{ return m_ItemIcon;}}

private int m_LockId;
 public int LockId { get{ return m_LockId;}}

public int getLockParamCount() { return 2; } 
 private int[] m_LockParam = new int[2];
 public int GetLockParambyIndex(int idx) {
 if(idx>=0 && idx<2) {
 return m_LockParam[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> LockParams { get {
  
return Array.AsReadOnly(m_LockParam);
}} 

private int m_LockPrice;
 public int LockPrice { get{ return m_LockPrice;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private int m_PersonalityId;
 public int PersonalityId { get{ return m_PersonalityId;}}

private int m_PersonalityLevel;
 public int PersonalityLevel { get{ return m_PersonalityLevel;}}

private int m_Priority;
 public int Priority { get{ return m_Priority;}}

private string m_SourceText;
 public string SourceText { get{ return m_SourceText;}}

public int getSpecAnimCount() { return 3; } 
 private int[] m_SpecAnim = new int[3];
 public int GetSpecAnimbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_SpecAnim[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> SpecAnims { get {
  
return Array.AsReadOnly(m_SpecAnim);
}} 

private string m_Theme;
 public string Theme { get{ return m_Theme;}}

public static bool LoadTable(Dictionary<int, List<Tab_SkinData> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_SkinData SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_SkinData _values = new Tab_SkinData();
 _values.m_AwardPersonalityId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AWARDPERSONALITYID_0] as string);
_values.m_AwardPersonalityId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AWARDPERSONALITYID_1] as string);
_values.m_AwardPersonalityId [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AWARDPERSONALITYID_2] as string);
_values.m_AwardPersonalityValue [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AWARDPERSONALITYVALUE_0] as string);
_values.m_AwardPersonalityValue [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AWARDPERSONALITYVALUE_1] as string);
_values.m_AwardPersonalityValue [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AWARDPERSONALITYVALUE_2] as string);
_values.m_Description =  valuesList[(int)_ID.ID_DESCRIPTION] as string;
_values.m_FateLineId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FATELINEID] as string);
_values.m_Hanging [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HANGING_0] as string);
_values.m_Hanging [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HANGING_1] as string);
_values.m_Hanging [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HANGING_2] as string);
_values.m_Hanging [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HANGING_3] as string);
_values.m_Hanging [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HANGING_4] as string);
_values.m_Hanging [ 5 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HANGING_5] as string);
_values.m_Hanging [ 6 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HANGING_6] as string);
_values.m_Hanging [ 7 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HANGING_7] as string);
_values.m_Icon =  valuesList[(int)_ID.ID_ICON] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_IsShowTab =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISSHOWTAB] as string);
_values.m_ItemIcon =  valuesList[(int)_ID.ID_ITEMICON] as string;
_values.m_LockId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LOCKID] as string);
_values.m_LockParam [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LOCKPARAM_0] as string);
_values.m_LockParam [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LOCKPARAM_1] as string);
_values.m_LockPrice =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LOCKPRICE] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_PersonalityId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PERSONALITYID] as string);
_values.m_PersonalityLevel =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PERSONALITYLEVEL] as string);
_values.m_Priority =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PRIORITY] as string);
_values.m_SourceText =  valuesList[(int)_ID.ID_SOURCETEXT] as string;
_values.m_SpecAnim [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SPECANIM_0] as string);
_values.m_SpecAnim [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SPECANIM_1] as string);
_values.m_SpecAnim [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SPECANIM_2] as string);
_values.m_Theme =  valuesList[(int)_ID.ID_THEME] as string;

 return _values; }


}
}

