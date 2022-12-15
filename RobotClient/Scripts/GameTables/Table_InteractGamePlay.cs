//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_InteractGamePlay
{ private const string TAB_FILE_DATA = "Table/InteractGamePlay.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_TYPE=2,
ID_SUBTYPE,
ID_STORYCHAPTERID,
ID_UIPACKAGE,
ID_DISPLAYTYPE,
ID_SHOWMASK,
ID_CANLEAVE,
ID_CANSKIP,
ID_AUTOCLOSE,
ID_RES,
ID_SHOWTYPE,
ID_EMPATHY,
ID_ANIMATIONDURATION,
ID_ISFULLSCREEN,
ID_BEGINID,
ID_DELAYTIME,
ID_ENDID,
ID_ENDDELAYTIME,
ID_LEAVESECTIONID,
ID_SURROUNDID,
ID_ERRORID,
ID_COUNTDOWN,
ID_COUNTDOWNTEXT,
ID_COUNTDOWNID,
ID_TITLE,
ID_STEPCOUNT,
ID_KEEPSTATE,
ID_EVENTPARAM_0,
ID_EVENTID_0,
ID_EVENTPARAM_1,
ID_EVENTID_1,
ID_EVENTPARAM_2,
ID_EVENTID_2,
ID_EVENTPARAM_3,
ID_EVENTID_3,
ID_EVENTPARAM_4,
ID_EVENTID_4,
ID_CUSTOMPARAM_0,
ID_CUSTOMPARAM_1,
ID_CUSTOMPARAM_2,
ID_CUSTOMPARAM_3,
ID_CUSTOMPARAM_4,
ID_BRANCHES_0,
ID_BRANCHESID_0,
ID_BRANCHES_1,
ID_BRANCHESID_1,
ID_BRANCHES_2,
ID_BRANCHESID_2,
ID_BRANCHES_3,
ID_BRANCHESID_3,
ID_BRANCHES_4,
ID_BRANCHESID_4,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private float m_AnimationDuration;
 public float AnimationDuration { get{ return m_AnimationDuration;}}

private int m_AutoClose;
 public int AutoClose { get{ return m_AutoClose;}}

private int m_BeginId;
 public int BeginId { get{ return m_BeginId;}}

public int getBranchesIdCount() { return 5; } 
 private int[] m_BranchesId = new int[5];
 public int GetBranchesIdbyIndex(int idx) {
 if(idx>=0 && idx<5) {
 return m_BranchesId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> BranchesIds { get {
  
return Array.AsReadOnly(m_BranchesId);
}} 

public int getBranchesCount() { return 5; } 
 private string[] m_Branches = new string[5];
 public string GetBranchesbyIndex(int idx) {
 if(idx>=0 && idx<5) {
 return m_Branches[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> Branchess { get {
  
return Array.AsReadOnly(m_Branches);
}} 

private int m_CanLeave;
 public int CanLeave { get{ return m_CanLeave;}}

private int m_CanSkip;
 public int CanSkip { get{ return m_CanSkip;}}

private int m_CountDown;
 public int CountDown { get{ return m_CountDown;}}

private int m_CountDownId;
 public int CountDownId { get{ return m_CountDownId;}}

private string m_CountDownText;
 public string CountDownText { get{ return m_CountDownText;}}

public int getCustomParamCount() { return 5; } 
 private string[] m_CustomParam = new string[5];
 public string GetCustomParambyIndex(int idx) {
 if(idx>=0 && idx<5) {
 return m_CustomParam[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> CustomParams { get {
  
return Array.AsReadOnly(m_CustomParam);
}} 

private float m_DelayTime;
 public float DelayTime { get{ return m_DelayTime;}}

private int m_DisplayType;
 public int DisplayType { get{ return m_DisplayType;}}

private int m_Empathy;
 public int Empathy { get{ return m_Empathy;}}

private float m_EndDelayTime;
 public float EndDelayTime { get{ return m_EndDelayTime;}}

private int m_EndId;
 public int EndId { get{ return m_EndId;}}

private int m_ErrorId;
 public int ErrorId { get{ return m_ErrorId;}}

public int getEventIdCount() { return 5; } 
 private int[] m_EventId = new int[5];
 public int GetEventIdbyIndex(int idx) {
 if(idx>=0 && idx<5) {
 return m_EventId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> EventIds { get {
  
return Array.AsReadOnly(m_EventId);
}} 

public int getEventParamCount() { return 5; } 
 private string[] m_EventParam = new string[5];
 public string GetEventParambyIndex(int idx) {
 if(idx>=0 && idx<5) {
 return m_EventParam[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> EventParams { get {
  
return Array.AsReadOnly(m_EventParam);
}} 

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_IsFullScreen;
 public int IsFullScreen { get{ return m_IsFullScreen;}}

private int m_KeepState;
 public int KeepState { get{ return m_KeepState;}}

private int m_LeaveSectionId;
 public int LeaveSectionId { get{ return m_LeaveSectionId;}}

private string m_Res;
 public string Res { get{ return m_Res;}}

private int m_ShowMask;
 public int ShowMask { get{ return m_ShowMask;}}

private int m_ShowType;
 public int ShowType { get{ return m_ShowType;}}

private int m_StepCount;
 public int StepCount { get{ return m_StepCount;}}

private int m_StoryChapterId;
 public int StoryChapterId { get{ return m_StoryChapterId;}}

private int m_SubType;
 public int SubType { get{ return m_SubType;}}

private int m_SurroundId;
 public int SurroundId { get{ return m_SurroundId;}}

private string m_Title;
 public string Title { get{ return m_Title;}}

private int m_Type;
 public int Type { get{ return m_Type;}}

private string m_UIPackage;
 public string UIPackage { get{ return m_UIPackage;}}

public static bool LoadTable(Dictionary<int, List<Tab_InteractGamePlay> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_InteractGamePlay SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_InteractGamePlay _values = new Tab_InteractGamePlay();
 _values.m_AnimationDuration =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_ANIMATIONDURATION] as string );
_values.m_AutoClose =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AUTOCLOSE] as string);
_values.m_BeginId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_BEGINID] as string);
_values.m_BranchesId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_BRANCHESID_0] as string);
_values.m_BranchesId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_BRANCHESID_1] as string);
_values.m_BranchesId [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_BRANCHESID_2] as string);
_values.m_BranchesId [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_BRANCHESID_3] as string);
_values.m_BranchesId [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_BRANCHESID_4] as string);
_values.m_Branches [ 0 ] =  valuesList[(int)_ID.ID_BRANCHES_0] as string;
_values.m_Branches [ 1 ] =  valuesList[(int)_ID.ID_BRANCHES_1] as string;
_values.m_Branches [ 2 ] =  valuesList[(int)_ID.ID_BRANCHES_2] as string;
_values.m_Branches [ 3 ] =  valuesList[(int)_ID.ID_BRANCHES_3] as string;
_values.m_Branches [ 4 ] =  valuesList[(int)_ID.ID_BRANCHES_4] as string;
_values.m_CanLeave =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CANLEAVE] as string);
_values.m_CanSkip =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CANSKIP] as string);
_values.m_CountDown =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_COUNTDOWN] as string);
_values.m_CountDownId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_COUNTDOWNID] as string);
_values.m_CountDownText =  valuesList[(int)_ID.ID_COUNTDOWNTEXT] as string;
_values.m_CustomParam [ 0 ] =  valuesList[(int)_ID.ID_CUSTOMPARAM_0] as string;
_values.m_CustomParam [ 1 ] =  valuesList[(int)_ID.ID_CUSTOMPARAM_1] as string;
_values.m_CustomParam [ 2 ] =  valuesList[(int)_ID.ID_CUSTOMPARAM_2] as string;
_values.m_CustomParam [ 3 ] =  valuesList[(int)_ID.ID_CUSTOMPARAM_3] as string;
_values.m_CustomParam [ 4 ] =  valuesList[(int)_ID.ID_CUSTOMPARAM_4] as string;
_values.m_DelayTime =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_DELAYTIME] as string );
_values.m_DisplayType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DISPLAYTYPE] as string);
_values.m_Empathy =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_EMPATHY] as string);
_values.m_EndDelayTime =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_ENDDELAYTIME] as string );
_values.m_EndId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ENDID] as string);
_values.m_ErrorId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ERRORID] as string);
_values.m_EventId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_EVENTID_0] as string);
_values.m_EventId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_EVENTID_1] as string);
_values.m_EventId [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_EVENTID_2] as string);
_values.m_EventId [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_EVENTID_3] as string);
_values.m_EventId [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_EVENTID_4] as string);
_values.m_EventParam [ 0 ] =  valuesList[(int)_ID.ID_EVENTPARAM_0] as string;
_values.m_EventParam [ 1 ] =  valuesList[(int)_ID.ID_EVENTPARAM_1] as string;
_values.m_EventParam [ 2 ] =  valuesList[(int)_ID.ID_EVENTPARAM_2] as string;
_values.m_EventParam [ 3 ] =  valuesList[(int)_ID.ID_EVENTPARAM_3] as string;
_values.m_EventParam [ 4 ] =  valuesList[(int)_ID.ID_EVENTPARAM_4] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_IsFullScreen =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISFULLSCREEN] as string);
_values.m_KeepState =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_KEEPSTATE] as string);
_values.m_LeaveSectionId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LEAVESECTIONID] as string);
_values.m_Res =  valuesList[(int)_ID.ID_RES] as string;
_values.m_ShowMask =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SHOWMASK] as string);
_values.m_ShowType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SHOWTYPE] as string);
_values.m_StepCount =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_STEPCOUNT] as string);
_values.m_StoryChapterId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_STORYCHAPTERID] as string);
_values.m_SubType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SUBTYPE] as string);
_values.m_SurroundId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SURROUNDID] as string);
_values.m_Title =  valuesList[(int)_ID.ID_TITLE] as string;
_values.m_Type =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TYPE] as string);
_values.m_UIPackage =  valuesList[(int)_ID.ID_UIPACKAGE] as string;

 return _values; }


}
}

