//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_ArticleReply
{ private const string TAB_FILE_DATA = "Table/ArticleReply.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_ARTICLEID=2,
ID_WRITER,
ID_CONTENT,
ID_LIKEDTIMES,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_ArticleId;
 public int ArticleId { get{ return m_ArticleId;}}

private string m_Content;
 public string Content { get{ return m_Content;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_LikedTimes;
 public int LikedTimes { get{ return m_LikedTimes;}}

private int m_Writer;
 public int Writer { get{ return m_Writer;}}

public static bool LoadTable(Dictionary<int, List<Tab_ArticleReply> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_ArticleReply SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_ArticleReply _values = new Tab_ArticleReply();
 _values.m_ArticleId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ARTICLEID] as string);
_values.m_Content =  valuesList[(int)_ID.ID_CONTENT] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_LikedTimes =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LIKEDTIMES] as string);
_values.m_Writer =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_WRITER] as string);

 return _values; }


}
}

