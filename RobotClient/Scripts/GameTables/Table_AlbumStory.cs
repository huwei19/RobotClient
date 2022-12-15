//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_AlbumStory
{ private const string TAB_FILE_DATA = "Table/AlbumStory.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_TYPE=2,
ID_NAME,
ID_ICON,
ID_RES,
ID_CHAPTERID,
ID_CHAPTERRANK,
ID_CHARACTERID_0,
ID_CHARACTERID_1,
ID_TITLEID,
ID_ACTIVEAWARDITEMID,
ID_ACTIVEAWARDITEMNUM,
ID_GETWAYID,
ID_PRIORITY,
ID_SHAREREWARDTYPE,
ID_SHAREREWARDNUM,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_ActiveAwardItemId;
 public int ActiveAwardItemId { get{ return m_ActiveAwardItemId;}}

private int m_ActiveAwardItemNum;
 public int ActiveAwardItemNum { get{ return m_ActiveAwardItemNum;}}

private int m_ChapterId;
 public int ChapterId { get{ return m_ChapterId;}}

private int m_ChapterRank;
 public int ChapterRank { get{ return m_ChapterRank;}}

public int getCharacterIdCount() { return 2; } 
 private int[] m_CharacterId = new int[2];
 public int GetCharacterIdbyIndex(int idx) {
 if(idx>=0 && idx<2) {
 return m_CharacterId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> CharacterIds { get {
  
return Array.AsReadOnly(m_CharacterId);
}} 

private int m_GetWayId;
 public int GetWayId { get{ return m_GetWayId;}}

private string m_Icon;
 public string Icon { get{ return m_Icon;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private int m_Priority;
 public int Priority { get{ return m_Priority;}}

private string m_Res;
 public string Res { get{ return m_Res;}}

private int m_ShareRewardNum;
 public int ShareRewardNum { get{ return m_ShareRewardNum;}}

private int m_ShareRewardType;
 public int ShareRewardType { get{ return m_ShareRewardType;}}

private int m_TitleId;
 public int TitleId { get{ return m_TitleId;}}

private int m_Type;
 public int Type { get{ return m_Type;}}

public static bool LoadTable(Dictionary<int, List<Tab_AlbumStory> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_AlbumStory SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_AlbumStory _values = new Tab_AlbumStory();
 _values.m_ActiveAwardItemId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIVEAWARDITEMID] as string);
_values.m_ActiveAwardItemNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIVEAWARDITEMNUM] as string);
_values.m_ChapterId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHAPTERID] as string);
_values.m_ChapterRank =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHAPTERRANK] as string);
_values.m_CharacterId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHARACTERID_0] as string);
_values.m_CharacterId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHARACTERID_1] as string);
_values.m_GetWayId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GETWAYID] as string);
_values.m_Icon =  valuesList[(int)_ID.ID_ICON] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_Priority =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PRIORITY] as string);
_values.m_Res =  valuesList[(int)_ID.ID_RES] as string;
_values.m_ShareRewardNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SHAREREWARDNUM] as string);
_values.m_ShareRewardType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SHAREREWARDTYPE] as string);
_values.m_TitleId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TITLEID] as string);
_values.m_Type =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TYPE] as string);

 return _values; }


}
}

