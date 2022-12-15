//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_Card
{ private const string TAB_FILE_DATA = "Table/Card.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NAME=2,
ID_LNAME,
ID_ENGLISHNAME,
ID_CV,
ID_TTS,
ID_DIALOGFORINVESTIGATE,
ID_CHARACTERID,
ID_TYPE,
ID_FATELINE,
ID_QUALITY,
ID_LEVEL,
ID_STAR,
ID_STARMAX,
ID_ITEMID,
ID_PIECEITEMID,
ID_ALBUMCARDID,
ID_ALBUMAWARDITEMID,
ID_ALBUMAWARDITEMNUM,
ID_PROSTAR,
ID_FRAMESTAR,
ID_PERSONALITY,
ID_SHAREREWARDTYPE,
ID_SHAREREWARDNUM,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_AlbumAwardItemId;
 public int AlbumAwardItemId { get{ return m_AlbumAwardItemId;}}

private int m_AlbumAwardItemNum;
 public int AlbumAwardItemNum { get{ return m_AlbumAwardItemNum;}}

private int m_AlbumCardId;
 public int AlbumCardId { get{ return m_AlbumCardId;}}

private int m_CharacterId;
 public int CharacterId { get{ return m_CharacterId;}}

private string m_Cv;
 public string Cv { get{ return m_Cv;}}

private string m_DialogForInvestigate;
 public string DialogForInvestigate { get{ return m_DialogForInvestigate;}}

private string m_EnglishName;
 public string EnglishName { get{ return m_EnglishName;}}

private int m_FateLine;
 public int FateLine { get{ return m_FateLine;}}

private int m_FrameStar;
 public int FrameStar { get{ return m_FrameStar;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_ItemId;
 public int ItemId { get{ return m_ItemId;}}

private string m_LName;
 public string LName { get{ return m_LName;}}

private int m_Level;
 public int Level { get{ return m_Level;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private int m_Personality;
 public int Personality { get{ return m_Personality;}}

private int m_PieceItemId;
 public int PieceItemId { get{ return m_PieceItemId;}}

private int m_ProStar;
 public int ProStar { get{ return m_ProStar;}}

private int m_Quality;
 public int Quality { get{ return m_Quality;}}

private int m_ShareRewardNum;
 public int ShareRewardNum { get{ return m_ShareRewardNum;}}

private int m_ShareRewardType;
 public int ShareRewardType { get{ return m_ShareRewardType;}}

private int m_Star;
 public int Star { get{ return m_Star;}}

private int m_StarMax;
 public int StarMax { get{ return m_StarMax;}}

private string m_Tts;
 public string Tts { get{ return m_Tts;}}

private int m_Type;
 public int Type { get{ return m_Type;}}

public static bool LoadTable(Dictionary<int, List<Tab_Card> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_Card SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_Card _values = new Tab_Card();
 _values.m_AlbumAwardItemId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ALBUMAWARDITEMID] as string);
_values.m_AlbumAwardItemNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ALBUMAWARDITEMNUM] as string);
_values.m_AlbumCardId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ALBUMCARDID] as string);
_values.m_CharacterId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHARACTERID] as string);
_values.m_Cv =  valuesList[(int)_ID.ID_CV] as string;
_values.m_DialogForInvestigate =  valuesList[(int)_ID.ID_DIALOGFORINVESTIGATE] as string;
_values.m_EnglishName =  valuesList[(int)_ID.ID_ENGLISHNAME] as string;
_values.m_FateLine =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FATELINE] as string);
_values.m_FrameStar =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FRAMESTAR] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_ItemId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMID] as string);
_values.m_LName =  valuesList[(int)_ID.ID_LNAME] as string;
_values.m_Level =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LEVEL] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_Personality =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PERSONALITY] as string);
_values.m_PieceItemId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PIECEITEMID] as string);
_values.m_ProStar =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PROSTAR] as string);
_values.m_Quality =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_QUALITY] as string);
_values.m_ShareRewardNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SHAREREWARDNUM] as string);
_values.m_ShareRewardType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SHAREREWARDTYPE] as string);
_values.m_Star =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_STAR] as string);
_values.m_StarMax =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_STARMAX] as string);
_values.m_Tts =  valuesList[(int)_ID.ID_TTS] as string;
_values.m_Type =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TYPE] as string);

 return _values; }


}
}

