//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_BuyStamina
{ private const string TAB_FILE_DATA = "Table/BuyStamina.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_DIAMOND=2,
ID_STAMINA,
ID_CONFIDENCE,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Confidence;
 public int Confidence { get{ return m_Confidence;}}

private int m_Diamond;
 public int Diamond { get{ return m_Diamond;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_Stamina;
 public int Stamina { get{ return m_Stamina;}}

public static bool LoadTable(Dictionary<int, List<Tab_BuyStamina> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_BuyStamina SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_BuyStamina _values = new Tab_BuyStamina();
 _values.m_Confidence =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CONFIDENCE] as string);
_values.m_Diamond =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DIAMOND] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Stamina =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_STAMINA] as string);

 return _values; }


}
}

