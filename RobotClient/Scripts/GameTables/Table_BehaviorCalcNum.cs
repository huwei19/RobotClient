//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_BehaviorCalcNum
{ private const string TAB_FILE_DATA = "Table/BehaviorCalcNum.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_ATTRTYPE=2,
ID_ATTRVALUE,
ID_SPTVAL,
ID_WISVAL,
ID_STRVAL,
ID_LCK,
ID_CUSTOMTYPE,
ID_FORCECUSTOMDET,
ID_CUSTOMBASEDET,
ID_CUSTOMCHARACTERIDDET,
ID_CUSTOMTAGIDDET,
ID_CUSTOMPERSONTYPEDET,
ID_ABILITYIDDET,
ID_FORCEABILITYDET,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_AbilityIdDet;
 public int AbilityIdDet { get{ return m_AbilityIdDet;}}

private int m_AttrType;
 public int AttrType { get{ return m_AttrType;}}

private int m_AttrValue;
 public int AttrValue { get{ return m_AttrValue;}}

private string m_CustomBaseDet;
 public string CustomBaseDet { get{ return m_CustomBaseDet;}}

private int m_CustomCharacterIdDet;
 public int CustomCharacterIdDet { get{ return m_CustomCharacterIdDet;}}

private int m_CustomPersonTypeDet;
 public int CustomPersonTypeDet { get{ return m_CustomPersonTypeDet;}}

private int m_CustomTagIdDet;
 public int CustomTagIdDet { get{ return m_CustomTagIdDet;}}

private int m_CustomType;
 public int CustomType { get{ return m_CustomType;}}

private int m_ForceAbilityDet;
 public int ForceAbilityDet { get{ return m_ForceAbilityDet;}}

private int m_ForceCustomDet;
 public int ForceCustomDet { get{ return m_ForceCustomDet;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_Lck;
 public int Lck { get{ return m_Lck;}}

private int m_SptVal;
 public int SptVal { get{ return m_SptVal;}}

private int m_StrVal;
 public int StrVal { get{ return m_StrVal;}}

private int m_WisVal;
 public int WisVal { get{ return m_WisVal;}}

public static bool LoadTable(Dictionary<int, List<Tab_BehaviorCalcNum> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_BehaviorCalcNum SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_BehaviorCalcNum _values = new Tab_BehaviorCalcNum();
 _values.m_AbilityIdDet =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ABILITYIDDET] as string);
_values.m_AttrType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ATTRTYPE] as string);
_values.m_AttrValue =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ATTRVALUE] as string);
_values.m_CustomBaseDet =  valuesList[(int)_ID.ID_CUSTOMBASEDET] as string;
_values.m_CustomCharacterIdDet =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CUSTOMCHARACTERIDDET] as string);
_values.m_CustomPersonTypeDet =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CUSTOMPERSONTYPEDET] as string);
_values.m_CustomTagIdDet =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CUSTOMTAGIDDET] as string);
_values.m_CustomType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CUSTOMTYPE] as string);
_values.m_ForceAbilityDet =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FORCEABILITYDET] as string);
_values.m_ForceCustomDet =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FORCECUSTOMDET] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Lck =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LCK] as string);
_values.m_SptVal =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SPTVAL] as string);
_values.m_StrVal =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_STRVAL] as string);
_values.m_WisVal =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_WISVAL] as string);

 return _values; }


}
}

