//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_StoryLine
{ private const string TAB_FILE_DATA = "Table/StoryLine.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NAME=2,
ID_RESID,
ID_TYPE,
ID_TIMERANGE,
ID_INITIALCHAPTER,
ID_CANQUICKSTART,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_CanQuickStart;
 public int CanQuickStart { get{ return m_CanQuickStart;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_InitialChapter;
 public int InitialChapter { get{ return m_InitialChapter;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private string m_ResId;
 public string ResId { get{ return m_ResId;}}

private int m_TimeRange;
 public int TimeRange { get{ return m_TimeRange;}}

private int m_Type;
 public int Type { get{ return m_Type;}}

public static bool LoadTable(Dictionary<int, List<Tab_StoryLine> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_StoryLine SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_StoryLine _values = new Tab_StoryLine();
 _values.m_CanQuickStart =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CANQUICKSTART] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_InitialChapter =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_INITIALCHAPTER] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_ResId =  valuesList[(int)_ID.ID_RESID] as string;
_values.m_TimeRange =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TIMERANGE] as string);
_values.m_Type =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TYPE] as string);

 return _values; }


}
}

