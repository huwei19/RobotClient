//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_Goto
{ private const string TAB_FILE_DATA = "Table/Goto.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NAME=2,
ID_CLASSID,
ID_NEEDFUNCTION,
ID_UINAME,
ID_INTPARAM_0,
ID_INTPARAM_1,
ID_INTPARAM_2,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_ClassId;
 public int ClassId { get{ return m_ClassId;}}

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

private string m_Name;
 public string Name { get{ return m_Name;}}

private int m_NeedFunction;
 public int NeedFunction { get{ return m_NeedFunction;}}

private string m_UIName;
 public string UIName { get{ return m_UIName;}}

public static bool LoadTable(Dictionary<int, List<Tab_Goto> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_Goto SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_Goto _values = new Tab_Goto();
 _values.m_ClassId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CLASSID] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_IntParam [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_INTPARAM_0] as string);
_values.m_IntParam [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_INTPARAM_1] as string);
_values.m_IntParam [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_INTPARAM_2] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_NeedFunction =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NEEDFUNCTION] as string);
_values.m_UIName =  valuesList[(int)_ID.ID_UINAME] as string;

 return _values; }


}
}

