//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_DrawCardPreview
{ private const string TAB_FILE_DATA = "Table/DrawCardPreview.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_TYPE=2,
ID_SUBTYPE,
ID_BGIMAGE,
ID_CONTENT,
ID_POOLNAME_0,
ID_POOLRATE_0,
ID_POOLID_0,
ID_POOLNAME_1,
ID_POOLRATE_1,
ID_POOLID_1,
ID_POOLNAME_2,
ID_POOLRATE_2,
ID_POOLID_2,
ID_POOLUPNAME_0,
ID_POOLUPRATE_0,
ID_POOLUPID_0,
ID_POOLUPNAME_1,
ID_POOLUPRATE_1,
ID_POOLUPID_1,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private string m_BgImage;
 public string BgImage { get{ return m_BgImage;}}

private string m_Content;
 public string Content { get{ return m_Content;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

public int getPoolIdCount() { return 3; } 
 private int[] m_PoolId = new int[3];
 public int GetPoolIdbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_PoolId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> PoolIds { get {
  
return Array.AsReadOnly(m_PoolId);
}} 

public int getPoolNameCount() { return 3; } 
 private string[] m_PoolName = new string[3];
 public string GetPoolNamebyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_PoolName[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> PoolNames { get {
  
return Array.AsReadOnly(m_PoolName);
}} 

public int getPoolRateCount() { return 3; } 
 private int[] m_PoolRate = new int[3];
 public int GetPoolRatebyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_PoolRate[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> PoolRates { get {
  
return Array.AsReadOnly(m_PoolRate);
}} 

public int getPoolUpIdCount() { return 2; } 
 private int[] m_PoolUpId = new int[2];
 public int GetPoolUpIdbyIndex(int idx) {
 if(idx>=0 && idx<2) {
 return m_PoolUpId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> PoolUpIds { get {
  
return Array.AsReadOnly(m_PoolUpId);
}} 

public int getPoolUpNameCount() { return 2; } 
 private string[] m_PoolUpName = new string[2];
 public string GetPoolUpNamebyIndex(int idx) {
 if(idx>=0 && idx<2) {
 return m_PoolUpName[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> PoolUpNames { get {
  
return Array.AsReadOnly(m_PoolUpName);
}} 

public int getPoolUpRateCount() { return 2; } 
 private int[] m_PoolUpRate = new int[2];
 public int GetPoolUpRatebyIndex(int idx) {
 if(idx>=0 && idx<2) {
 return m_PoolUpRate[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> PoolUpRates { get {
  
return Array.AsReadOnly(m_PoolUpRate);
}} 

private int m_SubType;
 public int SubType { get{ return m_SubType;}}

private int m_Type;
 public int Type { get{ return m_Type;}}

public static bool LoadTable(Dictionary<int, List<Tab_DrawCardPreview> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_DrawCardPreview SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_DrawCardPreview _values = new Tab_DrawCardPreview();
 _values.m_BgImage =  valuesList[(int)_ID.ID_BGIMAGE] as string;
_values.m_Content =  valuesList[(int)_ID.ID_CONTENT] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_PoolId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_POOLID_0] as string);
_values.m_PoolId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_POOLID_1] as string);
_values.m_PoolId [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_POOLID_2] as string);
_values.m_PoolName [ 0 ] =  valuesList[(int)_ID.ID_POOLNAME_0] as string;
_values.m_PoolName [ 1 ] =  valuesList[(int)_ID.ID_POOLNAME_1] as string;
_values.m_PoolName [ 2 ] =  valuesList[(int)_ID.ID_POOLNAME_2] as string;
_values.m_PoolRate [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_POOLRATE_0] as string);
_values.m_PoolRate [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_POOLRATE_1] as string);
_values.m_PoolRate [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_POOLRATE_2] as string);
_values.m_PoolUpId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_POOLUPID_0] as string);
_values.m_PoolUpId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_POOLUPID_1] as string);
_values.m_PoolUpName [ 0 ] =  valuesList[(int)_ID.ID_POOLUPNAME_0] as string;
_values.m_PoolUpName [ 1 ] =  valuesList[(int)_ID.ID_POOLUPNAME_1] as string;
_values.m_PoolUpRate [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_POOLUPRATE_0] as string);
_values.m_PoolUpRate [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_POOLUPRATE_1] as string);
_values.m_SubType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SUBTYPE] as string);
_values.m_Type =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TYPE] as string);

 return _values; }


}
}

