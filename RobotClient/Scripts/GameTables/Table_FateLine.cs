//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_FateLine
{ private const string TAB_FILE_DATA = "Table/FateLine.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NAME=2,
ID_DESC,
ID_CARDID,
ID_APPOINTID,
ID_RES,
ID_BGRES,
ID_HEADICON,
ID_CARDNAMECOLOR,
ID_CARDNAMEBG,
ID_FATEICON,
ID_LIGHTFATEICON,
ID_FATENAMERES,
ID_CONDITIONID,
ID_ISAUTOACTIVE,
ID_ACTIVEITEMID,
ID_ACTIVEITEMNUM,
ID_PERSONALITYID_0,
ID_PERSONALITYMIN_0,
ID_PERSONALITYID_1,
ID_PERSONALITYMIN_1,
ID_PERSONALITYID_2,
ID_PERSONALITYMIN_2,
ID_PERSONALITYMAX,
ID_PERSONALITYITEM,
ID_PERSONALITYVALUE,
ID_PERSONALITYCONSUME,
ID_AUDIOID,
ID_AUDIOEFFECTID,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_ActiveItemId;
 public int ActiveItemId { get{ return m_ActiveItemId;}}

private int m_ActiveItemNum;
 public int ActiveItemNum { get{ return m_ActiveItemNum;}}

private int m_AppointId;
 public int AppointId { get{ return m_AppointId;}}

private int m_AudioEffectId;
 public int AudioEffectId { get{ return m_AudioEffectId;}}

private int m_AudioId;
 public int AudioId { get{ return m_AudioId;}}

private string m_BgRes;
 public string BgRes { get{ return m_BgRes;}}

private int m_CardId;
 public int CardId { get{ return m_CardId;}}

private string m_CardNameBg;
 public string CardNameBg { get{ return m_CardNameBg;}}

private string m_CardNameColor;
 public string CardNameColor { get{ return m_CardNameColor;}}

private int m_ConditionId;
 public int ConditionId { get{ return m_ConditionId;}}

private string m_Desc;
 public string Desc { get{ return m_Desc;}}

private string m_FateIcon;
 public string FateIcon { get{ return m_FateIcon;}}

private string m_FateNameRes;
 public string FateNameRes { get{ return m_FateNameRes;}}

private string m_HeadIcon;
 public string HeadIcon { get{ return m_HeadIcon;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_IsAutoActive;
 public int IsAutoActive { get{ return m_IsAutoActive;}}

private string m_LightFateIcon;
 public string LightFateIcon { get{ return m_LightFateIcon;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private int m_PersonalityConsume;
 public int PersonalityConsume { get{ return m_PersonalityConsume;}}

public int getPersonalityIdCount() { return 3; } 
 private int[] m_PersonalityId = new int[3];
 public int GetPersonalityIdbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_PersonalityId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> PersonalityIds { get {
  
return Array.AsReadOnly(m_PersonalityId);
}} 

private int m_PersonalityItem;
 public int PersonalityItem { get{ return m_PersonalityItem;}}

private int m_PersonalityMax;
 public int PersonalityMax { get{ return m_PersonalityMax;}}

public int getPersonalityMinCount() { return 3; } 
 private int[] m_PersonalityMin = new int[3];
 public int GetPersonalityMinbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_PersonalityMin[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> PersonalityMins { get {
  
return Array.AsReadOnly(m_PersonalityMin);
}} 

private int m_PersonalityValue;
 public int PersonalityValue { get{ return m_PersonalityValue;}}

private string m_Res;
 public string Res { get{ return m_Res;}}

public static bool LoadTable(Dictionary<int, List<Tab_FateLine> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_FateLine SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_FateLine _values = new Tab_FateLine();
 _values.m_ActiveItemId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIVEITEMID] as string);
_values.m_ActiveItemNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIVEITEMNUM] as string);
_values.m_AppointId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_APPOINTID] as string);
_values.m_AudioEffectId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AUDIOEFFECTID] as string);
_values.m_AudioId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AUDIOID] as string);
_values.m_BgRes =  valuesList[(int)_ID.ID_BGRES] as string;
_values.m_CardId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CARDID] as string);
_values.m_CardNameBg =  valuesList[(int)_ID.ID_CARDNAMEBG] as string;
_values.m_CardNameColor =  valuesList[(int)_ID.ID_CARDNAMECOLOR] as string;
_values.m_ConditionId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CONDITIONID] as string);
_values.m_Desc =  valuesList[(int)_ID.ID_DESC] as string;
_values.m_FateIcon =  valuesList[(int)_ID.ID_FATEICON] as string;
_values.m_FateNameRes =  valuesList[(int)_ID.ID_FATENAMERES] as string;
_values.m_HeadIcon =  valuesList[(int)_ID.ID_HEADICON] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_IsAutoActive =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISAUTOACTIVE] as string);
_values.m_LightFateIcon =  valuesList[(int)_ID.ID_LIGHTFATEICON] as string;
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_PersonalityConsume =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PERSONALITYCONSUME] as string);
_values.m_PersonalityId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PERSONALITYID_0] as string);
_values.m_PersonalityId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PERSONALITYID_1] as string);
_values.m_PersonalityId [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PERSONALITYID_2] as string);
_values.m_PersonalityItem =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PERSONALITYITEM] as string);
_values.m_PersonalityMax =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PERSONALITYMAX] as string);
_values.m_PersonalityMin [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PERSONALITYMIN_0] as string);
_values.m_PersonalityMin [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PERSONALITYMIN_1] as string);
_values.m_PersonalityMin [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PERSONALITYMIN_2] as string);
_values.m_PersonalityValue =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PERSONALITYVALUE] as string);
_values.m_Res =  valuesList[(int)_ID.ID_RES] as string;

 return _values; }


}
}

