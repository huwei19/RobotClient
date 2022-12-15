//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_Divination
{ private const string TAB_FILE_DATA = "Table/Divination.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_DIVINATIONNAME=2,
ID_DIVINATIONDES,
ID_DIVINATIONSUFFIX,
ID_DIVINATIONREWARDID,
ID_DIVINATIONLEVEL,
ID_DIVINATIONGOOD,
ID_ISEGG,
ID_EGGDROPID,
ID_EGGDROPPREVIEWID,
ID_EGGACTIONID,
ID_PROPORTION,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private string m_DivinationDes;
 public string DivinationDes { get{ return m_DivinationDes;}}

private string m_DivinationGood;
 public string DivinationGood { get{ return m_DivinationGood;}}

private string m_DivinationLevel;
 public string DivinationLevel { get{ return m_DivinationLevel;}}

private string m_DivinationName;
 public string DivinationName { get{ return m_DivinationName;}}

private int m_DivinationRewardId;
 public int DivinationRewardId { get{ return m_DivinationRewardId;}}

private string m_DivinationSuffix;
 public string DivinationSuffix { get{ return m_DivinationSuffix;}}

private int m_EggActionId;
 public int EggActionId { get{ return m_EggActionId;}}

private int m_EggDropId;
 public int EggDropId { get{ return m_EggDropId;}}

private int m_EggDropPreviewId;
 public int EggDropPreviewId { get{ return m_EggDropPreviewId;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_IsEgg;
 public int IsEgg { get{ return m_IsEgg;}}

private int m_Proportion;
 public int Proportion { get{ return m_Proportion;}}

public static bool LoadTable(Dictionary<int, List<Tab_Divination> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_Divination SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_Divination _values = new Tab_Divination();
 _values.m_DivinationDes =  valuesList[(int)_ID.ID_DIVINATIONDES] as string;
_values.m_DivinationGood =  valuesList[(int)_ID.ID_DIVINATIONGOOD] as string;
_values.m_DivinationLevel =  valuesList[(int)_ID.ID_DIVINATIONLEVEL] as string;
_values.m_DivinationName =  valuesList[(int)_ID.ID_DIVINATIONNAME] as string;
_values.m_DivinationRewardId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DIVINATIONREWARDID] as string);
_values.m_DivinationSuffix =  valuesList[(int)_ID.ID_DIVINATIONSUFFIX] as string;
_values.m_EggActionId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_EGGACTIONID] as string);
_values.m_EggDropId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_EGGDROPID] as string);
_values.m_EggDropPreviewId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_EGGDROPPREVIEWID] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_IsEgg =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISEGG] as string);
_values.m_Proportion =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PROPORTION] as string);

 return _values; }


}
}

