//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_PuzzleLevelData
{ private const string TAB_FILE_DATA = "Table/PuzzleLevelData.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_STACONSUME=2,
ID_NORMAL_0,
ID_NORMAL_1,
ID_NORMAL_2,
ID_NORMAL_3,
ID_NORMAL_4,
ID_NORMAL_5,
ID_CRITICALID_0,
ID_CRITICALHIDDENID_0,
ID_CRITICALNAME_0,
ID_CRITICALBRANCHNAME_0,
ID_CRITICALSECTIONID_0,
ID_CRITICALID_1,
ID_CRITICALHIDDENID_1,
ID_CRITICALNAME_1,
ID_CRITICALBRANCHNAME_1,
ID_CRITICALSECTIONID_1,
ID_CRITICALID_2,
ID_CRITICALHIDDENID_2,
ID_CRITICALNAME_2,
ID_CRITICALBRANCHNAME_2,
ID_CRITICALSECTIONID_2,
ID_CRITICALID_3,
ID_CRITICALHIDDENID_3,
ID_CRITICALNAME_3,
ID_CRITICALBRANCHNAME_3,
ID_CRITICALSECTIONID_3,
ID_PLACEHOLDER,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

public int getCriticalBranchNameCount() { return 4; } 
 private string[] m_CriticalBranchName = new string[4];
 public string GetCriticalBranchNamebyIndex(int idx) {
 if(idx>=0 && idx<4) {
 return m_CriticalBranchName[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> CriticalBranchNames { get {
  
return Array.AsReadOnly(m_CriticalBranchName);
}} 

public int getCriticalHiddenIdCount() { return 4; } 
 private int[] m_CriticalHiddenId = new int[4];
 public int GetCriticalHiddenIdbyIndex(int idx) {
 if(idx>=0 && idx<4) {
 return m_CriticalHiddenId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> CriticalHiddenIds { get {
  
return Array.AsReadOnly(m_CriticalHiddenId);
}} 

public int getCriticalIdCount() { return 4; } 
 private int[] m_CriticalId = new int[4];
 public int GetCriticalIdbyIndex(int idx) {
 if(idx>=0 && idx<4) {
 return m_CriticalId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> CriticalIds { get {
  
return Array.AsReadOnly(m_CriticalId);
}} 

public int getCriticalNameCount() { return 4; } 
 private string[] m_CriticalName = new string[4];
 public string GetCriticalNamebyIndex(int idx) {
 if(idx>=0 && idx<4) {
 return m_CriticalName[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> CriticalNames { get {
  
return Array.AsReadOnly(m_CriticalName);
}} 

public int getCriticalSectionIdCount() { return 4; } 
 private int[] m_CriticalSectionId = new int[4];
 public int GetCriticalSectionIdbyIndex(int idx) {
 if(idx>=0 && idx<4) {
 return m_CriticalSectionId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> CriticalSectionIds { get {
  
return Array.AsReadOnly(m_CriticalSectionId);
}} 

private int m_Id;
 public int Id { get{ return m_Id;}}

public int getNormalCount() { return 6; } 
 private int[] m_Normal = new int[6];
 public int GetNormalbyIndex(int idx) {
 if(idx>=0 && idx<6) {
 return m_Normal[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> Normals { get {
  
return Array.AsReadOnly(m_Normal);
}} 

private int m_PlaceHolder;
 public int PlaceHolder { get{ return m_PlaceHolder;}}

private int m_StaConsume;
 public int StaConsume { get{ return m_StaConsume;}}

public static bool LoadTable(Dictionary<int, List<Tab_PuzzleLevelData> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_PuzzleLevelData SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_PuzzleLevelData _values = new Tab_PuzzleLevelData();
 _values.m_CriticalBranchName [ 0 ] =  valuesList[(int)_ID.ID_CRITICALBRANCHNAME_0] as string;
_values.m_CriticalBranchName [ 1 ] =  valuesList[(int)_ID.ID_CRITICALBRANCHNAME_1] as string;
_values.m_CriticalBranchName [ 2 ] =  valuesList[(int)_ID.ID_CRITICALBRANCHNAME_2] as string;
_values.m_CriticalBranchName [ 3 ] =  valuesList[(int)_ID.ID_CRITICALBRANCHNAME_3] as string;
_values.m_CriticalHiddenId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CRITICALHIDDENID_0] as string);
_values.m_CriticalHiddenId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CRITICALHIDDENID_1] as string);
_values.m_CriticalHiddenId [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CRITICALHIDDENID_2] as string);
_values.m_CriticalHiddenId [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CRITICALHIDDENID_3] as string);
_values.m_CriticalId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CRITICALID_0] as string);
_values.m_CriticalId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CRITICALID_1] as string);
_values.m_CriticalId [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CRITICALID_2] as string);
_values.m_CriticalId [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CRITICALID_3] as string);
_values.m_CriticalName [ 0 ] =  valuesList[(int)_ID.ID_CRITICALNAME_0] as string;
_values.m_CriticalName [ 1 ] =  valuesList[(int)_ID.ID_CRITICALNAME_1] as string;
_values.m_CriticalName [ 2 ] =  valuesList[(int)_ID.ID_CRITICALNAME_2] as string;
_values.m_CriticalName [ 3 ] =  valuesList[(int)_ID.ID_CRITICALNAME_3] as string;
_values.m_CriticalSectionId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CRITICALSECTIONID_0] as string);
_values.m_CriticalSectionId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CRITICALSECTIONID_1] as string);
_values.m_CriticalSectionId [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CRITICALSECTIONID_2] as string);
_values.m_CriticalSectionId [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CRITICALSECTIONID_3] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Normal [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NORMAL_0] as string);
_values.m_Normal [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NORMAL_1] as string);
_values.m_Normal [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NORMAL_2] as string);
_values.m_Normal [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NORMAL_3] as string);
_values.m_Normal [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NORMAL_4] as string);
_values.m_Normal [ 5 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NORMAL_5] as string);
_values.m_PlaceHolder =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PLACEHOLDER] as string);
_values.m_StaConsume =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_STACONSUME] as string);

 return _values; }


}
}

