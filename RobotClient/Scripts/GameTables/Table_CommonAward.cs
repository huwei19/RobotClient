//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_CommonAward
{ private const string TAB_FILE_DATA = "Table/CommonAward.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_AWARDTYPE_0=2,
ID_AWARDID_0,
ID_AWARDNUM_0,
ID_AWARDTYPE_1,
ID_AWARDID_1,
ID_AWARDNUM_1,
ID_AWARDTYPE_2,
ID_AWARDID_2,
ID_AWARDNUM_2,
ID_DROPID,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

public int getAwardIdCount() { return 3; } 
 private int[] m_AwardId = new int[3];
 public int GetAwardIdbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_AwardId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> AwardIds { get {
  
return Array.AsReadOnly(m_AwardId);
}} 

public int getAwardNumCount() { return 3; } 
 private int[] m_AwardNum = new int[3];
 public int GetAwardNumbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_AwardNum[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> AwardNums { get {
  
return Array.AsReadOnly(m_AwardNum);
}} 

public int getAwardTypeCount() { return 3; } 
 private int[] m_AwardType = new int[3];
 public int GetAwardTypebyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_AwardType[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> AwardTypes { get {
  
return Array.AsReadOnly(m_AwardType);
}} 

private int m_DropId;
 public int DropId { get{ return m_DropId;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

public static bool LoadTable(Dictionary<int, List<Tab_CommonAward> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_CommonAward SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_CommonAward _values = new Tab_CommonAward();
 _values.m_AwardId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AWARDID_0] as string);
_values.m_AwardId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AWARDID_1] as string);
_values.m_AwardId [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AWARDID_2] as string);
_values.m_AwardNum [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AWARDNUM_0] as string);
_values.m_AwardNum [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AWARDNUM_1] as string);
_values.m_AwardNum [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AWARDNUM_2] as string);
_values.m_AwardType [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AWARDTYPE_0] as string);
_values.m_AwardType [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AWARDTYPE_1] as string);
_values.m_AwardType [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AWARDTYPE_2] as string);
_values.m_DropId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPID] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);

 return _values; }


}
}

