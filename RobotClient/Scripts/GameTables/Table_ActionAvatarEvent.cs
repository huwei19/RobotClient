//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_ActionAvatarEvent
{ private const string TAB_FILE_DATA = "Table/ActionAvatarEvent.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_MOTION=2,
ID_FACIAL,
ID_CV,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_CV;
 public int CV { get{ return m_CV;}}

private int m_Facial;
 public int Facial { get{ return m_Facial;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_Motion;
 public int Motion { get{ return m_Motion;}}

public static bool LoadTable(Dictionary<int, List<Tab_ActionAvatarEvent> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_ActionAvatarEvent SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_ActionAvatarEvent _values = new Tab_ActionAvatarEvent();
 _values.m_CV =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CV] as string);
_values.m_Facial =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FACIAL] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Motion =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MOTION] as string);

 return _values; }


}
}

