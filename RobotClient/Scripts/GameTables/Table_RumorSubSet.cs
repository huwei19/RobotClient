//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_RumorSubSet
{ private const string TAB_FILE_DATA = "Table/RumorSubSet.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_PRESETID=2,
ID_RUMORSUB_0,
ID_RUMORSUB_1,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_PreSetId;
 public int PreSetId { get{ return m_PreSetId;}}

public int getRumorSubCount() { return 2; } 
 private int[] m_RumorSub = new int[2];
 public int GetRumorSubbyIndex(int idx) {
 if(idx>=0 && idx<2) {
 return m_RumorSub[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> RumorSubs { get {
  
return Array.AsReadOnly(m_RumorSub);
}} 

public static bool LoadTable(Dictionary<int, List<Tab_RumorSubSet> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_RumorSubSet SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_RumorSubSet _values = new Tab_RumorSubSet();
 _values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_PreSetId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PRESETID] as string);
_values.m_RumorSub [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_RUMORSUB_0] as string);
_values.m_RumorSub [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_RUMORSUB_1] as string);

 return _values; }


}
}

