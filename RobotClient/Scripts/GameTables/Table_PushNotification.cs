//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_PushNotification
{ private const string TAB_FILE_DATA = "Table/PushNotification.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NEWS=2,
ID_TIME,
ID_SOUND,
ID_TYPE,
ID_GROUP,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Group;
 public int Group { get{ return m_Group;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_News;
 public string News { get{ return m_News;}}

private string m_Sound;
 public string Sound { get{ return m_Sound;}}

private int m_Time;
 public int Time { get{ return m_Time;}}

private int m_Type;
 public int Type { get{ return m_Type;}}

public static bool LoadTable(Dictionary<int, List<Tab_PushNotification> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_PushNotification SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_PushNotification _values = new Tab_PushNotification();
 _values.m_Group =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GROUP] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_News =  valuesList[(int)_ID.ID_NEWS] as string;
_values.m_Sound =  valuesList[(int)_ID.ID_SOUND] as string;
_values.m_Time =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TIME] as string);
_values.m_Type =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TYPE] as string);

 return _values; }


}
}

