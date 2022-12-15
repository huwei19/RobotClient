//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_Plot
{ private const string TAB_FILE_DATA = "Table/Plot.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_RES=2,
ID_CUTSCENE,
ID_CHILD,
ID_ACTIVE,
ID_HIDEOTHER,
ID_SETPOS,
ID_POSX,
ID_POSY,
ID_SCALE,
ID_TRIGGER,
ID_LAYER,
ID_DURATION,
ID_EASE,
ID_FULLSCREEN,
ID_FADE,
ID_EMPATHY,
ID_POSADAPTION,
ID_ATTACHSCENE,
ID_OVERUI,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Active;
 public int Active { get{ return m_Active;}}

private int m_AttachScene;
 public int AttachScene { get{ return m_AttachScene;}}

private string m_Child;
 public string Child { get{ return m_Child;}}

private int m_CutScene;
 public int CutScene { get{ return m_CutScene;}}

private float m_Duration;
 public float Duration { get{ return m_Duration;}}

private int m_Ease;
 public int Ease { get{ return m_Ease;}}

private int m_Empathy;
 public int Empathy { get{ return m_Empathy;}}

private int m_Fade;
 public int Fade { get{ return m_Fade;}}

private int m_FullScreen;
 public int FullScreen { get{ return m_FullScreen;}}

private int m_HideOther;
 public int HideOther { get{ return m_HideOther;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private float m_Layer;
 public float Layer { get{ return m_Layer;}}

private int m_OverUI;
 public int OverUI { get{ return m_OverUI;}}

private int m_PosAdaption;
 public int PosAdaption { get{ return m_PosAdaption;}}

private float m_PosX;
 public float PosX { get{ return m_PosX;}}

private float m_PosY;
 public float PosY { get{ return m_PosY;}}

private string m_Res;
 public string Res { get{ return m_Res;}}

private float m_Scale;
 public float Scale { get{ return m_Scale;}}

private int m_SetPos;
 public int SetPos { get{ return m_SetPos;}}

private string m_Trigger;
 public string Trigger { get{ return m_Trigger;}}

public static bool LoadTable(Dictionary<int, List<Tab_Plot> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_Plot SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_Plot _values = new Tab_Plot();
 _values.m_Active =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIVE] as string);
_values.m_AttachScene =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ATTACHSCENE] as string);
_values.m_Child =  valuesList[(int)_ID.ID_CHILD] as string;
_values.m_CutScene =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CUTSCENE] as string);
_values.m_Duration =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_DURATION] as string );
_values.m_Ease =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_EASE] as string);
_values.m_Empathy =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_EMPATHY] as string);
_values.m_Fade =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FADE] as string);
_values.m_FullScreen =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FULLSCREEN] as string);
_values.m_HideOther =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HIDEOTHER] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Layer =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_LAYER] as string );
_values.m_OverUI =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_OVERUI] as string);
_values.m_PosAdaption =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_POSADAPTION] as string);
_values.m_PosX =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_POSX] as string );
_values.m_PosY =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_POSY] as string );
_values.m_Res =  valuesList[(int)_ID.ID_RES] as string;
_values.m_Scale =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_SCALE] as string );
_values.m_SetPos =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SETPOS] as string);
_values.m_Trigger =  valuesList[(int)_ID.ID_TRIGGER] as string;

 return _values; }


}
}

