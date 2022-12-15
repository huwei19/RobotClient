//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_PlotInteraction
{ private const string TAB_FILE_DATA = "Table/PlotInteraction.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_SCENEOBJECTID=2,
ID_DEFAULTACTIONID,
ID_CHAPTERID_0,
ID_ACTIONID_0,
ID_CHAPTERID_1,
ID_ACTIONID_1,
ID_CHAPTERID_2,
ID_ACTIONID_2,
ID_CHAPTERID_3,
ID_ACTIONID_3,
ID_CHAPTERID_4,
ID_ACTIONID_4,
ID_CHAPTERID_5,
ID_ACTIONID_5,
ID_CHAPTERID_6,
ID_ACTIONID_6,
ID_CHAPTERID_7,
ID_ACTIONID_7,
ID_CHAPTERID_8,
ID_ACTIONID_8,
ID_CHAPTERID_9,
ID_ACTIONID_9,
ID_CHAPTERID_10,
ID_ACTIONID_10,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

public int getActionIdCount() { return 11; } 
 private int[] m_ActionId = new int[11];
 public int GetActionIdbyIndex(int idx) {
 if(idx>=0 && idx<11) {
 return m_ActionId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> ActionIds { get {
  
return Array.AsReadOnly(m_ActionId);
}} 

public int getChapterIdCount() { return 11; } 
 private int[] m_ChapterId = new int[11];
 public int GetChapterIdbyIndex(int idx) {
 if(idx>=0 && idx<11) {
 return m_ChapterId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> ChapterIds { get {
  
return Array.AsReadOnly(m_ChapterId);
}} 

private int m_DefaultActionId;
 public int DefaultActionId { get{ return m_DefaultActionId;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_SceneObjectId;
 public int SceneObjectId { get{ return m_SceneObjectId;}}

public static bool LoadTable(Dictionary<int, List<Tab_PlotInteraction> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_PlotInteraction SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_PlotInteraction _values = new Tab_PlotInteraction();
 _values.m_ActionId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIONID_0] as string);
_values.m_ActionId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIONID_1] as string);
_values.m_ActionId [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIONID_2] as string);
_values.m_ActionId [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIONID_3] as string);
_values.m_ActionId [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIONID_4] as string);
_values.m_ActionId [ 5 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIONID_5] as string);
_values.m_ActionId [ 6 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIONID_6] as string);
_values.m_ActionId [ 7 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIONID_7] as string);
_values.m_ActionId [ 8 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIONID_8] as string);
_values.m_ActionId [ 9 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIONID_9] as string);
_values.m_ActionId [ 10 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIONID_10] as string);
_values.m_ChapterId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHAPTERID_0] as string);
_values.m_ChapterId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHAPTERID_1] as string);
_values.m_ChapterId [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHAPTERID_2] as string);
_values.m_ChapterId [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHAPTERID_3] as string);
_values.m_ChapterId [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHAPTERID_4] as string);
_values.m_ChapterId [ 5 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHAPTERID_5] as string);
_values.m_ChapterId [ 6 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHAPTERID_6] as string);
_values.m_ChapterId [ 7 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHAPTERID_7] as string);
_values.m_ChapterId [ 8 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHAPTERID_8] as string);
_values.m_ChapterId [ 9 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHAPTERID_9] as string);
_values.m_ChapterId [ 10 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHAPTERID_10] as string);
_values.m_DefaultActionId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DEFAULTACTIONID] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_SceneObjectId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SCENEOBJECTID] as string);

 return _values; }


}
}

