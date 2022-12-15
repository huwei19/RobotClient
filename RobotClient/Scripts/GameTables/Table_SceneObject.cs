//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_SceneObject
{ private const string TAB_FILE_DATA = "Table/SceneObject.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_SCENEID=2,
ID_OBJECTNAME,
ID_LOADTYPE,
ID_LOADPATH,
ID_PARENT,
ID_SCENENODEID,
ID_DESC,
ID_INITIMMIDIATELY,
ID_ACTIVE,
ID_SETPOS,
ID_POSX,
ID_POSY,
ID_LAYER,
ID_SCALE,
ID_CANTRIGGER,
ID_TRIGGERPOSX,
ID_TRIGGERPOSY,
ID_TRIGGERSIZEX,
ID_TRIGGERSIZEY,
ID_AUDIO,
ID_VISIBLEAUDIO,
ID_VISIBLEDELAYTIME,
ID_INVISIBLEAUDIO,
ID_OPER,
ID_OPERINTPARAM,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Active;
 public int Active { get{ return m_Active;}}

private int m_Audio;
 public int Audio { get{ return m_Audio;}}

private int m_CanTrigger;
 public int CanTrigger { get{ return m_CanTrigger;}}

private string m_Desc;
 public string Desc { get{ return m_Desc;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_InVisibleAudio;
 public int InVisibleAudio { get{ return m_InVisibleAudio;}}

private int m_InitImmidiately;
 public int InitImmidiately { get{ return m_InitImmidiately;}}

private int m_Layer;
 public int Layer { get{ return m_Layer;}}

private string m_LoadPath;
 public string LoadPath { get{ return m_LoadPath;}}

private int m_LoadType;
 public int LoadType { get{ return m_LoadType;}}

private string m_ObjectName;
 public string ObjectName { get{ return m_ObjectName;}}

private int m_Oper;
 public int Oper { get{ return m_Oper;}}

private int m_OperIntParam;
 public int OperIntParam { get{ return m_OperIntParam;}}

private int m_Parent;
 public int Parent { get{ return m_Parent;}}

private float m_PosX;
 public float PosX { get{ return m_PosX;}}

private float m_PosY;
 public float PosY { get{ return m_PosY;}}

private float m_Scale;
 public float Scale { get{ return m_Scale;}}

private int m_SceneId;
 public int SceneId { get{ return m_SceneId;}}

private int m_SceneNodeId;
 public int SceneNodeId { get{ return m_SceneNodeId;}}

private int m_SetPos;
 public int SetPos { get{ return m_SetPos;}}

private float m_TriggerPosX;
 public float TriggerPosX { get{ return m_TriggerPosX;}}

private float m_TriggerPosY;
 public float TriggerPosY { get{ return m_TriggerPosY;}}

private float m_TriggerSizeX;
 public float TriggerSizeX { get{ return m_TriggerSizeX;}}

private float m_TriggerSizeY;
 public float TriggerSizeY { get{ return m_TriggerSizeY;}}

private int m_VisibleAudio;
 public int VisibleAudio { get{ return m_VisibleAudio;}}

private int m_VisibleDelayTime;
 public int VisibleDelayTime { get{ return m_VisibleDelayTime;}}

public static bool LoadTable(Dictionary<int, List<Tab_SceneObject> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_SceneObject SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_SceneObject _values = new Tab_SceneObject();
 _values.m_Active =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIVE] as string);
_values.m_Audio =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AUDIO] as string);
_values.m_CanTrigger =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CANTRIGGER] as string);
_values.m_Desc =  valuesList[(int)_ID.ID_DESC] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_InVisibleAudio =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_INVISIBLEAUDIO] as string);
_values.m_InitImmidiately =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_INITIMMIDIATELY] as string);
_values.m_Layer =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LAYER] as string);
_values.m_LoadPath =  valuesList[(int)_ID.ID_LOADPATH] as string;
_values.m_LoadType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LOADTYPE] as string);
_values.m_ObjectName =  valuesList[(int)_ID.ID_OBJECTNAME] as string;
_values.m_Oper =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_OPER] as string);
_values.m_OperIntParam =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_OPERINTPARAM] as string);
_values.m_Parent =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PARENT] as string);
_values.m_PosX =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_POSX] as string );
_values.m_PosY =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_POSY] as string );
_values.m_Scale =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_SCALE] as string );
_values.m_SceneId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SCENEID] as string);
_values.m_SceneNodeId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SCENENODEID] as string);
_values.m_SetPos =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SETPOS] as string);
_values.m_TriggerPosX =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_TRIGGERPOSX] as string );
_values.m_TriggerPosY =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_TRIGGERPOSY] as string );
_values.m_TriggerSizeX =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_TRIGGERSIZEX] as string );
_values.m_TriggerSizeY =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_TRIGGERSIZEY] as string );
_values.m_VisibleAudio =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_VISIBLEAUDIO] as string);
_values.m_VisibleDelayTime =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_VISIBLEDELAYTIME] as string);

 return _values; }


}
}

