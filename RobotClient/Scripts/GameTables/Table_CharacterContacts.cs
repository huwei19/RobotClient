//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_CharacterContacts
{ private const string TAB_FILE_DATA = "Table/CharacterContacts.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_ISSYSCONTACTS=2,
ID_STORY,
ID_GREET,
ID_INTIMACY,
ID_INTIMACYMAX,
ID_ANIMID,
ID_PRIORITY,
ID_CONTACTSACTIONID,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_AnimId;
 public int AnimId { get{ return m_AnimId;}}

private int m_ContactsActionId;
 public int ContactsActionId { get{ return m_ContactsActionId;}}

private string m_Greet;
 public string Greet { get{ return m_Greet;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_Intimacy;
 public int Intimacy { get{ return m_Intimacy;}}

private int m_IntimacyMax;
 public int IntimacyMax { get{ return m_IntimacyMax;}}

private int m_IsSysContacts;
 public int IsSysContacts { get{ return m_IsSysContacts;}}

private int m_Priority;
 public int Priority { get{ return m_Priority;}}

private string m_Story;
 public string Story { get{ return m_Story;}}

public static bool LoadTable(Dictionary<int, List<Tab_CharacterContacts> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_CharacterContacts SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_CharacterContacts _values = new Tab_CharacterContacts();
 _values.m_AnimId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ANIMID] as string);
_values.m_ContactsActionId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CONTACTSACTIONID] as string);
_values.m_Greet =  valuesList[(int)_ID.ID_GREET] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Intimacy =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_INTIMACY] as string);
_values.m_IntimacyMax =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_INTIMACYMAX] as string);
_values.m_IsSysContacts =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISSYSCONTACTS] as string);
_values.m_Priority =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PRIORITY] as string);
_values.m_Story =  valuesList[(int)_ID.ID_STORY] as string;

 return _values; }


}
}

