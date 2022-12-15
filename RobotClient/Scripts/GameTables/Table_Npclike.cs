//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_Npclike
{ private const string TAB_FILE_DATA = "Table/Npclike.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NPCID=2,
ID_LIKECHARACTERID,
ID_ITEMTYPE,
ID_ITEMID,
ID_ITEMNUM,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_ItemID;
 public int ItemID { get{ return m_ItemID;}}

private int m_ItemNum;
 public int ItemNum { get{ return m_ItemNum;}}

private int m_ItemType;
 public int ItemType { get{ return m_ItemType;}}

private int m_LikeCharacterId;
 public int LikeCharacterId { get{ return m_LikeCharacterId;}}

private int m_NpcId;
 public int NpcId { get{ return m_NpcId;}}

public static bool LoadTable(Dictionary<int, List<Tab_Npclike> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_Npclike SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_Npclike _values = new Tab_Npclike();
 _values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_ItemID =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMID] as string);
_values.m_ItemNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMNUM] as string);
_values.m_ItemType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMTYPE] as string);
_values.m_LikeCharacterId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LIKECHARACTERID] as string);
_values.m_NpcId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NPCID] as string);

 return _values; }


}
}

