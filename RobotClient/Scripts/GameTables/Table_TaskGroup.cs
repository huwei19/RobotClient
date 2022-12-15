//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_TaskGroup
{ private const string TAB_FILE_DATA = "Table/TaskGroup.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_TASKTABID=2,
ID_ORDER,
ID_TASKGROUPNAME,
ID_ACTIVITYID,
ID_VERSIONNUM,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_ActivityId;
 public int ActivityId { get{ return m_ActivityId;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_Order;
 public int Order { get{ return m_Order;}}

private string m_TaskGroupName;
 public string TaskGroupName { get{ return m_TaskGroupName;}}

private int m_TaskTabId;
 public int TaskTabId { get{ return m_TaskTabId;}}

private int m_VersionNum;
 public int VersionNum { get{ return m_VersionNum;}}

public static bool LoadTable(Dictionary<int, List<Tab_TaskGroup> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_TaskGroup SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_TaskGroup _values = new Tab_TaskGroup();
 _values.m_ActivityId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIVITYID] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Order =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ORDER] as string);
_values.m_TaskGroupName =  valuesList[(int)_ID.ID_TASKGROUPNAME] as string;
_values.m_TaskTabId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TASKTABID] as string);
_values.m_VersionNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_VERSIONNUM] as string);

 return _values; }


}
}

