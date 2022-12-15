//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_PersonalStory
{ private const string TAB_FILE_DATA = "Table/PersonalStory.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_BG=2,
ID_STORYLINEID,
ID_FATELINEID,
ID_CONDITION,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private string m_Bg;
 public string Bg { get{ return m_Bg;}}

private int m_Condition;
 public int Condition { get{ return m_Condition;}}

private int m_FateLineId;
 public int FateLineId { get{ return m_FateLineId;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_StoryLineId;
 public int StoryLineId { get{ return m_StoryLineId;}}

public static bool LoadTable(Dictionary<int, List<Tab_PersonalStory> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_PersonalStory SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_PersonalStory _values = new Tab_PersonalStory();
 _values.m_Bg =  valuesList[(int)_ID.ID_BG] as string;
_values.m_Condition =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CONDITION] as string);
_values.m_FateLineId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FATELINEID] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_StoryLineId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_STORYLINEID] as string);

 return _values; }


}
}

