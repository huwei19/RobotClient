//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_Node
{ private const string TAB_FILE_DATA = "Table/Node.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NAME=2,
ID_CODE,
ID_PARAMINT_01,
ID_PARAMINT_02,
ID_PARAMINT_03,
ID_PARAMINT_04,
ID_PARAMINT_05,
ID_PARAMINT_06,
ID_PARAMINT_07,
ID_PARAMINT_08,
ID_PARAMINT_09,
ID_PARAMINT_10,
ID_PARAMINT_11,
ID_PARAMINT_12,
ID_PARAMINT_13,
ID_PARAMINT_14,
ID_PARAMINT_15,
ID_PARAMINT_16,
ID_PARAMINT_17,
ID_PARAMINT_18,
ID_PARAMINT_19,
ID_PARAMINT_20,
ID_PARAMSTR_01,
ID_PARAMSTR_02,
ID_PARAMSTR_03,
ID_PARAMSTR_04,
ID_PARAMSTR_05,
ID_PARAMSTR_06,
ID_PARAMSTR_07,
ID_PARAMSTR_08,
ID_PARAMSTR_09,
ID_PARAMSTR_10,
ID_PARAMSTR_11,
ID_PARAMSTR_12,
ID_PARAMSTR_13,
ID_PARAMSTR_14,
ID_PARAMSTR_15,
ID_PARAMSTR_16,
ID_PARAMSTR_17,
ID_PARAMSTR_18,
ID_PARAMSTR_19,
ID_PARAMSTR_20,
ID_RESERVED,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Code;
 public int Code { get{ return m_Code;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

public int getParamIntCount() { return 20; } 
 private int[] m_ParamInt = new int[20];
 public int GetParamIntbyIndex(int idx) {
 if(idx>=0 && idx<20) {
 return m_ParamInt[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> ParamInts { get {
  
return Array.AsReadOnly(m_ParamInt);
}} 

public int getParamStrCount() { return 20; } 
 private string[] m_ParamStr = new string[20];
 public string GetParamStrbyIndex(int idx) {
 if(idx>=0 && idx<20) {
 return m_ParamStr[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> ParamStrs { get {
  
return Array.AsReadOnly(m_ParamStr);
}} 

private int m_Reserved;
 public int Reserved { get{ return m_Reserved;}}

public static bool LoadTable(Dictionary<int, List<Tab_Node> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_Node SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_Node _values = new Tab_Node();
 _values.m_Code =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CODE] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_ParamInt [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PARAMINT_01] as string);
_values.m_ParamInt [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PARAMINT_02] as string);
_values.m_ParamInt [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PARAMINT_03] as string);
_values.m_ParamInt [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PARAMINT_04] as string);
_values.m_ParamInt [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PARAMINT_05] as string);
_values.m_ParamInt [ 5 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PARAMINT_06] as string);
_values.m_ParamInt [ 6 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PARAMINT_07] as string);
_values.m_ParamInt [ 7 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PARAMINT_08] as string);
_values.m_ParamInt [ 8 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PARAMINT_09] as string);
_values.m_ParamInt [ 9 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PARAMINT_10] as string);
_values.m_ParamInt [ 10 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PARAMINT_11] as string);
_values.m_ParamInt [ 11 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PARAMINT_12] as string);
_values.m_ParamInt [ 12 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PARAMINT_13] as string);
_values.m_ParamInt [ 13 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PARAMINT_14] as string);
_values.m_ParamInt [ 14 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PARAMINT_15] as string);
_values.m_ParamInt [ 15 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PARAMINT_16] as string);
_values.m_ParamInt [ 16 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PARAMINT_17] as string);
_values.m_ParamInt [ 17 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PARAMINT_18] as string);
_values.m_ParamInt [ 18 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PARAMINT_19] as string);
_values.m_ParamInt [ 19 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PARAMINT_20] as string);
_values.m_ParamStr [ 0 ] =  valuesList[(int)_ID.ID_PARAMSTR_01] as string;
_values.m_ParamStr [ 1 ] =  valuesList[(int)_ID.ID_PARAMSTR_02] as string;
_values.m_ParamStr [ 2 ] =  valuesList[(int)_ID.ID_PARAMSTR_03] as string;
_values.m_ParamStr [ 3 ] =  valuesList[(int)_ID.ID_PARAMSTR_04] as string;
_values.m_ParamStr [ 4 ] =  valuesList[(int)_ID.ID_PARAMSTR_05] as string;
_values.m_ParamStr [ 5 ] =  valuesList[(int)_ID.ID_PARAMSTR_06] as string;
_values.m_ParamStr [ 6 ] =  valuesList[(int)_ID.ID_PARAMSTR_07] as string;
_values.m_ParamStr [ 7 ] =  valuesList[(int)_ID.ID_PARAMSTR_08] as string;
_values.m_ParamStr [ 8 ] =  valuesList[(int)_ID.ID_PARAMSTR_09] as string;
_values.m_ParamStr [ 9 ] =  valuesList[(int)_ID.ID_PARAMSTR_10] as string;
_values.m_ParamStr [ 10 ] =  valuesList[(int)_ID.ID_PARAMSTR_11] as string;
_values.m_ParamStr [ 11 ] =  valuesList[(int)_ID.ID_PARAMSTR_12] as string;
_values.m_ParamStr [ 12 ] =  valuesList[(int)_ID.ID_PARAMSTR_13] as string;
_values.m_ParamStr [ 13 ] =  valuesList[(int)_ID.ID_PARAMSTR_14] as string;
_values.m_ParamStr [ 14 ] =  valuesList[(int)_ID.ID_PARAMSTR_15] as string;
_values.m_ParamStr [ 15 ] =  valuesList[(int)_ID.ID_PARAMSTR_16] as string;
_values.m_ParamStr [ 16 ] =  valuesList[(int)_ID.ID_PARAMSTR_17] as string;
_values.m_ParamStr [ 17 ] =  valuesList[(int)_ID.ID_PARAMSTR_18] as string;
_values.m_ParamStr [ 18 ] =  valuesList[(int)_ID.ID_PARAMSTR_19] as string;
_values.m_ParamStr [ 19 ] =  valuesList[(int)_ID.ID_PARAMSTR_20] as string;
_values.m_Reserved =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_RESERVED] as string);

 return _values; }


}
}

