//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_RewardPreview
{ private const string TAB_FILE_DATA = "Table/RewardPreview.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_TITLE=2,
ID_CONTENT_0,
ID_CONTENT_1,
ID_CONTENT_2,
ID_CONTENT_3,
ID_CUSTOMCONTENT_0,
ID_CUSTOMCONTENT_1,
ID_CUSTOMCONTENT_2,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

public int getContentCount() { return 4; } 
 private string[] m_Content = new string[4];
 public string GetContentbyIndex(int idx) {
 if(idx>=0 && idx<4) {
 return m_Content[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> Contents { get {
  
return Array.AsReadOnly(m_Content);
}} 

public int getCustomContentCount() { return 3; } 
 private string[] m_CustomContent = new string[3];
 public string GetCustomContentbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_CustomContent[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> CustomContents { get {
  
return Array.AsReadOnly(m_CustomContent);
}} 

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_Title;
 public string Title { get{ return m_Title;}}

public static bool LoadTable(Dictionary<int, List<Tab_RewardPreview> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_RewardPreview SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_RewardPreview _values = new Tab_RewardPreview();
 _values.m_Content [ 0 ] =  valuesList[(int)_ID.ID_CONTENT_0] as string;
_values.m_Content [ 1 ] =  valuesList[(int)_ID.ID_CONTENT_1] as string;
_values.m_Content [ 2 ] =  valuesList[(int)_ID.ID_CONTENT_2] as string;
_values.m_Content [ 3 ] =  valuesList[(int)_ID.ID_CONTENT_3] as string;
_values.m_CustomContent [ 0 ] =  valuesList[(int)_ID.ID_CUSTOMCONTENT_0] as string;
_values.m_CustomContent [ 1 ] =  valuesList[(int)_ID.ID_CUSTOMCONTENT_1] as string;
_values.m_CustomContent [ 2 ] =  valuesList[(int)_ID.ID_CUSTOMCONTENT_2] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Title =  valuesList[(int)_ID.ID_TITLE] as string;

 return _values; }


}
}

