//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_SceneEventDesc
{ private const string TAB_FILE_DATA = "Table/SceneEventDesc.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_TOPOLOGYDESC=2,
ID_UNKNOWNTOPODESC,
ID_PERCEPTION,
ID_DESC,
ID_PERSONALITYDESC,
ID_COMMONFAILEDREASON,
ID_SPECIALFAILEDREASON,
ID_HOLDER,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private string m_CommonFailedReason;
 public string CommonFailedReason { get{ return m_CommonFailedReason;}}

private string m_Desc;
 public string Desc { get{ return m_Desc;}}

private int m_Holder;
 public int Holder { get{ return m_Holder;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_Perception;
 public string Perception { get{ return m_Perception;}}

private string m_PersonalityDesc;
 public string PersonalityDesc { get{ return m_PersonalityDesc;}}

private string m_SpecialFailedReason;
 public string SpecialFailedReason { get{ return m_SpecialFailedReason;}}

private string m_TopologyDesc;
 public string TopologyDesc { get{ return m_TopologyDesc;}}

private string m_UnKnownTopoDesc;
 public string UnKnownTopoDesc { get{ return m_UnKnownTopoDesc;}}

public static bool LoadTable(Dictionary<int, List<Tab_SceneEventDesc> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_SceneEventDesc SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_SceneEventDesc _values = new Tab_SceneEventDesc();
 _values.m_CommonFailedReason =  valuesList[(int)_ID.ID_COMMONFAILEDREASON] as string;
_values.m_Desc =  valuesList[(int)_ID.ID_DESC] as string;
_values.m_Holder =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HOLDER] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Perception =  valuesList[(int)_ID.ID_PERCEPTION] as string;
_values.m_PersonalityDesc =  valuesList[(int)_ID.ID_PERSONALITYDESC] as string;
_values.m_SpecialFailedReason =  valuesList[(int)_ID.ID_SPECIALFAILEDREASON] as string;
_values.m_TopologyDesc =  valuesList[(int)_ID.ID_TOPOLOGYDESC] as string;
_values.m_UnKnownTopoDesc =  valuesList[(int)_ID.ID_UNKNOWNTOPODESC] as string;

 return _values; }


}
}

