//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_Guide
{ private const string TAB_FILE_DATA = "Table/Guide.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_ISWAITSERVER=2,
ID_MAINPANELGUIDEID,
ID_TRIGGERPRECONDITION,
ID_FUNUNLOCKID,
ID_TRIGGERCONDITION,
ID_TRIGGERPARAM,
ID_COMPLETIONCONDITION,
ID_GUIDEPANELID,
ID_GOTOSETPID,
ID_CLOSEPANEL,
ID_CHANGESCENE,
ID_IMAGEPATH,
ID_IMAGEW,
ID_IMAGEH,
ID_IMAGEPOSX,
ID_IMAGEPOSY,
ID_ISMOVECAMERA,
ID_MASKTYPE,
ID_MASKELEMENT,
ID_MASKELEMENTSCALE,
ID_MASKADDX,
ID_MASKADDY,
ID_MASKMOVEX,
ID_MASKMOVEY,
ID_GUIDEELEMENT,
ID_GUIDEMOVEX,
ID_GUIDEMOVEY,
ID_GUIDETIP,
ID_ISGUIDETIPSSHOW,
ID_GUIDETIPMOVEELEMENT,
ID_GUIDETIPTYPE,
ID_GUIDETIPPOS,
ID_GUIDETIPMOVEX,
ID_GUIDETIPMOVEY,
ID_GUIDEEVENTID,
ID_GUIDEEVENTPARAM,
ID_ACTIONID,
ID_WAITTIME,
ID_ISBI,
ID_ISEXITLEVEL,
ID_ISERRORGOTO,
ID_ISUPDATAPOS,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_ActionId;
 public int ActionId { get{ return m_ActionId;}}

private int m_ChangeScene;
 public int ChangeScene { get{ return m_ChangeScene;}}

private int m_ClosePanel;
 public int ClosePanel { get{ return m_ClosePanel;}}

private int m_CompletionCondition;
 public int CompletionCondition { get{ return m_CompletionCondition;}}

private int m_FunUnlockId;
 public int FunUnlockId { get{ return m_FunUnlockId;}}

private int m_GotoSetpId;
 public int GotoSetpId { get{ return m_GotoSetpId;}}

private string m_GuideElement;
 public string GuideElement { get{ return m_GuideElement;}}

private int m_GuideEventId;
 public int GuideEventId { get{ return m_GuideEventId;}}

private string m_GuideEventParam;
 public string GuideEventParam { get{ return m_GuideEventParam;}}

private int m_GuideMoveX;
 public int GuideMoveX { get{ return m_GuideMoveX;}}

private int m_GuideMoveY;
 public int GuideMoveY { get{ return m_GuideMoveY;}}

private int m_GuidePanelId;
 public int GuidePanelId { get{ return m_GuidePanelId;}}

private string m_GuideTip;
 public string GuideTip { get{ return m_GuideTip;}}

private string m_GuideTipMoveElement;
 public string GuideTipMoveElement { get{ return m_GuideTipMoveElement;}}

private int m_GuideTipMoveX;
 public int GuideTipMoveX { get{ return m_GuideTipMoveX;}}

private int m_GuideTipMoveY;
 public int GuideTipMoveY { get{ return m_GuideTipMoveY;}}

private int m_GuideTipPos;
 public int GuideTipPos { get{ return m_GuideTipPos;}}

private int m_GuideTipType;
 public int GuideTipType { get{ return m_GuideTipType;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_ImageH;
 public int ImageH { get{ return m_ImageH;}}

private string m_ImagePath;
 public string ImagePath { get{ return m_ImagePath;}}

private int m_ImagePosX;
 public int ImagePosX { get{ return m_ImagePosX;}}

private int m_ImagePosY;
 public int ImagePosY { get{ return m_ImagePosY;}}

private int m_ImageW;
 public int ImageW { get{ return m_ImageW;}}

private int m_IsBI;
 public int IsBI { get{ return m_IsBI;}}

private int m_IsExitLevel;
 public int IsExitLevel { get{ return m_IsExitLevel;}}

private int m_IsGuideTipsShow;
 public int IsGuideTipsShow { get{ return m_IsGuideTipsShow;}}

private int m_IsMoveCamera;
 public int IsMoveCamera { get{ return m_IsMoveCamera;}}

private int m_IsUpdataPos;
 public int IsUpdataPos { get{ return m_IsUpdataPos;}}

private int m_IsWaitServer;
 public int IsWaitServer { get{ return m_IsWaitServer;}}

private int m_MainpanelGuideId;
 public int MainpanelGuideId { get{ return m_MainpanelGuideId;}}

private int m_MaskAddX;
 public int MaskAddX { get{ return m_MaskAddX;}}

private int m_MaskAddY;
 public int MaskAddY { get{ return m_MaskAddY;}}

private string m_MaskElement;
 public string MaskElement { get{ return m_MaskElement;}}

private float m_MaskElementScale;
 public float MaskElementScale { get{ return m_MaskElementScale;}}

private int m_MaskMoveX;
 public int MaskMoveX { get{ return m_MaskMoveX;}}

private int m_MaskMoveY;
 public int MaskMoveY { get{ return m_MaskMoveY;}}

private int m_MaskType;
 public int MaskType { get{ return m_MaskType;}}

private int m_TriggerCondition;
 public int TriggerCondition { get{ return m_TriggerCondition;}}

private int m_TriggerParam;
 public int TriggerParam { get{ return m_TriggerParam;}}

private int m_TriggerPrecondition;
 public int TriggerPrecondition { get{ return m_TriggerPrecondition;}}

private float m_WaitTime;
 public float WaitTime { get{ return m_WaitTime;}}

private int m_IsErrorGoto;
 public int IsErrorGoto { get{ return m_IsErrorGoto;}}

public static bool LoadTable(Dictionary<int, List<Tab_Guide> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_Guide SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_Guide _values = new Tab_Guide();
 _values.m_ActionId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIONID] as string);
_values.m_ChangeScene =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHANGESCENE] as string);
_values.m_ClosePanel =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CLOSEPANEL] as string);
_values.m_CompletionCondition =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_COMPLETIONCONDITION] as string);
_values.m_FunUnlockId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FUNUNLOCKID] as string);
_values.m_GotoSetpId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GOTOSETPID] as string);
_values.m_GuideElement =  valuesList[(int)_ID.ID_GUIDEELEMENT] as string;
_values.m_GuideEventId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GUIDEEVENTID] as string);
_values.m_GuideEventParam =  valuesList[(int)_ID.ID_GUIDEEVENTPARAM] as string;
_values.m_GuideMoveX =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GUIDEMOVEX] as string);
_values.m_GuideMoveY =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GUIDEMOVEY] as string);
_values.m_GuidePanelId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GUIDEPANELID] as string);
_values.m_GuideTip =  valuesList[(int)_ID.ID_GUIDETIP] as string;
_values.m_GuideTipMoveElement =  valuesList[(int)_ID.ID_GUIDETIPMOVEELEMENT] as string;
_values.m_GuideTipMoveX =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GUIDETIPMOVEX] as string);
_values.m_GuideTipMoveY =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GUIDETIPMOVEY] as string);
_values.m_GuideTipPos =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GUIDETIPPOS] as string);
_values.m_GuideTipType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_GUIDETIPTYPE] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_ImageH =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_IMAGEH] as string);
_values.m_ImagePath =  valuesList[(int)_ID.ID_IMAGEPATH] as string;
_values.m_ImagePosX =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_IMAGEPOSX] as string);
_values.m_ImagePosY =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_IMAGEPOSY] as string);
_values.m_ImageW =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_IMAGEW] as string);
_values.m_IsBI =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISBI] as string);
_values.m_IsExitLevel =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISEXITLEVEL] as string);
_values.m_IsGuideTipsShow =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISGUIDETIPSSHOW] as string);
_values.m_IsMoveCamera =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISMOVECAMERA] as string);
_values.m_IsUpdataPos =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISUPDATAPOS] as string);
_values.m_IsWaitServer =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISWAITSERVER] as string);
_values.m_MainpanelGuideId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MAINPANELGUIDEID] as string);
_values.m_MaskAddX =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MASKADDX] as string);
_values.m_MaskAddY =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MASKADDY] as string);
_values.m_MaskElement =  valuesList[(int)_ID.ID_MASKELEMENT] as string;
_values.m_MaskElementScale =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_MASKELEMENTSCALE] as string );
_values.m_MaskMoveX =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MASKMOVEX] as string);
_values.m_MaskMoveY =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MASKMOVEY] as string);
_values.m_MaskType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MASKTYPE] as string);
_values.m_TriggerCondition =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TRIGGERCONDITION] as string);
_values.m_TriggerParam =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TRIGGERPARAM] as string);
_values.m_TriggerPrecondition =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TRIGGERPRECONDITION] as string);
_values.m_WaitTime =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_WAITTIME] as string );
_values.m_IsErrorGoto =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISERRORGOTO] as string);

 return _values; }


}
}

