//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_MisReputationLevel
{ private const string TAB_FILE_DATA = "Table/MisReputationLevel.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_REPUTATION=2,
ID_DROPID,
ID_GOLDNUM,
ID_GOLDTIME,
ID_GOLDMAX,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_DropId;
 public int DropId { get{ return m_DropId;}}

private int m_GoldMax;
 public int GoldMax { get{ return m_GoldMax;}}

private int m_GoldNum;
 public int GoldNum { get{ return m_GoldNum;}}

private int m_GoldTime;
 public int GoldTime { get{ return m_GoldTime;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_Reputation;
 public int Reputation { get{ return m_Reputation;}}

public static bool LoadTable(Dictionary<int, List<Tab_MisReputationLevel> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_MisReputationLevel SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_MisReputationLevel _values = new Tab_MisReputationLevel();
 _values.m_DropId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPID] as string);
_values.m_GoldMax =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GOLDMAX] as string);
_values.m_GoldNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GOLDNUM] as string);
_values.m_GoldTime =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GOLDTIME] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Reputation =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REPUTATION] as string);

 return _values; }


}
}

