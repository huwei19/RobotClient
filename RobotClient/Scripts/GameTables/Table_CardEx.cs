//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_CardEx
{ private const string TAB_FILE_DATA = "Table/CardEx.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_ATTRTYPE=2,
ID_MAINATTR,
ID_SUBATTR1,
ID_SUBATTR2,
ID_LCK,
ID_SPT,
ID_WIS,
ID_STR,
ID_ABILITY_0,
ID_ABILITY_1,
ID_ABILITY_2,
ID_ABILITY_3,
ID_TAG_0,
ID_TAG_1,
ID_TAG_2,
ID_TAG_3,
ID_TAG_4,
ID_TAG_5,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

public int getAbilityCount() { return 4; } 
 private int[] m_Ability = new int[4];
 public int GetAbilitybyIndex(int idx) {
 if(idx>=0 && idx<4) {
 return m_Ability[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> Abilitys { get {
  
return Array.AsReadOnly(m_Ability);
}} 

private int m_AttrType;
 public int AttrType { get{ return m_AttrType;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_Lck;
 public int Lck { get{ return m_Lck;}}

private int m_MainAttr;
 public int MainAttr { get{ return m_MainAttr;}}

private int m_Spt;
 public int Spt { get{ return m_Spt;}}

private int m_Str;
 public int Str { get{ return m_Str;}}

public int getSubAttrCount() { return 2; } 
 private int[] m_SubAttr = new int[2];
 public int GetSubAttrbyIndex(int idx) {
 if(idx>=0 && idx<2) {
 return m_SubAttr[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> SubAttrs { get {
  
return Array.AsReadOnly(m_SubAttr);
}} 

public int getTagCount() { return 6; } 
 private int[] m_Tag = new int[6];
 public int GetTagbyIndex(int idx) {
 if(idx>=0 && idx<6) {
 return m_Tag[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> Tags { get {
  
return Array.AsReadOnly(m_Tag);
}} 

private int m_Wis;
 public int Wis { get{ return m_Wis;}}

public static bool LoadTable(Dictionary<int, List<Tab_CardEx> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_CardEx SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_CardEx _values = new Tab_CardEx();
 _values.m_Ability [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ABILITY_0] as string);
_values.m_Ability [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ABILITY_1] as string);
_values.m_Ability [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ABILITY_2] as string);
_values.m_Ability [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ABILITY_3] as string);
_values.m_AttrType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ATTRTYPE] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Lck =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LCK] as string);
_values.m_MainAttr =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MAINATTR] as string);
_values.m_Spt =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SPT] as string);
_values.m_Str =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_STR] as string);
_values.m_SubAttr [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SUBATTR1] as string);
_values.m_SubAttr [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SUBATTR2] as string);
_values.m_Tag [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TAG_0] as string);
_values.m_Tag [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TAG_1] as string);
_values.m_Tag [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TAG_2] as string);
_values.m_Tag [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TAG_3] as string);
_values.m_Tag [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TAG_4] as string);
_values.m_Tag [ 5 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TAG_5] as string);
_values.m_Wis =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_WIS] as string);

 return _values; }


}
}

