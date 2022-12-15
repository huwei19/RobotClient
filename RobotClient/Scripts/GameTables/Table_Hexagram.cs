//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_Hexagram
{ private const string TAB_FILE_DATA = "Table/Hexagram.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_VERSIONNUM=2,
ID_ACTIVITYTID,
ID_INTROACTIONID,
ID_USEITEMID,
ID_USEITEMCOUNT,
ID_MUSICSCORE,
ID_DROPID,
ID_DROPPREVIEWID,
ID_MUSICACTIONID,
ID_MUSICCOUNT,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_ActivitytId;
 public int ActivitytId { get{ return m_ActivitytId;}}

private int m_DropId;
 public int DropId { get{ return m_DropId;}}

private int m_DropPreviewId;
 public int DropPreviewId { get{ return m_DropPreviewId;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_IntroActionId;
 public int IntroActionId { get{ return m_IntroActionId;}}

private int m_MusicActionId;
 public int MusicActionId { get{ return m_MusicActionId;}}

private int m_MusicCount;
 public int MusicCount { get{ return m_MusicCount;}}

private string m_MusicScore;
 public string MusicScore { get{ return m_MusicScore;}}

private int m_UseItemCount;
 public int UseItemCount { get{ return m_UseItemCount;}}

private int m_UseItemId;
 public int UseItemId { get{ return m_UseItemId;}}

private int m_VersionNum;
 public int VersionNum { get{ return m_VersionNum;}}

public static bool LoadTable(Dictionary<int, List<Tab_Hexagram> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_Hexagram SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_Hexagram _values = new Tab_Hexagram();
 _values.m_ActivitytId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIVITYTID] as string);
_values.m_DropId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPID] as string);
_values.m_DropPreviewId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPREVIEWID] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_IntroActionId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_INTROACTIONID] as string);
_values.m_MusicActionId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MUSICACTIONID] as string);
_values.m_MusicCount =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MUSICCOUNT] as string);
_values.m_MusicScore =  valuesList[(int)_ID.ID_MUSICSCORE] as string;
_values.m_UseItemCount =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_USEITEMCOUNT] as string);
_values.m_UseItemId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_USEITEMID] as string);
_values.m_VersionNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_VERSIONNUM] as string);

 return _values; }


}
}

