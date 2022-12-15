//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_DrawCardAdvanceCardWeight
{ private const string TAB_FILE_DATA = "table/DrawCardAdvanceCardWeight.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_CARDID=2,
ID_WEIGHT,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_CardId;
 public int CardId { get{ return m_CardId;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_Weight;
 public int Weight { get{ return m_Weight;}}

public static bool LoadTable(Dictionary<int, List<Tab_DrawCardAdvanceCardWeight> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_DrawCardAdvanceCardWeight SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_DrawCardAdvanceCardWeight _values = new Tab_DrawCardAdvanceCardWeight();
 _values.m_CardId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CARDID] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Weight =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_WEIGHT] as string);

 return _values; }


}
}

