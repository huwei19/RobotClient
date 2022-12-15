//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_RegionList
{ private const string TAB_FILE_DATA = "table/RegionList.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_LOGINREDISIP=2,
ID_LOGINREDISPORT,
ID_LOGINREDISAUTH,
ID_GAMEREDISIP,
ID_GAMEREDISPORT,
ID_GAMEREDISAUTH,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private string m_GameRedisAuth;
 public string GameRedisAuth { get{ return m_GameRedisAuth;}}

private string m_GameRedisIP;
 public string GameRedisIP { get{ return m_GameRedisIP;}}

private int m_GameRedisPort;
 public int GameRedisPort { get{ return m_GameRedisPort;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_LoginRedisAuth;
 public string LoginRedisAuth { get{ return m_LoginRedisAuth;}}

private string m_LoginRedisIP;
 public string LoginRedisIP { get{ return m_LoginRedisIP;}}

private int m_LoginRedisPort;
 public int LoginRedisPort { get{ return m_LoginRedisPort;}}

public static bool LoadTable(Dictionary<int, List<Tab_RegionList> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_RegionList SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_RegionList _values = new Tab_RegionList();
 _values.m_GameRedisAuth =  valuesList[(int)_ID.ID_GAMEREDISAUTH] as string;
_values.m_GameRedisIP =  valuesList[(int)_ID.ID_GAMEREDISIP] as string;
_values.m_GameRedisPort =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GAMEREDISPORT] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_LoginRedisAuth =  valuesList[(int)_ID.ID_LOGINREDISAUTH] as string;
_values.m_LoginRedisIP =  valuesList[(int)_ID.ID_LOGINREDISIP] as string;
_values.m_LoginRedisPort =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LOGINREDISPORT] as string);

 return _values; }


}
}

