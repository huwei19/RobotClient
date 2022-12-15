//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_RumorSub
{ private const string TAB_FILE_DATA = "Table/RumorSub.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NAME=2,
ID_LOCATION,
ID_DESC_0,
ID_DESC_1,
ID_ICON,
ID_PRERUMORSUB,
ID_LEVELID,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

public int getDescCount() { return 2; } 
 private string[] m_Desc = new string[2];
 public string GetDescbyIndex(int idx) {
 if(idx>=0 && idx<2) {
 return m_Desc[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> Descs { get {
  
return Array.AsReadOnly(m_Desc);
}} 

private int m_Icon;
 public int Icon { get{ return m_Icon;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_LevelId;
 public int LevelId { get{ return m_LevelId;}}

private string m_Location;
 public string Location { get{ return m_Location;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private int m_PreRumorSub;
 public int PreRumorSub { get{ return m_PreRumorSub;}}

public static bool LoadTable(Dictionary<int, List<Tab_RumorSub> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_RumorSub SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_RumorSub _values = new Tab_RumorSub();
 _values.m_Desc [ 0 ] =  valuesList[(int)_ID.ID_DESC_0] as string;
_values.m_Desc [ 1 ] =  valuesList[(int)_ID.ID_DESC_1] as string;
_values.m_Icon =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ICON] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_LevelId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LEVELID] as string);
_values.m_Location =  valuesList[(int)_ID.ID_LOCATION] as string;
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_PreRumorSub =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PRERUMORSUB] as string);

 return _values; }


}
}

