//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_Article
{ private const string TAB_FILE_DATA = "Table/Article.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_BEGINDATE=2,
ID_BEGINTIME,
ID_NEEDLEVEL,
ID_ACCOUNTID,
ID_TYPE,
ID_WRITER,
ID_CONDITIONID,
ID_FORWARDCONDITIONID,
ID_CIRCLEID_0,
ID_CIRCLEID_1,
ID_CIRCLEID_2,
ID_READTIMES,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_AccountId;
 public int AccountId { get{ return m_AccountId;}}

private int m_BeginDate;
 public int BeginDate { get{ return m_BeginDate;}}

private int m_BeginTime;
 public int BeginTime { get{ return m_BeginTime;}}

public int getCircleIdCount() { return 3; } 
 private int[] m_CircleId = new int[3];
 public int GetCircleIdbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_CircleId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> CircleIds { get {
  
return Array.AsReadOnly(m_CircleId);
}} 

private int m_ConditionId;
 public int ConditionId { get{ return m_ConditionId;}}

private int m_ForwardConditionId;
 public int ForwardConditionId { get{ return m_ForwardConditionId;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_NeedLevel;
 public int NeedLevel { get{ return m_NeedLevel;}}

private int m_ReadTimes;
 public int ReadTimes { get{ return m_ReadTimes;}}

private int m_Type;
 public int Type { get{ return m_Type;}}

private int m_Writer;
 public int Writer { get{ return m_Writer;}}

public static bool LoadTable(Dictionary<int, List<Tab_Article> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_Article SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_Article _values = new Tab_Article();
 _values.m_AccountId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACCOUNTID] as string);
_values.m_BeginDate =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_BEGINDATE] as string);
_values.m_BeginTime =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_BEGINTIME] as string);
_values.m_CircleId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CIRCLEID_0] as string);
_values.m_CircleId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CIRCLEID_1] as string);
_values.m_CircleId [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CIRCLEID_2] as string);
_values.m_ConditionId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CONDITIONID] as string);
_values.m_ForwardConditionId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FORWARDCONDITIONID] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_NeedLevel =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NEEDLEVEL] as string);
_values.m_ReadTimes =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_READTIMES] as string);
_values.m_Type =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TYPE] as string);
_values.m_Writer =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_WRITER] as string);

 return _values; }


}
}

