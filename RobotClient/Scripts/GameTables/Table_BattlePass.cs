//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_BattlePass
{ private const string TAB_FILE_DATA = "Table/BattlePass.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NAME=2,
ID_DESCRIBE,
ID_LASTBPID,
ID_TYPE,
ID_UNLOCKID,
ID_DROPID,
ID_DROPPREVIEWID,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private string m_Describe;
 public string Describe { get{ return m_Describe;}}

private int m_DropId;
 public int DropId { get{ return m_DropId;}}

private int m_DroppreviewId;
 public int DroppreviewId { get{ return m_DroppreviewId;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_LastBPId;
 public int LastBPId { get{ return m_LastBPId;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private int m_Type;
 public int Type { get{ return m_Type;}}

private int m_UnLockId;
 public int UnLockId { get{ return m_UnLockId;}}

public static bool LoadTable(Dictionary<int, List<Tab_BattlePass> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_BattlePass SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_BattlePass _values = new Tab_BattlePass();
 _values.m_Describe =  valuesList[(int)_ID.ID_DESCRIBE] as string;
_values.m_DropId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPID] as string);
_values.m_DroppreviewId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPREVIEWID] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_LastBPId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LASTBPID] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_Type =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TYPE] as string);
_values.m_UnLockId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_UNLOCKID] as string);

 return _values; }


}
}

