//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_StoryChapterEndingRule
{ private const string TAB_FILE_DATA = "Table/StoryChapterEndingRule.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_DESC=2,
ID_UNLOCKPREVRANKREQ_0,
ID_UNLOCKPREVRANKREQ_1,
ID_UNLOCKPREVRANKREQ_2,
ID_PLACEHOLDER,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private string m_Desc;
 public string Desc { get{ return m_Desc;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_PlaceHolder;
 public int PlaceHolder { get{ return m_PlaceHolder;}}

public int getUnlockPrevRankReqCount() { return 3; } 
 private string[] m_UnlockPrevRankReq = new string[3];
 public string GetUnlockPrevRankReqbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_UnlockPrevRankReq[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> UnlockPrevRankReqs { get {
  
return Array.AsReadOnly(m_UnlockPrevRankReq);
}} 

public static bool LoadTable(Dictionary<int, List<Tab_StoryChapterEndingRule> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_StoryChapterEndingRule SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_StoryChapterEndingRule _values = new Tab_StoryChapterEndingRule();
 _values.m_Desc =  valuesList[(int)_ID.ID_DESC] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_PlaceHolder =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PLACEHOLDER] as string);
_values.m_UnlockPrevRankReq [ 0 ] =  valuesList[(int)_ID.ID_UNLOCKPREVRANKREQ_0] as string;
_values.m_UnlockPrevRankReq [ 1 ] =  valuesList[(int)_ID.ID_UNLOCKPREVRANKREQ_1] as string;
_values.m_UnlockPrevRankReq [ 2 ] =  valuesList[(int)_ID.ID_UNLOCKPREVRANKREQ_2] as string;

 return _values; }


}
}

