//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_CityCopyFloorDesc
{ private const string TAB_FILE_DATA = "Table/CityCopyFloorDesc.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_OFFICIALDESC=2,
ID_TRUTHDESC,
ID_HOLDER,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Holder;
 public int Holder { get{ return m_Holder;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_OfficialDesc;
 public string OfficialDesc { get{ return m_OfficialDesc;}}

private string m_TruthDesc;
 public string TruthDesc { get{ return m_TruthDesc;}}

public static bool LoadTable(Dictionary<int, List<Tab_CityCopyFloorDesc> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_CityCopyFloorDesc SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_CityCopyFloorDesc _values = new Tab_CityCopyFloorDesc();
 _values.m_Holder =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HOLDER] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_OfficialDesc =  valuesList[(int)_ID.ID_OFFICIALDESC] as string;
_values.m_TruthDesc =  valuesList[(int)_ID.ID_TRUTHDESC] as string;

 return _values; }


}
}

