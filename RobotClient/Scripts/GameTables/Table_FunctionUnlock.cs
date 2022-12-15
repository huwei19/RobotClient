//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_FunctionUnlock
{ private const string TAB_FILE_DATA = "Table/FunctionUnlock.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NAME=2,
ID_RESIMAGE,
ID_GUIDEID,
ID_ISTIPSSHOW,
ID_REQFUNCTION,
ID_REQLEV,
ID_REQSTORY,
ID_REQSTORYENDING,
ID_REQSTORYLEVEL_0,
ID_REQSTORYLEVEL_1,
ID_REQONLINEORDERLEV,
ID_ISPREUNLOCK,
ID_PREREQFUNCTION,
ID_PREREQLEV,
ID_PREREQSTORY,
ID_PREREQSTORYENDING,
ID_PREREQSTORYLEVEL_0,
ID_PREREQSTORYLEVEL_1,
ID_PREREQONLINEORDERLEV,
ID_RECOMMEND,
ID_DEFAULTREC,
ID_STORYCHAPTERID,
ID_STORYENDRANK,
ID_REQDEBTPUNISHSTATE,
ID_ISSHOWPANEL,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_DefaultRec;
 public int DefaultRec { get{ return m_DefaultRec;}}

private int m_GuideID;
 public int GuideID { get{ return m_GuideID;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_IsPreUnLock;
 public int IsPreUnLock { get{ return m_IsPreUnLock;}}

private int m_IsShowPanel;
 public int IsShowPanel { get{ return m_IsShowPanel;}}

private int m_IsTipsShow;
 public int IsTipsShow { get{ return m_IsTipsShow;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private int m_PreReqFunction;
 public int PreReqFunction { get{ return m_PreReqFunction;}}

private int m_PreReqLev;
 public int PreReqLev { get{ return m_PreReqLev;}}

private int m_PreReqOnlineOrderLev;
 public int PreReqOnlineOrderLev { get{ return m_PreReqOnlineOrderLev;}}

private int m_PreReqStory;
 public int PreReqStory { get{ return m_PreReqStory;}}

private int m_PreReqStoryEnding;
 public int PreReqStoryEnding { get{ return m_PreReqStoryEnding;}}

public int getPreReqStoryLevelCount() { return 2; } 
 private int[] m_PreReqStoryLevel = new int[2];
 public int GetPreReqStoryLevelbyIndex(int idx) {
 if(idx>=0 && idx<2) {
 return m_PreReqStoryLevel[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> PreReqStoryLevels { get {
  
return Array.AsReadOnly(m_PreReqStoryLevel);
}} 

private int m_Recommend;
 public int Recommend { get{ return m_Recommend;}}

private int m_ReqDebtPunishState;
 public int ReqDebtPunishState { get{ return m_ReqDebtPunishState;}}

private int m_ReqFunction;
 public int ReqFunction { get{ return m_ReqFunction;}}

private int m_ReqLev;
 public int ReqLev { get{ return m_ReqLev;}}

private int m_ReqOnlineOrderLev;
 public int ReqOnlineOrderLev { get{ return m_ReqOnlineOrderLev;}}

private int m_ReqStory;
 public int ReqStory { get{ return m_ReqStory;}}

private int m_ReqStoryEnding;
 public int ReqStoryEnding { get{ return m_ReqStoryEnding;}}

public int getReqStoryLevelCount() { return 2; } 
 private int[] m_ReqStoryLevel = new int[2];
 public int GetReqStoryLevelbyIndex(int idx) {
 if(idx>=0 && idx<2) {
 return m_ReqStoryLevel[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> ReqStoryLevels { get {
  
return Array.AsReadOnly(m_ReqStoryLevel);
}} 

private string m_ResImage;
 public string ResImage { get{ return m_ResImage;}}

private int m_StoryChapterId;
 public int StoryChapterId { get{ return m_StoryChapterId;}}

private int m_StoryEndRank;
 public int StoryEndRank { get{ return m_StoryEndRank;}}

public static bool LoadTable(Dictionary<int, List<Tab_FunctionUnlock> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_FunctionUnlock SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_FunctionUnlock _values = new Tab_FunctionUnlock();
 _values.m_DefaultRec =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DEFAULTREC] as string);
_values.m_GuideID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GUIDEID] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_IsPreUnLock =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISPREUNLOCK] as string);
_values.m_IsShowPanel =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISSHOWPANEL] as string);
_values.m_IsTipsShow =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISTIPSSHOW] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_PreReqFunction =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PREREQFUNCTION] as string);
_values.m_PreReqLev =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PREREQLEV] as string);
_values.m_PreReqOnlineOrderLev =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PREREQONLINEORDERLEV] as string);
_values.m_PreReqStory =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PREREQSTORY] as string);
_values.m_PreReqStoryEnding =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PREREQSTORYENDING] as string);
_values.m_PreReqStoryLevel [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PREREQSTORYLEVEL_0] as string);
_values.m_PreReqStoryLevel [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PREREQSTORYLEVEL_1] as string);
_values.m_Recommend =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_RECOMMEND] as string);
_values.m_ReqDebtPunishState =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REQDEBTPUNISHSTATE] as string);
_values.m_ReqFunction =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REQFUNCTION] as string);
_values.m_ReqLev =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REQLEV] as string);
_values.m_ReqOnlineOrderLev =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REQONLINEORDERLEV] as string);
_values.m_ReqStory =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REQSTORY] as string);
_values.m_ReqStoryEnding =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REQSTORYENDING] as string);
_values.m_ReqStoryLevel [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REQSTORYLEVEL_0] as string);
_values.m_ReqStoryLevel [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REQSTORYLEVEL_1] as string);
_values.m_ResImage =  valuesList[(int)_ID.ID_RESIMAGE] as string;
_values.m_StoryChapterId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_STORYCHAPTERID] as string);
_values.m_StoryEndRank =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_STORYENDRANK] as string);

 return _values; }


}
}

