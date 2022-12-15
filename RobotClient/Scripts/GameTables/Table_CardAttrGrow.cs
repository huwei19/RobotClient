//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_CardAttrGrow
{ private const string TAB_FILE_DATA = "Table/CardAttrGrow.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_LCK=2,
ID_SPT,
ID_WIS,
ID_STR,
ID_CBT,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Cbt;
 public int Cbt { get{ return m_Cbt;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_Lck;
 public int Lck { get{ return m_Lck;}}

private int m_Spt;
 public int Spt { get{ return m_Spt;}}

private int m_Str;
 public int Str { get{ return m_Str;}}

private int m_Wis;
 public int Wis { get{ return m_Wis;}}

public static bool LoadTable(Dictionary<int, List<Tab_CardAttrGrow> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_CardAttrGrow SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_CardAttrGrow _values = new Tab_CardAttrGrow();
 _values.m_Cbt =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CBT] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Lck =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LCK] as string);
_values.m_Spt =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SPT] as string);
_values.m_Str =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_STR] as string);
_values.m_Wis =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_WIS] as string);

 return _values; }


}
}

