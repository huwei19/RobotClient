//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_PersonalityMonologue
{ private const string TAB_FILE_DATA = "Table/PersonalityMonologue.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_DESC=2,
ID_FLAG,
ID_CV,
ID_MOVEMENT,
ID_ACTION,
ID_COSTTYPE,
ID_COSTNUM,
ID_FATELINEID,
ID_PERSONALITYLEVEL,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Action;
 public int Action { get{ return m_Action;}}

private int m_CostNum;
 public int CostNum { get{ return m_CostNum;}}

private int m_CostType;
 public int CostType { get{ return m_CostType;}}

private int m_Cv;
 public int Cv { get{ return m_Cv;}}

private string m_Desc;
 public string Desc { get{ return m_Desc;}}

private int m_FateLineId;
 public int FateLineId { get{ return m_FateLineId;}}

private int m_Flag;
 public int Flag { get{ return m_Flag;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_Movement;
 public int Movement { get{ return m_Movement;}}

private int m_PersonalityLevel;
 public int PersonalityLevel { get{ return m_PersonalityLevel;}}

public static bool LoadTable(Dictionary<int, List<Tab_PersonalityMonologue> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_PersonalityMonologue SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_PersonalityMonologue _values = new Tab_PersonalityMonologue();
 _values.m_Action =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTION] as string);
_values.m_CostNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_COSTNUM] as string);
_values.m_CostType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_COSTTYPE] as string);
_values.m_Cv =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CV] as string);
_values.m_Desc =  valuesList[(int)_ID.ID_DESC] as string;
_values.m_FateLineId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FATELINEID] as string);
_values.m_Flag =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FLAG] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Movement =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MOVEMENT] as string);
_values.m_PersonalityLevel =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PERSONALITYLEVEL] as string);

 return _values; }


}
}

