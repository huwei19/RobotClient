//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_SkillEx
{ private const string TAB_FILE_DATA = "Table/SkillEx.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_PLAYERLEVEL=2,
ID_DESC,
ID_VALUE,
ID_RATE,
ID_INTPARAM_0,
ID_INTPARAM_1,
ID_INTPARAM_2,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private string m_Desc;
 public string Desc { get{ return m_Desc;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

public int getIntParamCount() { return 3; } 
 private int[] m_IntParam = new int[3];
 public int GetIntParambyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_IntParam[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> IntParams { get {
  
return Array.AsReadOnly(m_IntParam);
}} 

private int m_PlayerLevel;
 public int PlayerLevel { get{ return m_PlayerLevel;}}

private int m_Rate;
 public int Rate { get{ return m_Rate;}}

private int m_Value;
 public int Value { get{ return m_Value;}}

public static bool LoadTable(Dictionary<int, List<Tab_SkillEx> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_SkillEx SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_SkillEx _values = new Tab_SkillEx();
 _values.m_Desc =  valuesList[(int)_ID.ID_DESC] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_IntParam [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_INTPARAM_0] as string);
_values.m_IntParam [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_INTPARAM_1] as string);
_values.m_IntParam [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_INTPARAM_2] as string);
_values.m_PlayerLevel =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PLAYERLEVEL] as string);
_values.m_Rate =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_RATE] as string);
_values.m_Value =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_VALUE] as string);

 return _values; }


}
}

