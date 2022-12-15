//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_NoviceGuide
{ private const string TAB_FILE_DATA = "Table/NoviceGuide.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_SAVEID=2,
ID_NEXTID,
ID_NAME,
ID_CONTROLNAME,
ID_ISPARENT,
ID_ISLIST,
ID_LISTCHILDNUM,
ID_LISTCCNUM,
ID_LISTCCCNUM2,
ID_LISTCCCCNUM,
ID_LISTCHIDBUTTON,
ID_SCENENAME,
ID_OBJECTNAME,
ID_WIDE,
ID_HIGH,
ID_EXCURSIONPOSX,
ID_EXCURSIONPOSY,
ID_CONTENT,
ID_CONTENTPOS,
ID_ISCALLBACK,
ID_WAITTIME,
ID_NEXTPANEL,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private string m_Content;
 public string Content { get{ return m_Content;}}

private string m_ContentPos;
 public string ContentPos { get{ return m_ContentPos;}}

private string m_ControlName;
 public string ControlName { get{ return m_ControlName;}}

private int m_ExcursionPosX;
 public int ExcursionPosX { get{ return m_ExcursionPosX;}}

private int m_ExcursionPosY;
 public int ExcursionPosY { get{ return m_ExcursionPosY;}}

private int m_High;
 public int High { get{ return m_High;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_IsCallBack;
 public int IsCallBack { get{ return m_IsCallBack;}}

private int m_IsList;
 public int IsList { get{ return m_IsList;}}

private int m_IsParent;
 public int IsParent { get{ return m_IsParent;}}

private int m_ListCCCCNum;
 public int ListCCCCNum { get{ return m_ListCCCCNum;}}

private int m_ListCCCNum2;
 public int ListCCCNum2 { get{ return m_ListCCCNum2;}}

private int m_ListCCNum;
 public int ListCCNum { get{ return m_ListCCNum;}}

private string m_ListChidButton;
 public string ListChidButton { get{ return m_ListChidButton;}}

private int m_ListChildNum;
 public int ListChildNum { get{ return m_ListChildNum;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private int m_NextId;
 public int NextId { get{ return m_NextId;}}

private int m_NextPanel;
 public int NextPanel { get{ return m_NextPanel;}}

private string m_ObjectName;
 public string ObjectName { get{ return m_ObjectName;}}

private int m_SaveId;
 public int SaveId { get{ return m_SaveId;}}

private string m_SceneName;
 public string SceneName { get{ return m_SceneName;}}

private int m_Wide;
 public int Wide { get{ return m_Wide;}}

private float m_WaitTime;
 public float WaitTime { get{ return m_WaitTime;}}

public static bool LoadTable(Dictionary<int, List<Tab_NoviceGuide> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_NoviceGuide SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_NoviceGuide _values = new Tab_NoviceGuide();
 _values.m_Content =  valuesList[(int)_ID.ID_CONTENT] as string;
_values.m_ContentPos =  valuesList[(int)_ID.ID_CONTENTPOS] as string;
_values.m_ControlName =  valuesList[(int)_ID.ID_CONTROLNAME] as string;
_values.m_ExcursionPosX =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_EXCURSIONPOSX] as string);
_values.m_ExcursionPosY =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_EXCURSIONPOSY] as string);
_values.m_High =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HIGH] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_IsCallBack =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISCALLBACK] as string);
_values.m_IsList =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISLIST] as string);
_values.m_IsParent =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISPARENT] as string);
_values.m_ListCCCCNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LISTCCCCNUM] as string);
_values.m_ListCCCNum2 =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LISTCCCNUM2] as string);
_values.m_ListCCNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LISTCCNUM] as string);
_values.m_ListChidButton =  valuesList[(int)_ID.ID_LISTCHIDBUTTON] as string;
_values.m_ListChildNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LISTCHILDNUM] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_NextId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NEXTID] as string);
_values.m_NextPanel =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NEXTPANEL] as string);
_values.m_ObjectName =  valuesList[(int)_ID.ID_OBJECTNAME] as string;
_values.m_SaveId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SAVEID] as string);
_values.m_SceneName =  valuesList[(int)_ID.ID_SCENENAME] as string;
_values.m_Wide =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_WIDE] as string);
_values.m_WaitTime =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_WAITTIME] as string );

 return _values; }


}
}

