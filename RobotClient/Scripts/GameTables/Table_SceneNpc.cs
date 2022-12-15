//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_SceneNpc
{ private const string TAB_FILE_DATA = "Table/SceneNpc.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_SCENEID=2,
ID_CREATERULE,
ID_DIALOGID_0,
ID_DIALOGID_1,
ID_DATAID_0,
ID_DATAID_1,
ID_EFFECTID,
ID_DYECOLORID,
ID_POSX,
ID_POSY,
ID_POSZ,
ID_FACEDIRECTION,
ID_ANIMTION,
ID_CANBESELECT,
ID_REPLACEID,
ID_RANDOMANIM,
ID_RANDOMBUBBLE,
ID_RANDOMBUBBLEINTERVAL,
ID_MISCID,
ID_FUNCICON,
ID_FUNCNAME,
ID_HEADFLAG,
ID_ISCANCHANGEHEADFLAG,
ID_HELLORANGE,
ID_HELLOSOUNDID,
ID_HELLOFACETO,
ID_HELLOANM,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Animtion;
 public int Animtion { get{ return m_Animtion;}}

private int m_CanBeSelect;
 public int CanBeSelect { get{ return m_CanBeSelect;}}

private int m_CreateRule;
 public int CreateRule { get{ return m_CreateRule;}}

public int getDataIDCount() { return 2; } 
 private int[] m_DataID = new int[2];
 public int GetDataIDbyIndex(int idx) {
 if(idx>=0 && idx<2) {
 return m_DataID[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> DataIDs { get {
  
return Array.AsReadOnly(m_DataID);
}} 

public int getDialogIDCount() { return 2; } 
 private int[] m_DialogID = new int[2];
 public int GetDialogIDbyIndex(int idx) {
 if(idx>=0 && idx<2) {
 return m_DialogID[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> DialogIDs { get {
  
return Array.AsReadOnly(m_DialogID);
}} 

private int m_DyeColorID;
 public int DyeColorID { get{ return m_DyeColorID;}}

private int m_EffectID;
 public int EffectID { get{ return m_EffectID;}}

private float m_FaceDirection;
 public float FaceDirection { get{ return m_FaceDirection;}}

private string m_FuncIcon;
 public string FuncIcon { get{ return m_FuncIcon;}}

private string m_FuncName;
 public string FuncName { get{ return m_FuncName;}}

private int m_HeadFlag;
 public int HeadFlag { get{ return m_HeadFlag;}}

private int m_HelloAnm;
 public int HelloAnm { get{ return m_HelloAnm;}}

private int m_HelloFaceTo;
 public int HelloFaceTo { get{ return m_HelloFaceTo;}}

private float m_HelloRange;
 public float HelloRange { get{ return m_HelloRange;}}

private int m_HelloSoundID;
 public int HelloSoundID { get{ return m_HelloSoundID;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_IsCanChangeHeadFlag;
 public int IsCanChangeHeadFlag { get{ return m_IsCanChangeHeadFlag;}}

private int m_MiscID;
 public int MiscID { get{ return m_MiscID;}}

private float m_PosX;
 public float PosX { get{ return m_PosX;}}

private float m_PosY;
 public float PosY { get{ return m_PosY;}}

private float m_PosZ;
 public float PosZ { get{ return m_PosZ;}}

private int m_RandomAnim;
 public int RandomAnim { get{ return m_RandomAnim;}}

private int m_RandomBubble;
 public int RandomBubble { get{ return m_RandomBubble;}}

private float m_RandomBubbleInterval;
 public float RandomBubbleInterval { get{ return m_RandomBubbleInterval;}}

private int m_ReplaceId;
 public int ReplaceId { get{ return m_ReplaceId;}}

private int m_SceneID;
 public int SceneID { get{ return m_SceneID;}}

public static bool LoadTable(Dictionary<int, List<Tab_SceneNpc> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_SceneNpc SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_SceneNpc _values = new Tab_SceneNpc();
 _values.m_Animtion =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ANIMTION] as string);
_values.m_CanBeSelect =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CANBESELECT] as string);
_values.m_CreateRule =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CREATERULE] as string);
_values.m_DataID [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DATAID_0] as string);
_values.m_DataID [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DATAID_1] as string);
_values.m_DialogID [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DIALOGID_0] as string);
_values.m_DialogID [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DIALOGID_1] as string);
_values.m_DyeColorID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DYECOLORID] as string);
_values.m_EffectID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_EFFECTID] as string);
_values.m_FaceDirection =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_FACEDIRECTION] as string );
_values.m_FuncIcon =  valuesList[(int)_ID.ID_FUNCICON] as string;
_values.m_FuncName =  valuesList[(int)_ID.ID_FUNCNAME] as string;
_values.m_HeadFlag =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HEADFLAG] as string);
_values.m_HelloAnm =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HELLOANM] as string);
_values.m_HelloFaceTo =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HELLOFACETO] as string);
_values.m_HelloRange =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_HELLORANGE] as string );
_values.m_HelloSoundID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HELLOSOUNDID] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_IsCanChangeHeadFlag =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISCANCHANGEHEADFLAG] as string);
_values.m_MiscID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MISCID] as string);
_values.m_PosX =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_POSX] as string );
_values.m_PosY =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_POSY] as string );
_values.m_PosZ =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_POSZ] as string );
_values.m_RandomAnim =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_RANDOMANIM] as string);
_values.m_RandomBubble =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_RANDOMBUBBLE] as string);
_values.m_RandomBubbleInterval =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_RANDOMBUBBLEINTERVAL] as string );
_values.m_ReplaceId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REPLACEID] as string);
_values.m_SceneID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SCENEID] as string);

 return _values; }


}
}

