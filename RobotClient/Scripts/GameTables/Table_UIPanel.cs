//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_UIPanel
{ private const string TAB_FILE_DATA = "Table/UIPanel.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NAME=2,
ID_ISLUA,
ID_PACKAGE,
ID_LAYER,
ID_ISFAIRYBATCHING,
ID_HIDEMASK,
ID_UIMASK,
ID_SORTIDX,
ID_ANCHOR,
ID_OVERRIDEPIVOT,
ID_PIVOTX,
ID_PIVOTY,
ID_RELPOSX,
ID_RELPOSY,
ID_FULLSCREEN,
ID_SHOWTYPE,
ID_TRANSITION,
ID_TRANSITIONTIME,
ID_BGNAME,
ID_OPENAUDIOID,
ID_CLOSEAUDIOID,
ID_FUNMUSID,
ID_FUNAMBID,
ID_CACHETYPE,
ID_UPDATETIME,
ID_ISEXAGUIDE,
ID_ISJUMP,
ID_ISHIDE,
ID_ISOHS,
ID_ISOVERLOOKTITLE,
ID_OUTSIDE,
ID_WAITTIME,
ID_CLOSEWAITTIME,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Anchor;
 public int Anchor { get{ return m_Anchor;}}

private string m_BGName;
 public string BGName { get{ return m_BGName;}}

private int m_CacheType;
 public int CacheType { get{ return m_CacheType;}}

private int m_CloseAudioId;
 public int CloseAudioId { get{ return m_CloseAudioId;}}

private float m_CloseWaitTime;
 public float CloseWaitTime { get{ return m_CloseWaitTime;}}

private int m_FullScreen;
 public int FullScreen { get{ return m_FullScreen;}}

private int m_FunAmbID;
 public int FunAmbID { get{ return m_FunAmbID;}}

private int m_FunMusID;
 public int FunMusID { get{ return m_FunMusID;}}

private int m_HideMask;
 public int HideMask { get{ return m_HideMask;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_IsExaGuide;
 public int IsExaGuide { get{ return m_IsExaGuide;}}

private int m_IsFairyBatching;
 public int IsFairyBatching { get{ return m_IsFairyBatching;}}

private int m_IsHide;
 public int IsHide { get{ return m_IsHide;}}

private int m_IsJump;
 public int IsJump { get{ return m_IsJump;}}

private int m_IsLua;
 public int IsLua { get{ return m_IsLua;}}

private int m_IsOHS;
 public int IsOHS { get{ return m_IsOHS;}}

private int m_IsOverlookTitle;
 public int IsOverlookTitle { get{ return m_IsOverlookTitle;}}

private int m_Layer;
 public int Layer { get{ return m_Layer;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private int m_OpenAudioId;
 public int OpenAudioId { get{ return m_OpenAudioId;}}

private int m_Outside;
 public int Outside { get{ return m_Outside;}}

private int m_OverridePivot;
 public int OverridePivot { get{ return m_OverridePivot;}}

private string m_Package;
 public string Package { get{ return m_Package;}}

private float m_PivotX;
 public float PivotX { get{ return m_PivotX;}}

private float m_PivotY;
 public float PivotY { get{ return m_PivotY;}}

private float m_RelPosX;
 public float RelPosX { get{ return m_RelPosX;}}

private float m_RelPosY;
 public float RelPosY { get{ return m_RelPosY;}}

private int m_ShowType;
 public int ShowType { get{ return m_ShowType;}}

private int m_SortIdx;
 public int SortIdx { get{ return m_SortIdx;}}

private int m_Transition;
 public int Transition { get{ return m_Transition;}}

private float m_TransitionTime;
 public float TransitionTime { get{ return m_TransitionTime;}}

private int m_UIMask;
 public int UIMask { get{ return m_UIMask;}}

private float m_UpdateTime;
 public float UpdateTime { get{ return m_UpdateTime;}}

private float m_WaitTime;
 public float WaitTime { get{ return m_WaitTime;}}

public static bool LoadTable(Dictionary<int, List<Tab_UIPanel> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_UIPanel SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_UIPanel _values = new Tab_UIPanel();
 _values.m_Anchor =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ANCHOR] as string);
_values.m_BGName =  valuesList[(int)_ID.ID_BGNAME] as string;
_values.m_CacheType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CACHETYPE] as string);
_values.m_CloseAudioId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CLOSEAUDIOID] as string);
_values.m_CloseWaitTime =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_CLOSEWAITTIME] as string );
_values.m_FullScreen =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FULLSCREEN] as string);
_values.m_FunAmbID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FUNAMBID] as string);
_values.m_FunMusID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FUNMUSID] as string);
_values.m_HideMask =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HIDEMASK] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_IsExaGuide =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISEXAGUIDE] as string);
_values.m_IsFairyBatching =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISFAIRYBATCHING] as string);
_values.m_IsHide =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISHIDE] as string);
_values.m_IsJump =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISJUMP] as string);
_values.m_IsLua =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISLUA] as string);
_values.m_IsOHS =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISOHS] as string);
_values.m_IsOverlookTitle =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISOVERLOOKTITLE] as string);
_values.m_Layer =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LAYER] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_OpenAudioId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_OPENAUDIOID] as string);
_values.m_Outside =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_OUTSIDE] as string);
_values.m_OverridePivot =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_OVERRIDEPIVOT] as string);
_values.m_Package =  valuesList[(int)_ID.ID_PACKAGE] as string;
_values.m_PivotX =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_PIVOTX] as string );
_values.m_PivotY =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_PIVOTY] as string );
_values.m_RelPosX =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_RELPOSX] as string );
_values.m_RelPosY =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_RELPOSY] as string );
_values.m_ShowType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SHOWTYPE] as string);
_values.m_SortIdx =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SORTIDX] as string);
_values.m_Transition =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TRANSITION] as string);
_values.m_TransitionTime =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_TRANSITIONTIME] as string );
_values.m_UIMask =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_UIMASK] as string);
_values.m_UpdateTime =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_UPDATETIME] as string );
_values.m_WaitTime =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_WAITTIME] as string );

 return _values; }


}
}

