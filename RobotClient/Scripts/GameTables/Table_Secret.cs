//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_Secret
{ private const string TAB_FILE_DATA = "Table/Secret.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NAME=2,
ID_FATELINEID,
ID_DROPREWARD,
ID_DROPREWARDPREVIEWID,
ID_INTIMACYREWARD,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_DropReward;
 public int DropReward { get{ return m_DropReward;}}

private int m_DropRewardPreviewId;
 public int DropRewardPreviewId { get{ return m_DropRewardPreviewId;}}

private int m_FateLineId;
 public int FateLineId { get{ return m_FateLineId;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_IntimacyReward;
 public int IntimacyReward { get{ return m_IntimacyReward;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

public static bool LoadTable(Dictionary<int, List<Tab_Secret> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_Secret SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_Secret _values = new Tab_Secret();
 _values.m_DropReward =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPREWARD] as string);
_values.m_DropRewardPreviewId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPREWARDPREVIEWID] as string);
_values.m_FateLineId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FATELINEID] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_IntimacyReward =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_INTIMACYREWARD] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;

 return _values; }


}
}

