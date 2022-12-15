//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_EffectAsset
{ private const string TAB_FILE_DATA = "Table/EffectAsset.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_TYPE=2,
ID_NAME,
ID_ISACTIVE,
ID_HIGHLOCK,
ID_MEDIUMLOCK,
ID_LOWLOCK,
ID_AUDIOTYPE_0,
ID_AUDIOID_0,
ID_AUDIODELAY_0,
ID_AUDIOTYPE_1,
ID_AUDIOID_1,
ID_AUDIODELAY_1,
ID_AUDIOTYPE_2,
ID_AUDIOID_2,
ID_AUDIODELAY_2,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

public int getAudioDelayCount() { return 3; } 
 private float[] m_AudioDelay = new float[3];
 public float GetAudioDelaybyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_AudioDelay[idx]; }
 return 0.0f;
 }
 public ReadOnlyCollection <float> AudioDelays { get {
  
return Array.AsReadOnly(m_AudioDelay);
}} 

public int getAudioIdCount() { return 3; } 
 private int[] m_AudioId = new int[3];
 public int GetAudioIdbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_AudioId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> AudioIds { get {
  
return Array.AsReadOnly(m_AudioId);
}} 

public int getAudioTypeCount() { return 3; } 
 private int[] m_AudioType = new int[3];
 public int GetAudioTypebyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_AudioType[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> AudioTypes { get {
  
return Array.AsReadOnly(m_AudioType);
}} 

private int m_HighLock;
 public int HighLock { get{ return m_HighLock;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_IsActive;
 public int IsActive { get{ return m_IsActive;}}

private int m_LowLock;
 public int LowLock { get{ return m_LowLock;}}

private int m_MediumLock;
 public int MediumLock { get{ return m_MediumLock;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private int m_Type;
 public int Type { get{ return m_Type;}}

public static bool LoadTable(Dictionary<int, List<Tab_EffectAsset> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_EffectAsset SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_EffectAsset _values = new Tab_EffectAsset();
 _values.m_AudioDelay [ 0 ] =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_AUDIODELAY_0] as string );
_values.m_AudioDelay [ 1 ] =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_AUDIODELAY_1] as string );
_values.m_AudioDelay [ 2 ] =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_AUDIODELAY_2] as string );
_values.m_AudioId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AUDIOID_0] as string);
_values.m_AudioId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AUDIOID_1] as string);
_values.m_AudioId [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AUDIOID_2] as string);
_values.m_AudioType [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AUDIOTYPE_0] as string);
_values.m_AudioType [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AUDIOTYPE_1] as string);
_values.m_AudioType [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AUDIOTYPE_2] as string);
_values.m_HighLock =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HIGHLOCK] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_IsActive =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISACTIVE] as string);
_values.m_LowLock =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LOWLOCK] as string);
_values.m_MediumLock =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MEDIUMLOCK] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_Type =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TYPE] as string);

 return _values; }


}
}

