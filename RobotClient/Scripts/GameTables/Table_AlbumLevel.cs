//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_AlbumLevel
{ private const string TAB_FILE_DATA = "Table/AlbumLevel.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_EXP=2,
ID_LCK,
ID_SPT,
ID_WIS,
ID_STR,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Exp;
 public int Exp { get{ return m_Exp;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_Lck;
 public int Lck { get{ return m_Lck;}}

private int m_Spt;
 public int Spt { get{ return m_Spt;}}

private int m_Str;
 public int Str { get{ return m_Str;}}

private int m_Wis;
 public int Wis { get{ return m_Wis;}}

public static bool LoadTable(Dictionary<int, List<Tab_AlbumLevel> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_AlbumLevel SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_AlbumLevel _values = new Tab_AlbumLevel();
 _values.m_Exp =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_EXP] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Lck =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LCK] as string);
_values.m_Spt =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SPT] as string);
_values.m_Str =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_STR] as string);
_values.m_Wis =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_WIS] as string);

 return _values; }


}
}

