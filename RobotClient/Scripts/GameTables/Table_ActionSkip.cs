//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_ActionSkip
{ private const string TAB_FILE_DATA = "Table/ActionSkip.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_STEP=2,
ID_ISSHOWDESC,
ID_DESC,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private string m_Desc;
 public string Desc { get{ return m_Desc;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_IsShowDesc;
 public int IsShowDesc { get{ return m_IsShowDesc;}}

private int m_Step;
 public int Step { get{ return m_Step;}}

public static bool LoadTable(Dictionary<int, List<Tab_ActionSkip> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_ActionSkip SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_ActionSkip _values = new Tab_ActionSkip();
 _values.m_Desc =  valuesList[(int)_ID.ID_DESC] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_IsShowDesc =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISSHOWDESC] as string);
_values.m_Step =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_STEP] as string);

 return _values; }


}
}

