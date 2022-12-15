//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_AssetList
{ private const string TAB_FILE_DATA = "Table/AssetList.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NAME=2,
ID_PATH,
ID_DEPENDBUNDLES,
ID_SIZE,
ID_ASSETTYPE,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_AssetType;
 public int AssetType { get{ return m_AssetType;}}

private string m_DependBundles;
 public string DependBundles { get{ return m_DependBundles;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private string m_Path;
 public string Path { get{ return m_Path;}}

private int m_Size;
 public int Size { get{ return m_Size;}}

public static bool LoadTable(Dictionary<int, List<Tab_AssetList> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_AssetList SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_AssetList _values = new Tab_AssetList();
 _values.m_AssetType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ASSETTYPE] as string);
_values.m_DependBundles =  valuesList[(int)_ID.ID_DEPENDBUNDLES] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_Path =  valuesList[(int)_ID.ID_PATH] as string;
_values.m_Size =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SIZE] as string);

 return _values; }


}
}

