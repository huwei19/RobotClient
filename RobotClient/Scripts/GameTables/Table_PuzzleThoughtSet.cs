//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_PuzzleThoughtSet
{ private const string TAB_FILE_DATA = "Table/PuzzleThoughtSet.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_THOUGHT_0=2,
ID_THOUGHT_1,
ID_THOUGHT_2,
ID_THOUGHT_3,
ID_THOUGHT_4,
ID_THOUGHT_5,
ID_QUESTION,
ID_CONCLUSION_0,
ID_CONCLUSION_1,
ID_CONCLUSION_2,
ID_PLACEHOLDER,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

public int getConclusionCount() { return 3; } 
 private string[] m_Conclusion = new string[3];
 public string GetConclusionbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_Conclusion[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> Conclusions { get {
  
return Array.AsReadOnly(m_Conclusion);
}} 

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_PlaceHolder;
 public int PlaceHolder { get{ return m_PlaceHolder;}}

private int m_Question;
 public int Question { get{ return m_Question;}}

public int getThoughtCount() { return 6; } 
 private int[] m_Thought = new int[6];
 public int GetThoughtbyIndex(int idx) {
 if(idx>=0 && idx<6) {
 return m_Thought[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> Thoughts { get {
  
return Array.AsReadOnly(m_Thought);
}} 

public static bool LoadTable(Dictionary<int, List<Tab_PuzzleThoughtSet> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_PuzzleThoughtSet SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_PuzzleThoughtSet _values = new Tab_PuzzleThoughtSet();
 _values.m_Conclusion [ 0 ] =  valuesList[(int)_ID.ID_CONCLUSION_0] as string;
_values.m_Conclusion [ 1 ] =  valuesList[(int)_ID.ID_CONCLUSION_1] as string;
_values.m_Conclusion [ 2 ] =  valuesList[(int)_ID.ID_CONCLUSION_2] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_PlaceHolder =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PLACEHOLDER] as string);
_values.m_Question =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_QUESTION] as string);
_values.m_Thought [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_THOUGHT_0] as string);
_values.m_Thought [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_THOUGHT_1] as string);
_values.m_Thought [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_THOUGHT_2] as string);
_values.m_Thought [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_THOUGHT_3] as string);
_values.m_Thought [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_THOUGHT_4] as string);
_values.m_Thought [ 5 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_THOUGHT_5] as string);

 return _values; }


}
}

