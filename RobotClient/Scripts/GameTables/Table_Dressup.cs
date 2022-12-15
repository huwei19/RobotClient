//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_Dressup
{ private const string TAB_FILE_DATA = "Table/Dressup.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_CARDSKINID=2,
ID_TYPE,
ID_DATAINDEX,
ID_DATAPOS,
ID_NAME,
ID_DESCRIPTION,
ID_ICON,
ID_LOCKTYPE,
ID_LOCKPARAM_0,
ID_LOCKPARAM_1,
ID_LOCKPRICE,
ID_PERSONALITYID,
ID_PERSONALITYLEVEL,
ID_AUDIOID,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_AudioId;
 public int AudioId { get{ return m_AudioId;}}

private int m_CardSkinId;
 public int CardSkinId { get{ return m_CardSkinId;}}

private int m_DataIndex;
 public int DataIndex { get{ return m_DataIndex;}}

private int m_DataPos;
 public int DataPos { get{ return m_DataPos;}}

private string m_Description;
 public string Description { get{ return m_Description;}}

private string m_Icon;
 public string Icon { get{ return m_Icon;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

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

private int m_LockType;
 public int LockType { get{ return m_LockType;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private int m_PersonalityId;
 public int PersonalityId { get{ return m_PersonalityId;}}

private int m_PersonalityLevel;
 public int PersonalityLevel { get{ return m_PersonalityLevel;}}

private int m_Type;
 public int Type { get{ return m_Type;}}

public static bool LoadTable(Dictionary<int, List<Tab_Dressup> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_Dressup SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_Dressup _values = new Tab_Dressup();
 _values.m_AudioId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AUDIOID] as string);
_values.m_CardSkinId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CARDSKINID] as string);
_values.m_DataIndex =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DATAINDEX] as string);
_values.m_DataPos =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DATAPOS] as string);
_values.m_Description =  valuesList[(int)_ID.ID_DESCRIPTION] as string;
_values.m_Icon =  valuesList[(int)_ID.ID_ICON] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_LockParam [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LOCKPARAM_0] as string);
_values.m_LockParam [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LOCKPARAM_1] as string);
_values.m_LockPrice =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LOCKPRICE] as string);
_values.m_LockType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LOCKTYPE] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_PersonalityId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PERSONALITYID] as string);
_values.m_PersonalityLevel =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PERSONALITYLEVEL] as string);
_values.m_Type =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TYPE] as string);

 return _values; }


}
}

