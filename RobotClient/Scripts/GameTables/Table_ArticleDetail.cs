//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_ArticleDetail
{ private const string TAB_FILE_DATA = "Table/ArticleDetail.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_TITLE=2,
ID_SUBTITLE,
ID_IMAGE,
ID_CONTENT,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private string m_Content;
 public string Content { get{ return m_Content;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_Image;
 public string Image { get{ return m_Image;}}

private string m_SubTitle;
 public string SubTitle { get{ return m_SubTitle;}}

private string m_Title;
 public string Title { get{ return m_Title;}}

public static bool LoadTable(Dictionary<int, List<Tab_ArticleDetail> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_ArticleDetail SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_ArticleDetail _values = new Tab_ArticleDetail();
 _values.m_Content =  valuesList[(int)_ID.ID_CONTENT] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Image =  valuesList[(int)_ID.ID_IMAGE] as string;
_values.m_SubTitle =  valuesList[(int)_ID.ID_SUBTITLE] as string;
_values.m_Title =  valuesList[(int)_ID.ID_TITLE] as string;

 return _values; }


}
}

