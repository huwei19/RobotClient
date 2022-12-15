//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_Camera
{ private const string TAB_FILE_DATA = "Table/Camera.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_TIMELINE=2,
ID_FLAG,
ID_JUMP,
ID_IMMEDIATELY,
ID_WAIT,
ID_RESET,
ID_WAITSPEED,
ID_TARGET,
ID_RANGE,
ID_POSX,
ID_POSY,
ID_DURATION,
ID_EASE,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private float m_Duration;
 public float Duration { get{ return m_Duration;}}

private int m_Ease;
 public int Ease { get{ return m_Ease;}}

private int m_Flag;
 public int Flag { get{ return m_Flag;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_Immediately;
 public int Immediately { get{ return m_Immediately;}}

private int m_Jump;
 public int Jump { get{ return m_Jump;}}

private float m_PosX;
 public float PosX { get{ return m_PosX;}}

private float m_PosY;
 public float PosY { get{ return m_PosY;}}

private float m_Range;
 public float Range { get{ return m_Range;}}

private int m_Reset;
 public int Reset { get{ return m_Reset;}}

private string m_Target;
 public string Target { get{ return m_Target;}}

private float m_TimeLine;
 public float TimeLine { get{ return m_TimeLine;}}

private int m_Wait;
 public int Wait { get{ return m_Wait;}}

private float m_WaitSpeed;
 public float WaitSpeed { get{ return m_WaitSpeed;}}

public static bool LoadTable(Dictionary<int, List<Tab_Camera> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_Camera SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_Camera _values = new Tab_Camera();
 _values.m_Duration =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_DURATION] as string );
_values.m_Ease =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_EASE] as string);
_values.m_Flag =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FLAG] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Immediately =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_IMMEDIATELY] as string);
_values.m_Jump =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_JUMP] as string);
_values.m_PosX =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_POSX] as string );
_values.m_PosY =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_POSY] as string );
_values.m_Range =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_RANGE] as string );
_values.m_Reset =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_RESET] as string);
_values.m_Target =  valuesList[(int)_ID.ID_TARGET] as string;
_values.m_TimeLine =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_TIMELINE] as string );
_values.m_Wait =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_WAIT] as string);
_values.m_WaitSpeed =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_WAITSPEED] as string );

 return _values; }


}
}

