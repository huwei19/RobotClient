//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_NpcLevel
{ private const string TAB_FILE_DATA = "Table/NpcLevel.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_EXP=2,
ID_QUALITY_0,
ID_WEIGHT_0,
ID_QUALITY_1,
ID_WEIGHT_1,
ID_QUALITY_2,
ID_WEIGHT_2,
ID_QUALITY_3,
ID_WEIGHT_3,
ID_QUALITY_4,
ID_WEIGHT_4,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Exp;
 public int Exp { get{ return m_Exp;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

public int getQualityCount() { return 5; } 
 private int[] m_Quality = new int[5];
 public int GetQualitybyIndex(int idx) {
 if(idx>=0 && idx<5) {
 return m_Quality[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> Qualitys { get {
  
return Array.AsReadOnly(m_Quality);
}} 

public int getWeightCount() { return 5; } 
 private int[] m_Weight = new int[5];
 public int GetWeightbyIndex(int idx) {
 if(idx>=0 && idx<5) {
 return m_Weight[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> Weights { get {
  
return Array.AsReadOnly(m_Weight);
}} 

public static bool LoadTable(Dictionary<int, List<Tab_NpcLevel> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_NpcLevel SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_NpcLevel _values = new Tab_NpcLevel();
 _values.m_Exp =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_EXP] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Quality [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_QUALITY_0] as string);
_values.m_Quality [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_QUALITY_1] as string);
_values.m_Quality [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_QUALITY_2] as string);
_values.m_Quality [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_QUALITY_3] as string);
_values.m_Quality [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_QUALITY_4] as string);
_values.m_Weight [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_WEIGHT_0] as string);
_values.m_Weight [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_WEIGHT_1] as string);
_values.m_Weight [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_WEIGHT_2] as string);
_values.m_Weight [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_WEIGHT_3] as string);
_values.m_Weight [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_WEIGHT_4] as string);

 return _values; }


}
}

