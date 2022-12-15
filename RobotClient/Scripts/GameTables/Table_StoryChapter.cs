//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_StoryChapter
{ private const string TAB_FILE_DATA = "Table/StoryChapter.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_RESID=2,
ID_SOUNDNAME,
ID_STORYLINEID,
ID_SHOWID,
ID_NAME,
ID_FUNCNAME,
ID_STARTTIME,
ID_SNAPSHOT,
ID_MAPRES,
ID_OPENNINGDIALOGID,
ID_MAINPLOTID,
ID_STARTLEVEL_0,
ID_STARTLEVEL_1,
ID_ENDING_0,
ID_ENDING_1,
ID_ENDING_2,
ID_ENDING_3,
ID_ENDING_4,
ID_CHECKPOINT_0,
ID_CHECKPOINT_1,
ID_CHECKPOINT_2,
ID_CHECKPOINT_3,
ID_NPC_0,
ID_NPC_1,
ID_NPC_2,
ID_NPC_3,
ID_NPC_4,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

public int getCheckpointCount() { return 4; } 
 private int[] m_Checkpoint = new int[4];
 public int GetCheckpointbyIndex(int idx) {
 if(idx>=0 && idx<4) {
 return m_Checkpoint[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> Checkpoints { get {
  
return Array.AsReadOnly(m_Checkpoint);
}} 

public int getEndingCount() { return 5; } 
 private int[] m_Ending = new int[5];
 public int GetEndingbyIndex(int idx) {
 if(idx>=0 && idx<5) {
 return m_Ending[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> Endings { get {
  
return Array.AsReadOnly(m_Ending);
}} 

private string m_FuncName;
 public string FuncName { get{ return m_FuncName;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_MainPlotId;
 public int MainPlotId { get{ return m_MainPlotId;}}

private string m_MapRes;
 public string MapRes { get{ return m_MapRes;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

public int getNpcCount() { return 5; } 
 private int[] m_Npc = new int[5];
 public int GetNpcbyIndex(int idx) {
 if(idx>=0 && idx<5) {
 return m_Npc[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> Npcs { get {
  
return Array.AsReadOnly(m_Npc);
}} 

private int m_OpenningDialogId;
 public int OpenningDialogId { get{ return m_OpenningDialogId;}}

private string m_ResId;
 public string ResId { get{ return m_ResId;}}

private int m_ShowId;
 public int ShowId { get{ return m_ShowId;}}

private string m_Snapshot;
 public string Snapshot { get{ return m_Snapshot;}}

private string m_SoundName;
 public string SoundName { get{ return m_SoundName;}}

public int getStartLevelCount() { return 2; } 
 private int[] m_StartLevel = new int[2];
 public int GetStartLevelbyIndex(int idx) {
 if(idx>=0 && idx<2) {
 return m_StartLevel[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> StartLevels { get {
  
return Array.AsReadOnly(m_StartLevel);
}} 

private string m_StartTime;
 public string StartTime { get{ return m_StartTime;}}

private int m_StoryLineId;
 public int StoryLineId { get{ return m_StoryLineId;}}

public static bool LoadTable(Dictionary<int, List<Tab_StoryChapter> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_StoryChapter SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_StoryChapter _values = new Tab_StoryChapter();
 _values.m_Checkpoint [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHECKPOINT_0] as string);
_values.m_Checkpoint [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHECKPOINT_1] as string);
_values.m_Checkpoint [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHECKPOINT_2] as string);
_values.m_Checkpoint [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHECKPOINT_3] as string);
_values.m_Ending [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ENDING_0] as string);
_values.m_Ending [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ENDING_1] as string);
_values.m_Ending [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ENDING_2] as string);
_values.m_Ending [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ENDING_3] as string);
_values.m_Ending [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ENDING_4] as string);
_values.m_FuncName =  valuesList[(int)_ID.ID_FUNCNAME] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_MainPlotId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MAINPLOTID] as string);
_values.m_MapRes =  valuesList[(int)_ID.ID_MAPRES] as string;
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_Npc [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NPC_0] as string);
_values.m_Npc [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NPC_1] as string);
_values.m_Npc [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NPC_2] as string);
_values.m_Npc [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NPC_3] as string);
_values.m_Npc [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NPC_4] as string);
_values.m_OpenningDialogId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_OPENNINGDIALOGID] as string);
_values.m_ResId =  valuesList[(int)_ID.ID_RESID] as string;
_values.m_ShowId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SHOWID] as string);
_values.m_Snapshot =  valuesList[(int)_ID.ID_SNAPSHOT] as string;
_values.m_SoundName =  valuesList[(int)_ID.ID_SOUNDNAME] as string;
_values.m_StartLevel [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_STARTLEVEL_0] as string);
_values.m_StartLevel [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_STARTLEVEL_1] as string);
_values.m_StartTime =  valuesList[(int)_ID.ID_STARTTIME] as string;
_values.m_StoryLineId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_STORYLINEID] as string);

 return _values; }


}
}

