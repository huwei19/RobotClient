//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_CardLevel
{ private const string TAB_FILE_DATA = "Table/CardLevel.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_EXP=2,
ID_INTIMACY,
ID_ALBUMEXPITEMNUM,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_AlbumExpItemNum;
 public int AlbumExpItemNum { get{ return m_AlbumExpItemNum;}}

private int m_Exp;
 public int Exp { get{ return m_Exp;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_Intimacy;
 public int Intimacy { get{ return m_Intimacy;}}

public static bool LoadTable(Dictionary<int, List<Tab_CardLevel> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_CardLevel SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_CardLevel _values = new Tab_CardLevel();
 _values.m_AlbumExpItemNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ALBUMEXPITEMNUM] as string);
_values.m_Exp =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_EXP] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Intimacy =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_INTIMACY] as string);

 return _values; }


}
}

