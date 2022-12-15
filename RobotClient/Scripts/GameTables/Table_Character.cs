//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_Character
{ private const string TAB_FILE_DATA = "Table/Character.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NAMERES=2,
ID_CARDDETAILHEAD,
ID_ATTRTYPE,
ID_FATELINEID,
ID_FATELINECOUNT,
ID_PERSONRES,
ID_PERSONUIRES,
ID_PERSONUNLOCKNUM,
ID_PERSONSTORY_0,
ID_PERSONSTORY_1,
ID_INTERFLOWSHOW,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_AttrType;
 public int AttrType { get{ return m_AttrType;}}

private int m_FateLineCount;
 public int FateLineCount { get{ return m_FateLineCount;}}

private int m_FateLineId;
 public int FateLineId { get{ return m_FateLineId;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_InterflowShow;
 public int InterflowShow { get{ return m_InterflowShow;}}

private string m_NameRes;
 public string NameRes { get{ return m_NameRes;}}

private string m_PersonRes;
 public string PersonRes { get{ return m_PersonRes;}}

public int getPersonStoryCount() { return 2; } 
 private int[] m_PersonStory = new int[2];
 public int GetPersonStorybyIndex(int idx) {
 if(idx>=0 && idx<2) {
 return m_PersonStory[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> PersonStorys { get {
  
return Array.AsReadOnly(m_PersonStory);
}} 

private string m_PersonUIRes;
 public string PersonUIRes { get{ return m_PersonUIRes;}}

private int m_PersonUnlockNum;
 public int PersonUnlockNum { get{ return m_PersonUnlockNum;}}

private string m_CardDetailHead;
 public string CardDetailHead { get{ return m_CardDetailHead;}}

public static bool LoadTable(Dictionary<int, List<Tab_Character> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_Character SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_Character _values = new Tab_Character();
 _values.m_AttrType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ATTRTYPE] as string);
_values.m_FateLineCount =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FATELINECOUNT] as string);
_values.m_FateLineId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FATELINEID] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_InterflowShow =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_INTERFLOWSHOW] as string);
_values.m_NameRes =  valuesList[(int)_ID.ID_NAMERES] as string;
_values.m_PersonRes =  valuesList[(int)_ID.ID_PERSONRES] as string;
_values.m_PersonStory [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PERSONSTORY_0] as string);
_values.m_PersonStory [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PERSONSTORY_1] as string);
_values.m_PersonUIRes =  valuesList[(int)_ID.ID_PERSONUIRES] as string;
_values.m_PersonUnlockNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PERSONUNLOCKNUM] as string);
_values.m_CardDetailHead =  valuesList[(int)_ID.ID_CARDDETAILHEAD] as string;

 return _values; }


}
}

