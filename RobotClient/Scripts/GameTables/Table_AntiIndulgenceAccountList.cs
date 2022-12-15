//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_AntiIndulgenceAccountList
{ private const string TAB_FILE_DATA = "table/AntiIndulgenceAccountList.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_ACCOUNT=2,
ID_TOKEN,
ID_AUTHORITYID,
ID_RESOURCETYPE,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private string m_Account;
 public string Account { get{ return m_Account;}}

private int m_AuthorityId;
 public int AuthorityId { get{ return m_AuthorityId;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_ResourceType;
 public int ResourceType { get{ return m_ResourceType;}}

private string m_Token;
 public string Token { get{ return m_Token;}}

public static bool LoadTable(Dictionary<int, List<Tab_AntiIndulgenceAccountList> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_AntiIndulgenceAccountList SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_AntiIndulgenceAccountList _values = new Tab_AntiIndulgenceAccountList();
 _values.m_Account =  valuesList[(int)_ID.ID_ACCOUNT] as string;
_values.m_AuthorityId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AUTHORITYID] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_ResourceType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_RESOURCETYPE] as string);
_values.m_Token =  valuesList[(int)_ID.ID_TOKEN] as string;

 return _values; }


}
}

