//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_VChatMsg
{ private const string TAB_FILE_DATA = "Table/VChatMsg.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_CHATID=2,
ID_TYPE,
ID_CHARACTERID,
ID_TITLE,
ID_CONTENT,
ID_VOICEID,
ID_EMOJI,
ID_SHOWTIME,
ID_OPTIONID,
ID_NEXTID,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_CharacterId;
 public int CharacterId { get{ return m_CharacterId;}}

private int m_ChatId;
 public int ChatId { get{ return m_ChatId;}}

private string m_Content;
 public string Content { get{ return m_Content;}}

private int m_Emoji;
 public int Emoji { get{ return m_Emoji;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_NextId;
 public int NextId { get{ return m_NextId;}}

private int m_OptionId;
 public int OptionId { get{ return m_OptionId;}}

private float m_ShowTime;
 public float ShowTime { get{ return m_ShowTime;}}

private string m_Title;
 public string Title { get{ return m_Title;}}

private int m_Type;
 public int Type { get{ return m_Type;}}

private int m_VoiceID;
 public int VoiceID { get{ return m_VoiceID;}}

public static bool LoadTable(Dictionary<int, List<Tab_VChatMsg> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_VChatMsg SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_VChatMsg _values = new Tab_VChatMsg();
 _values.m_CharacterId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHARACTERID] as string);
_values.m_ChatId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHATID] as string);
_values.m_Content =  valuesList[(int)_ID.ID_CONTENT] as string;
_values.m_Emoji =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_EMOJI] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_NextId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NEXTID] as string);
_values.m_OptionId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_OPTIONID] as string);
_values.m_ShowTime =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_SHOWTIME] as string );
_values.m_Title =  valuesList[(int)_ID.ID_TITLE] as string;
_values.m_Type =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TYPE] as string);
_values.m_VoiceID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_VOICEID] as string);

 return _values; }


}
}

