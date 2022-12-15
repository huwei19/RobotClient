//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_CharacterAsset
{ private const string TAB_FILE_DATA = "Table/CharacterAsset.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_KEY=2,
ID_OFFSETX,
ID_OFFSETY,
ID_BASICSCALE,
ID_SCALERATE,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private float m_BasicScale;
 public float BasicScale { get{ return m_BasicScale;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_Key;
 public string Key { get{ return m_Key;}}

private float m_OffsetX;
 public float OffsetX { get{ return m_OffsetX;}}

private float m_OffsetY;
 public float OffsetY { get{ return m_OffsetY;}}

private float m_ScaleRate;
 public float ScaleRate { get{ return m_ScaleRate;}}

public static bool LoadTable(Dictionary<int, List<Tab_CharacterAsset> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_CharacterAsset SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_CharacterAsset _values = new Tab_CharacterAsset();
 _values.m_BasicScale =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_BASICSCALE] as string );
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Key =  valuesList[(int)_ID.ID_KEY] as string;
_values.m_OffsetX =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_OFFSETX] as string );
_values.m_OffsetY =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_OFFSETY] as string );
_values.m_ScaleRate =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_SCALERATE] as string );

 return _values; }


}
}

