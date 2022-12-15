//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_CardAudio
{ private const string TAB_FILE_DATA = "Table/CardAudio.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_AUDIOA=2,
ID_AUDIOB,
ID_BIGAUDIOA,
ID_BIGAUDIOB,
ID_CLOSEBIGAUDIOA,
ID_CLOSEBIGAUDIOB,
ID_CVID,
ID_AUDIOID,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_AudioA;
 public int AudioA { get{ return m_AudioA;}}

private int m_AudioB;
 public int AudioB { get{ return m_AudioB;}}

private int m_AudioId;
 public int AudioId { get{ return m_AudioId;}}

private int m_BigAudioA;
 public int BigAudioA { get{ return m_BigAudioA;}}

private int m_BigAudioB;
 public int BigAudioB { get{ return m_BigAudioB;}}

private int m_CVId;
 public int CVId { get{ return m_CVId;}}

private int m_CloseBigAudioA;
 public int CloseBigAudioA { get{ return m_CloseBigAudioA;}}

private int m_CloseBigAudioB;
 public int CloseBigAudioB { get{ return m_CloseBigAudioB;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

public static bool LoadTable(Dictionary<int, List<Tab_CardAudio> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_CardAudio SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_CardAudio _values = new Tab_CardAudio();
 _values.m_AudioA =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AUDIOA] as string);
_values.m_AudioB =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AUDIOB] as string);
_values.m_AudioId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AUDIOID] as string);
_values.m_BigAudioA =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_BIGAUDIOA] as string);
_values.m_BigAudioB =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_BIGAUDIOB] as string);
_values.m_CVId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CVID] as string);
_values.m_CloseBigAudioA =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CLOSEBIGAUDIOA] as string);
_values.m_CloseBigAudioB =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CLOSEBIGAUDIOB] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);

 return _values; }


}
}

