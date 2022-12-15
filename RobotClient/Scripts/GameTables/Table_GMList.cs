//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_GMList
{ private const string TAB_FILE_DATA = "table/GMList.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_ACCOUNT=2,
ID_PARAM1,
ID_PARAM2,
ID_PARAM3,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private string m_Account;
 public string Account { get{ return m_Account;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

public int getParamCount() { return 3; } 
 private int[] m_Param = new int[3];
 public int GetParambyIndex(int idx) {
 if(idx>=0 && idx<3) return m_Param[idx];
 return -1;
 }
 public ReadOnlyCollection <int> Params { get { return Array.AsReadOnly(m_Param);}} 

public static bool LoadTable(Dictionary<int, List<Tab_GMList> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_GMList SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_GMList _values = new Tab_GMList();
 _values.m_Account =  valuesList[(int)_ID.ID_ACCOUNT] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Param [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PARAM1] as string);
_values.m_Param [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PARAM2] as string);
_values.m_Param [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PARAM3] as string);

 return _values; }


}
}

