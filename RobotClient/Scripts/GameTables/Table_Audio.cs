//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_Audio
{ private const string TAB_FILE_DATA = "Table/Audio.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NAME=2,
ID_SELECTORNAME,
ID_LABELNAME,
ID_TYPE,
ID_AUDIOACBID,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_AudioAcbId;
 public int AudioAcbId { get{ return m_AudioAcbId;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_LabelName;
 public string LabelName { get{ return m_LabelName;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private string m_SelectorName;
 public string SelectorName { get{ return m_SelectorName;}}

private int m_Type;
 public int Type { get{ return m_Type;}}

public static bool LoadTable(Dictionary<int, List<Tab_Audio> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_Audio SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_Audio _values = new Tab_Audio();
 _values.m_AudioAcbId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AUDIOACBID] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_LabelName =  valuesList[(int)_ID.ID_LABELNAME] as string;
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_SelectorName =  valuesList[(int)_ID.ID_SELECTORNAME] as string;
_values.m_Type =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TYPE] as string);

 return _values; }


}
}

