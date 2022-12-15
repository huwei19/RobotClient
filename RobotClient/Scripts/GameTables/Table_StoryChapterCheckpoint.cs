//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_StoryChapterCheckpoint
{ private const string TAB_FILE_DATA = "Table/StoryChapterCheckpoint.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NAME=2,
ID_DESC,
ID_CHECKPOINTID_0,
ID_CHECKPOINTDESC_0,
ID_CHECKPOINTID_1,
ID_CHECKPOINTDESC_1,
ID_CHECKPOINTID_2,
ID_CHECKPOINTDESC_2,
ID_CHECKPOINTID_3,
ID_CHECKPOINTDESC_3,
ID_CHECKPOINTID_4,
ID_CHECKPOINTDESC_4,
ID_PLACEHOLDER,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

public int getCheckpointDescCount() { return 5; } 
 private string[] m_CheckpointDesc = new string[5];
 public string GetCheckpointDescbyIndex(int idx) {
 if(idx>=0 && idx<5) {
 return m_CheckpointDesc[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> CheckpointDescs { get {
  
return Array.AsReadOnly(m_CheckpointDesc);
}} 

public int getCheckpointIdCount() { return 5; } 
 private int[] m_CheckpointId = new int[5];
 public int GetCheckpointIdbyIndex(int idx) {
 if(idx>=0 && idx<5) {
 return m_CheckpointId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> CheckpointIds { get {
  
return Array.AsReadOnly(m_CheckpointId);
}} 

private string m_Desc;
 public string Desc { get{ return m_Desc;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private int m_PlaceHolder;
 public int PlaceHolder { get{ return m_PlaceHolder;}}

public static bool LoadTable(Dictionary<int, List<Tab_StoryChapterCheckpoint> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_StoryChapterCheckpoint SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_StoryChapterCheckpoint _values = new Tab_StoryChapterCheckpoint();
 _values.m_CheckpointDesc [ 0 ] =  valuesList[(int)_ID.ID_CHECKPOINTDESC_0] as string;
_values.m_CheckpointDesc [ 1 ] =  valuesList[(int)_ID.ID_CHECKPOINTDESC_1] as string;
_values.m_CheckpointDesc [ 2 ] =  valuesList[(int)_ID.ID_CHECKPOINTDESC_2] as string;
_values.m_CheckpointDesc [ 3 ] =  valuesList[(int)_ID.ID_CHECKPOINTDESC_3] as string;
_values.m_CheckpointDesc [ 4 ] =  valuesList[(int)_ID.ID_CHECKPOINTDESC_4] as string;
_values.m_CheckpointId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHECKPOINTID_0] as string);
_values.m_CheckpointId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHECKPOINTID_1] as string);
_values.m_CheckpointId [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHECKPOINTID_2] as string);
_values.m_CheckpointId [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHECKPOINTID_3] as string);
_values.m_CheckpointId [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHECKPOINTID_4] as string);
_values.m_Desc =  valuesList[(int)_ID.ID_DESC] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_PlaceHolder =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PLACEHOLDER] as string);

 return _values; }


}
}

