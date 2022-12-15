//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_ExtraConfig
{ private const string TAB_FILE_DATA = "Table/ExtraConfig.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_TYPE=2,
ID_CLASS,
ID_NAME,
ID_TEXT,
ID_LINEID,
ID_CHAPTERID,
ID_DIR_0,
ID_DIR_1,
ID_DIR_2,
ID_DIR_3,
ID_DIR_4,
ID_DIR_5,
ID_DIR_6,
ID_DIR_7,
ID_DIR_8,
ID_DIR_9,
ID_DIR_10,
ID_DIR_11,
ID_DIR_12,
ID_DIR_13,
ID_DIR_14,
ID_DIR_15,
ID_DIR_16,
ID_DIR_17,
ID_DIR_18,
ID_DIR_19,
ID_DIR_20,
ID_AUDIO_0,
ID_AUDIO_1,
ID_AUDIO_2,
ID_AUDIO_3,
ID_AUDIO_4,
ID_AUDIO_5,
ID_AUDIO_6,
ID_AUDIO_7,
ID_AUDIO_8,
ID_AUDIO_9,
ID_AUDIO_10,
ID_AUDIO_11,
ID_AUDIO_12,
ID_ISBUILTIN,
ID_PRIORITY,
ID_ISLAUNCHDOWNLOAD,
ID_ISENABLE,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

public int getAudioCount() { return 13; } 
 private string[] m_Audio = new string[13];
 public string GetAudiobyIndex(int idx) {
 if(idx>=0 && idx<13) {
 return m_Audio[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> Audios { get {
  
return Array.AsReadOnly(m_Audio);
}} 

private int m_ChapterId;
 public int ChapterId { get{ return m_ChapterId;}}

private int m_Class;
 public int Class { get{ return m_Class;}}

public int getDirCount() { return 21; } 
 private string[] m_Dir = new string[21];
 public string GetDirbyIndex(int idx) {
 if(idx>=0 && idx<21) {
 return m_Dir[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> Dirs { get {
  
return Array.AsReadOnly(m_Dir);
}} 

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_IsBuiltIn;
 public int IsBuiltIn { get{ return m_IsBuiltIn;}}

private int m_IsEnable;
 public int IsEnable { get{ return m_IsEnable;}}

private int m_IsLaunchDownload;
 public int IsLaunchDownload { get{ return m_IsLaunchDownload;}}

private int m_LineId;
 public int LineId { get{ return m_LineId;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private int m_Priority;
 public int Priority { get{ return m_Priority;}}

private string m_Text;
 public string Text { get{ return m_Text;}}

private int m_Type;
 public int Type { get{ return m_Type;}}

public static bool LoadTable(Dictionary<int, List<Tab_ExtraConfig> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_ExtraConfig SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_ExtraConfig _values = new Tab_ExtraConfig();
 _values.m_Audio [ 0 ] =  valuesList[(int)_ID.ID_AUDIO_0] as string;
_values.m_Audio [ 1 ] =  valuesList[(int)_ID.ID_AUDIO_1] as string;
_values.m_Audio [ 2 ] =  valuesList[(int)_ID.ID_AUDIO_2] as string;
_values.m_Audio [ 3 ] =  valuesList[(int)_ID.ID_AUDIO_3] as string;
_values.m_Audio [ 4 ] =  valuesList[(int)_ID.ID_AUDIO_4] as string;
_values.m_Audio [ 5 ] =  valuesList[(int)_ID.ID_AUDIO_5] as string;
_values.m_Audio [ 6 ] =  valuesList[(int)_ID.ID_AUDIO_6] as string;
_values.m_Audio [ 7 ] =  valuesList[(int)_ID.ID_AUDIO_7] as string;
_values.m_Audio [ 8 ] =  valuesList[(int)_ID.ID_AUDIO_8] as string;
_values.m_Audio [ 9 ] =  valuesList[(int)_ID.ID_AUDIO_9] as string;
_values.m_Audio [ 10 ] =  valuesList[(int)_ID.ID_AUDIO_10] as string;
_values.m_Audio [ 11 ] =  valuesList[(int)_ID.ID_AUDIO_11] as string;
_values.m_Audio [ 12 ] =  valuesList[(int)_ID.ID_AUDIO_12] as string;
_values.m_ChapterId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHAPTERID] as string);
_values.m_Class =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CLASS] as string);
_values.m_Dir [ 0 ] =  valuesList[(int)_ID.ID_DIR_0] as string;
_values.m_Dir [ 1 ] =  valuesList[(int)_ID.ID_DIR_1] as string;
_values.m_Dir [ 2 ] =  valuesList[(int)_ID.ID_DIR_2] as string;
_values.m_Dir [ 3 ] =  valuesList[(int)_ID.ID_DIR_3] as string;
_values.m_Dir [ 4 ] =  valuesList[(int)_ID.ID_DIR_4] as string;
_values.m_Dir [ 5 ] =  valuesList[(int)_ID.ID_DIR_5] as string;
_values.m_Dir [ 6 ] =  valuesList[(int)_ID.ID_DIR_6] as string;
_values.m_Dir [ 7 ] =  valuesList[(int)_ID.ID_DIR_7] as string;
_values.m_Dir [ 8 ] =  valuesList[(int)_ID.ID_DIR_8] as string;
_values.m_Dir [ 9 ] =  valuesList[(int)_ID.ID_DIR_9] as string;
_values.m_Dir [ 10 ] =  valuesList[(int)_ID.ID_DIR_10] as string;
_values.m_Dir [ 11 ] =  valuesList[(int)_ID.ID_DIR_11] as string;
_values.m_Dir [ 12 ] =  valuesList[(int)_ID.ID_DIR_12] as string;
_values.m_Dir [ 13 ] =  valuesList[(int)_ID.ID_DIR_13] as string;
_values.m_Dir [ 14 ] =  valuesList[(int)_ID.ID_DIR_14] as string;
_values.m_Dir [ 15 ] =  valuesList[(int)_ID.ID_DIR_15] as string;
_values.m_Dir [ 16 ] =  valuesList[(int)_ID.ID_DIR_16] as string;
_values.m_Dir [ 17 ] =  valuesList[(int)_ID.ID_DIR_17] as string;
_values.m_Dir [ 18 ] =  valuesList[(int)_ID.ID_DIR_18] as string;
_values.m_Dir [ 19 ] =  valuesList[(int)_ID.ID_DIR_19] as string;
_values.m_Dir [ 20 ] =  valuesList[(int)_ID.ID_DIR_20] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_IsBuiltIn =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISBUILTIN] as string);
_values.m_IsEnable =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISENABLE] as string);
_values.m_IsLaunchDownload =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISLAUNCHDOWNLOAD] as string);
_values.m_LineId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LINEID] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_Priority =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PRIORITY] as string);
_values.m_Text =  valuesList[(int)_ID.ID_TEXT] as string;
_values.m_Type =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TYPE] as string);

 return _values; }


}
}

