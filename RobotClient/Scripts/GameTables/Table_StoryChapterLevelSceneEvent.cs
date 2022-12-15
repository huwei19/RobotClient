//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_StoryChapterLevelSceneEvent
{ private const string TAB_FILE_DATA = "Table/StoryChapterLevelSceneEvent.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NAME=2,
ID_STORYCHAPTERLEVELID,
ID_SECTIONID,
ID_SCENEOBJECT,
ID_BEHAVIORID,
ID_INLIST,
ID_ACTIVEONAWAKE,
ID_ISMAINEVENT,
ID_EVENTTYPE,
ID_DISPLAYTYPE,
ID_HIDE,
ID_ONCE,
ID_ONCEAWARD,
ID_ONCEAWARDPREVIEW,
ID_SAVEPOINT,
ID_ENDINGNOTICE,
ID_FLOORDESC,
ID_TIMELIMIT,
ID_ACTIONPOINTS,
ID_CLUENUM,
ID_FORWARDTIME,
ID_ISPASSIVE,
ID_CATEGORY,
ID_CARDTYPE,
ID_PERSONALITY,
ID_PERSONLITYLEVEL,
ID_PROGRESS,
ID_TAGHINT_0,
ID_TAGHINT_1,
ID_TAGHINT_2,
ID_HIDDENTAGHINT_0,
ID_HIDDENTAGHINT_1,
ID_HIDDENTAGHINT_2,
ID_PASSIVETAGHINT_0,
ID_PASSIVETAGHINT_1,
ID_PASSIVETAGHINT_2,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_ActionPoints;
 public int ActionPoints { get{ return m_ActionPoints;}}

private int m_ActiveOnAwake;
 public int ActiveOnAwake { get{ return m_ActiveOnAwake;}}

private int m_BehaviorId;
 public int BehaviorId { get{ return m_BehaviorId;}}

private int m_CardType;
 public int CardType { get{ return m_CardType;}}

private string m_Category;
 public string Category { get{ return m_Category;}}

private int m_ClueNum;
 public int ClueNum { get{ return m_ClueNum;}}

private int m_DisplayType;
 public int DisplayType { get{ return m_DisplayType;}}

private int m_EndingNotice;
 public int EndingNotice { get{ return m_EndingNotice;}}

private int m_EventType;
 public int EventType { get{ return m_EventType;}}

private int m_FloorDesc;
 public int FloorDesc { get{ return m_FloorDesc;}}

private int m_ForwardTime;
 public int ForwardTime { get{ return m_ForwardTime;}}

public int getHiddenTagHintCount() { return 3; } 
 private int[] m_HiddenTagHint = new int[3];
 public int GetHiddenTagHintbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_HiddenTagHint[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> HiddenTagHints { get {
  
return Array.AsReadOnly(m_HiddenTagHint);
}} 

private int m_Hide;
 public int Hide { get{ return m_Hide;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_InList;
 public int InList { get{ return m_InList;}}

private int m_IsMainEvent;
 public int IsMainEvent { get{ return m_IsMainEvent;}}

private int m_IsPassive;
 public int IsPassive { get{ return m_IsPassive;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private int m_Once;
 public int Once { get{ return m_Once;}}

private int m_OnceAward;
 public int OnceAward { get{ return m_OnceAward;}}

private int m_OnceAwardPreview;
 public int OnceAwardPreview { get{ return m_OnceAwardPreview;}}

public int getPassiveTagHintCount() { return 3; } 
 private int[] m_PassiveTagHint = new int[3];
 public int GetPassiveTagHintbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_PassiveTagHint[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> PassiveTagHints { get {
  
return Array.AsReadOnly(m_PassiveTagHint);
}} 

private int m_Personality;
 public int Personality { get{ return m_Personality;}}

private int m_PersonlityLevel;
 public int PersonlityLevel { get{ return m_PersonlityLevel;}}

private int m_Progress;
 public int Progress { get{ return m_Progress;}}

private int m_SavePoint;
 public int SavePoint { get{ return m_SavePoint;}}

private int m_SceneObject;
 public int SceneObject { get{ return m_SceneObject;}}

private int m_SectionId;
 public int SectionId { get{ return m_SectionId;}}

private int m_StoryChapterLevelId;
 public int StoryChapterLevelId { get{ return m_StoryChapterLevelId;}}

public int getTagHintCount() { return 3; } 
 private int[] m_TagHint = new int[3];
 public int GetTagHintbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_TagHint[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> TagHints { get {
  
return Array.AsReadOnly(m_TagHint);
}} 

private int m_TimeLimit;
 public int TimeLimit { get{ return m_TimeLimit;}}

public static bool LoadTable(Dictionary<int, List<Tab_StoryChapterLevelSceneEvent> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_StoryChapterLevelSceneEvent SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_StoryChapterLevelSceneEvent _values = new Tab_StoryChapterLevelSceneEvent();
 _values.m_ActionPoints =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIONPOINTS] as string);
_values.m_ActiveOnAwake =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIVEONAWAKE] as string);
_values.m_BehaviorId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_BEHAVIORID] as string);
_values.m_CardType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CARDTYPE] as string);
_values.m_Category =  valuesList[(int)_ID.ID_CATEGORY] as string;
_values.m_ClueNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CLUENUM] as string);
_values.m_DisplayType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DISPLAYTYPE] as string);
_values.m_EndingNotice =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ENDINGNOTICE] as string);
_values.m_EventType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_EVENTTYPE] as string);
_values.m_FloorDesc =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FLOORDESC] as string);
_values.m_ForwardTime =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FORWARDTIME] as string);
_values.m_HiddenTagHint [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HIDDENTAGHINT_0] as string);
_values.m_HiddenTagHint [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HIDDENTAGHINT_1] as string);
_values.m_HiddenTagHint [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HIDDENTAGHINT_2] as string);
_values.m_Hide =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HIDE] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_InList =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_INLIST] as string);
_values.m_IsMainEvent =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISMAINEVENT] as string);
_values.m_IsPassive =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISPASSIVE] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_Once =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ONCE] as string);
_values.m_OnceAward =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ONCEAWARD] as string);
_values.m_OnceAwardPreview =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ONCEAWARDPREVIEW] as string);
_values.m_PassiveTagHint [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PASSIVETAGHINT_0] as string);
_values.m_PassiveTagHint [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PASSIVETAGHINT_1] as string);
_values.m_PassiveTagHint [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PASSIVETAGHINT_2] as string);
_values.m_Personality =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PERSONALITY] as string);
_values.m_PersonlityLevel =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PERSONLITYLEVEL] as string);
_values.m_Progress =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PROGRESS] as string);
_values.m_SavePoint =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SAVEPOINT] as string);
_values.m_SceneObject =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SCENEOBJECT] as string);
_values.m_SectionId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SECTIONID] as string);
_values.m_StoryChapterLevelId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_STORYCHAPTERLEVELID] as string);
_values.m_TagHint [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TAGHINT_0] as string);
_values.m_TagHint [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TAGHINT_1] as string);
_values.m_TagHint [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TAGHINT_2] as string);
_values.m_TimeLimit =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TIMELIMIT] as string);

 return _values; }


}
}

