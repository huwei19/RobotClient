//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_StoryChapterLevelRule
{ private const string TAB_FILE_DATA = "Table/StoryChapterLevelRule.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_CHAPTERRANKREQ=2,
ID_STACONSUME,
ID_STARECONSUME,
ID_MAXLINEUPNUM,
ID_MINLEVEL,
ID_MAXLEVEL,
ID_ITEMID,
ID_ITEMCONSUME,
ID_RULETYPE,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private string m_ChapterRankReq;
 public string ChapterRankReq { get{ return m_ChapterRankReq;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_ItemConsume;
 public int ItemConsume { get{ return m_ItemConsume;}}

private int m_ItemId;
 public int ItemId { get{ return m_ItemId;}}

private int m_MaxLevel;
 public int MaxLevel { get{ return m_MaxLevel;}}

private int m_MaxLineupNum;
 public int MaxLineupNum { get{ return m_MaxLineupNum;}}

private int m_MinLevel;
 public int MinLevel { get{ return m_MinLevel;}}

private int m_RuleType;
 public int RuleType { get{ return m_RuleType;}}

private int m_StaConsume;
 public int StaConsume { get{ return m_StaConsume;}}

private int m_StaReConsume;
 public int StaReConsume { get{ return m_StaReConsume;}}

public static bool LoadTable(Dictionary<int, List<Tab_StoryChapterLevelRule> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_StoryChapterLevelRule SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_StoryChapterLevelRule _values = new Tab_StoryChapterLevelRule();
 _values.m_ChapterRankReq =  valuesList[(int)_ID.ID_CHAPTERRANKREQ] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_ItemConsume =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMCONSUME] as string);
_values.m_ItemId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMID] as string);
_values.m_MaxLevel =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MAXLEVEL] as string);
_values.m_MaxLineupNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MAXLINEUPNUM] as string);
_values.m_MinLevel =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MINLEVEL] as string);
_values.m_RuleType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_RULETYPE] as string);
_values.m_StaConsume =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_STACONSUME] as string);
_values.m_StaReConsume =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_STARECONSUME] as string);

 return _values; }


}
}

