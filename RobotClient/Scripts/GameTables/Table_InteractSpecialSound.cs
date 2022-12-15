//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_InteractSpecialSound
{ private const string TAB_FILE_DATA = "Table/InteractSpecialSound.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_OPTIONCOUNT=2,
ID_SCENEID,
ID_DURATION,
ID_OPTIONPOSITIONS,
ID_CLICKSOUND,
ID_OPTIONCONTENT_0,
ID_RESULTTYPE_0,
ID_RESULTPARAM_0,
ID_OPTIONCONTENT_1,
ID_RESULTTYPE_1,
ID_RESULTPARAM_1,
ID_OPTIONCONTENT_2,
ID_RESULTTYPE_2,
ID_RESULTPARAM_2,
ID_OPTIONCONTENT_3,
ID_RESULTTYPE_3,
ID_RESULTPARAM_3,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_ClickSound;
 public int ClickSound { get{ return m_ClickSound;}}

private int m_Duration;
 public int Duration { get{ return m_Duration;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

public int getOptionContentCount() { return 4; } 
 private string[] m_OptionContent = new string[4];
 public string GetOptionContentbyIndex(int idx) {
 if(idx>=0 && idx<4) {
 return m_OptionContent[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> OptionContents { get {
  
return Array.AsReadOnly(m_OptionContent);
}} 

private int m_OptionCount;
 public int OptionCount { get{ return m_OptionCount;}}

private string m_OptionPositions;
 public string OptionPositions { get{ return m_OptionPositions;}}

public int getResultParamCount() { return 4; } 
 private string[] m_ResultParam = new string[4];
 public string GetResultParambyIndex(int idx) {
 if(idx>=0 && idx<4) {
 return m_ResultParam[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> ResultParams { get {
  
return Array.AsReadOnly(m_ResultParam);
}} 

public int getResultTypeCount() { return 4; } 
 private int[] m_ResultType = new int[4];
 public int GetResultTypebyIndex(int idx) {
 if(idx>=0 && idx<4) {
 return m_ResultType[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> ResultTypes { get {
  
return Array.AsReadOnly(m_ResultType);
}} 

private int m_SceneId;
 public int SceneId { get{ return m_SceneId;}}

public static bool LoadTable(Dictionary<int, List<Tab_InteractSpecialSound> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_InteractSpecialSound SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_InteractSpecialSound _values = new Tab_InteractSpecialSound();
 _values.m_ClickSound =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CLICKSOUND] as string);
_values.m_Duration =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DURATION] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_OptionContent [ 0 ] =  valuesList[(int)_ID.ID_OPTIONCONTENT_0] as string;
_values.m_OptionContent [ 1 ] =  valuesList[(int)_ID.ID_OPTIONCONTENT_1] as string;
_values.m_OptionContent [ 2 ] =  valuesList[(int)_ID.ID_OPTIONCONTENT_2] as string;
_values.m_OptionContent [ 3 ] =  valuesList[(int)_ID.ID_OPTIONCONTENT_3] as string;
_values.m_OptionCount =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_OPTIONCOUNT] as string);
_values.m_OptionPositions =  valuesList[(int)_ID.ID_OPTIONPOSITIONS] as string;
_values.m_ResultParam [ 0 ] =  valuesList[(int)_ID.ID_RESULTPARAM_0] as string;
_values.m_ResultParam [ 1 ] =  valuesList[(int)_ID.ID_RESULTPARAM_1] as string;
_values.m_ResultParam [ 2 ] =  valuesList[(int)_ID.ID_RESULTPARAM_2] as string;
_values.m_ResultParam [ 3 ] =  valuesList[(int)_ID.ID_RESULTPARAM_3] as string;
_values.m_ResultType [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_RESULTTYPE_0] as string);
_values.m_ResultType [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_RESULTTYPE_1] as string);
_values.m_ResultType [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_RESULTTYPE_2] as string);
_values.m_ResultType [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_RESULTTYPE_3] as string);
_values.m_SceneId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SCENEID] as string);

 return _values; }


}
}

