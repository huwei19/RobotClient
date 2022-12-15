//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_ShopDiamond
{ private const string TAB_FILE_DATA = "Table/ShopDiamond.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_SHOPTYPE=2,
ID_DIAMOND,
ID_REFUNDDIAMOND,
ID_RESOURCEICON,
ID_POSITIONINDEX,
ID_FUNCTIONTYPE,
ID_REFRESHTYPE,
ID_BUYLIMIT,
ID_OVERRUNREDEEM,
ID_PRODUCEMAPID,
ID_MIDASDESC,
ID_DISCRIPTION,
ID_DISCRIPTIONDOUBLE,
ID_PRICE,
ID_SHOWPRICE,
ID_FIRSTPAYAWARD,
ID_EXTRAAWARD,
ID_SHOW,
ID_ISINLONGSCORE,
ID_ISINLIMITSCORE,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_BuyLimit;
 public int BuyLimit { get{ return m_BuyLimit;}}

private int m_Diamond;
 public int Diamond { get{ return m_Diamond;}}

private int m_ExtraAward;
 public int ExtraAward { get{ return m_ExtraAward;}}

private int m_FirstPayAward;
 public int FirstPayAward { get{ return m_FirstPayAward;}}

private int m_FunctionType;
 public int FunctionType { get{ return m_FunctionType;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_IsInLimitScore;
 public int IsInLimitScore { get{ return m_IsInLimitScore;}}

private int m_IsInLongScore;
 public int IsInLongScore { get{ return m_IsInLongScore;}}

private string m_MidasDesc;
 public string MidasDesc { get{ return m_MidasDesc;}}

private int m_OverrunRedeem;
 public int OverrunRedeem { get{ return m_OverrunRedeem;}}

private int m_PositionIndex;
 public int PositionIndex { get{ return m_PositionIndex;}}

private int m_Price;
 public int Price { get{ return m_Price;}}

private int m_ProduceMapID;
 public int ProduceMapID { get{ return m_ProduceMapID;}}

private int m_ReFreshType;
 public int ReFreshType { get{ return m_ReFreshType;}}

private int m_RefundDiamond;
 public int RefundDiamond { get{ return m_RefundDiamond;}}

private string m_ResourceIcon;
 public string ResourceIcon { get{ return m_ResourceIcon;}}

private int m_ShopType;
 public int ShopType { get{ return m_ShopType;}}

private int m_Show;
 public int Show { get{ return m_Show;}}

private int m_ShowPrice;
 public int ShowPrice { get{ return m_ShowPrice;}}

private string m_Discription;
 public string Discription { get{ return m_Discription;}}

private string m_DiscriptionDouble;
 public string DiscriptionDouble { get{ return m_DiscriptionDouble;}}

public static bool LoadTable(Dictionary<int, List<Tab_ShopDiamond> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_ShopDiamond SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_ShopDiamond _values = new Tab_ShopDiamond();
 _values.m_BuyLimit =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_BUYLIMIT] as string);
_values.m_Diamond =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DIAMOND] as string);
_values.m_ExtraAward =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_EXTRAAWARD] as string);
_values.m_FirstPayAward =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FIRSTPAYAWARD] as string);
_values.m_FunctionType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FUNCTIONTYPE] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_IsInLimitScore =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISINLIMITSCORE] as string);
_values.m_IsInLongScore =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISINLONGSCORE] as string);
_values.m_MidasDesc =  valuesList[(int)_ID.ID_MIDASDESC] as string;
_values.m_OverrunRedeem =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_OVERRUNREDEEM] as string);
_values.m_PositionIndex =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_POSITIONINDEX] as string);
_values.m_Price =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PRICE] as string);
_values.m_ProduceMapID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PRODUCEMAPID] as string);
_values.m_ReFreshType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REFRESHTYPE] as string);
_values.m_RefundDiamond =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REFUNDDIAMOND] as string);
_values.m_ResourceIcon =  valuesList[(int)_ID.ID_RESOURCEICON] as string;
_values.m_ShopType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SHOPTYPE] as string);
_values.m_Show =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SHOW] as string);
_values.m_ShowPrice =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SHOWPRICE] as string);
_values.m_Discription =  valuesList[(int)_ID.ID_DISCRIPTION] as string;
_values.m_DiscriptionDouble =  valuesList[(int)_ID.ID_DISCRIPTIONDOUBLE] as string;

 return _values; }


}
}

