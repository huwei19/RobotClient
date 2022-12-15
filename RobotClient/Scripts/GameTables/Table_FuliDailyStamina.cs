//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_FuliDailyStamina
{ private const string TAB_FILE_DATA = "Table/FuliDailyStamina.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_BEGIN=2,
ID_END,
ID_STAMINA,
ID_OVERTIMECOST,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Begin;
 public int Begin { get{ return m_Begin;}}

private int m_End;
 public int End { get{ return m_End;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_OverTimeCost;
 public int OverTimeCost { get{ return m_OverTimeCost;}}

private int m_Stamina;
 public int Stamina { get{ return m_Stamina;}}

public static bool LoadTable(Dictionary<int, List<Tab_FuliDailyStamina> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_FuliDailyStamina SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_FuliDailyStamina _values = new Tab_FuliDailyStamina();
 _values.m_Begin =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_BEGIN] as string);
_values.m_End =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_END] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_OverTimeCost =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_OVERTIMECOST] as string);
_values.m_Stamina =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_STAMINA] as string);

 return _values; }


}
}

