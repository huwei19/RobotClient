//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_AutoSystemMail
{ private const string TAB_FILE_DATA = "table/AutoSystemMail.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_STARTDATE=2,
ID_STARTTIME,
ID_ENDDATE,
ID_ENDTIME,
ID_MAILUSESTARTTIME,
ID_REQUIRELEVEL,
ID_SYSTEMMAILID,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_EndDate;
 public int EndDate { get{ return m_EndDate;}}

private int m_EndTime;
 public int EndTime { get{ return m_EndTime;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_MailUseStartTime;
 public int MailUseStartTime { get{ return m_MailUseStartTime;}}

private int m_RequireLevel;
 public int RequireLevel { get{ return m_RequireLevel;}}

private int m_StartDate;
 public int StartDate { get{ return m_StartDate;}}

private int m_StartTime;
 public int StartTime { get{ return m_StartTime;}}

private int m_SystemMailID;
 public int SystemMailID { get{ return m_SystemMailID;}}

public static bool LoadTable(Dictionary<int, List<Tab_AutoSystemMail> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_AutoSystemMail SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_AutoSystemMail _values = new Tab_AutoSystemMail();
 _values.m_EndDate =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ENDDATE] as string);
_values.m_EndTime =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ENDTIME] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_MailUseStartTime =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MAILUSESTARTTIME] as string);
_values.m_RequireLevel =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REQUIRELEVEL] as string);
_values.m_StartDate =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_STARTDATE] as string);
_values.m_StartTime =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_STARTTIME] as string);
_values.m_SystemMailID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SYSTEMMAILID] as string);

 return _values; }


}
}

