//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_RechargeShop
{ private const string TAB_FILE_DATA = "Table/RechargeShop.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_ITEMID=2,
ID_ITEMNUM,
ID_POSITIONINDEX,
ID_REFRESHTYPE,
ID_BUYLIMIT,
ID_PRODUCEMAPID,
ID_MIDASDESC,
ID_TEXTURE,
ID_FIRSTPAYTEXTURE,
ID_COMMONPAYTEXTURE,
ID_DISCRIPTION,
ID_DISCRIPTIONDOUBLE,
ID_LEFTICON,
ID_PRICE,
ID_SHOWPRICE,
ID_FIRSTPAYAWARD,
ID_EXTRAAWARD,
ID_SHOW,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_BuyLimit;
 public int BuyLimit { get{ return m_BuyLimit;}}

private string m_CommonPayTexture;
 public string CommonPayTexture { get{ return m_CommonPayTexture;}}

private int m_ExtraAward;
 public int ExtraAward { get{ return m_ExtraAward;}}

private int m_FirstPayAward;
 public int FirstPayAward { get{ return m_FirstPayAward;}}

private string m_FirstPayTexture;
 public string FirstPayTexture { get{ return m_FirstPayTexture;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_ItemId;
 public int ItemId { get{ return m_ItemId;}}

private int m_ItemNum;
 public int ItemNum { get{ return m_ItemNum;}}

private string m_LeftIcon;
 public string LeftIcon { get{ return m_LeftIcon;}}

private string m_MidasDesc;
 public string MidasDesc { get{ return m_MidasDesc;}}

private int m_PositionIndex;
 public int PositionIndex { get{ return m_PositionIndex;}}

private int m_Price;
 public int Price { get{ return m_Price;}}

private int m_ProduceMapID;
 public int ProduceMapID { get{ return m_ProduceMapID;}}

private int m_ReFreshType;
 public int ReFreshType { get{ return m_ReFreshType;}}

private int m_Show;
 public int Show { get{ return m_Show;}}

private int m_ShowPrice;
 public int ShowPrice { get{ return m_ShowPrice;}}

private string m_Texture;
 public string Texture { get{ return m_Texture;}}

private string m_Discription;
 public string Discription { get{ return m_Discription;}}

private string m_DiscriptionDouble;
 public string DiscriptionDouble { get{ return m_DiscriptionDouble;}}

public static bool LoadTable(Dictionary<int, List<Tab_RechargeShop> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_RechargeShop SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_RechargeShop _values = new Tab_RechargeShop();
 _values.m_BuyLimit =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_BUYLIMIT] as string);
_values.m_CommonPayTexture =  valuesList[(int)_ID.ID_COMMONPAYTEXTURE] as string;
_values.m_ExtraAward =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_EXTRAAWARD] as string);
_values.m_FirstPayAward =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FIRSTPAYAWARD] as string);
_values.m_FirstPayTexture =  valuesList[(int)_ID.ID_FIRSTPAYTEXTURE] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_ItemId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMID] as string);
_values.m_ItemNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMNUM] as string);
_values.m_LeftIcon =  valuesList[(int)_ID.ID_LEFTICON] as string;
_values.m_MidasDesc =  valuesList[(int)_ID.ID_MIDASDESC] as string;
_values.m_PositionIndex =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_POSITIONINDEX] as string);
_values.m_Price =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PRICE] as string);
_values.m_ProduceMapID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PRODUCEMAPID] as string);
_values.m_ReFreshType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REFRESHTYPE] as string);
_values.m_Show =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SHOW] as string);
_values.m_ShowPrice =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SHOWPRICE] as string);
_values.m_Texture =  valuesList[(int)_ID.ID_TEXTURE] as string;
_values.m_Discription =  valuesList[(int)_ID.ID_DISCRIPTION] as string;
_values.m_DiscriptionDouble =  valuesList[(int)_ID.ID_DISCRIPTIONDOUBLE] as string;

 return _values; }


}
}

