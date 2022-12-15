//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_ContainerManager
{ private const string TAB_FILE_DATA = "table/ContainerManager.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NAME=2,
ID_MAXINSTCOUNT,
ID_PLAYERSMAXA,
ID_PLAYERSMAXB,
ID_PLAYERSMAXC,
ID_GROUPNORMALSIZE,
ID_GROUPSLOWSIZE,
ID_GROUPPAUSESIZE,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_GroupNormalSize;
 public int GroupNormalSize { get{ return m_GroupNormalSize;}}

private int m_GroupPauseSize;
 public int GroupPauseSize { get{ return m_GroupPauseSize;}}

private int m_GroupSlowSize;
 public int GroupSlowSize { get{ return m_GroupSlowSize;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_MaxInstCount;
 public int MaxInstCount { get{ return m_MaxInstCount;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private int m_PlayersMaxA;
 public int PlayersMaxA { get{ return m_PlayersMaxA;}}

private int m_PlayersMaxB;
 public int PlayersMaxB { get{ return m_PlayersMaxB;}}

private int m_PlayersMaxC;
 public int PlayersMaxC { get{ return m_PlayersMaxC;}}

public static bool LoadTable(Dictionary<int, List<Tab_ContainerManager> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_ContainerManager SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_ContainerManager _values = new Tab_ContainerManager();
 _values.m_GroupNormalSize =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GROUPNORMALSIZE] as string);
_values.m_GroupPauseSize =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GROUPPAUSESIZE] as string);
_values.m_GroupSlowSize =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GROUPSLOWSIZE] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_MaxInstCount =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MAXINSTCOUNT] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_PlayersMaxA =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PLAYERSMAXA] as string);
_values.m_PlayersMaxB =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PLAYERSMAXB] as string);
_values.m_PlayersMaxC =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PLAYERSMAXC] as string);

 return _values; }


}
}

