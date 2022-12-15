//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_TeleportPoint
{ private const string TAB_FILE_DATA = "Table/TeleportPoint.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_SCENEID=2,
ID_POSX,
ID_POSZ,
ID_ISPLAYERTELEPORT,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_IsPlayerTeleport;
 public int IsPlayerTeleport { get{ return m_IsPlayerTeleport;}}

private float m_PosX;
 public float PosX { get{ return m_PosX;}}

private float m_PosZ;
 public float PosZ { get{ return m_PosZ;}}

private int m_SceneID;
 public int SceneID { get{ return m_SceneID;}}

public static bool LoadTable(Dictionary<int, List<Tab_TeleportPoint> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_TeleportPoint SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_TeleportPoint _values = new Tab_TeleportPoint();
 _values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_IsPlayerTeleport =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISPLAYERTELEPORT] as string);
_values.m_PosX =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_POSX] as string );
_values.m_PosZ =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_POSZ] as string );
_values.m_SceneID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SCENEID] as string);

 return _values; }


}
}

