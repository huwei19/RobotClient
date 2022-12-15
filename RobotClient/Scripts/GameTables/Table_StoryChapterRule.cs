//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_StoryChapterRule
{ private const string TAB_FILE_DATA = "Table/StoryChapterRule.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_DESC=2,
ID_MINPLAYERLEVEL,
ID_MINPREVRANK,
ID_ALTSTORYLINE,
ID_ALTCHAPTERID,
ID_MINALTCHAPTERRANK,
ID_MISSION,
ID_ITEMCONSUME,
ID_ITEMNUM,
ID_BANREUSECARD,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_AltChapterId;
 public int AltChapterId { get{ return m_AltChapterId;}}

private int m_AltStoryLine;
 public int AltStoryLine { get{ return m_AltStoryLine;}}

private int m_BanReuseCard;
 public int BanReuseCard { get{ return m_BanReuseCard;}}

private string m_Desc;
 public string Desc { get{ return m_Desc;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_ItemConsume;
 public int ItemConsume { get{ return m_ItemConsume;}}

private int m_ItemNum;
 public int ItemNum { get{ return m_ItemNum;}}

private string m_MinAltChapterRank;
 public string MinAltChapterRank { get{ return m_MinAltChapterRank;}}

private int m_MinPlayerLevel;
 public int MinPlayerLevel { get{ return m_MinPlayerLevel;}}

private string m_MinPrevRank;
 public string MinPrevRank { get{ return m_MinPrevRank;}}

private int m_Mission;
 public int Mission { get{ return m_Mission;}}

public static bool LoadTable(Dictionary<int, List<Tab_StoryChapterRule> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_StoryChapterRule SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_StoryChapterRule _values = new Tab_StoryChapterRule();
 _values.m_AltChapterId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ALTCHAPTERID] as string);
_values.m_AltStoryLine =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ALTSTORYLINE] as string);
_values.m_BanReuseCard =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_BANREUSECARD] as string);
_values.m_Desc =  valuesList[(int)_ID.ID_DESC] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_ItemConsume =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMCONSUME] as string);
_values.m_ItemNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMNUM] as string);
_values.m_MinAltChapterRank =  valuesList[(int)_ID.ID_MINALTCHAPTERRANK] as string;
_values.m_MinPlayerLevel =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MINPLAYERLEVEL] as string);
_values.m_MinPrevRank =  valuesList[(int)_ID.ID_MINPREVRANK] as string;
_values.m_Mission =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MISSION] as string);

 return _values; }


}
}

