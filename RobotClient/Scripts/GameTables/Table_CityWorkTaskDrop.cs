//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_CityWorkTaskDrop
{ private const string TAB_FILE_DATA = "Table/CityWorkTaskDrop.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_DROPID=2,
ID_DROPID_EXTRA,
ID_DROPPREVIEWID,
ID_DROPPREVIEWID_EXTRA,
ID_DROPTIME,
ID_NPCFELL,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_DropID;
 public int DropID { get{ return m_DropID;}}

private int m_DropIDExtra;
 public int DropIDExtra { get{ return m_DropIDExtra;}}

private int m_DropPreviewID;
 public int DropPreviewID { get{ return m_DropPreviewID;}}

private int m_DropPreviewIDExtra;
 public int DropPreviewIDExtra { get{ return m_DropPreviewIDExtra;}}

private int m_DropTime;
 public int DropTime { get{ return m_DropTime;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_NPCFell;
 public int NPCFell { get{ return m_NPCFell;}}

public static bool LoadTable(Dictionary<int, List<Tab_CityWorkTaskDrop> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_CityWorkTaskDrop SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_CityWorkTaskDrop _values = new Tab_CityWorkTaskDrop();
 _values.m_DropID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPID] as string);
_values.m_DropIDExtra =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPID_EXTRA] as string);
_values.m_DropPreviewID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPREVIEWID] as string);
_values.m_DropPreviewIDExtra =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPREVIEWID_EXTRA] as string);
_values.m_DropTime =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPTIME] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_NPCFell =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NPCFELL] as string);

 return _values; }


}
}

