//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_Retrieval
{ private const string TAB_FILE_DATA = "Table/Retrieval.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_TYPEID=2,
ID_CLUEID,
ID_CONTENTNAME,
ID_ENTRYNAME,
ID_RETRIEVALINFO,
ID_ACTIONID,
ID_SOUND,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_ActionID;
 public int ActionID { get{ return m_ActionID;}}

private int m_ClueId;
 public int ClueId { get{ return m_ClueId;}}

private string m_ContentName;
 public string ContentName { get{ return m_ContentName;}}

private string m_EntryName;
 public string EntryName { get{ return m_EntryName;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_RetrievalInfo;
 public string RetrievalInfo { get{ return m_RetrievalInfo;}}

private int m_Sound;
 public int Sound { get{ return m_Sound;}}

private int m_TypeId;
 public int TypeId { get{ return m_TypeId;}}

public static bool LoadTable(Dictionary<int, List<Tab_Retrieval> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_Retrieval SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_Retrieval _values = new Tab_Retrieval();
 _values.m_ActionID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIONID] as string);
_values.m_ClueId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CLUEID] as string);
_values.m_ContentName =  valuesList[(int)_ID.ID_CONTENTNAME] as string;
_values.m_EntryName =  valuesList[(int)_ID.ID_ENTRYNAME] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_RetrievalInfo =  valuesList[(int)_ID.ID_RETRIEVALINFO] as string;
_values.m_Sound =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SOUND] as string);
_values.m_TypeId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TYPEID] as string);

 return _values; }


}
}

