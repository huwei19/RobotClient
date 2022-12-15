//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_StoryChapterLevelReq
{ private const string TAB_FILE_DATA = "Table/StoryChapterLevelReq.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_ACTION=2,
ID_ACTIONREQ,
ID_ABILITYID_0,
ID_ABILITYSTATE_0,
ID_ABILITYREQ_0,
ID_ABILITYID_1,
ID_ABILITYSTATE_1,
ID_ABILITYREQ_1,
ID_ABILITYID_2,
ID_ABILITYSTATE_2,
ID_ABILITYREQ_2,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

public int getAbilityIdCount() { return 3; } 
 private int[] m_AbilityId = new int[3];
 public int GetAbilityIdbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_AbilityId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> AbilityIds { get {
  
return Array.AsReadOnly(m_AbilityId);
}} 

public int getAbilityReqCount() { return 3; } 
 private int[] m_AbilityReq = new int[3];
 public int GetAbilityReqbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_AbilityReq[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> AbilityReqs { get {
  
return Array.AsReadOnly(m_AbilityReq);
}} 

public int getAbilityStateCount() { return 3; } 
 private int[] m_AbilityState = new int[3];
 public int GetAbilityStatebyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_AbilityState[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> AbilityStates { get {
  
return Array.AsReadOnly(m_AbilityState);
}} 

private int m_Action;
 public int Action { get{ return m_Action;}}

private int m_ActionReq;
 public int ActionReq { get{ return m_ActionReq;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

public static bool LoadTable(Dictionary<int, List<Tab_StoryChapterLevelReq> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_StoryChapterLevelReq SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_StoryChapterLevelReq _values = new Tab_StoryChapterLevelReq();
 _values.m_AbilityId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ABILITYID_0] as string);
_values.m_AbilityId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ABILITYID_1] as string);
_values.m_AbilityId [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ABILITYID_2] as string);
_values.m_AbilityReq [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ABILITYREQ_0] as string);
_values.m_AbilityReq [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ABILITYREQ_1] as string);
_values.m_AbilityReq [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ABILITYREQ_2] as string);
_values.m_AbilityState [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ABILITYSTATE_0] as string);
_values.m_AbilityState [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ABILITYSTATE_1] as string);
_values.m_AbilityState [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ABILITYSTATE_2] as string);
_values.m_Action =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTION] as string);
_values.m_ActionReq =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIONREQ] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);

 return _values; }


}
}

