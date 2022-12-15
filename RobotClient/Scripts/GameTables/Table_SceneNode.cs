//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_SceneNode
{ private const string TAB_FILE_DATA = "Table/SceneNode.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_WEATHER=2,
ID_GEOGRAPHIC,
ID_CAMERAID,
ID_TIMERANGE,
ID_AUDIOID_0,
ID_AUDIOLOGIC_1,
ID_AUDIOID_1,
ID_AUDIOLOGIC_2,
ID_AUDIOID_2,
ID_AUDIOLOGIC_3,
ID_BACKGROUND,
ID_INITIALSCENE,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

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

public int getAudioLogicCount() { return 3; } 
 private int[] m_AudioLogic = new int[3];
 public int GetAudioLogicbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_AudioLogic[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> AudioLogics { get {
  
return Array.AsReadOnly(m_AudioLogic);
}} 

private int m_Background;
 public int Background { get{ return m_Background;}}

private int m_CameraId;
 public int CameraId { get{ return m_CameraId;}}

private int m_Geographic;
 public int Geographic { get{ return m_Geographic;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_Initialscene;
 public int Initialscene { get{ return m_Initialscene;}}

private int m_TimeRange;
 public int TimeRange { get{ return m_TimeRange;}}

private int m_Weather;
 public int Weather { get{ return m_Weather;}}

public static bool LoadTable(Dictionary<int, List<Tab_SceneNode> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_SceneNode SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_SceneNode _values = new Tab_SceneNode();
 _values.m_AudioId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AUDIOID_0] as string);
_values.m_AudioId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AUDIOID_1] as string);
_values.m_AudioId [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AUDIOID_2] as string);
_values.m_AudioLogic [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AUDIOLOGIC_1] as string);
_values.m_AudioLogic [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AUDIOLOGIC_2] as string);
_values.m_AudioLogic [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AUDIOLOGIC_3] as string);
_values.m_Background =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_BACKGROUND] as string);
_values.m_CameraId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CAMERAID] as string);
_values.m_Geographic =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GEOGRAPHIC] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Initialscene =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_INITIALSCENE] as string);
_values.m_TimeRange =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TIMERANGE] as string);
_values.m_Weather =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_WEATHER] as string);

 return _values; }


}
}

