//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_BuyGold
{ private const string TAB_FILE_DATA = "Table/BuyGold.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_DIAMOND=2,
ID_GOLDCOIN,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Diamond;
 public int Diamond { get{ return m_Diamond;}}

private int m_GoldCoin;
 public int GoldCoin { get{ return m_GoldCoin;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

public static bool LoadTable(Dictionary<int, List<Tab_BuyGold> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_BuyGold SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_BuyGold _values = new Tab_BuyGold();
 _values.m_Diamond =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DIAMOND] as string);
_values.m_GoldCoin =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GOLDCOIN] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);

 return _values; }


}
}

