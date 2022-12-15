//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_DialogAvatar
{ private const string TAB_FILE_DATA = "Table/DialogAvatar.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_TYPE=2,
ID_CHARACTERID,
ID_FAKEAVATARID,
ID_POSITION,
ID_SCALE,
ID_MOTION,
ID_FACIAL,
ID_DURATION,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_CharacterId;
 public int CharacterId { get{ return m_CharacterId;}}

private float m_Duration;
 public float Duration { get{ return m_Duration;}}

private int m_Facial;
 public int Facial { get{ return m_Facial;}}

private int m_FakeAvatarId;
 public int FakeAvatarId { get{ return m_FakeAvatarId;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_Motion;
 public int Motion { get{ return m_Motion;}}

private int m_Position;
 public int Position { get{ return m_Position;}}

private float m_Scale;
 public float Scale { get{ return m_Scale;}}

private int m_Type;
 public int Type { get{ return m_Type;}}

public static bool LoadTable(Dictionary<int, List<Tab_DialogAvatar> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_DialogAvatar SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_DialogAvatar _values = new Tab_DialogAvatar();
 _values.m_CharacterId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHARACTERID] as string);
_values.m_Duration =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_DURATION] as string );
_values.m_Facial =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FACIAL] as string);
_values.m_FakeAvatarId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FAKEAVATARID] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Motion =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MOTION] as string);
_values.m_Position =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_POSITION] as string);
_values.m_Scale =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_SCALE] as string );
_values.m_Type =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TYPE] as string);

 return _values; }


}
}

