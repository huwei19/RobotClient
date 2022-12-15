//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_MainSceneTimeSceneEnv
{ private const string TAB_FILE_DATA = "Table/MainSceneTimeSceneEnv.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_BEGINTIME=2,
ID_ENDTIME,
ID_ENV_1,
ID_ENV_2,
ID_LOADINGMUSIC_1,
ID_LOADINGMUSIC_2,
ID_LOADINGSOUND_1,
ID_LOADINGSOUND_2,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private string m_BeginTime;
 public string BeginTime { get{ return m_BeginTime;}}

private string m_EndTime;
 public string EndTime { get{ return m_EndTime;}}

public int getEnvCount() { return 2; } 
 private string[] m_Env = new string[2];
 public string GetEnvbyIndex(int idx) {
 if(idx>=0 && idx<2) {
 return m_Env[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> Envs { get {
  
return Array.AsReadOnly(m_Env);
}} 

private int m_Id;
 public int Id { get{ return m_Id;}}

public int getLoadingMusicCount() { return 2; } 
 private int[] m_LoadingMusic = new int[2];
 public int GetLoadingMusicbyIndex(int idx) {
 if(idx>=0 && idx<2) {
 return m_LoadingMusic[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> LoadingMusics { get {
  
return Array.AsReadOnly(m_LoadingMusic);
}} 

public int getLoadingSoundCount() { return 2; } 
 private int[] m_LoadingSound = new int[2];
 public int GetLoadingSoundbyIndex(int idx) {
 if(idx>=0 && idx<2) {
 return m_LoadingSound[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> LoadingSounds { get {
  
return Array.AsReadOnly(m_LoadingSound);
}} 

public static bool LoadTable(Dictionary<int, List<Tab_MainSceneTimeSceneEnv> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_MainSceneTimeSceneEnv SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_MainSceneTimeSceneEnv _values = new Tab_MainSceneTimeSceneEnv();
 _values.m_BeginTime =  valuesList[(int)_ID.ID_BEGINTIME] as string;
_values.m_EndTime =  valuesList[(int)_ID.ID_ENDTIME] as string;
_values.m_Env [ 0 ] =  valuesList[(int)_ID.ID_ENV_1] as string;
_values.m_Env [ 1 ] =  valuesList[(int)_ID.ID_ENV_2] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_LoadingMusic [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LOADINGMUSIC_1] as string);
_values.m_LoadingMusic [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LOADINGMUSIC_2] as string);
_values.m_LoadingSound [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LOADINGSOUND_1] as string);
_values.m_LoadingSound [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LOADINGSOUND_2] as string);

 return _values; }


}
}

