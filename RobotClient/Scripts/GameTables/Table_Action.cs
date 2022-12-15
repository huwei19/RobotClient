//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_Action
{ private const string TAB_FILE_DATA = "Table/Action.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_PLAYABLETYPE_0=2,
ID_PLAYABLEID_0,
ID_PLAYABLEDELAYTIME_0,
ID_PLAYABLETYPE_1,
ID_PLAYABLEID_1,
ID_PLAYABLEDELAYTIME_1,
ID_PLAYABLETYPE_2,
ID_PLAYABLEID_2,
ID_PLAYABLEDELAYTIME_2,
ID_PLAYABLETYPE_3,
ID_PLAYABLEID_3,
ID_PLAYABLEDELAYTIME_3,
ID_PLAYABLETYPE_4,
ID_PLAYABLEID_4,
ID_PLAYABLEDELAYTIME_4,
ID_PLAYABLETYPE_5,
ID_PLAYABLEID_5,
ID_PLAYABLEDELAYTIME_5,
ID_PLAYABLETYPE_6,
ID_PLAYABLEID_6,
ID_PLAYABLEDELAYTIME_6,
ID_PLAYABLETYPE_7,
ID_PLAYABLEID_7,
ID_PLAYABLEDELAYTIME_7,
ID_PLAYABLETYPE_8,
ID_PLAYABLEID_8,
ID_PLAYABLEDELAYTIME_8,
ID_PLAYABLETYPE_9,
ID_PLAYABLEID_9,
ID_PLAYABLEDELAYTIME_9,
ID_NEXT,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_Next;
 public int Next { get{ return m_Next;}}

public int getPlayableDelayTimeCount() { return 10; } 
 private float[] m_PlayableDelayTime = new float[10];
 public float GetPlayableDelayTimebyIndex(int idx) {
 if(idx>=0 && idx<10) {
 return m_PlayableDelayTime[idx]; }
 return 0.0f;
 }
 public ReadOnlyCollection <float> PlayableDelayTimes { get {
  
return Array.AsReadOnly(m_PlayableDelayTime);
}} 

public int getPlayableIdCount() { return 10; } 
 private int[] m_PlayableId = new int[10];
 public int GetPlayableIdbyIndex(int idx) {
 if(idx>=0 && idx<10) {
 return m_PlayableId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> PlayableIds { get {
  
return Array.AsReadOnly(m_PlayableId);
}} 

public int getPlayableTypeCount() { return 10; } 
 private int[] m_PlayableType = new int[10];
 public int GetPlayableTypebyIndex(int idx) {
 if(idx>=0 && idx<10) {
 return m_PlayableType[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> PlayableTypes { get {
  
return Array.AsReadOnly(m_PlayableType);
}} 

public static bool LoadTable(Dictionary<int, List<Tab_Action> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_Action SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_Action _values = new Tab_Action();
 _values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Next =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NEXT] as string);
_values.m_PlayableDelayTime [ 0 ] =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_PLAYABLEDELAYTIME_0] as string );
_values.m_PlayableDelayTime [ 1 ] =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_PLAYABLEDELAYTIME_1] as string );
_values.m_PlayableDelayTime [ 2 ] =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_PLAYABLEDELAYTIME_2] as string );
_values.m_PlayableDelayTime [ 3 ] =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_PLAYABLEDELAYTIME_3] as string );
_values.m_PlayableDelayTime [ 4 ] =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_PLAYABLEDELAYTIME_4] as string );
_values.m_PlayableDelayTime [ 5 ] =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_PLAYABLEDELAYTIME_5] as string );
_values.m_PlayableDelayTime [ 6 ] =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_PLAYABLEDELAYTIME_6] as string );
_values.m_PlayableDelayTime [ 7 ] =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_PLAYABLEDELAYTIME_7] as string );
_values.m_PlayableDelayTime [ 8 ] =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_PLAYABLEDELAYTIME_8] as string );
_values.m_PlayableDelayTime [ 9 ] =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_PLAYABLEDELAYTIME_9] as string );
_values.m_PlayableId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PLAYABLEID_0] as string);
_values.m_PlayableId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PLAYABLEID_1] as string);
_values.m_PlayableId [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PLAYABLEID_2] as string);
_values.m_PlayableId [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PLAYABLEID_3] as string);
_values.m_PlayableId [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PLAYABLEID_4] as string);
_values.m_PlayableId [ 5 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PLAYABLEID_5] as string);
_values.m_PlayableId [ 6 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PLAYABLEID_6] as string);
_values.m_PlayableId [ 7 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PLAYABLEID_7] as string);
_values.m_PlayableId [ 8 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PLAYABLEID_8] as string);
_values.m_PlayableId [ 9 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PLAYABLEID_9] as string);
_values.m_PlayableType [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PLAYABLETYPE_0] as string);
_values.m_PlayableType [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PLAYABLETYPE_1] as string);
_values.m_PlayableType [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PLAYABLETYPE_2] as string);
_values.m_PlayableType [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PLAYABLETYPE_3] as string);
_values.m_PlayableType [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PLAYABLETYPE_4] as string);
_values.m_PlayableType [ 5 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PLAYABLETYPE_5] as string);
_values.m_PlayableType [ 6 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PLAYABLETYPE_6] as string);
_values.m_PlayableType [ 7 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PLAYABLETYPE_7] as string);
_values.m_PlayableType [ 8 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PLAYABLETYPE_8] as string);
_values.m_PlayableType [ 9 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PLAYABLETYPE_9] as string);

 return _values; }


}
}

