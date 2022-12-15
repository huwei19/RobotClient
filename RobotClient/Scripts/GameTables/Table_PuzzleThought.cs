//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_PuzzleThought
{ private const string TAB_FILE_DATA = "Table/PuzzleThought.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NAME=2,
ID_DESC,
ID_SCLUE_0,
ID_SCLUE_1,
ID_SCLUE_2,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private string m_Desc;
 public string Desc { get{ return m_Desc;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

public int getSclueCount() { return 3; } 
 private int[] m_Sclue = new int[3];
 public int GetScluebyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_Sclue[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> Sclues { get {
  
return Array.AsReadOnly(m_Sclue);
}} 

public static bool LoadTable(Dictionary<int, List<Tab_PuzzleThought> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_PuzzleThought SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_PuzzleThought _values = new Tab_PuzzleThought();
 _values.m_Desc =  valuesList[(int)_ID.ID_DESC] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_Sclue [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SCLUE_0] as string);
_values.m_Sclue [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SCLUE_1] as string);
_values.m_Sclue [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SCLUE_2] as string);

 return _values; }


}
}

