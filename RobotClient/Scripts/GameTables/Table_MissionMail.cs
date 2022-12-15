//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_MissionMail
{ private const string TAB_FILE_DATA = "Table/MissionMail.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_MAILCONTENT=2,
ID_REPLAY_0,
ID_REPLAY_1,
ID_REPLAY_2,
ID_RECEIPT_0,
ID_RECEIPT_1,
ID_RECEIPT_2,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_MailContent;
 public string MailContent { get{ return m_MailContent;}}

public int getReceiptCount() { return 3; } 
 private string[] m_Receipt = new string[3];
 public string GetReceiptbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_Receipt[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> Receipts { get {
  
return Array.AsReadOnly(m_Receipt);
}} 

public int getReplayCount() { return 3; } 
 private string[] m_Replay = new string[3];
 public string GetReplaybyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_Replay[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> Replays { get {
  
return Array.AsReadOnly(m_Replay);
}} 

public static bool LoadTable(Dictionary<int, List<Tab_MissionMail> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_MissionMail SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_MissionMail _values = new Tab_MissionMail();
 _values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_MailContent =  valuesList[(int)_ID.ID_MAILCONTENT] as string;
_values.m_Receipt [ 0 ] =  valuesList[(int)_ID.ID_RECEIPT_0] as string;
_values.m_Receipt [ 1 ] =  valuesList[(int)_ID.ID_RECEIPT_1] as string;
_values.m_Receipt [ 2 ] =  valuesList[(int)_ID.ID_RECEIPT_2] as string;
_values.m_Replay [ 0 ] =  valuesList[(int)_ID.ID_REPLAY_0] as string;
_values.m_Replay [ 1 ] =  valuesList[(int)_ID.ID_REPLAY_1] as string;
_values.m_Replay [ 2 ] =  valuesList[(int)_ID.ID_REPLAY_2] as string;

 return _values; }


}
}

