//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_RumorRewardRule
{ private const string TAB_FILE_DATA = "Table/RumorRewardRule.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_ACTIVITYID=2,
ID_TYPE,
ID_RATE,
ID_EXCLUDEITEMID_0,
ID_EXCLUDEITEMID_1,
ID_EXCLUDEITEMID_2,
ID_EXTRADROPID,
ID_EXTRADROPPREVIEWID,
ID_VERSIONNUM,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_ActivityId;
 public int ActivityId { get{ return m_ActivityId;}}

public int getExcludeItemIdCount() { return 3; } 
 private int[] m_ExcludeItemId = new int[3];
 public int GetExcludeItemIdbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_ExcludeItemId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> ExcludeItemIds { get {
  
return Array.AsReadOnly(m_ExcludeItemId);
}} 

private int m_ExtraDropId;
 public int ExtraDropId { get{ return m_ExtraDropId;}}

private int m_ExtraDropPreviewId;
 public int ExtraDropPreviewId { get{ return m_ExtraDropPreviewId;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_Rate;
 public int Rate { get{ return m_Rate;}}

private int m_Type;
 public int Type { get{ return m_Type;}}

private int m_VersionNum;
 public int VersionNum { get{ return m_VersionNum;}}

public static bool LoadTable(Dictionary<int, List<Tab_RumorRewardRule> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_RumorRewardRule SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_RumorRewardRule _values = new Tab_RumorRewardRule();
 _values.m_ActivityId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIVITYID] as string);
_values.m_ExcludeItemId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_EXCLUDEITEMID_0] as string);
_values.m_ExcludeItemId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_EXCLUDEITEMID_1] as string);
_values.m_ExcludeItemId [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_EXCLUDEITEMID_2] as string);
_values.m_ExtraDropId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_EXTRADROPID] as string);
_values.m_ExtraDropPreviewId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_EXTRADROPPREVIEWID] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Rate =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_RATE] as string);
_values.m_Type =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TYPE] as string);
_values.m_VersionNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_VERSIONNUM] as string);

 return _values; }


}
}

