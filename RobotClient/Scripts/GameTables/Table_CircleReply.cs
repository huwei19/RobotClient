//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_CircleReply
{ private const string TAB_FILE_DATA = "Table/CircleReply.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_CIRCLEID=2,
ID_WRITER,
ID_ISNEEDAT,
ID_ISNEEDPLAYERREPLAY,
ID_REPLYTO,
ID_CONTENT_0,
ID_CONTENT_1,
ID_CONTENT_2,
ID_PRIORITY,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_CircleId;
 public int CircleId { get{ return m_CircleId;}}

public int getContentCount() { return 3; } 
 private string[] m_Content = new string[3];
 public string GetContentbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_Content[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> Contents { get {
  
return Array.AsReadOnly(m_Content);
}} 

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_IsNeedAt;
 public int IsNeedAt { get{ return m_IsNeedAt;}}

private int m_IsNeedPlayerReplay;
 public int IsNeedPlayerReplay { get{ return m_IsNeedPlayerReplay;}}

private int m_Priority;
 public int Priority { get{ return m_Priority;}}

private int m_ReplyTo;
 public int ReplyTo { get{ return m_ReplyTo;}}

private int m_Writer;
 public int Writer { get{ return m_Writer;}}

public static bool LoadTable(Dictionary<int, List<Tab_CircleReply> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_CircleReply SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_CircleReply _values = new Tab_CircleReply();
 _values.m_CircleId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CIRCLEID] as string);
_values.m_Content [ 0 ] =  valuesList[(int)_ID.ID_CONTENT_0] as string;
_values.m_Content [ 1 ] =  valuesList[(int)_ID.ID_CONTENT_1] as string;
_values.m_Content [ 2 ] =  valuesList[(int)_ID.ID_CONTENT_2] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_IsNeedAt =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISNEEDAT] as string);
_values.m_IsNeedPlayerReplay =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISNEEDPLAYERREPLAY] as string);
_values.m_Priority =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PRIORITY] as string);
_values.m_ReplyTo =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REPLYTO] as string);
_values.m_Writer =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_WRITER] as string);

 return _values; }


}
}

