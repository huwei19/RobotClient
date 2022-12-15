//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_DrawCardNormalCard
{ private const string TAB_FILE_DATA = "Table/DrawCardNormalCard.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_CARDID=2,
ID_POTID,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_CardId;
 public int CardId { get{ return m_CardId;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_PotId;
 public int PotId { get{ return m_PotId;}}

public static bool LoadTable(Dictionary<int, List<Tab_DrawCardNormalCard> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_DrawCardNormalCard SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_DrawCardNormalCard _values = new Tab_DrawCardNormalCard();
 _values.m_CardId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CARDID] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_PotId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_POTID] as string);

 return _values; }


}
}

