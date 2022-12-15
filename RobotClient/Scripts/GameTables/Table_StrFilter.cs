//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_StrFilter
{ private const string TAB_FILE_DATA = "Table/StrFilter.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_WORD=2,
ID_ISTYPE_0,
ID_ISTYPE_1,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Id;
 public int Id { get{ return m_Id;}}

public int getIsTypeCount() { return 2; } 
 private int[] m_IsType = new int[2];
 public int GetIsTypebyIndex(int idx) {
 if(idx>=0 && idx<2) {
 return m_IsType[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> IsTypes { get {
  
return Array.AsReadOnly(m_IsType);
}} 

private string m_Word;
 public string Word { get{ return m_Word;}}

public static bool LoadTable(Dictionary<int, List<Tab_StrFilter> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_StrFilter SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_StrFilter _values = new Tab_StrFilter();
 _values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_IsType [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISTYPE_0] as string);
_values.m_IsType [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISTYPE_1] as string);
_values.m_Word =  valuesList[(int)_ID.ID_WORD] as string;

 return _values; }


}
}

