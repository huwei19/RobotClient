//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_ShopType
{ private const string TAB_FILE_DATA = "Table/ShopType.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_INDEX=2,
ID_NAME,
ID_SUBTYPE_0,
ID_SUBTYPE_1,
ID_SUBTYPE_2,
ID_SUBTYPE_3,
ID_SUBTYPE_4,
ID_SUBTYPE_5,
ID_SUBTYPE_6,
ID_SUBTYPE_7,
ID_SUBCOUNT,
ID_RECHARGEPANEL,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_Index;
 public int Index { get{ return m_Index;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private int m_RechargePanel;
 public int RechargePanel { get{ return m_RechargePanel;}}

private int m_SubCount;
 public int SubCount { get{ return m_SubCount;}}

public int getSubTypeCount() { return 8; } 
 private string[] m_SubType = new string[8];
 public string GetSubTypebyIndex(int idx) {
 if(idx>=0 && idx<8) {
 return m_SubType[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> SubTypes { get {
  
return Array.AsReadOnly(m_SubType);
}} 

public static bool LoadTable(Dictionary<int, List<Tab_ShopType> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_ShopType SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_ShopType _values = new Tab_ShopType();
 _values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Index =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_INDEX] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_RechargePanel =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_RECHARGEPANEL] as string);
_values.m_SubCount =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SUBCOUNT] as string);
_values.m_SubType [ 0 ] =  valuesList[(int)_ID.ID_SUBTYPE_0] as string;
_values.m_SubType [ 1 ] =  valuesList[(int)_ID.ID_SUBTYPE_1] as string;
_values.m_SubType [ 2 ] =  valuesList[(int)_ID.ID_SUBTYPE_2] as string;
_values.m_SubType [ 3 ] =  valuesList[(int)_ID.ID_SUBTYPE_3] as string;
_values.m_SubType [ 4 ] =  valuesList[(int)_ID.ID_SUBTYPE_4] as string;
_values.m_SubType [ 5 ] =  valuesList[(int)_ID.ID_SUBTYPE_5] as string;
_values.m_SubType [ 6 ] =  valuesList[(int)_ID.ID_SUBTYPE_6] as string;
_values.m_SubType [ 7 ] =  valuesList[(int)_ID.ID_SUBTYPE_7] as string;

 return _values; }


}
}

