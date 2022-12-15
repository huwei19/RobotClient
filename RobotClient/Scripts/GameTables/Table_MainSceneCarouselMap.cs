//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_MainSceneCarouselMap
{ private const string TAB_FILE_DATA = "Table/MainSceneCarouselMap.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_RESPATH=2,
ID_JUMPID,
ID_ACTIVITYID,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_ActivityId;
 public int ActivityId { get{ return m_ActivityId;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_JumpID;
 public int JumpID { get{ return m_JumpID;}}

private string m_ResPath;
 public string ResPath { get{ return m_ResPath;}}

public static bool LoadTable(Dictionary<int, List<Tab_MainSceneCarouselMap> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_MainSceneCarouselMap SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_MainSceneCarouselMap _values = new Tab_MainSceneCarouselMap();
 _values.m_ActivityId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIVITYID] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_JumpID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_JUMPID] as string);
_values.m_ResPath =  valuesList[(int)_ID.ID_RESPATH] as string;

 return _values; }


}
}

