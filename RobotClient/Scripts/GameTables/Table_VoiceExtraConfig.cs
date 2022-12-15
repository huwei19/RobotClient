//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_VoiceExtraConfig
{ private const string TAB_FILE_DATA = "Table/VoiceExtraConfig.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_TYPE=2,
ID_CLASS,
ID_NAME,
ID_TEXT,
ID_VOICEID,
ID_LINEID,
ID_CHAPTERID,
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
ID_ISENABLE,
ID_ISBASE,
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

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_IsBase;
 public int IsBase { get{ return m_IsBase;}}

private int m_IsBuiltIn;
 public int IsBuiltIn { get{ return m_IsBuiltIn;}}

private int m_IsEnable;
 public int IsEnable { get{ return m_IsEnable;}}

private int m_LineId;
 public int LineId { get{ return m_LineId;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private string m_Text;
 public string Text { get{ return m_Text;}}

private int m_Type;
 public int Type { get{ return m_Type;}}

private int m_VoiceId;
 public int VoiceId { get{ return m_VoiceId;}}

public static bool LoadTable(Dictionary<int, List<Tab_VoiceExtraConfig> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_VoiceExtraConfig SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_VoiceExtraConfig _values = new Tab_VoiceExtraConfig();
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
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_IsBase =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISBASE] as string);
_values.m_IsBuiltIn =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISBUILTIN] as string);
_values.m_IsEnable =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISENABLE] as string);
_values.m_LineId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LINEID] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_Text =  valuesList[(int)_ID.ID_TEXT] as string;
_values.m_Type =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TYPE] as string);
_values.m_VoiceId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_VOICEID] as string);

 return _values; }


}
}

