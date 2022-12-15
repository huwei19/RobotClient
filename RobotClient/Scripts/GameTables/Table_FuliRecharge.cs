//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_FuliRecharge
{ private const string TAB_FILE_DATA = "Table/FuliRecharge.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_ACTIVITYID=2,
ID_SCORELEVEL,
ID_DROPID,
ID_DROPPREVIEWID,
ID_SPSHOWPARAM,
ID_SPSHOWNAME,
ID_SPSHOWTYPE,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_ActivityID;
 public int ActivityID { get{ return m_ActivityID;}}

private int m_DropId;
 public int DropId { get{ return m_DropId;}}

private int m_DropPreviewId;
 public int DropPreviewId { get{ return m_DropPreviewId;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_SPShowName;
 public string SPShowName { get{ return m_SPShowName;}}

private string m_SPShowParam;
 public string SPShowParam { get{ return m_SPShowParam;}}

private int m_SPShowType;
 public int SPShowType { get{ return m_SPShowType;}}

private int m_ScoreLevel;
 public int ScoreLevel { get{ return m_ScoreLevel;}}

public static bool LoadTable(Dictionary<int, List<Tab_FuliRecharge> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_FuliRecharge SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_FuliRecharge _values = new Tab_FuliRecharge();
 _values.m_ActivityID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIVITYID] as string);
_values.m_DropId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPID] as string);
_values.m_DropPreviewId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPREVIEWID] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_SPShowName =  valuesList[(int)_ID.ID_SPSHOWNAME] as string;
_values.m_SPShowParam =  valuesList[(int)_ID.ID_SPSHOWPARAM] as string;
_values.m_SPShowType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SPSHOWTYPE] as string);
_values.m_ScoreLevel =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SCORELEVEL] as string);

 return _values; }


}
}

