//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_DrawCardActivity
{ private const string TAB_FILE_DATA = "table/DrawCardActivity.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_POTID_0=2,
ID_POTWEIGHT_0,
ID_POTID_1,
ID_POTWEIGHT_1,
ID_POTID_2,
ID_POTWEIGHT_2,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Id;
 public int Id { get{ return m_Id;}}

public int getPotIdCount() { return 3; } 
 private int[] m_PotId = new int[3];
 public int GetPotIdbyIndex(int idx) {
 if(idx>=0 && idx<3) return m_PotId[idx];
 return -1;
 }
 public ReadOnlyCollection <int> PotIds { get { return Array.AsReadOnly(m_PotId);}} 

public int getPotWeightCount() { return 3; } 
 private int[] m_PotWeight = new int[3];
 public int GetPotWeightbyIndex(int idx) {
 if(idx>=0 && idx<3) return m_PotWeight[idx];
 return -1;
 }
 public ReadOnlyCollection <int> PotWeights { get { return Array.AsReadOnly(m_PotWeight);}} 

public static bool LoadTable(Dictionary<int, List<Tab_DrawCardActivity> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_DrawCardActivity SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_DrawCardActivity _values = new Tab_DrawCardActivity();
 _values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_PotId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_POTID_0] as string);
_values.m_PotId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_POTID_1] as string);
_values.m_PotId [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_POTID_2] as string);
_values.m_PotWeight [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_POTWEIGHT_0] as string);
_values.m_PotWeight [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_POTWEIGHT_1] as string);
_values.m_PotWeight [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_POTWEIGHT_2] as string);

 return _values; }


}
}

