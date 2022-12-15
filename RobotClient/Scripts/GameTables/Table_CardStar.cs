//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_CardStar
{ private const string TAB_FILE_DATA = "Table/CardStar.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_LEVELMIN=2,
ID_LEVELMAX,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_LevelMax;
 public int LevelMax { get{ return m_LevelMax;}}

private int m_LevelMin;
 public int LevelMin { get{ return m_LevelMin;}}

public static bool LoadTable(Dictionary<int, List<Tab_CardStar> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_CardStar SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_CardStar _values = new Tab_CardStar();
 _values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_LevelMax =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LEVELMAX] as string);
_values.m_LevelMin =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LEVELMIN] as string);

 return _values; }


}
}

