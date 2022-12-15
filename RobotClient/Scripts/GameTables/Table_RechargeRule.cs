//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_RechargeRule
{ private const string TAB_FILE_DATA = "Table/RechargeRule.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_RECHARGEURL=2,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_RechargeUrl;
 public string RechargeUrl { get{ return m_RechargeUrl;}}

public static bool LoadTable(Dictionary<int, List<Tab_RechargeRule> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_RechargeRule SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_RechargeRule _values = new Tab_RechargeRule();
 _values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_RechargeUrl =  valuesList[(int)_ID.ID_RECHARGEURL] as string;

 return _values; }


}
}

