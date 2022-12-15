//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_SpecialLevelGamePlay
{ private const string TAB_FILE_DATA = "Table/SpecialLevelGamePlay.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_ENDACTION=2,
ID_FIRSTTYPE,
ID_FIRSTRES,
ID_FIRSTSTRPARAM_0,
ID_FIRSTSTRPARAM_1,
ID_FIRSTSTRPARAM_2,
ID_SECONDTYPE,
ID_SECONDRES,
ID_SECONDSTRPARAM_0,
ID_SECONDSTRPARAM_1,
ID_SECONDSTRPARAM_2,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_EndAction;
 public int EndAction { get{ return m_EndAction;}}

private string m_FirstRes;
 public string FirstRes { get{ return m_FirstRes;}}

public int getFirstStrParamCount() { return 3; } 
 private string[] m_FirstStrParam = new string[3];
 public string GetFirstStrParambyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_FirstStrParam[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> FirstStrParams { get {
  
return Array.AsReadOnly(m_FirstStrParam);
}} 

private int m_FirstType;
 public int FirstType { get{ return m_FirstType;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_SecondRes;
 public string SecondRes { get{ return m_SecondRes;}}

public int getSecondStrParamCount() { return 3; } 
 private string[] m_SecondStrParam = new string[3];
 public string GetSecondStrParambyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_SecondStrParam[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> SecondStrParams { get {
  
return Array.AsReadOnly(m_SecondStrParam);
}} 

private int m_SecondType;
 public int SecondType { get{ return m_SecondType;}}

public static bool LoadTable(Dictionary<int, List<Tab_SpecialLevelGamePlay> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_SpecialLevelGamePlay SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_SpecialLevelGamePlay _values = new Tab_SpecialLevelGamePlay();
 _values.m_EndAction =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ENDACTION] as string);
_values.m_FirstRes =  valuesList[(int)_ID.ID_FIRSTRES] as string;
_values.m_FirstStrParam [ 0 ] =  valuesList[(int)_ID.ID_FIRSTSTRPARAM_0] as string;
_values.m_FirstStrParam [ 1 ] =  valuesList[(int)_ID.ID_FIRSTSTRPARAM_1] as string;
_values.m_FirstStrParam [ 2 ] =  valuesList[(int)_ID.ID_FIRSTSTRPARAM_2] as string;
_values.m_FirstType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FIRSTTYPE] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_SecondRes =  valuesList[(int)_ID.ID_SECONDRES] as string;
_values.m_SecondStrParam [ 0 ] =  valuesList[(int)_ID.ID_SECONDSTRPARAM_0] as string;
_values.m_SecondStrParam [ 1 ] =  valuesList[(int)_ID.ID_SECONDSTRPARAM_1] as string;
_values.m_SecondStrParam [ 2 ] =  valuesList[(int)_ID.ID_SECONDSTRPARAM_2] as string;
_values.m_SecondType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SECONDTYPE] as string);

 return _values; }


}
}

