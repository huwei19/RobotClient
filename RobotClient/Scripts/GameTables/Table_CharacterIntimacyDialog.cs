//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_CharacterIntimacyDialog
{ private const string TAB_FILE_DATA = "Table/CharacterIntimacyDialog.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_DIALOGCONTENT_0=2,
ID_DIALOGEMOTION_0,
ID_DIALOGANIM_0,
ID_VOICEABSTRACT_0,
ID_DIALOGCV_0,
ID_DIALOGCONTENT_1,
ID_DIALOGEMOTION_1,
ID_DIALOGANIM_1,
ID_VOICEABSTRACT_1,
ID_DIALOGCV_1,
ID_DIALOGCONTENT_2,
ID_DIALOGEMOTION_2,
ID_DIALOGANIM_2,
ID_VOICEABSTRACT_2,
ID_DIALOGCV_2,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

public int getDialogAnimCount() { return 3; } 
 private int[] m_DialogAnim = new int[3];
 public int GetDialogAnimbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_DialogAnim[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> DialogAnims { get {
  
return Array.AsReadOnly(m_DialogAnim);
}} 

public int getDialogCVCount() { return 3; } 
 private int[] m_DialogCV = new int[3];
 public int GetDialogCVbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_DialogCV[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> DialogCVs { get {
  
return Array.AsReadOnly(m_DialogCV);
}} 

public int getDialogContentCount() { return 3; } 
 private string[] m_DialogContent = new string[3];
 public string GetDialogContentbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_DialogContent[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> DialogContents { get {
  
return Array.AsReadOnly(m_DialogContent);
}} 

public int getDialogEmotionCount() { return 3; } 
 private int[] m_DialogEmotion = new int[3];
 public int GetDialogEmotionbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_DialogEmotion[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> DialogEmotions { get {
  
return Array.AsReadOnly(m_DialogEmotion);
}} 

private int m_Id;
 public int Id { get{ return m_Id;}}

public int getVoiceAbstractCount() { return 3; } 
 private string[] m_VoiceAbstract = new string[3];
 public string GetVoiceAbstractbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_VoiceAbstract[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> VoiceAbstracts { get {
  
return Array.AsReadOnly(m_VoiceAbstract);
}} 

public static bool LoadTable(Dictionary<int, List<Tab_CharacterIntimacyDialog> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_CharacterIntimacyDialog SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_CharacterIntimacyDialog _values = new Tab_CharacterIntimacyDialog();
 _values.m_DialogAnim [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DIALOGANIM_0] as string);
_values.m_DialogAnim [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DIALOGANIM_1] as string);
_values.m_DialogAnim [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DIALOGANIM_2] as string);
_values.m_DialogCV [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DIALOGCV_0] as string);
_values.m_DialogCV [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DIALOGCV_1] as string);
_values.m_DialogCV [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DIALOGCV_2] as string);
_values.m_DialogContent [ 0 ] =  valuesList[(int)_ID.ID_DIALOGCONTENT_0] as string;
_values.m_DialogContent [ 1 ] =  valuesList[(int)_ID.ID_DIALOGCONTENT_1] as string;
_values.m_DialogContent [ 2 ] =  valuesList[(int)_ID.ID_DIALOGCONTENT_2] as string;
_values.m_DialogEmotion [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DIALOGEMOTION_0] as string);
_values.m_DialogEmotion [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DIALOGEMOTION_1] as string);
_values.m_DialogEmotion [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DIALOGEMOTION_2] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_VoiceAbstract [ 0 ] =  valuesList[(int)_ID.ID_VOICEABSTRACT_0] as string;
_values.m_VoiceAbstract [ 1 ] =  valuesList[(int)_ID.ID_VOICEABSTRACT_1] as string;
_values.m_VoiceAbstract [ 2 ] =  valuesList[(int)_ID.ID_VOICEABSTRACT_2] as string;

 return _values; }


}
}

