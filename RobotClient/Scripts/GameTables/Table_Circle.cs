//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_Circle
{ private const string TAB_FILE_DATA = "Table/Circle.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_TYPE=2,
ID_WRITER,
ID_CONDITIONID,
ID_TITLE,
ID_IMAGE,
ID_IMAGEHEIGHT,
ID_CONTENT,
ID_PLAYERREPLYID,
ID_PLAYERREPLYIDCOMMENT,
ID_REPLYAWARD_0,
ID_REPLYAWARD_1,
ID_REPLYAWARD_2,
ID_ATCHARACTER_0,
ID_ATCHARACTER_1,
ID_ATCHARACTER_2,
ID_ATCHARACTER_3,
ID_ATCHARACTER_4,
ID_ATCHARACTER_5,
ID_PRIORITY,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

public int getAtCharacterCount() { return 6; } 
 private int[] m_AtCharacter = new int[6];
 public int GetAtCharacterbyIndex(int idx) {
 if(idx>=0 && idx<6) {
 return m_AtCharacter[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> AtCharacters { get {
  
return Array.AsReadOnly(m_AtCharacter);
}} 

private int m_ConditionId;
 public int ConditionId { get{ return m_ConditionId;}}

private string m_Content;
 public string Content { get{ return m_Content;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_Image;
 public string Image { get{ return m_Image;}}

private float m_ImageHeight;
 public float ImageHeight { get{ return m_ImageHeight;}}

private int m_PlayerReplyId;
 public int PlayerReplyId { get{ return m_PlayerReplyId;}}

private int m_PlayerReplyIdComment;
 public int PlayerReplyIdComment { get{ return m_PlayerReplyIdComment;}}

private int m_Priority;
 public int Priority { get{ return m_Priority;}}

public int getReplyAwardCount() { return 3; } 
 private int[] m_ReplyAward = new int[3];
 public int GetReplyAwardbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_ReplyAward[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> ReplyAwards { get {
  
return Array.AsReadOnly(m_ReplyAward);
}} 

private string m_Title;
 public string Title { get{ return m_Title;}}

private int m_Type;
 public int Type { get{ return m_Type;}}

private int m_Writer;
 public int Writer { get{ return m_Writer;}}

public static bool LoadTable(Dictionary<int, List<Tab_Circle> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_Circle SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_Circle _values = new Tab_Circle();
 _values.m_AtCharacter [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ATCHARACTER_0] as string);
_values.m_AtCharacter [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ATCHARACTER_1] as string);
_values.m_AtCharacter [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ATCHARACTER_2] as string);
_values.m_AtCharacter [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ATCHARACTER_3] as string);
_values.m_AtCharacter [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ATCHARACTER_4] as string);
_values.m_AtCharacter [ 5 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ATCHARACTER_5] as string);
_values.m_ConditionId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CONDITIONID] as string);
_values.m_Content =  valuesList[(int)_ID.ID_CONTENT] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Image =  valuesList[(int)_ID.ID_IMAGE] as string;
_values.m_ImageHeight =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_IMAGEHEIGHT] as string );
_values.m_PlayerReplyId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PLAYERREPLYID] as string);
_values.m_PlayerReplyIdComment =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PLAYERREPLYIDCOMMENT] as string);
_values.m_Priority =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PRIORITY] as string);
_values.m_ReplyAward [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REPLYAWARD_0] as string);
_values.m_ReplyAward [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REPLYAWARD_1] as string);
_values.m_ReplyAward [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REPLYAWARD_2] as string);
_values.m_Title =  valuesList[(int)_ID.ID_TITLE] as string;
_values.m_Type =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TYPE] as string);
_values.m_Writer =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_WRITER] as string);

 return _values; }


}
}

