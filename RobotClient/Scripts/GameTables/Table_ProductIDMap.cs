//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_ProductIDMap
{ private const string TAB_FILE_DATA = "Table/ProductIDMap.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_PRODUCEIDGROUP0=2,
ID_PRODUCEIDGROUP1,
ID_PRODUCEIDGROUP2,
ID_PRODUCEIDGROUP3,
ID_PRODUCEIDGROUP4,
ID_PRODUCEIDGROUP5,
ID_PRODUCEIDGROUP6,
ID_PRODUCEIDGROUP7,
ID_PRODUCEIDGROUP8,
ID_PRODUCEIDGROUP9,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Id;
 public int Id { get{ return m_Id;}}

public int getProduceIdGroupCount() { return 10; } 
 private string[] m_ProduceIdGroup = new string[10];
 public string GetProduceIdGroupbyIndex(int idx) {
 if(idx>=0 && idx<10) {
 return m_ProduceIdGroup[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> ProduceIdGroups { get {
  
return Array.AsReadOnly(m_ProduceIdGroup);
}} 

public static bool LoadTable(Dictionary<int, List<Tab_ProductIDMap> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_ProductIDMap SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_ProductIDMap _values = new Tab_ProductIDMap();
 _values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_ProduceIdGroup [ 0 ] =  valuesList[(int)_ID.ID_PRODUCEIDGROUP0] as string;
_values.m_ProduceIdGroup [ 1 ] =  valuesList[(int)_ID.ID_PRODUCEIDGROUP1] as string;
_values.m_ProduceIdGroup [ 2 ] =  valuesList[(int)_ID.ID_PRODUCEIDGROUP2] as string;
_values.m_ProduceIdGroup [ 3 ] =  valuesList[(int)_ID.ID_PRODUCEIDGROUP3] as string;
_values.m_ProduceIdGroup [ 4 ] =  valuesList[(int)_ID.ID_PRODUCEIDGROUP4] as string;
_values.m_ProduceIdGroup [ 5 ] =  valuesList[(int)_ID.ID_PRODUCEIDGROUP5] as string;
_values.m_ProduceIdGroup [ 6 ] =  valuesList[(int)_ID.ID_PRODUCEIDGROUP6] as string;
_values.m_ProduceIdGroup [ 7 ] =  valuesList[(int)_ID.ID_PRODUCEIDGROUP7] as string;
_values.m_ProduceIdGroup [ 8 ] =  valuesList[(int)_ID.ID_PRODUCEIDGROUP8] as string;
_values.m_ProduceIdGroup [ 9 ] =  valuesList[(int)_ID.ID_PRODUCEIDGROUP9] as string;

 return _values; }


}
}

