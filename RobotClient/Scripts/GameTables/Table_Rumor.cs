//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_Rumor
{ private const string TAB_FILE_DATA = "Table/Rumor.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NAME=2,
ID_ICON,
ID_ACITIVITYREWARDRULE,
ID_TARGETDESC,
ID_PROPERTY,
ID_AUDIENCE,
ID_PREGROUPID,
ID_PRERUMORID,
ID_CHAPTERID,
ID_CHAPTERRANK,
ID_GROUPID,
ID_OUTPUTTYPE,
ID_TYPE,
ID_NPCID,
ID_SUBSETCOUNT,
ID_HOT,
ID_HOTMAX,
ID_GROUTHINTERVALTIME,
ID_GROUTHNUM,
ID_ENDSUBID,
ID_ACTIONID,
ID_CONSUMENUM,
ID_REDUCEDROPID,
ID_REDUCEDROPPREVIEWID,
ID_REDUCEDROPTIMES,
ID_JUMPID,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_AcitivityRewardRule;
 public int AcitivityRewardRule { get{ return m_AcitivityRewardRule;}}

private int m_ActionID;
 public int ActionID { get{ return m_ActionID;}}

private string m_Audience;
 public string Audience { get{ return m_Audience;}}

private int m_ChapterId;
 public int ChapterId { get{ return m_ChapterId;}}

private int m_ChapterRank;
 public int ChapterRank { get{ return m_ChapterRank;}}

private int m_ConsumeNum;
 public int ConsumeNum { get{ return m_ConsumeNum;}}

private int m_EndSubId;
 public int EndSubId { get{ return m_EndSubId;}}

private int m_GroupId;
 public int GroupId { get{ return m_GroupId;}}

private int m_GrouthIntervalTime;
 public int GrouthIntervalTime { get{ return m_GrouthIntervalTime;}}

private int m_GrouthNum;
 public int GrouthNum { get{ return m_GrouthNum;}}

private int m_Hot;
 public int Hot { get{ return m_Hot;}}

private int m_HotMax;
 public int HotMax { get{ return m_HotMax;}}

private string m_Icon;
 public string Icon { get{ return m_Icon;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private int m_NpcId;
 public int NpcId { get{ return m_NpcId;}}

private int m_OutputType;
 public int OutputType { get{ return m_OutputType;}}

private int m_PreGroupId;
 public int PreGroupId { get{ return m_PreGroupId;}}

private int m_PreRumorId;
 public int PreRumorId { get{ return m_PreRumorId;}}

private string m_Property;
 public string Property { get{ return m_Property;}}

private int m_ReduceDropId;
 public int ReduceDropId { get{ return m_ReduceDropId;}}

private int m_ReduceDropPreviewId;
 public int ReduceDropPreviewId { get{ return m_ReduceDropPreviewId;}}

private int m_ReduceDropTimes;
 public int ReduceDropTimes { get{ return m_ReduceDropTimes;}}

private int m_SubSetCount;
 public int SubSetCount { get{ return m_SubSetCount;}}

private string m_TargetDesc;
 public string TargetDesc { get{ return m_TargetDesc;}}

private int m_Type;
 public int Type { get{ return m_Type;}}

private int m_Jumpid;
 public int Jumpid { get{ return m_Jumpid;}}

public static bool LoadTable(Dictionary<int, List<Tab_Rumor> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_Rumor SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_Rumor _values = new Tab_Rumor();
 _values.m_AcitivityRewardRule =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACITIVITYREWARDRULE] as string);
_values.m_ActionID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIONID] as string);
_values.m_Audience =  valuesList[(int)_ID.ID_AUDIENCE] as string;
_values.m_ChapterId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHAPTERID] as string);
_values.m_ChapterRank =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHAPTERRANK] as string);
_values.m_ConsumeNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CONSUMENUM] as string);
_values.m_EndSubId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ENDSUBID] as string);
_values.m_GroupId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GROUPID] as string);
_values.m_GrouthIntervalTime =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GROUTHINTERVALTIME] as string);
_values.m_GrouthNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GROUTHNUM] as string);
_values.m_Hot =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HOT] as string);
_values.m_HotMax =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HOTMAX] as string);
_values.m_Icon =  valuesList[(int)_ID.ID_ICON] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_NpcId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NPCID] as string);
_values.m_OutputType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_OUTPUTTYPE] as string);
_values.m_PreGroupId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PREGROUPID] as string);
_values.m_PreRumorId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PRERUMORID] as string);
_values.m_Property =  valuesList[(int)_ID.ID_PROPERTY] as string;
_values.m_ReduceDropId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REDUCEDROPID] as string);
_values.m_ReduceDropPreviewId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REDUCEDROPPREVIEWID] as string);
_values.m_ReduceDropTimes =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REDUCEDROPTIMES] as string);
_values.m_SubSetCount =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SUBSETCOUNT] as string);
_values.m_TargetDesc =  valuesList[(int)_ID.ID_TARGETDESC] as string;
_values.m_Type =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TYPE] as string);
_values.m_Jumpid =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_JUMPID] as string);

 return _values; }


}
}

