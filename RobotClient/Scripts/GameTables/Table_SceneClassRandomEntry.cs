//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_SceneClassRandomEntry
{ private const string TAB_FILE_DATA = "Table/SceneClassRandomEntry.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_DEFAULTENTRYX_0=2,
ID_DEFAULTENTRYZ_0,
ID_DEFAULTENTRYX_1,
ID_DEFAULTENTRYZ_1,
ID_DEFAULTENTRYX_2,
ID_DEFAULTENTRYZ_2,
ID_DEFAULTENTRYX_3,
ID_DEFAULTENTRYZ_3,
ID_DEFAULTENTRYX_4,
ID_DEFAULTENTRYZ_4,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

public int getDefaultEntryXCount() { return 5; } 
 private float[] m_DefaultEntryX = new float[5];
 public float GetDefaultEntryXbyIndex(int idx) {
 if(idx>=0 && idx<5) {
 return m_DefaultEntryX[idx]; }
 return 0.0f;
 }
 public ReadOnlyCollection <float> DefaultEntryXs { get {
  
return Array.AsReadOnly(m_DefaultEntryX);
}} 

public int getDefaultEntryZCount() { return 5; } 
 private float[] m_DefaultEntryZ = new float[5];
 public float GetDefaultEntryZbyIndex(int idx) {
 if(idx>=0 && idx<5) {
 return m_DefaultEntryZ[idx]; }
 return 0.0f;
 }
 public ReadOnlyCollection <float> DefaultEntryZs { get {
  
return Array.AsReadOnly(m_DefaultEntryZ);
}} 

private int m_Id;
 public int Id { get{ return m_Id;}}

public static bool LoadTable(Dictionary<int, List<Tab_SceneClassRandomEntry> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_SceneClassRandomEntry SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_SceneClassRandomEntry _values = new Tab_SceneClassRandomEntry();
 _values.m_DefaultEntryX [ 0 ] =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_DEFAULTENTRYX_0] as string );
_values.m_DefaultEntryX [ 1 ] =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_DEFAULTENTRYX_1] as string );
_values.m_DefaultEntryX [ 2 ] =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_DEFAULTENTRYX_2] as string );
_values.m_DefaultEntryX [ 3 ] =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_DEFAULTENTRYX_3] as string );
_values.m_DefaultEntryX [ 4 ] =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_DEFAULTENTRYX_4] as string );
_values.m_DefaultEntryZ [ 0 ] =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_DEFAULTENTRYZ_0] as string );
_values.m_DefaultEntryZ [ 1 ] =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_DEFAULTENTRYZ_1] as string );
_values.m_DefaultEntryZ [ 2 ] =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_DEFAULTENTRYZ_2] as string );
_values.m_DefaultEntryZ [ 3 ] =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_DEFAULTENTRYZ_3] as string );
_values.m_DefaultEntryZ [ 4 ] =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_DEFAULTENTRYZ_4] as string );
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);

 return _values; }


}
}

