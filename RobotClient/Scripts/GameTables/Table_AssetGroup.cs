//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_AssetGroup
{ private const string TAB_FILE_DATA = "Table/AssetGroup.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NAME=2,
ID_PATH,
ID_ASSETTYPE,
ID_TYPES,
ID_EXCLUDEASSETS,
ID_LABELS,
ID_ADDRESSTYPE,
ID_PRELOADTYPE,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_AddressType;
 public int AddressType { get{ return m_AddressType;}}

private int m_AssetType;
 public int AssetType { get{ return m_AssetType;}}

private string m_ExcludeAssets;
 public string ExcludeAssets { get{ return m_ExcludeAssets;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_Labels;
 public string Labels { get{ return m_Labels;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private string m_Path;
 public string Path { get{ return m_Path;}}

private int m_PreloadType;
 public int PreloadType { get{ return m_PreloadType;}}

private string m_Types;
 public string Types { get{ return m_Types;}}

public static bool LoadTable(Dictionary<int, List<Tab_AssetGroup> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_AssetGroup SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_AssetGroup _values = new Tab_AssetGroup();
 _values.m_AddressType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ADDRESSTYPE] as string);
_values.m_AssetType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ASSETTYPE] as string);
_values.m_ExcludeAssets =  valuesList[(int)_ID.ID_EXCLUDEASSETS] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Labels =  valuesList[(int)_ID.ID_LABELS] as string;
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_Path =  valuesList[(int)_ID.ID_PATH] as string;
_values.m_PreloadType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PRELOADTYPE] as string);
_values.m_Types =  valuesList[(int)_ID.ID_TYPES] as string;

 return _values; }


}
}

