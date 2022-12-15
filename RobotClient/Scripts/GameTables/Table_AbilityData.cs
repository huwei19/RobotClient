//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_AbilityData
{ private const string TAB_FILE_DATA = "Table/AbilityData.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_ABILITYNAME=2,
ID_ABILITYDESC,
ID_ABILITYICON,
ID_COLOR,
ID_ASSOCATTR,
ID_LEVEL,
ID_ABILITYCLUE_0,
ID_ABILITYCLUE_1,
ID_ABILITYCLUE_2,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

public int getAbilityClueCount() { return 3; } 
 private int[] m_AbilityClue = new int[3];
 public int GetAbilityCluebyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_AbilityClue[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> AbilityClues { get {
  
return Array.AsReadOnly(m_AbilityClue);
}} 

private string m_AbilityDesc;
 public string AbilityDesc { get{ return m_AbilityDesc;}}

private string m_AbilityIcon;
 public string AbilityIcon { get{ return m_AbilityIcon;}}

private string m_AbilityName;
 public string AbilityName { get{ return m_AbilityName;}}

private string m_AssocAttr;
 public string AssocAttr { get{ return m_AssocAttr;}}

private string m_Color;
 public string Color { get{ return m_Color;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_Level;
 public int Level { get{ return m_Level;}}

public static bool LoadTable(Dictionary<int, List<Tab_AbilityData> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_AbilityData SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_AbilityData _values = new Tab_AbilityData();
 _values.m_AbilityClue [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ABILITYCLUE_0] as string);
_values.m_AbilityClue [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ABILITYCLUE_1] as string);
_values.m_AbilityClue [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ABILITYCLUE_2] as string);
_values.m_AbilityDesc =  valuesList[(int)_ID.ID_ABILITYDESC] as string;
_values.m_AbilityIcon =  valuesList[(int)_ID.ID_ABILITYICON] as string;
_values.m_AbilityName =  valuesList[(int)_ID.ID_ABILITYNAME] as string;
_values.m_AssocAttr =  valuesList[(int)_ID.ID_ASSOCATTR] as string;
_values.m_Color =  valuesList[(int)_ID.ID_COLOR] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Level =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LEVEL] as string);

 return _values; }


}
}

