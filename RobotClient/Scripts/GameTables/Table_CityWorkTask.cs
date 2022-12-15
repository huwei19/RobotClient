//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_CityWorkTask
{ private const string TAB_FILE_DATA = "Table/CityWorkTask.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_CITYID=2,
ID_NAME,
ID_DESCRIBE,
ID_QUALITY,
ID_CARDNUM,
ID_CARDATTRTYPE,
ID_CARDATTRNUM,
ID_CARDSTAR,
ID_STARNUM,
ID_NPCLIKENUM,
ID_DROPID0,
ID_DROPID1,
ID_DROPID2,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_CardAttrNum;
 public int CardAttrNum { get{ return m_CardAttrNum;}}

private int m_CardAttrType;
 public int CardAttrType { get{ return m_CardAttrType;}}

private int m_CardNum;
 public int CardNum { get{ return m_CardNum;}}

private int m_CardStar;
 public int CardStar { get{ return m_CardStar;}}

private int m_CityId;
 public int CityId { get{ return m_CityId;}}

private string m_Describe;
 public string Describe { get{ return m_Describe;}}

public int getDropIDCount() { return 3; } 
 private int[] m_DropID = new int[3];
 public int GetDropIDbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_DropID[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> DropIDs { get {
  
return Array.AsReadOnly(m_DropID);
}} 

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private int m_NpclikeNum;
 public int NpclikeNum { get{ return m_NpclikeNum;}}

private int m_Quality;
 public int Quality { get{ return m_Quality;}}

private int m_StarNum;
 public int StarNum { get{ return m_StarNum;}}

public static bool LoadTable(Dictionary<int, List<Tab_CityWorkTask> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_CityWorkTask SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_CityWorkTask _values = new Tab_CityWorkTask();
 _values.m_CardAttrNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CARDATTRNUM] as string);
_values.m_CardAttrType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CARDATTRTYPE] as string);
_values.m_CardNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CARDNUM] as string);
_values.m_CardStar =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CARDSTAR] as string);
_values.m_CityId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CITYID] as string);
_values.m_Describe =  valuesList[(int)_ID.ID_DESCRIBE] as string;
_values.m_DropID [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPID0] as string);
_values.m_DropID [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPID1] as string);
_values.m_DropID [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPID2] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_NpclikeNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NPCLIKENUM] as string);
_values.m_Quality =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_QUALITY] as string);
_values.m_StarNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_STARNUM] as string);

 return _values; }


}
}

