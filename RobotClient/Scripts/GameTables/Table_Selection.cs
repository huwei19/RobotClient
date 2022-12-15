//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_Selection
{ private const string TAB_FILE_DATA = "Table/Selection.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_BRANCHID_0=2,
ID_BRANCHCONTENT_0,
ID_BRANCHBGM_0,
ID_BRANCHAUDIO_0,
ID_BRANCHENDINGNOTICE_0,
ID_BRANCHID_1,
ID_BRANCHCONTENT_1,
ID_BRANCHBGM_1,
ID_BRANCHAUDIO_1,
ID_BRANCHENDINGNOTICE_1,
ID_BRANCHID_2,
ID_BRANCHCONTENT_2,
ID_BRANCHBGM_2,
ID_BRANCHAUDIO_2,
ID_BRANCHENDINGNOTICE_2,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

public int getBranchAudioCount() { return 3; } 
 private int[] m_BranchAudio = new int[3];
 public int GetBranchAudiobyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_BranchAudio[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> BranchAudios { get {
  
return Array.AsReadOnly(m_BranchAudio);
}} 

public int getBranchBGMCount() { return 3; } 
 private int[] m_BranchBGM = new int[3];
 public int GetBranchBGMbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_BranchBGM[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> BranchBGMs { get {
  
return Array.AsReadOnly(m_BranchBGM);
}} 

public int getBranchContentCount() { return 3; } 
 private string[] m_BranchContent = new string[3];
 public string GetBranchContentbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_BranchContent[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> BranchContents { get {
  
return Array.AsReadOnly(m_BranchContent);
}} 

public int getBranchEndingNoticeCount() { return 3; } 
 private int[] m_BranchEndingNotice = new int[3];
 public int GetBranchEndingNoticebyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_BranchEndingNotice[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> BranchEndingNotices { get {
  
return Array.AsReadOnly(m_BranchEndingNotice);
}} 

public int getBranchIdCount() { return 3; } 
 private string[] m_BranchId = new string[3];
 public string GetBranchIdbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_BranchId[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> BranchIds { get {
  
return Array.AsReadOnly(m_BranchId);
}} 

private int m_Id;
 public int Id { get{ return m_Id;}}

public static bool LoadTable(Dictionary<int, List<Tab_Selection> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_Selection SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_Selection _values = new Tab_Selection();
 _values.m_BranchAudio [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_BRANCHAUDIO_0] as string);
_values.m_BranchAudio [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_BRANCHAUDIO_1] as string);
_values.m_BranchAudio [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_BRANCHAUDIO_2] as string);
_values.m_BranchBGM [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_BRANCHBGM_0] as string);
_values.m_BranchBGM [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_BRANCHBGM_1] as string);
_values.m_BranchBGM [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_BRANCHBGM_2] as string);
_values.m_BranchContent [ 0 ] =  valuesList[(int)_ID.ID_BRANCHCONTENT_0] as string;
_values.m_BranchContent [ 1 ] =  valuesList[(int)_ID.ID_BRANCHCONTENT_1] as string;
_values.m_BranchContent [ 2 ] =  valuesList[(int)_ID.ID_BRANCHCONTENT_2] as string;
_values.m_BranchEndingNotice [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_BRANCHENDINGNOTICE_0] as string);
_values.m_BranchEndingNotice [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_BRANCHENDINGNOTICE_1] as string);
_values.m_BranchEndingNotice [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_BRANCHENDINGNOTICE_2] as string);
_values.m_BranchId [ 0 ] =  valuesList[(int)_ID.ID_BRANCHID_0] as string;
_values.m_BranchId [ 1 ] =  valuesList[(int)_ID.ID_BRANCHID_1] as string;
_values.m_BranchId [ 2 ] =  valuesList[(int)_ID.ID_BRANCHID_2] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);

 return _values; }


}
}

