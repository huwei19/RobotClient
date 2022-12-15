//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_ActionReview
{ private const string TAB_FILE_DATA = "Table/ActionReview.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_PAGINGID=2,
ID_TYPE,
ID_PLAYTYPE,
ID_ACTIONID,
ID_CHAPTERID,
ID_RESPATH,
ID_NAME,
ID_SKETCH,
ID_ISFINISH,
ID_ISPICKUPOUTLETSTASK,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_ActionId;
 public int ActionId { get{ return m_ActionId;}}

private int m_ChapterId;
 public int ChapterId { get{ return m_ChapterId;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_IsFinish;
 public int IsFinish { get{ return m_IsFinish;}}

private int m_IsPickUpOutletsTask;
 public int IsPickUpOutletsTask { get{ return m_IsPickUpOutletsTask;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private int m_PagingId;
 public int PagingId { get{ return m_PagingId;}}

private int m_PlayType;
 public int PlayType { get{ return m_PlayType;}}

private string m_ResPath;
 public string ResPath { get{ return m_ResPath;}}

private string m_Sketch;
 public string Sketch { get{ return m_Sketch;}}

private int m_Type;
 public int Type { get{ return m_Type;}}

public static bool LoadTable(Dictionary<int, List<Tab_ActionReview> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_ActionReview SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_ActionReview _values = new Tab_ActionReview();
 _values.m_ActionId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIONID] as string);
_values.m_ChapterId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHAPTERID] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_IsFinish =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISFINISH] as string);
_values.m_IsPickUpOutletsTask =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISPICKUPOUTLETSTASK] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_PagingId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PAGINGID] as string);
_values.m_PlayType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PLAYTYPE] as string);
_values.m_ResPath =  valuesList[(int)_ID.ID_RESPATH] as string;
_values.m_Sketch =  valuesList[(int)_ID.ID_SKETCH] as string;
_values.m_Type =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TYPE] as string);

 return _values; }


}
}

