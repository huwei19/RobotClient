//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_AlbumStorySub
{ private const string TAB_FILE_DATA = "Table/AlbumStorySub.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_ALBUMSTORYID=2,
ID_NAME,
ID_NEEDRANK,
ID_NEEDCHARACTER,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_AlbumStoryId;
 public int AlbumStoryId { get{ return m_AlbumStoryId;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private int m_NeedCharacter;
 public int NeedCharacter { get{ return m_NeedCharacter;}}

private int m_NeedRank;
 public int NeedRank { get{ return m_NeedRank;}}

public static bool LoadTable(Dictionary<int, List<Tab_AlbumStorySub> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_AlbumStorySub SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_AlbumStorySub _values = new Tab_AlbumStorySub();
 _values.m_AlbumStoryId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ALBUMSTORYID] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_NeedCharacter =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NEEDCHARACTER] as string);
_values.m_NeedRank =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NEEDRANK] as string);

 return _values; }


}
}

