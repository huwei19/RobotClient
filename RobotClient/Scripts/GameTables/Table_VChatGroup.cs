//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_VChatGroup
{ private const string TAB_FILE_DATA = "Table/VChatGroup.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NAME=2,
ID_NOTICE,
ID_ICON,
ID_OWNER,
ID_CHARACTERID_0,
ID_CHARACTERID_1,
ID_CHARACTERID_2,
ID_CHARACTERID_3,
ID_CHARACTERID_4,
ID_CHARACTERID_5,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

public int getCharacterIdCount() { return 6; } 
 private int[] m_CharacterId = new int[6];
 public int GetCharacterIdbyIndex(int idx) {
 if(idx>=0 && idx<6) {
 return m_CharacterId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> CharacterIds { get {
  
return Array.AsReadOnly(m_CharacterId);
}} 

private string m_Icon;
 public string Icon { get{ return m_Icon;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private string m_Notice;
 public string Notice { get{ return m_Notice;}}

private int m_Owner;
 public int Owner { get{ return m_Owner;}}

public static bool LoadTable(Dictionary<int, List<Tab_VChatGroup> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_VChatGroup SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_VChatGroup _values = new Tab_VChatGroup();
 _values.m_CharacterId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHARACTERID_0] as string);
_values.m_CharacterId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHARACTERID_1] as string);
_values.m_CharacterId [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHARACTERID_2] as string);
_values.m_CharacterId [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHARACTERID_3] as string);
_values.m_CharacterId [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHARACTERID_4] as string);
_values.m_CharacterId [ 5 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHARACTERID_5] as string);
_values.m_Icon =  valuesList[(int)_ID.ID_ICON] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_Notice =  valuesList[(int)_ID.ID_NOTICE] as string;
_values.m_Owner =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_OWNER] as string);

 return _values; }


}
}

