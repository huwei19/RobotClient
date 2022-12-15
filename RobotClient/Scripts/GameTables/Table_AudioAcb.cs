//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_AudioAcb
{ private const string TAB_FILE_DATA = "Table/AudioAcb.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_ACBNAME=2,
ID_ACBPATH,
ID_PERSISTENT,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private string m_AcbName;
 public string AcbName { get{ return m_AcbName;}}

private string m_AcbPath;
 public string AcbPath { get{ return m_AcbPath;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_Persistent;
 public int Persistent { get{ return m_Persistent;}}

public static bool LoadTable(Dictionary<int, List<Tab_AudioAcb> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_AudioAcb SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_AudioAcb _values = new Tab_AudioAcb();
 _values.m_AcbName =  valuesList[(int)_ID.ID_ACBNAME] as string;
_values.m_AcbPath =  valuesList[(int)_ID.ID_ACBPATH] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Persistent =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PERSISTENT] as string);

 return _values; }


}
}

