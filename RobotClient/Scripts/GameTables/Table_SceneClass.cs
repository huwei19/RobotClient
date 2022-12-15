//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_SceneClass
{ private const string TAB_FILE_DATA = "Table/SceneClass.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NAME=2,
ID_SCENERESOURCE,
ID_TYPE,
ID_SUBTYPE,
ID_BGMUSIC,
ID_DEFAULTENV,
ID_DAYENVID,
ID_DAYRESID,
ID_NIGHTEVNID,
ID_NIGHTRESID,
ID_CAMERACFGID,
ID_LOADINGTEXTURE,
ID_LOADINGTEXT,
ID_LOADINGMUSIC,
ID_DRAGGABLEOBJECT,
ID_DRAGCHECKUI,
ID_LOADINGSOUND,
ID_SCREENFADEID,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_BGMusic;
 public int BGMusic { get{ return m_BGMusic;}}

private int m_CameraCfgID;
 public int CameraCfgID { get{ return m_CameraCfgID;}}

private int m_DayEnvID;
 public int DayEnvID { get{ return m_DayEnvID;}}

private string m_DayResID;
 public string DayResID { get{ return m_DayResID;}}

private int m_DefaultEnv;
 public int DefaultEnv { get{ return m_DefaultEnv;}}

private int m_DragCheckUI;
 public int DragCheckUI { get{ return m_DragCheckUI;}}

private string m_DraggableObject;
 public string DraggableObject { get{ return m_DraggableObject;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_LoadingMusic;
 public int LoadingMusic { get{ return m_LoadingMusic;}}

private int m_LoadingSound;
 public int LoadingSound { get{ return m_LoadingSound;}}

private int m_LoadingText;
 public int LoadingText { get{ return m_LoadingText;}}

private int m_LoadingTexture;
 public int LoadingTexture { get{ return m_LoadingTexture;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private int m_NightEvnID;
 public int NightEvnID { get{ return m_NightEvnID;}}

private string m_NightResID;
 public string NightResID { get{ return m_NightResID;}}

private string m_SceneResource;
 public string SceneResource { get{ return m_SceneResource;}}

private int m_ScreenFadeId;
 public int ScreenFadeId { get{ return m_ScreenFadeId;}}

private int m_SubType;
 public int SubType { get{ return m_SubType;}}

private int m_Type;
 public int Type { get{ return m_Type;}}

public static bool LoadTable(Dictionary<int, List<Tab_SceneClass> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_SceneClass SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_SceneClass _values = new Tab_SceneClass();
 _values.m_BGMusic =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_BGMUSIC] as string);
_values.m_CameraCfgID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CAMERACFGID] as string);
_values.m_DayEnvID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DAYENVID] as string);
_values.m_DayResID =  valuesList[(int)_ID.ID_DAYRESID] as string;
_values.m_DefaultEnv =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DEFAULTENV] as string);
_values.m_DragCheckUI =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DRAGCHECKUI] as string);
_values.m_DraggableObject =  valuesList[(int)_ID.ID_DRAGGABLEOBJECT] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_LoadingMusic =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LOADINGMUSIC] as string);
_values.m_LoadingSound =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LOADINGSOUND] as string);
_values.m_LoadingText =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LOADINGTEXT] as string);
_values.m_LoadingTexture =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LOADINGTEXTURE] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_NightEvnID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NIGHTEVNID] as string);
_values.m_NightResID =  valuesList[(int)_ID.ID_NIGHTRESID] as string;
_values.m_SceneResource =  valuesList[(int)_ID.ID_SCENERESOURCE] as string;
_values.m_ScreenFadeId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SCREENFADEID] as string);
_values.m_SubType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SUBTYPE] as string);
_values.m_Type =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TYPE] as string);

 return _values; }


}
}

