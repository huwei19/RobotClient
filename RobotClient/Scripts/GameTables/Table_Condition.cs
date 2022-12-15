//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_Condition
{ private const string TAB_FILE_DATA = "Table/Condition.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_LOGICTYPE=2,
ID_DESCRIBE,
ID_SPARAM,
ID_PARAM_0,
ID_PARAM_1,
ID_PARAM_2,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private string m_Describe;
 public string Describe { get{ return m_Describe;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_LogicType;
 public int LogicType { get{ return m_LogicType;}}

public int getParamCount() { return 3; } 
 private int[] m_Param = new int[3];
 public int GetParambyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_Param[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> Params { get {
  
return Array.AsReadOnly(m_Param);
}} 

private string m_SParam;
 public string SParam { get{ return m_SParam;}}

public static bool LoadTable(Dictionary<int, List<Tab_Condition> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_Condition SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_Condition _values = new Tab_Condition();
 _values.m_Describe =  valuesList[(int)_ID.ID_DESCRIBE] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_LogicType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LOGICTYPE] as string);
_values.m_Param [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PARAM_0] as string);
_values.m_Param [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PARAM_1] as string);
_values.m_Param [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PARAM_2] as string);
_values.m_SParam =  valuesList[(int)_ID.ID_SPARAM] as string;

 return _values; }


}
}

