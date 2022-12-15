//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_AntiIndulgenceResource
{ private const string TAB_FILE_DATA = "table/AntiIndulgenceResource.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_RESOURCETYPE=2,
ID_ITEMTYPE,
ID_ITEMID,
ID_ITEMCOUNT,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_ItemCount;
 public int ItemCount { get{ return m_ItemCount;}}

private int m_ItemId;
 public int ItemId { get{ return m_ItemId;}}

private int m_ItemType;
 public int ItemType { get{ return m_ItemType;}}

private int m_ResourceType;
 public int ResourceType { get{ return m_ResourceType;}}

public static bool LoadTable(Dictionary<int, List<Tab_AntiIndulgenceResource> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_AntiIndulgenceResource SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_AntiIndulgenceResource _values = new Tab_AntiIndulgenceResource();
 _values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_ItemCount =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMCOUNT] as string);
_values.m_ItemId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMID] as string);
_values.m_ItemType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMTYPE] as string);
_values.m_ResourceType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_RESOURCETYPE] as string);

 return _values; }


}
}

