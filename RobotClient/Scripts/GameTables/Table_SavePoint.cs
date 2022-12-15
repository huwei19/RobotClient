//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_SavePoint
{ private const string TAB_FILE_DATA = "Table/SavePoint.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_ACTIVESCENENODE=2,
ID_ACTIVEOBJECTS,
ID_DEACTIVEOBJECTS,
ID_CAMERAPOSX,
ID_CAMERAPOSY,
ID_CAMERAORTH,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private string m_ActiveObjects;
 public string ActiveObjects { get{ return m_ActiveObjects;}}

private int m_ActiveSceneNode;
 public int ActiveSceneNode { get{ return m_ActiveSceneNode;}}

private float m_CameraOrth;
 public float CameraOrth { get{ return m_CameraOrth;}}

private float m_CameraPosX;
 public float CameraPosX { get{ return m_CameraPosX;}}

private float m_CameraPosY;
 public float CameraPosY { get{ return m_CameraPosY;}}

private string m_DeactiveObjects;
 public string DeactiveObjects { get{ return m_DeactiveObjects;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

public static bool LoadTable(Dictionary<int, List<Tab_SavePoint> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_SavePoint SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_SavePoint _values = new Tab_SavePoint();
 _values.m_ActiveObjects =  valuesList[(int)_ID.ID_ACTIVEOBJECTS] as string;
_values.m_ActiveSceneNode =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIVESCENENODE] as string);
_values.m_CameraOrth =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_CAMERAORTH] as string );
_values.m_CameraPosX =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_CAMERAPOSX] as string );
_values.m_CameraPosY =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_CAMERAPOSY] as string );
_values.m_DeactiveObjects =  valuesList[(int)_ID.ID_DEACTIVEOBJECTS] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);

 return _values; }


}
}

