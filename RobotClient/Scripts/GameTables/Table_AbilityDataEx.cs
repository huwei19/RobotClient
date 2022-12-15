//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_AbilityDataEx
{ private const string TAB_FILE_DATA = "Table/AbilityDataEx.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_DESCRIBE=2,
ID_CONSUMEITEM0,
ID_CONSUMEITEM1,
ID_CONSUMEITEMNUM0,
ID_CONSUMEITEMNUM1,
ID_CURRENCYTYPE,
ID_CURRENCYNUM,
ID_ABILITYDATA,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_AbilityData;
 public int AbilityData { get{ return m_AbilityData;}}

public int getConsumeItemCount() { return 2; } 
 private int[] m_ConsumeItem = new int[2];
 public int GetConsumeItembyIndex(int idx) {
 if(idx>=0 && idx<2) {
 return m_ConsumeItem[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> ConsumeItems { get {
  
return Array.AsReadOnly(m_ConsumeItem);
}} 

public int getConsumeItemNumCount() { return 2; } 
 private int[] m_ConsumeItemNum = new int[2];
 public int GetConsumeItemNumbyIndex(int idx) {
 if(idx>=0 && idx<2) {
 return m_ConsumeItemNum[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> ConsumeItemNums { get {
  
return Array.AsReadOnly(m_ConsumeItemNum);
}} 

private int m_CurrencyNum;
 public int CurrencyNum { get{ return m_CurrencyNum;}}

private int m_CurrencyType;
 public int CurrencyType { get{ return m_CurrencyType;}}

private string m_Describe;
 public string Describe { get{ return m_Describe;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

public static bool LoadTable(Dictionary<int, List<Tab_AbilityDataEx> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_AbilityDataEx SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_AbilityDataEx _values = new Tab_AbilityDataEx();
 _values.m_AbilityData =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ABILITYDATA] as string);
_values.m_ConsumeItem [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CONSUMEITEM0] as string);
_values.m_ConsumeItem [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CONSUMEITEM1] as string);
_values.m_ConsumeItemNum [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CONSUMEITEMNUM0] as string);
_values.m_ConsumeItemNum [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CONSUMEITEMNUM1] as string);
_values.m_CurrencyNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CURRENCYNUM] as string);
_values.m_CurrencyType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CURRENCYTYPE] as string);
_values.m_Describe =  valuesList[(int)_ID.ID_DESCRIBE] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);

 return _values; }


}
}

