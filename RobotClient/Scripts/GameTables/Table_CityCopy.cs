//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_CityCopy
{ private const string TAB_FILE_DATA = "Table/CityCopy.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_CITYID=2,
ID_SHOWTIPS,
ID_STORYCHAPERID,
ID_TIMELIMITRESTART,
ID_FASTNUM,
ID_FASTFREENUM,
ID_REWARDMAXTIME,
ID_FASTREWARDTIME,
ID_REFRESHTIPTIME,
ID_FIRSTACTION,
ID_VERSIONNUM,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_CityId;
 public int CityId { get{ return m_CityId;}}

private int m_FastFreeNum;
 public int FastFreeNum { get{ return m_FastFreeNum;}}

private int m_FastNum;
 public int FastNum { get{ return m_FastNum;}}

private int m_FastRewardTime;
 public int FastRewardTime { get{ return m_FastRewardTime;}}

private int m_FirstAction;
 public int FirstAction { get{ return m_FirstAction;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_RefreshTipTime;
 public int RefreshTipTime { get{ return m_RefreshTipTime;}}

private int m_RewardMaxTime;
 public int RewardMaxTime { get{ return m_RewardMaxTime;}}

private string m_ShowTips;
 public string ShowTips { get{ return m_ShowTips;}}

private int m_StoryChaperId;
 public int StoryChaperId { get{ return m_StoryChaperId;}}

private int m_TimeLimitReStart;
 public int TimeLimitReStart { get{ return m_TimeLimitReStart;}}

private int m_VersionNum;
 public int VersionNum { get{ return m_VersionNum;}}

public static bool LoadTable(Dictionary<int, List<Tab_CityCopy> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_CityCopy SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_CityCopy _values = new Tab_CityCopy();
 _values.m_CityId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CITYID] as string);
_values.m_FastFreeNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FASTFREENUM] as string);
_values.m_FastNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FASTNUM] as string);
_values.m_FastRewardTime =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FASTREWARDTIME] as string);
_values.m_FirstAction =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FIRSTACTION] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_RefreshTipTime =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REFRESHTIPTIME] as string);
_values.m_RewardMaxTime =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REWARDMAXTIME] as string);
_values.m_ShowTips =  valuesList[(int)_ID.ID_SHOWTIPS] as string;
_values.m_StoryChaperId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_STORYCHAPERID] as string);
_values.m_TimeLimitReStart =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TIMELIMITRESTART] as string);
_values.m_VersionNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_VERSIONNUM] as string);

 return _values; }


}
}

