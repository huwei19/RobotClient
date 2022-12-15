//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_CV
{ private const string TAB_FILE_DATA = "Table/CV.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_GROUP=2,
ID_FILE,
ID_VOLUME,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private string m_File;
 public string File { get{ return m_File;}}

private string m_Group;
 public string Group { get{ return m_Group;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private float m_Volume;
 public float Volume { get{ return m_Volume;}}

public static bool LoadTable(Dictionary<int, List<Tab_CV> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_CV SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_CV _values = new Tab_CV();
 _values.m_File =  valuesList[(int)_ID.ID_FILE] as string;
_values.m_Group =  valuesList[(int)_ID.ID_GROUP] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Volume =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_VOLUME] as string );

 return _values; }


}
}

