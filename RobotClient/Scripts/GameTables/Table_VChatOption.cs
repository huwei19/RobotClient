//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_VChatOption
{ private const string TAB_FILE_DATA = "Table/VChatOption.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_CHATID=2,
ID_INTIMACY_0,
ID_INTIMACY_1,
ID_INTIMACY_2,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_ChatId;
 public int ChatId { get{ return m_ChatId;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

public int getIntimacyCount() { return 3; } 
 private int[] m_Intimacy = new int[3];
 public int GetIntimacybyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_Intimacy[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> Intimacys { get {
  
return Array.AsReadOnly(m_Intimacy);
}} 

public static bool LoadTable(Dictionary<int, List<Tab_VChatOption> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_VChatOption SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_VChatOption _values = new Tab_VChatOption();
 _values.m_ChatId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHATID] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Intimacy [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_INTIMACY_0] as string);
_values.m_Intimacy [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_INTIMACY_1] as string);
_values.m_Intimacy [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_INTIMACY_2] as string);

 return _values; }


}
}

