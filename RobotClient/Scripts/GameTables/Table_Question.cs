//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_Question
{ private const string TAB_FILE_DATA = "Table/Question.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_ISREPEATABLE=2,
ID_CONTENT,
ID_CONTENTAUDIOID,
ID_OPTIONCONTENT_0,
ID_OPTIONTYPE_0,
ID_OPTIONPARAM_0,
ID_OPTIONPREVIEW_0,
ID_OPTIONMONOLOGUE_0,
ID_OPTIONCONTENT_1,
ID_OPTIONTYPE_1,
ID_OPTIONPARAM_1,
ID_OPTIONPREVIEW_1,
ID_OPTIONMONOLOGUE_1,
ID_OPTIONCONTENT_2,
ID_OPTIONTYPE_2,
ID_OPTIONPARAM_2,
ID_OPTIONPREVIEW_2,
ID_OPTIONMONOLOGUE_2,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private string m_Content;
 public string Content { get{ return m_Content;}}

private int m_ContentAudioId;
 public int ContentAudioId { get{ return m_ContentAudioId;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_IsRepeatable;
 public int IsRepeatable { get{ return m_IsRepeatable;}}

public int getOptionContentCount() { return 3; } 
 private string[] m_OptionContent = new string[3];
 public string GetOptionContentbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_OptionContent[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> OptionContents { get {
  
return Array.AsReadOnly(m_OptionContent);
}} 

public int getOptionMonologueCount() { return 3; } 
 private int[] m_OptionMonologue = new int[3];
 public int GetOptionMonologuebyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_OptionMonologue[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> OptionMonologues { get {
  
return Array.AsReadOnly(m_OptionMonologue);
}} 

public int getOptionParamCount() { return 3; } 
 private int[] m_OptionParam = new int[3];
 public int GetOptionParambyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_OptionParam[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> OptionParams { get {
  
return Array.AsReadOnly(m_OptionParam);
}} 

public int getOptionPreviewCount() { return 3; } 
 private int[] m_OptionPreview = new int[3];
 public int GetOptionPreviewbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_OptionPreview[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> OptionPreviews { get {
  
return Array.AsReadOnly(m_OptionPreview);
}} 

public int getOptionTypeCount() { return 3; } 
 private int[] m_OptionType = new int[3];
 public int GetOptionTypebyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_OptionType[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> OptionTypes { get {
  
return Array.AsReadOnly(m_OptionType);
}} 

public static bool LoadTable(Dictionary<int, List<Tab_Question> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_Question SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_Question _values = new Tab_Question();
 _values.m_Content =  valuesList[(int)_ID.ID_CONTENT] as string;
_values.m_ContentAudioId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CONTENTAUDIOID] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_IsRepeatable =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISREPEATABLE] as string);
_values.m_OptionContent [ 0 ] =  valuesList[(int)_ID.ID_OPTIONCONTENT_0] as string;
_values.m_OptionContent [ 1 ] =  valuesList[(int)_ID.ID_OPTIONCONTENT_1] as string;
_values.m_OptionContent [ 2 ] =  valuesList[(int)_ID.ID_OPTIONCONTENT_2] as string;
_values.m_OptionMonologue [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_OPTIONMONOLOGUE_0] as string);
_values.m_OptionMonologue [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_OPTIONMONOLOGUE_1] as string);
_values.m_OptionMonologue [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_OPTIONMONOLOGUE_2] as string);
_values.m_OptionParam [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_OPTIONPARAM_0] as string);
_values.m_OptionParam [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_OPTIONPARAM_1] as string);
_values.m_OptionParam [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_OPTIONPARAM_2] as string);
_values.m_OptionPreview [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_OPTIONPREVIEW_0] as string);
_values.m_OptionPreview [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_OPTIONPREVIEW_1] as string);
_values.m_OptionPreview [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_OPTIONPREVIEW_2] as string);
_values.m_OptionType [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_OPTIONTYPE_0] as string);
_values.m_OptionType [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_OPTIONTYPE_1] as string);
_values.m_OptionType [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_OPTIONTYPE_2] as string);

 return _values; }


}
}

