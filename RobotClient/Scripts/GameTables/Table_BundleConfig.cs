//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_BundleConfig
{ private const string TAB_FILE_DATA = "Table/BundleConfig.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_PATH=2,
ID_RELATIVEPATH,
ID_ASSETNAMEFORMAT,
ID_BUNDLENAMEFORMAT,
ID_FILTERTYPE,
ID_ISLISTASSETS,
ID_EXCLUDEFILES,
ID_BUNDLEVAR,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private string m_AssetNameFormat;
 public string AssetNameFormat { get{ return m_AssetNameFormat;}}

private string m_BundleNameFormat;
 public string BundleNameFormat { get{ return m_BundleNameFormat;}}

private string m_BundleVar;
 public string BundleVar { get{ return m_BundleVar;}}

private string m_ExcludeFiles;
 public string ExcludeFiles { get{ return m_ExcludeFiles;}}

private string m_FilterType;
 public string FilterType { get{ return m_FilterType;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_IsListAssets;
 public int IsListAssets { get{ return m_IsListAssets;}}

private string m_Path;
 public string Path { get{ return m_Path;}}

private string m_RelativePath;
 public string RelativePath { get{ return m_RelativePath;}}

public static bool LoadTable(Dictionary<int, List<Tab_BundleConfig> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_BundleConfig SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_BundleConfig _values = new Tab_BundleConfig();
 _values.m_AssetNameFormat =  valuesList[(int)_ID.ID_ASSETNAMEFORMAT] as string;
_values.m_BundleNameFormat =  valuesList[(int)_ID.ID_BUNDLENAMEFORMAT] as string;
_values.m_BundleVar =  valuesList[(int)_ID.ID_BUNDLEVAR] as string;
_values.m_ExcludeFiles =  valuesList[(int)_ID.ID_EXCLUDEFILES] as string;
_values.m_FilterType =  valuesList[(int)_ID.ID_FILTERTYPE] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_IsListAssets =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISLISTASSETS] as string);
_values.m_Path =  valuesList[(int)_ID.ID_PATH] as string;
_values.m_RelativePath =  valuesList[(int)_ID.ID_RELATIVEPATH] as string;

 return _values; }


}
}

