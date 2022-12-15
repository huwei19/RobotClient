//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_CameraShake
{ private const string TAB_FILE_DATA = "Table/CameraShake.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_TARGET=2,
ID_TYPE,
ID_RANGE,
ID_FREQUENCY,
ID_DECAY,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private float m_Decay;
 public float Decay { get{ return m_Decay;}}

private float m_Frequency;
 public float Frequency { get{ return m_Frequency;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private float m_Range;
 public float Range { get{ return m_Range;}}

private int m_Target;
 public int Target { get{ return m_Target;}}

private int m_Type;
 public int Type { get{ return m_Type;}}

public static bool LoadTable(Dictionary<int, List<Tab_CameraShake> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_CameraShake SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_CameraShake _values = new Tab_CameraShake();
 _values.m_Decay =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_DECAY] as string );
_values.m_Frequency =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_FREQUENCY] as string );
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Range =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_RANGE] as string );
_values.m_Target =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TARGET] as string);
_values.m_Type =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TYPE] as string);

 return _values; }


}
}

