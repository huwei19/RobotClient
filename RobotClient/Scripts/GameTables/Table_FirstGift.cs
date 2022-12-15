//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_FirstGift
{ private const string TAB_FILE_DATA = "Table/FirstGift.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_DAY=2,
ID_DROPREWARD,
ID_DROPREWARDPREVIEWID,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private string m_Day;
 public string Day { get{ return m_Day;}}

private int m_DropReward;
 public int DropReward { get{ return m_DropReward;}}

private int m_DropRewardPreviewId;
 public int DropRewardPreviewId { get{ return m_DropRewardPreviewId;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

public static bool LoadTable(Dictionary<int, List<Tab_FirstGift> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_FirstGift SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_FirstGift _values = new Tab_FirstGift();
 _values.m_Day =  valuesList[(int)_ID.ID_DAY] as string;
_values.m_DropReward =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPREWARD] as string);
_values.m_DropRewardPreviewId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPREWARDPREVIEWID] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);

 return _values; }


}
}

