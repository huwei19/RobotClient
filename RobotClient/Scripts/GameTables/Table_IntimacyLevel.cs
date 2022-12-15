//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_IntimacyLevel
{ private const string TAB_FILE_DATA = "Table/IntimacyLevel.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_INTIMACY=2,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_Intimacy;
 public int Intimacy { get{ return m_Intimacy;}}

public static bool LoadTable(Dictionary<int, List<Tab_IntimacyLevel> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_IntimacyLevel SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_IntimacyLevel _values = new Tab_IntimacyLevel();
 _values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Intimacy =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_INTIMACY] as string);

 return _values; }


}
}

