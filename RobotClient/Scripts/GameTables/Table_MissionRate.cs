//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_MissionRate
{ private const string TAB_FILE_DATA = "table/MissionRate.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_RATE=2,
ID_MIN,
ID_MAX,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_Max;
 public int Max { get{ return m_Max;}}

private int m_Min;
 public int Min { get{ return m_Min;}}

private int m_Rate;
 public int Rate { get{ return m_Rate;}}

public static bool LoadTable(Dictionary<int, List<Tab_MissionRate> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_MissionRate SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_MissionRate _values = new Tab_MissionRate();
 _values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Max =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MAX] as string);
_values.m_Min =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MIN] as string);
_values.m_Rate =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_RATE] as string);

 return _values; }


}
}

