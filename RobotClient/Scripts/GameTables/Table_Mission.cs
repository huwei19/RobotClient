//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_Mission
{ private const string TAB_FILE_DATA = "Table/Mission.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NPC=2,
ID_FILTERSTATUS,
ID_TITLE,
ID_DESC,
ID_DESCREQ,
ID_REPUTATIONLEVEL,
ID_LEVEL,
ID_PREMIS,
ID_TYPE,
ID_PARAM_0,
ID_PARAM_1,
ID_DROPID,
ID_DROPPREVIEWID,
ID_ACTIONID,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_ActionId;
 public int ActionId { get{ return m_ActionId;}}

private string m_Desc;
 public string Desc { get{ return m_Desc;}}

private string m_DescReq;
 public string DescReq { get{ return m_DescReq;}}

private int m_DropId;
 public int DropId { get{ return m_DropId;}}

private int m_DropPreviewId;
 public int DropPreviewId { get{ return m_DropPreviewId;}}

private int m_FilterStatus;
 public int FilterStatus { get{ return m_FilterStatus;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_Level;
 public int Level { get{ return m_Level;}}

private int m_Npc;
 public int Npc { get{ return m_Npc;}}

public int getParamCount() { return 2; } 
 private int[] m_Param = new int[2];
 public int GetParambyIndex(int idx) {
 if(idx>=0 && idx<2) {
 return m_Param[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> Params { get {
  
return Array.AsReadOnly(m_Param);
}} 

private int m_PreMis;
 public int PreMis { get{ return m_PreMis;}}

private int m_ReputationLevel;
 public int ReputationLevel { get{ return m_ReputationLevel;}}

private string m_Title;
 public string Title { get{ return m_Title;}}

private int m_Type;
 public int Type { get{ return m_Type;}}

public static bool LoadTable(Dictionary<int, List<Tab_Mission> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_Mission SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_Mission _values = new Tab_Mission();
 _values.m_ActionId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIONID] as string);
_values.m_Desc =  valuesList[(int)_ID.ID_DESC] as string;
_values.m_DescReq =  valuesList[(int)_ID.ID_DESCREQ] as string;
_values.m_DropId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPID] as string);
_values.m_DropPreviewId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPREVIEWID] as string);
_values.m_FilterStatus =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FILTERSTATUS] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Level =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LEVEL] as string);
_values.m_Npc =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NPC] as string);
_values.m_Param [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PARAM_0] as string);
_values.m_Param [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PARAM_1] as string);
_values.m_PreMis =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PREMIS] as string);
_values.m_ReputationLevel =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REPUTATIONLEVEL] as string);
_values.m_Title =  valuesList[(int)_ID.ID_TITLE] as string;
_values.m_Type =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TYPE] as string);

 return _values; }


}
}

