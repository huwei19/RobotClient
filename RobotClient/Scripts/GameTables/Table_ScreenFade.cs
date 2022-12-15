//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_ScreenFade
{ private const string TAB_FILE_DATA = "Table/ScreenFade.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_TYPE=2,
ID_MODE,
ID_UILAYER,
ID_DIRECTION,
ID_COLOR,
ID_ALPHA,
ID_IMMEDIATELY,
ID_DURATION,
ID_INTERVAL,
ID_AUDIO,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private float m_Alpha;
 public float Alpha { get{ return m_Alpha;}}

private int m_Audio;
 public int Audio { get{ return m_Audio;}}

private string m_Color;
 public string Color { get{ return m_Color;}}

private int m_Direction;
 public int Direction { get{ return m_Direction;}}

private float m_Duration;
 public float Duration { get{ return m_Duration;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_Immediately;
 public int Immediately { get{ return m_Immediately;}}

private float m_Interval;
 public float Interval { get{ return m_Interval;}}

private int m_Mode;
 public int Mode { get{ return m_Mode;}}

private int m_Type;
 public int Type { get{ return m_Type;}}

private int m_UILayer;
 public int UILayer { get{ return m_UILayer;}}

public static bool LoadTable(Dictionary<int, List<Tab_ScreenFade> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_ScreenFade SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_ScreenFade _values = new Tab_ScreenFade();
 _values.m_Alpha =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_ALPHA] as string );
_values.m_Audio =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AUDIO] as string);
_values.m_Color =  valuesList[(int)_ID.ID_COLOR] as string;
_values.m_Direction =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DIRECTION] as string);
_values.m_Duration =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_DURATION] as string );
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Immediately =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_IMMEDIATELY] as string);
_values.m_Interval =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_INTERVAL] as string );
_values.m_Mode =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MODE] as string);
_values.m_Type =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TYPE] as string);
_values.m_UILayer =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_UILAYER] as string);

 return _values; }


}
}

