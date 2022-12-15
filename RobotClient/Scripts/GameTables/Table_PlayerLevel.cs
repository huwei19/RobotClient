//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_PlayerLevel
{ private const string TAB_FILE_DATA = "Table/PlayerLevel.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_EXP=2,
ID_STAMINAMAX,
ID_CONFIDENCEMAX,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_ConfidenceMax;
 public int ConfidenceMax { get{ return m_ConfidenceMax;}}

private int m_Exp;
 public int Exp { get{ return m_Exp;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_StaminaMax;
 public int StaminaMax { get{ return m_StaminaMax;}}

public static bool LoadTable(Dictionary<int, List<Tab_PlayerLevel> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_PlayerLevel SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_PlayerLevel _values = new Tab_PlayerLevel();
 _values.m_ConfidenceMax =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CONFIDENCEMAX] as string);
_values.m_Exp =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_EXP] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_StaminaMax =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_STAMINAMAX] as string);

 return _values; }


}
}

