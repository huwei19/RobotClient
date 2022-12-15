//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_Survery
{ private const string TAB_FILE_DATA = "table/Survery.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NAME=2,
ID_VERSIONID,
ID_CHANNELID,
ID_SUBCHANNELID,
ID_SERVERID,
ID_STARTTIME,
ID_ENDTIME,
ID_URL,
ID_MINLEVEL,
ID_MAXLEVEL,
ID_MINTOTALCASH,
ID_MAXTOTALCASH,
ID_CHAPTERID_0,
ID_CHAPTEREND_0,
ID_CHAPTERID_1,
ID_CHAPTEREND_1,
ID_CHAPTERID_2,
ID_CHAPTEREND_2,
ID_CHAPTERID_3,
ID_CHAPTEREND_3,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_ChannelID;
 public int ChannelID { get{ return m_ChannelID;}}

public int getChapterEndCount() { return 4; } 
 private int[] m_ChapterEnd = new int[4];
 public int GetChapterEndbyIndex(int idx) {
 if(idx>=0 && idx<4) return m_ChapterEnd[idx];
 return -1;
 }
 public ReadOnlyCollection <int> ChapterEnds { get { return Array.AsReadOnly(m_ChapterEnd);}} 

public int getChapterIdCount() { return 4; } 
 private int[] m_ChapterId = new int[4];
 public int GetChapterIdbyIndex(int idx) {
 if(idx>=0 && idx<4) return m_ChapterId[idx];
 return -1;
 }
 public ReadOnlyCollection <int> ChapterIds { get { return Array.AsReadOnly(m_ChapterId);}} 

private string m_EndTime;
 public string EndTime { get{ return m_EndTime;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_MaxLevel;
 public int MaxLevel { get{ return m_MaxLevel;}}

private int m_MaxTotalcash;
 public int MaxTotalcash { get{ return m_MaxTotalcash;}}

private int m_MinLevel;
 public int MinLevel { get{ return m_MinLevel;}}

private int m_MinTotalcash;
 public int MinTotalcash { get{ return m_MinTotalcash;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private int m_ServerID;
 public int ServerID { get{ return m_ServerID;}}

private string m_StartTime;
 public string StartTime { get{ return m_StartTime;}}

private int m_SubChannelId;
 public int SubChannelId { get{ return m_SubChannelId;}}

private string m_Url;
 public string Url { get{ return m_Url;}}

private int m_VersionId;
 public int VersionId { get{ return m_VersionId;}}

public static bool LoadTable(Dictionary<int, List<Tab_Survery> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_Survery SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_Survery _values = new Tab_Survery();
 _values.m_ChannelID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHANNELID] as string);
_values.m_ChapterEnd [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHAPTEREND_0] as string);
_values.m_ChapterEnd [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHAPTEREND_1] as string);
_values.m_ChapterEnd [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHAPTEREND_2] as string);
_values.m_ChapterEnd [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHAPTEREND_3] as string);
_values.m_ChapterId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHAPTERID_0] as string);
_values.m_ChapterId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHAPTERID_1] as string);
_values.m_ChapterId [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHAPTERID_2] as string);
_values.m_ChapterId [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHAPTERID_3] as string);
_values.m_EndTime =  valuesList[(int)_ID.ID_ENDTIME] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_MaxLevel =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MAXLEVEL] as string);
_values.m_MaxTotalcash =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MAXTOTALCASH] as string);
_values.m_MinLevel =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MINLEVEL] as string);
_values.m_MinTotalcash =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MINTOTALCASH] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_ServerID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SERVERID] as string);
_values.m_StartTime =  valuesList[(int)_ID.ID_STARTTIME] as string;
_values.m_SubChannelId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SUBCHANNELID] as string);
_values.m_Url =  valuesList[(int)_ID.ID_URL] as string;
_values.m_VersionId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_VERSIONID] as string);

 return _values; }


}
}

