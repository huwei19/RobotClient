//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_HeartBeat
{ private const string TAB_FILE_DATA = "Table/HeartBeat.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_KJNAME=2,
ID_NAME,
ID_SITENAME,
ID_BG,
ID_BGSMALL,
ID_UNLOCKID,
ID_CHARACTERID,
ID_MUSICID,
ID_SOUNDID,
ID_ACBID,
ID_FACIAL,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_AcbId;
 public int AcbId { get{ return m_AcbId;}}

private string m_Bg;
 public string Bg { get{ return m_Bg;}}

private string m_BgSmall;
 public string BgSmall { get{ return m_BgSmall;}}

private int m_CharacterId;
 public int CharacterId { get{ return m_CharacterId;}}

private int m_Facial;
 public int Facial { get{ return m_Facial;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_Kjname;
 public string Kjname { get{ return m_Kjname;}}

private int m_MusicId;
 public int MusicId { get{ return m_MusicId;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private string m_SiteName;
 public string SiteName { get{ return m_SiteName;}}

private int m_SoundId;
 public int SoundId { get{ return m_SoundId;}}

private int m_Unlockid;
 public int Unlockid { get{ return m_Unlockid;}}

public static bool LoadTable(Dictionary<int, List<Tab_HeartBeat> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_HeartBeat SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_HeartBeat _values = new Tab_HeartBeat();
 _values.m_AcbId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACBID] as string);
_values.m_Bg =  valuesList[(int)_ID.ID_BG] as string;
_values.m_BgSmall =  valuesList[(int)_ID.ID_BGSMALL] as string;
_values.m_CharacterId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHARACTERID] as string);
_values.m_Facial =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FACIAL] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Kjname =  valuesList[(int)_ID.ID_KJNAME] as string;
_values.m_MusicId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MUSICID] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_SiteName =  valuesList[(int)_ID.ID_SITENAME] as string;
_values.m_SoundId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SOUNDID] as string);
_values.m_Unlockid =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_UNLOCKID] as string);

 return _values; }


}
}

