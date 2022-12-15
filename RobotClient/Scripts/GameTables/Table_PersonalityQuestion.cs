//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_PersonalityQuestion
{ private const string TAB_FILE_DATA = "Table/PersonalityQuestion.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_QUESTION=2,
ID_ANSWERDESC_0,
ID_ANSWERPERSONALITY_0,
ID_ANSWERNUM_0,
ID_ANSWERDIALOGASSET_0,
ID_ANSWERDIALOGID_0,
ID_ANSWERMONOLOGID_0,
ID_ANSWERDESC_1,
ID_ANSWERPERSONALITY_1,
ID_ANSWERNUM_1,
ID_ANSWERDIALOGASSET_1,
ID_ANSWERDIALOGID_1,
ID_ANSWERMONOLOGID_1,
ID_ANSWERDESC_2,
ID_ANSWERPERSONALITY_2,
ID_ANSWERNUM_2,
ID_ANSWERDIALOGASSET_2,
ID_ANSWERDIALOGID_2,
ID_ANSWERMONOLOGID_2,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

public int getAnswerDescCount() { return 3; } 
 private string[] m_AnswerDesc = new string[3];
 public string GetAnswerDescbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_AnswerDesc[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> AnswerDescs { get {
  
return Array.AsReadOnly(m_AnswerDesc);
}} 

public int getAnswerDialogAssetCount() { return 3; } 
 private string[] m_AnswerDialogAsset = new string[3];
 public string GetAnswerDialogAssetbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_AnswerDialogAsset[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> AnswerDialogAssets { get {
  
return Array.AsReadOnly(m_AnswerDialogAsset);
}} 

public int getAnswerDialogIdCount() { return 3; } 
 private string[] m_AnswerDialogId = new string[3];
 public string GetAnswerDialogIdbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_AnswerDialogId[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> AnswerDialogIds { get {
  
return Array.AsReadOnly(m_AnswerDialogId);
}} 

public int getAnswerMonologIdCount() { return 3; } 
 private int[] m_AnswerMonologId = new int[3];
 public int GetAnswerMonologIdbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_AnswerMonologId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> AnswerMonologIds { get {
  
return Array.AsReadOnly(m_AnswerMonologId);
}} 

public int getAnswerNumCount() { return 3; } 
 private int[] m_AnswerNum = new int[3];
 public int GetAnswerNumbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_AnswerNum[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> AnswerNums { get {
  
return Array.AsReadOnly(m_AnswerNum);
}} 

public int getAnswerPersonalityCount() { return 3; } 
 private int[] m_AnswerPersonality = new int[3];
 public int GetAnswerPersonalitybyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_AnswerPersonality[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> AnswerPersonalitys { get {
  
return Array.AsReadOnly(m_AnswerPersonality);
}} 

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_Question;
 public string Question { get{ return m_Question;}}

public static bool LoadTable(Dictionary<int, List<Tab_PersonalityQuestion> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_PersonalityQuestion SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_PersonalityQuestion _values = new Tab_PersonalityQuestion();
 _values.m_AnswerDesc [ 0 ] =  valuesList[(int)_ID.ID_ANSWERDESC_0] as string;
_values.m_AnswerDesc [ 1 ] =  valuesList[(int)_ID.ID_ANSWERDESC_1] as string;
_values.m_AnswerDesc [ 2 ] =  valuesList[(int)_ID.ID_ANSWERDESC_2] as string;
_values.m_AnswerDialogAsset [ 0 ] =  valuesList[(int)_ID.ID_ANSWERDIALOGASSET_0] as string;
_values.m_AnswerDialogAsset [ 1 ] =  valuesList[(int)_ID.ID_ANSWERDIALOGASSET_1] as string;
_values.m_AnswerDialogAsset [ 2 ] =  valuesList[(int)_ID.ID_ANSWERDIALOGASSET_2] as string;
_values.m_AnswerDialogId [ 0 ] =  valuesList[(int)_ID.ID_ANSWERDIALOGID_0] as string;
_values.m_AnswerDialogId [ 1 ] =  valuesList[(int)_ID.ID_ANSWERDIALOGID_1] as string;
_values.m_AnswerDialogId [ 2 ] =  valuesList[(int)_ID.ID_ANSWERDIALOGID_2] as string;
_values.m_AnswerMonologId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ANSWERMONOLOGID_0] as string);
_values.m_AnswerMonologId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ANSWERMONOLOGID_1] as string);
_values.m_AnswerMonologId [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ANSWERMONOLOGID_2] as string);
_values.m_AnswerNum [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ANSWERNUM_0] as string);
_values.m_AnswerNum [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ANSWERNUM_1] as string);
_values.m_AnswerNum [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ANSWERNUM_2] as string);
_values.m_AnswerPersonality [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ANSWERPERSONALITY_0] as string);
_values.m_AnswerPersonality [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ANSWERPERSONALITY_1] as string);
_values.m_AnswerPersonality [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ANSWERPERSONALITY_2] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Question =  valuesList[(int)_ID.ID_QUESTION] as string;

 return _values; }


}
}

