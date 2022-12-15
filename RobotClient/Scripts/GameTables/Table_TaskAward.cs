//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_TaskAward
{ private const string TAB_FILE_DATA = "Table/TaskAward.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_REFRESHTYPE=2,
ID_VALUE,
ID_DROPID,
ID_DROPPREVIEWID,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_DropId;
 public int DropId { get{ return m_DropId;}}

private int m_DropPreviewId;
 public int DropPreviewId { get{ return m_DropPreviewId;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_RefreshType;
 public int RefreshType { get{ return m_RefreshType;}}

private int m_Value;
 public int Value { get{ return m_Value;}}

public static bool LoadTable(Dictionary<int, List<Tab_TaskAward> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_TaskAward SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_TaskAward _values = new Tab_TaskAward();
 _values.m_DropId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPID] as string);
_values.m_DropPreviewId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPREVIEWID] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_RefreshType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REFRESHTYPE] as string);
_values.m_Value =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_VALUE] as string);

 return _values; }


}
}

