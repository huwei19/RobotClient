//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_StoryChapterLevel
{ private const string TAB_FILE_DATA = "Table/StoryChapterLevel.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_RESID=2,
ID_STORYFILE,
ID_DIALOG,
ID_STORYCHAPTERID,
ID_RUMORSUBID,
ID_GUIDEID,
ID_SAVEPOINTVERSION,
ID_LEVELRULE,
ID_NAME,
ID_DESC,
ID_EXPLAIN,
ID_SUGGESTION,
ID_FLOOR,
ID_ATTRVALUE,
ID_SPTVAL,
ID_WISVAL,
ID_STRVAL,
ID_LEVELHIDE,
ID_LEVELHIDETIPS,
ID_LEVELTYPE,
ID_LEVELSTAGE,
ID_BRANCHNAME_0,
ID_BRANCHLEVELID_0,
ID_BRANCHNAME_1,
ID_BRANCHLEVELID_1,
ID_BRANCHNAME_2,
ID_BRANCHLEVELID_2,
ID_LOCATIONID,
ID_LOCATIONNAME,
ID_LEVELSCENE,
ID_WEATHER,
ID_ELAPSEDTIME,
ID_ACTIONPOINTS,
ID_MINCLUENUM,
ID_SEX,
ID_LOCKCARD,
ID_LOCKCHARACTER,
ID_LOCKFATE,
ID_RECOMMEND_0,
ID_RECOMMEND_1,
ID_RECOMMEND_2,
ID_RECOMMEND_3,
ID_RECOMMEND_4,
ID_RECOMMEND_5,
ID_PERSONALITY_0,
ID_PERSONALITY_1,
ID_CLUENUM,
ID_IMPORTANTEVENTNUM,
ID_INVESTIGATEEVENTNUM,
ID_SPECIALCLUES,
ID_SPECIALCLUENUM,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_ActionPoints;
 public int ActionPoints { get{ return m_ActionPoints;}}

private int m_AttrValue;
 public int AttrValue { get{ return m_AttrValue;}}

public int getBranchLevelIdCount() { return 3; } 
 private string[] m_BranchLevelId = new string[3];
 public string GetBranchLevelIdbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_BranchLevelId[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> BranchLevelIds { get {
  
return Array.AsReadOnly(m_BranchLevelId);
}} 

public int getBranchNameCount() { return 3; } 
 private string[] m_BranchName = new string[3];
 public string GetBranchNamebyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_BranchName[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> BranchNames { get {
  
return Array.AsReadOnly(m_BranchName);
}} 

private int m_ClueNum;
 public int ClueNum { get{ return m_ClueNum;}}

private string m_Desc;
 public string Desc { get{ return m_Desc;}}

private int m_Dialog;
 public int Dialog { get{ return m_Dialog;}}

private int m_ElapsedTime;
 public int ElapsedTime { get{ return m_ElapsedTime;}}

private string m_Explain;
 public string Explain { get{ return m_Explain;}}

private int m_Floor;
 public int Floor { get{ return m_Floor;}}

private int m_GuideId;
 public int GuideId { get{ return m_GuideId;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_ImportantEventNum;
 public int ImportantEventNum { get{ return m_ImportantEventNum;}}

private int m_InvestigateEventNum;
 public int InvestigateEventNum { get{ return m_InvestigateEventNum;}}

private int m_LevelHide;
 public int LevelHide { get{ return m_LevelHide;}}

private int m_LevelHideTips;
 public int LevelHideTips { get{ return m_LevelHideTips;}}

private int m_LevelRule;
 public int LevelRule { get{ return m_LevelRule;}}

private int m_LevelScene;
 public int LevelScene { get{ return m_LevelScene;}}

private int m_LevelStage;
 public int LevelStage { get{ return m_LevelStage;}}

private int m_LevelType;
 public int LevelType { get{ return m_LevelType;}}

private string m_LocationId;
 public string LocationId { get{ return m_LocationId;}}

private string m_LocationName;
 public string LocationName { get{ return m_LocationName;}}

private int m_LockCard;
 public int LockCard { get{ return m_LockCard;}}

private int m_LockCharacter;
 public int LockCharacter { get{ return m_LockCharacter;}}

private int m_LockFate;
 public int LockFate { get{ return m_LockFate;}}

private int m_MinClueNum;
 public int MinClueNum { get{ return m_MinClueNum;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

public int getPersonalityCount() { return 2; } 
 private int[] m_Personality = new int[2];
 public int GetPersonalitybyIndex(int idx) {
 if(idx>=0 && idx<2) {
 return m_Personality[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> Personalitys { get {
  
return Array.AsReadOnly(m_Personality);
}} 

public int getRecommendCount() { return 6; } 
 private int[] m_Recommend = new int[6];
 public int GetRecommendbyIndex(int idx) {
 if(idx>=0 && idx<6) {
 return m_Recommend[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> Recommends { get {
  
return Array.AsReadOnly(m_Recommend);
}} 

private string m_ResId;
 public string ResId { get{ return m_ResId;}}

private int m_RumorSubId;
 public int RumorSubId { get{ return m_RumorSubId;}}

private int m_SavePointVersion;
 public int SavePointVersion { get{ return m_SavePointVersion;}}

private int m_Sex;
 public int Sex { get{ return m_Sex;}}

private int m_SpecialClueNum;
 public int SpecialClueNum { get{ return m_SpecialClueNum;}}

private string m_SpecialClues;
 public string SpecialClues { get{ return m_SpecialClues;}}

private int m_SptVal;
 public int SptVal { get{ return m_SptVal;}}

private int m_StoryChapterId;
 public int StoryChapterId { get{ return m_StoryChapterId;}}

private string m_StoryFile;
 public string StoryFile { get{ return m_StoryFile;}}

private int m_StrVal;
 public int StrVal { get{ return m_StrVal;}}

private string m_Suggestion;
 public string Suggestion { get{ return m_Suggestion;}}

private int m_Weather;
 public int Weather { get{ return m_Weather;}}

private int m_WisVal;
 public int WisVal { get{ return m_WisVal;}}

public static bool LoadTable(Dictionary<int, List<Tab_StoryChapterLevel> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_StoryChapterLevel SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_StoryChapterLevel _values = new Tab_StoryChapterLevel();
 _values.m_ActionPoints =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIONPOINTS] as string);
_values.m_AttrValue =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ATTRVALUE] as string);
_values.m_BranchLevelId [ 0 ] =  valuesList[(int)_ID.ID_BRANCHLEVELID_0] as string;
_values.m_BranchLevelId [ 1 ] =  valuesList[(int)_ID.ID_BRANCHLEVELID_1] as string;
_values.m_BranchLevelId [ 2 ] =  valuesList[(int)_ID.ID_BRANCHLEVELID_2] as string;
_values.m_BranchName [ 0 ] =  valuesList[(int)_ID.ID_BRANCHNAME_0] as string;
_values.m_BranchName [ 1 ] =  valuesList[(int)_ID.ID_BRANCHNAME_1] as string;
_values.m_BranchName [ 2 ] =  valuesList[(int)_ID.ID_BRANCHNAME_2] as string;
_values.m_ClueNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CLUENUM] as string);
_values.m_Desc =  valuesList[(int)_ID.ID_DESC] as string;
_values.m_Dialog =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DIALOG] as string);
_values.m_ElapsedTime =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ELAPSEDTIME] as string);
_values.m_Explain =  valuesList[(int)_ID.ID_EXPLAIN] as string;
_values.m_Floor =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FLOOR] as string);
_values.m_GuideId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GUIDEID] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_ImportantEventNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_IMPORTANTEVENTNUM] as string);
_values.m_InvestigateEventNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_INVESTIGATEEVENTNUM] as string);
_values.m_LevelHide =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LEVELHIDE] as string);
_values.m_LevelHideTips =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LEVELHIDETIPS] as string);
_values.m_LevelRule =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LEVELRULE] as string);
_values.m_LevelScene =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LEVELSCENE] as string);
_values.m_LevelStage =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LEVELSTAGE] as string);
_values.m_LevelType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LEVELTYPE] as string);
_values.m_LocationId =  valuesList[(int)_ID.ID_LOCATIONID] as string;
_values.m_LocationName =  valuesList[(int)_ID.ID_LOCATIONNAME] as string;
_values.m_LockCard =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LOCKCARD] as string);
_values.m_LockCharacter =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LOCKCHARACTER] as string);
_values.m_LockFate =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LOCKFATE] as string);
_values.m_MinClueNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MINCLUENUM] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_Personality [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PERSONALITY_0] as string);
_values.m_Personality [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PERSONALITY_1] as string);
_values.m_Recommend [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_RECOMMEND_0] as string);
_values.m_Recommend [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_RECOMMEND_1] as string);
_values.m_Recommend [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_RECOMMEND_2] as string);
_values.m_Recommend [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_RECOMMEND_3] as string);
_values.m_Recommend [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_RECOMMEND_4] as string);
_values.m_Recommend [ 5 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_RECOMMEND_5] as string);
_values.m_ResId =  valuesList[(int)_ID.ID_RESID] as string;
_values.m_RumorSubId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_RUMORSUBID] as string);
_values.m_SavePointVersion =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SAVEPOINTVERSION] as string);
_values.m_Sex =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SEX] as string);
_values.m_SpecialClueNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SPECIALCLUENUM] as string);
_values.m_SpecialClues =  valuesList[(int)_ID.ID_SPECIALCLUES] as string;
_values.m_SptVal =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SPTVAL] as string);
_values.m_StoryChapterId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_STORYCHAPTERID] as string);
_values.m_StoryFile =  valuesList[(int)_ID.ID_STORYFILE] as string;
_values.m_StrVal =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_STRVAL] as string);
_values.m_Suggestion =  valuesList[(int)_ID.ID_SUGGESTION] as string;
_values.m_Weather =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_WEATHER] as string);
_values.m_WisVal =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_WISVAL] as string);

 return _values; }


}
}

