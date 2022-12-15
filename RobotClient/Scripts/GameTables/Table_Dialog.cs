//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_Dialog
{ private const string TAB_FILE_DATA = "Table/Dialog.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_CONTENT=2,
ID_STYLE,
ID_CHARACTERID_0,
ID_CHARACTERALIAS_0,
ID_CHARACTERID_1,
ID_CHARACTERALIAS_1,
ID_CHARACTERID_2,
ID_CHARACTERALIAS_2,
ID_CVID,
ID_UNKNOWN,
ID_AUTOFOLD,
ID_CLICKFADEOUT,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private float m_AutoFold;
 public float AutoFold { get{ return m_AutoFold;}}

private int m_CVId;
 public int CVId { get{ return m_CVId;}}

public int getCharacterAliasCount() { return 3; } 
 private string[] m_CharacterAlias = new string[3];
 public string GetCharacterAliasbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_CharacterAlias[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> CharacterAliass { get {
  
return Array.AsReadOnly(m_CharacterAlias);
}} 

public int getCharacterIdCount() { return 3; } 
 private int[] m_CharacterId = new int[3];
 public int GetCharacterIdbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_CharacterId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> CharacterIds { get {
  
return Array.AsReadOnly(m_CharacterId);
}} 

private int m_ClickFadeOut;
 public int ClickFadeOut { get{ return m_ClickFadeOut;}}

private string m_Content;
 public string Content { get{ return m_Content;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_Style;
 public int Style { get{ return m_Style;}}

private int m_Unknown;
 public int Unknown { get{ return m_Unknown;}}

public static bool LoadTable(Dictionary<int, List<Tab_Dialog> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_Dialog SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_Dialog _values = new Tab_Dialog();
 _values.m_AutoFold =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_AUTOFOLD] as string );
_values.m_CVId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CVID] as string);
_values.m_CharacterAlias [ 0 ] =  valuesList[(int)_ID.ID_CHARACTERALIAS_0] as string;
_values.m_CharacterAlias [ 1 ] =  valuesList[(int)_ID.ID_CHARACTERALIAS_1] as string;
_values.m_CharacterAlias [ 2 ] =  valuesList[(int)_ID.ID_CHARACTERALIAS_2] as string;
_values.m_CharacterId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHARACTERID_0] as string);
_values.m_CharacterId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHARACTERID_1] as string);
_values.m_CharacterId [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHARACTERID_2] as string);
_values.m_ClickFadeOut =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CLICKFADEOUT] as string);
_values.m_Content =  valuesList[(int)_ID.ID_CONTENT] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Style =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_STYLE] as string);
_values.m_Unknown =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_UNKNOWN] as string);

 return _values; }


}
}

