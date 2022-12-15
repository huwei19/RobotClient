//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_VChat
{ private const string TAB_FILE_DATA = "Table/VChat.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NAME=2,
ID_TYPE,
ID_CHATERID,
ID_PRIORITY,
ID_BEGINMSG,
ID_CONDITIONID,
ID_UNLOCKCOSTITEMID,
ID_UNLOCKCOSTITEMNUM,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_BeginMsg;
 public int BeginMsg { get{ return m_BeginMsg;}}

private int m_ChaterId;
 public int ChaterId { get{ return m_ChaterId;}}

private int m_ConditionId;
 public int ConditionId { get{ return m_ConditionId;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private int m_Priority;
 public int Priority { get{ return m_Priority;}}

private int m_Type;
 public int Type { get{ return m_Type;}}

private int m_UnLockCostItemId;
 public int UnLockCostItemId { get{ return m_UnLockCostItemId;}}

private int m_UnLockCostItemNum;
 public int UnLockCostItemNum { get{ return m_UnLockCostItemNum;}}

public static bool LoadTable(Dictionary<int, List<Tab_VChat> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_VChat SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_VChat _values = new Tab_VChat();
 _values.m_BeginMsg =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_BEGINMSG] as string);
_values.m_ChaterId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHATERID] as string);
_values.m_ConditionId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CONDITIONID] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_Priority =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PRIORITY] as string);
_values.m_Type =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TYPE] as string);
_values.m_UnLockCostItemId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_UNLOCKCOSTITEMID] as string);
_values.m_UnLockCostItemNum =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_UNLOCKCOSTITEMNUM] as string);

 return _values; }


}
}

