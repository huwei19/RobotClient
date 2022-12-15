//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_HeartBeatDialog
{ private const string TAB_FILE_DATA = "Table/HeartBeatDialog.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_DIALOGEMOTION=2,
ID_DIALOGANIM,
ID_DIALOGCV,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_DialogAnim;
 public int DialogAnim { get{ return m_DialogAnim;}}

private int m_DialogCV;
 public int DialogCV { get{ return m_DialogCV;}}

private int m_DialogEmotion;
 public int DialogEmotion { get{ return m_DialogEmotion;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

public static bool LoadTable(Dictionary<int, List<Tab_HeartBeatDialog> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_HeartBeatDialog SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_HeartBeatDialog _values = new Tab_HeartBeatDialog();
 _values.m_DialogAnim =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DIALOGANIM] as string);
_values.m_DialogCV =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DIALOGCV] as string);
_values.m_DialogEmotion =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DIALOGEMOTION] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);

 return _values; }


}
}

