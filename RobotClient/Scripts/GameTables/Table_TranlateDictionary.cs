//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_TranlateDictionary
{ private const string TAB_FILE_DATA = "Table/TranlateDictionary.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_STRDICTIONARY=2,
MAX_RECORD
 }
 public static string GetInstanceFile(){return LocalizationManager.GetInstance().GetTabFileDataByTranlateDictionary(); }

private long m_Id;
 public long Id { get{ return m_Id;}}

private string m_StrDictionary;
 public string StrDictionary { get{ return m_StrDictionary;}}

public static bool LoadTable(Dictionary<long, List<Tab_TranlateDictionary> > _tab)
 {
 if(!TableManager.ReaderPListLong(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_TranlateDictionary SerializableTable(string[] valuesList,long skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_TranlateDictionary _values = new Tab_TranlateDictionary();
 _values.m_Id =  TableManager.ConvertToInt64(valuesList[(int)_ID.ID_ID] as string);
_values.m_StrDictionary =  valuesList[(int)_ID.ID_STRDICTIONARY] as string;

 return _values; }


}
}

