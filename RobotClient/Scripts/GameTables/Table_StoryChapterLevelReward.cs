//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_StoryChapterLevelReward
{ private const string TAB_FILE_DATA = "Table/StoryChapterLevelReward.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_LEVELSUCCDROPID=2,
ID_LEVELSUCCDROPPREVIEWID,
ID_RELEVELSUCCDROPID,
ID_RELEVELSUCCDROPPREVIEWID,
ID_CUSTOMONETIMEDROPID_0,
ID_CUSTOMONETIMEDROPPREVIEWID_0,
ID_CUSTOMONETIMEDROPID_1,
ID_CUSTOMONETIMEDROPPREVIEWID_1,
ID_CUSTOMONETIMEDROPID_2,
ID_CUSTOMONETIMEDROPPREVIEWID_2,
ID_CUSTOMONETIMEDROPID_3,
ID_CUSTOMONETIMEDROPPREVIEWID_3,
ID_CUSTOMONETIMEDROPID_4,
ID_CUSTOMONETIMEDROPPREVIEWID_4,
ID_COMPLETEPERCENT_0,
ID_COMPLETEDROPID_0,
ID_COMPLETEDROPPREVIEWID_0,
ID_COMPLETEPERCENT_1,
ID_COMPLETEDROPID_1,
ID_COMPLETEDROPPREVIEWID_1,
ID_COMPLETEPERCENT_2,
ID_COMPLETEDROPID_2,
ID_COMPLETEDROPPREVIEWID_2,
ID_COMPLETEPERCENT_3,
ID_COMPLETEDROPID_3,
ID_COMPLETEDROPPREVIEWID_3,
ID_COMPLETEPERCENT_4,
ID_COMPLETEDROPID_4,
ID_COMPLETEDROPPREVIEWID_4,
ID_SCENEEVENTHUGESUCCDROPID,
ID_SCENEEVENTHUGESUCCDROPPREVIEWID,
ID_SCENEEVENTHUGESUCCDROPLIMIT,
ID_PUZZLEFIRSTSUCCDROPID,
ID_PUZZLEFIRSTSUCCDROPPREVIEWID,
ID_PUZZLEFIRSTPERFECTDROPID,
ID_PUZZLEFIRSTPERFECTDROPPREVIEWID,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

public int getCompleteDropIdCount() { return 5; } 
 private int[] m_CompleteDropId = new int[5];
 public int GetCompleteDropIdbyIndex(int idx) {
 if(idx>=0 && idx<5) {
 return m_CompleteDropId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> CompleteDropIds { get {
  
return Array.AsReadOnly(m_CompleteDropId);
}} 

public int getCompleteDropPreviewIdCount() { return 5; } 
 private int[] m_CompleteDropPreviewId = new int[5];
 public int GetCompleteDropPreviewIdbyIndex(int idx) {
 if(idx>=0 && idx<5) {
 return m_CompleteDropPreviewId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> CompleteDropPreviewIds { get {
  
return Array.AsReadOnly(m_CompleteDropPreviewId);
}} 

public int getCompletePercentCount() { return 5; } 
 private int[] m_CompletePercent = new int[5];
 public int GetCompletePercentbyIndex(int idx) {
 if(idx>=0 && idx<5) {
 return m_CompletePercent[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> CompletePercents { get {
  
return Array.AsReadOnly(m_CompletePercent);
}} 

public int getCustomOneTimeDropIdCount() { return 5; } 
 private int[] m_CustomOneTimeDropId = new int[5];
 public int GetCustomOneTimeDropIdbyIndex(int idx) {
 if(idx>=0 && idx<5) {
 return m_CustomOneTimeDropId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> CustomOneTimeDropIds { get {
  
return Array.AsReadOnly(m_CustomOneTimeDropId);
}} 

public int getCustomOneTimeDropPreviewIdCount() { return 5; } 
 private int[] m_CustomOneTimeDropPreviewId = new int[5];
 public int GetCustomOneTimeDropPreviewIdbyIndex(int idx) {
 if(idx>=0 && idx<5) {
 return m_CustomOneTimeDropPreviewId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> CustomOneTimeDropPreviewIds { get {
  
return Array.AsReadOnly(m_CustomOneTimeDropPreviewId);
}} 

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_LevelSuccDropId;
 public int LevelSuccDropId { get{ return m_LevelSuccDropId;}}

private int m_LevelSuccDropPreviewId;
 public int LevelSuccDropPreviewId { get{ return m_LevelSuccDropPreviewId;}}

private int m_PuzzleFirstPerfectDropId;
 public int PuzzleFirstPerfectDropId { get{ return m_PuzzleFirstPerfectDropId;}}

private int m_PuzzleFirstPerfectDropPreviewId;
 public int PuzzleFirstPerfectDropPreviewId { get{ return m_PuzzleFirstPerfectDropPreviewId;}}

private int m_PuzzleFirstSuccDropId;
 public int PuzzleFirstSuccDropId { get{ return m_PuzzleFirstSuccDropId;}}

private int m_PuzzleFirstSuccDropPreviewId;
 public int PuzzleFirstSuccDropPreviewId { get{ return m_PuzzleFirstSuccDropPreviewId;}}

private int m_ReLevelSuccDropId;
 public int ReLevelSuccDropId { get{ return m_ReLevelSuccDropId;}}

private int m_ReLevelSuccDropPreviewId;
 public int ReLevelSuccDropPreviewId { get{ return m_ReLevelSuccDropPreviewId;}}

private int m_SceneEventHugeSuccDropId;
 public int SceneEventHugeSuccDropId { get{ return m_SceneEventHugeSuccDropId;}}

private int m_SceneEventHugeSuccDropLimit;
 public int SceneEventHugeSuccDropLimit { get{ return m_SceneEventHugeSuccDropLimit;}}

private int m_SceneEventHugeSuccDropPreviewId;
 public int SceneEventHugeSuccDropPreviewId { get{ return m_SceneEventHugeSuccDropPreviewId;}}

public static bool LoadTable(Dictionary<int, List<Tab_StoryChapterLevelReward> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_StoryChapterLevelReward SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_StoryChapterLevelReward _values = new Tab_StoryChapterLevelReward();
 _values.m_CompleteDropId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_COMPLETEDROPID_0] as string);
_values.m_CompleteDropId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_COMPLETEDROPID_1] as string);
_values.m_CompleteDropId [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_COMPLETEDROPID_2] as string);
_values.m_CompleteDropId [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_COMPLETEDROPID_3] as string);
_values.m_CompleteDropId [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_COMPLETEDROPID_4] as string);
_values.m_CompleteDropPreviewId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_COMPLETEDROPPREVIEWID_0] as string);
_values.m_CompleteDropPreviewId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_COMPLETEDROPPREVIEWID_1] as string);
_values.m_CompleteDropPreviewId [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_COMPLETEDROPPREVIEWID_2] as string);
_values.m_CompleteDropPreviewId [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_COMPLETEDROPPREVIEWID_3] as string);
_values.m_CompleteDropPreviewId [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_COMPLETEDROPPREVIEWID_4] as string);
_values.m_CompletePercent [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_COMPLETEPERCENT_0] as string);
_values.m_CompletePercent [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_COMPLETEPERCENT_1] as string);
_values.m_CompletePercent [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_COMPLETEPERCENT_2] as string);
_values.m_CompletePercent [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_COMPLETEPERCENT_3] as string);
_values.m_CompletePercent [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_COMPLETEPERCENT_4] as string);
_values.m_CustomOneTimeDropId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CUSTOMONETIMEDROPID_0] as string);
_values.m_CustomOneTimeDropId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CUSTOMONETIMEDROPID_1] as string);
_values.m_CustomOneTimeDropId [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CUSTOMONETIMEDROPID_2] as string);
_values.m_CustomOneTimeDropId [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CUSTOMONETIMEDROPID_3] as string);
_values.m_CustomOneTimeDropId [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CUSTOMONETIMEDROPID_4] as string);
_values.m_CustomOneTimeDropPreviewId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CUSTOMONETIMEDROPPREVIEWID_0] as string);
_values.m_CustomOneTimeDropPreviewId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CUSTOMONETIMEDROPPREVIEWID_1] as string);
_values.m_CustomOneTimeDropPreviewId [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CUSTOMONETIMEDROPPREVIEWID_2] as string);
_values.m_CustomOneTimeDropPreviewId [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CUSTOMONETIMEDROPPREVIEWID_3] as string);
_values.m_CustomOneTimeDropPreviewId [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CUSTOMONETIMEDROPPREVIEWID_4] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_LevelSuccDropId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LEVELSUCCDROPID] as string);
_values.m_LevelSuccDropPreviewId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LEVELSUCCDROPPREVIEWID] as string);
_values.m_PuzzleFirstPerfectDropId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PUZZLEFIRSTPERFECTDROPID] as string);
_values.m_PuzzleFirstPerfectDropPreviewId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PUZZLEFIRSTPERFECTDROPPREVIEWID] as string);
_values.m_PuzzleFirstSuccDropId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PUZZLEFIRSTSUCCDROPID] as string);
_values.m_PuzzleFirstSuccDropPreviewId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PUZZLEFIRSTSUCCDROPPREVIEWID] as string);
_values.m_ReLevelSuccDropId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_RELEVELSUCCDROPID] as string);
_values.m_ReLevelSuccDropPreviewId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_RELEVELSUCCDROPPREVIEWID] as string);
_values.m_SceneEventHugeSuccDropId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SCENEEVENTHUGESUCCDROPID] as string);
_values.m_SceneEventHugeSuccDropLimit =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SCENEEVENTHUGESUCCDROPLIMIT] as string);
_values.m_SceneEventHugeSuccDropPreviewId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SCENEEVENTHUGESUCCDROPPREVIEWID] as string);

 return _values; }


}
}

