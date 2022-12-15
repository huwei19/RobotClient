//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_CardTrain
{ private const string TAB_FILE_DATA = "Table/CardTrain.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_ICONTYPE=2,
ID_ITEMID0,
ID_ITEMNUM0,
ID_ITEMID1,
ID_ITEMNUM1,
ID_CURRENCYTYPE,
ID_CURRENCYNUM,
ID_TRAINDATA,
ID_ISEFFECT,
ID_AWARDDROPID,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_AwardDropId;
 public int AwardDropId { get{ return m_AwardDropId;}}

private int m_CurrencyNum;
 public int CurrencyNum { get{ return m_CurrencyNum;}}

private int m_CurrencyType;
 public int CurrencyType { get{ return m_CurrencyType;}}

private int m_IconType;
 public int IconType { get{ return m_IconType;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_IsEffect;
 public int IsEffect { get{ return m_IsEffect;}}

public int getItemIdCount() { return 2; } 
 private int[] m_ItemId = new int[2];
 public int GetItemIdbyIndex(int idx) {
 if(idx>=0 && idx<2) {
 return m_ItemId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> ItemIds { get {
  
return Array.AsReadOnly(m_ItemId);
}} 

public int getItemNumCount() { return 2; } 
 private int[] m_ItemNum = new int[2];
 public int GetItemNumbyIndex(int idx) {
 if(idx>=0 && idx<2) {
 return m_ItemNum[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> ItemNums { get {
  
return Array.AsReadOnly(m_ItemNum);
}} 

private int m_TrainData;
 public int TrainData { get{ return m_TrainData;}}

public static bool LoadTable(Dictionary<int, List<Tab_CardTrain> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_CardTrain SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_CardTrain _values = new Tab_CardTrain();
 _values.m_AwardDropId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AWARDDROPID] as string);
_values.m_CurrencyNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CURRENCYNUM] as string);
_values.m_CurrencyType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CURRENCYTYPE] as string);
_values.m_IconType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ICONTYPE] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_IsEffect =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISEFFECT] as string);
_values.m_ItemId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMID0] as string);
_values.m_ItemId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMID1] as string);
_values.m_ItemNum [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMNUM0] as string);
_values.m_ItemNum [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMNUM1] as string);
_values.m_TrainData =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TRAINDATA] as string);

 return _values; }


}
}

