//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_DivinationReward
{ private const string TAB_FILE_DATA = "Table/DivinationReward.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_HEXAGRAMID=2,
ID_DROPID,
ID_DROPPREVIEWID,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_DropId;
 public int DropId { get{ return m_DropId;}}

private int m_DropPreviewId;
 public int DropPreviewId { get{ return m_DropPreviewId;}}

private int m_HexagramId;
 public int HexagramId { get{ return m_HexagramId;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

public static bool LoadTable(Dictionary<int, List<Tab_DivinationReward> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_DivinationReward SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_DivinationReward _values = new Tab_DivinationReward();
 _values.m_DropId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPID] as string);
_values.m_DropPreviewId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPREVIEWID] as string);
_values.m_HexagramId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HEXAGRAMID] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);

 return _values; }


}
}

