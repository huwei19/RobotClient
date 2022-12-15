//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_ServerList
{ private const string TAB_FILE_DATA = "Table/ServerList.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_WORLDID=2,
ID_NAME,
ID_IP,
ID_PORT,
ID_STATEICON,
ID_RECOMMEND,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_Ip;
 public string Ip { get{ return m_Ip;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private int m_Port;
 public int Port { get{ return m_Port;}}

private int m_Recommend;
 public int Recommend { get{ return m_Recommend;}}

private int m_StateIcon;
 public int StateIcon { get{ return m_StateIcon;}}

private int m_WorldId;
 public int WorldId { get{ return m_WorldId;}}

public static bool LoadTable(Dictionary<int, List<Tab_ServerList> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_ServerList SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_ServerList _values = new Tab_ServerList();
 _values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Ip =  valuesList[(int)_ID.ID_IP] as string;
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_Port =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PORT] as string);
_values.m_Recommend =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_RECOMMEND] as string);
_values.m_StateIcon =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_STATEICON] as string);
_values.m_WorldId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_WORLDID] as string);

 return _values; }


}
}

