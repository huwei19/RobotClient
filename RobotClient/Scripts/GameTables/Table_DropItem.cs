//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_DropItem
{ private const string TAB_FILE_DATA = "table/DropItem.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_TYPE=2,
ID_ITEMMAX,
ID_ISNOTICE,
ID_NOTIFYID,
ID_RANDTIMES,
ID_MINSIZE_COMMON,
ID_DROPTYPE1,
ID_DROPID1,
ID_DROPPARAM1,
ID_DROPCOUNT1,
ID_DROPRATEORWEIGHT1,
ID_DROPTYPE2,
ID_DROPID2,
ID_DROPPARAM2,
ID_DROPCOUNT2,
ID_DROPRATEORWEIGHT2,
ID_DROPTYPE3,
ID_DROPID3,
ID_DROPPARAM3,
ID_DROPCOUNT3,
ID_DROPRATEORWEIGHT3,
ID_DROPTYPE4,
ID_DROPID4,
ID_DROPPARAM4,
ID_DROPCOUNT4,
ID_DROPRATEORWEIGHT4,
ID_DROPTYPE5,
ID_DROPID5,
ID_DROPPARAM5,
ID_DROPCOUNT5,
ID_DROPRATEORWEIGHT5,
ID_DROPTYPE6,
ID_DROPID6,
ID_DROPPARAM6,
ID_DROPCOUNT6,
ID_DROPRATEORWEIGHT6,
ID_DROPTYPE7,
ID_DROPID7,
ID_DROPPARAM7,
ID_DROPCOUNT7,
ID_DROPRATEORWEIGHT7,
ID_DROPTYPE8,
ID_DROPID8,
ID_DROPPARAM8,
ID_DROPCOUNT8,
ID_DROPRATEORWEIGHT8,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

public int getDropCountCount() { return 8; } 
 private int[] m_DropCount = new int[8];
 public int GetDropCountbyIndex(int idx) {
 if(idx>=0 && idx<8) return m_DropCount[idx];
 return -1;
 }
 public ReadOnlyCollection <int> DropCounts { get { return Array.AsReadOnly(m_DropCount);}} 

public int getDropIDCount() { return 8; } 
 private int[] m_DropID = new int[8];
 public int GetDropIDbyIndex(int idx) {
 if(idx>=0 && idx<8) return m_DropID[idx];
 return -1;
 }
 public ReadOnlyCollection <int> DropIDs { get { return Array.AsReadOnly(m_DropID);}} 

public int getDropParamCount() { return 8; } 
 private int[] m_DropParam = new int[8];
 public int GetDropParambyIndex(int idx) {
 if(idx>=0 && idx<8) return m_DropParam[idx];
 return -1;
 }
 public ReadOnlyCollection <int> DropParams { get { return Array.AsReadOnly(m_DropParam);}} 

public int getDropRateOrWeightCount() { return 8; } 
 private int[] m_DropRateOrWeight = new int[8];
 public int GetDropRateOrWeightbyIndex(int idx) {
 if(idx>=0 && idx<8) return m_DropRateOrWeight[idx];
 return -1;
 }
 public ReadOnlyCollection <int> DropRateOrWeights { get { return Array.AsReadOnly(m_DropRateOrWeight);}} 

public int getDropTypeCount() { return 8; } 
 private int[] m_DropType = new int[8];
 public int GetDropTypebyIndex(int idx) {
 if(idx>=0 && idx<8) return m_DropType[idx];
 return -1;
 }
 public ReadOnlyCollection <int> DropTypes { get { return Array.AsReadOnly(m_DropType);}} 

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_IsNotice;
 public int IsNotice { get{ return m_IsNotice;}}

private int m_ItemMax;
 public int ItemMax { get{ return m_ItemMax;}}

private int m_MinSizeCommon;
 public int MinSizeCommon { get{ return m_MinSizeCommon;}}

private int m_NotifyId;
 public int NotifyId { get{ return m_NotifyId;}}

private int m_RandTimes;
 public int RandTimes { get{ return m_RandTimes;}}

private int m_Type;
 public int Type { get{ return m_Type;}}

public static bool LoadTable(Dictionary<int, List<Tab_DropItem> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_DropItem SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_DropItem _values = new Tab_DropItem();
 _values.m_DropCount [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPCOUNT1] as string);
_values.m_DropCount [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPCOUNT2] as string);
_values.m_DropCount [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPCOUNT3] as string);
_values.m_DropCount [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPCOUNT4] as string);
_values.m_DropCount [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPCOUNT5] as string);
_values.m_DropCount [ 5 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPCOUNT6] as string);
_values.m_DropCount [ 6 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPCOUNT7] as string);
_values.m_DropCount [ 7 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPCOUNT8] as string);
_values.m_DropID [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPID1] as string);
_values.m_DropID [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPID2] as string);
_values.m_DropID [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPID3] as string);
_values.m_DropID [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPID4] as string);
_values.m_DropID [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPID5] as string);
_values.m_DropID [ 5 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPID6] as string);
_values.m_DropID [ 6 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPID7] as string);
_values.m_DropID [ 7 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPID8] as string);
_values.m_DropParam [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPARAM1] as string);
_values.m_DropParam [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPARAM2] as string);
_values.m_DropParam [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPARAM3] as string);
_values.m_DropParam [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPARAM4] as string);
_values.m_DropParam [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPARAM5] as string);
_values.m_DropParam [ 5 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPARAM6] as string);
_values.m_DropParam [ 6 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPARAM7] as string);
_values.m_DropParam [ 7 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPARAM8] as string);
_values.m_DropRateOrWeight [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPRATEORWEIGHT1] as string);
_values.m_DropRateOrWeight [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPRATEORWEIGHT2] as string);
_values.m_DropRateOrWeight [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPRATEORWEIGHT3] as string);
_values.m_DropRateOrWeight [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPRATEORWEIGHT4] as string);
_values.m_DropRateOrWeight [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPRATEORWEIGHT5] as string);
_values.m_DropRateOrWeight [ 5 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPRATEORWEIGHT6] as string);
_values.m_DropRateOrWeight [ 6 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPRATEORWEIGHT7] as string);
_values.m_DropRateOrWeight [ 7 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPRATEORWEIGHT8] as string);
_values.m_DropType [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPTYPE1] as string);
_values.m_DropType [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPTYPE2] as string);
_values.m_DropType [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPTYPE3] as string);
_values.m_DropType [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPTYPE4] as string);
_values.m_DropType [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPTYPE5] as string);
_values.m_DropType [ 5 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPTYPE6] as string);
_values.m_DropType [ 6 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPTYPE7] as string);
_values.m_DropType [ 7 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPTYPE8] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_IsNotice =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ISNOTICE] as string);
_values.m_ItemMax =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ITEMMAX] as string);
_values.m_MinSizeCommon =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MINSIZE_COMMON] as string);
_values.m_NotifyId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NOTIFYID] as string);
_values.m_RandTimes =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_RANDTIMES] as string);
_values.m_Type =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TYPE] as string);

 return _values; }


}
}

