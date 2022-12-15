//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_Drop
{ private const string TAB_FILE_DATA = "table/Drop.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_ISNOTICE=2,
ID_DIAMONDMIN,
ID_DIAMONDMAX,
ID_DIAMONDPERCENT,
ID_GOLDMIN,
ID_GOLDMAX,
ID_GOLDPERCENT,
ID_STAMINAMIN,
ID_STAMINAMAX,
ID_STAMINAPERCENT,
ID_EXPMIN,
ID_EXPMAX,
ID_CARDEXPMIN,
ID_CARDEXPMAX,
ID_DROPITEMID,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_CardExpMax;
 public int CardExpMax { get{ return m_CardExpMax;}}

private int m_CardExpMin;
 public int CardExpMin { get{ return m_CardExpMin;}}

private int m_DiamondMax;
 public int DiamondMax { get{ return m_DiamondMax;}}

private int m_DiamondMin;
 public int DiamondMin { get{ return m_DiamondMin;}}

private int m_DiamondPercent;
 public int DiamondPercent { get{ return m_DiamondPercent;}}

private int m_DropItemID;
 public int DropItemID { get{ return m_DropItemID;}}

private int m_ExpMax;
 public int ExpMax { get{ return m_ExpMax;}}

private int m_ExpMin;
 public int ExpMin { get{ return m_ExpMin;}}

private int m_GoldMax;
 public int GoldMax { get{ return m_GoldMax;}}

private int m_GoldMin;
 public int GoldMin { get{ return m_GoldMin;}}

private int m_GoldPercent;
 public int GoldPercent { get{ return m_GoldPercent;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_IsNotice;
 public int IsNotice { get{ return m_IsNotice;}}

private int m_StaminaMax;
 public int StaminaMax { get{ return m_StaminaMax;}}

private int m_StaminaMin;
 public int StaminaMin { get{ return m_StaminaMin;}}

private int m_StaminaPercent;
 public int StaminaPercent { get{ return m_StaminaPercent;}}

public static bool LoadTable(Dictionary<int, List<Tab_Drop> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_Drop SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_Drop _values = new Tab_Drop();
 _values.m_CardExpMax =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CARDEXPMAX] as string);
_values.m_CardExpMin =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CARDEXPMIN] as string);
_values.m_DiamondMax =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DIAMONDMAX] as string);
_values.m_DiamondMin =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DIAMONDMIN] as string);
_values.m_DiamondPercent =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DIAMONDPERCENT] as string);
_values.m_DropItemID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPITEMID] as string);
_values.m_ExpMax =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_EXPMAX] as string);
_values.m_ExpMin =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_EXPMIN] as string);
_values.m_GoldMax =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GOLDMAX] as string);
_values.m_GoldMin =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GOLDMIN] as string);
_values.m_GoldPercent =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GOLDPERCENT] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_IsNotice =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISNOTICE] as string);
_values.m_StaminaMax =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_STAMINAMAX] as string);
_values.m_StaminaMin =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_STAMINAMIN] as string);
_values.m_StaminaPercent =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_STAMINAPERCENT] as string);

 return _values; }


}
}

