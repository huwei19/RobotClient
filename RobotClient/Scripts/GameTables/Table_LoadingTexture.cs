//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_LoadingTexture
{ private const string TAB_FILE_DATA = "Table/LoadingTexture.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_TEXTURERES=2,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_TextureRes;
 public string TextureRes { get{ return m_TextureRes;}}

public static bool LoadTable(Dictionary<int, List<Tab_LoadingTexture> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_LoadingTexture SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_LoadingTexture _values = new Tab_LoadingTexture();
 _values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_TextureRes =  valuesList[(int)_ID.ID_TEXTURERES] as string;

 return _values; }


}
}

