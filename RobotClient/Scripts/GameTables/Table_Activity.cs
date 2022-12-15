//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_Activity
{ private const string TAB_FILE_DATA = "table/Activity.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NAME=2,
ID_ISSHOWINTAB,
ID_PRIORITY,
ID_REDPOINT_TYPE,
ID_ISCYCLE_TIME,
ID_SHOWSTARTTIME,
ID_SHOWENDTIME,
ID_TRUESTARTTIME_DATE,
ID_TRUESTARTTIME_CLOCK,
ID_TRUEENDTIME_DATE,
ID_TRUEENDTIME_CLOCK,
ID_STYLETYPE,
ID_ACT_GROUP,
ID_ACT_TYPE,
ID_RELATIONID,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_ActGroup;
 public int ActGroup { get{ return m_ActGroup;}}

private int m_ActType;
 public int ActType { get{ return m_ActType;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_IsCycleTime;
 public int IsCycleTime { get{ return m_IsCycleTime;}}

private int m_IsShowInTab;
 public int IsShowInTab { get{ return m_IsShowInTab;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private int m_Priority;
 public int Priority { get{ return m_Priority;}}

private int m_RedPointType;
 public int RedPointType { get{ return m_RedPointType;}}

private int m_RelationId;
 public int RelationId { get{ return m_RelationId;}}

private string m_ShowEndTime;
 public string ShowEndTime { get{ return m_ShowEndTime;}}

private string m_ShowStartTime;
 public string ShowStartTime { get{ return m_ShowStartTime;}}

private int m_StyleType;
 public int StyleType { get{ return m_StyleType;}}

private string m_TrueEndTimeClock;
 public string TrueEndTimeClock { get{ return m_TrueEndTimeClock;}}

private string m_TrueEndTimeDate;
 public string TrueEndTimeDate { get{ return m_TrueEndTimeDate;}}

private string m_TrueStartTimeClock;
 public string TrueStartTimeClock { get{ return m_TrueStartTimeClock;}}

private string m_TrueStartTimeDate;
 public string TrueStartTimeDate { get{ return m_TrueStartTimeDate;}}

public static bool LoadTable(Dictionary<int, List<Tab_Activity> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_Activity SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_Activity _values = new Tab_Activity();
 _values.m_ActGroup =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACT_GROUP] as string);
_values.m_ActType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACT_TYPE] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_IsCycleTime =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISCYCLE_TIME] as string);
_values.m_IsShowInTab =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISSHOWINTAB] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_Priority =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PRIORITY] as string);
_values.m_RedPointType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REDPOINT_TYPE] as string);
_values.m_RelationId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_RELATIONID] as string);
_values.m_ShowEndTime =  valuesList[(int)_ID.ID_SHOWENDTIME] as string;
_values.m_ShowStartTime =  valuesList[(int)_ID.ID_SHOWSTARTTIME] as string;
_values.m_StyleType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_STYLETYPE] as string);
_values.m_TrueEndTimeClock =  valuesList[(int)_ID.ID_TRUEENDTIME_CLOCK] as string;
_values.m_TrueEndTimeDate =  valuesList[(int)_ID.ID_TRUEENDTIME_DATE] as string;
_values.m_TrueStartTimeClock =  valuesList[(int)_ID.ID_TRUESTARTTIME_CLOCK] as string;
_values.m_TrueStartTimeDate =  valuesList[(int)_ID.ID_TRUESTARTTIME_DATE] as string;

 return _values; }


}
}

