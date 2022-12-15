//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_StoryChapterEnding
{ private const string TAB_FILE_DATA = "Table/StoryChapterEnding.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_RANK=2,
ID_RULE,
ID_HINT_0,
ID_HINT_1,
ID_HINT_2,
ID_REWARD,
ID_REWARDPREVIEW,
ID_AUDIOID,
ID_CLUEREQ,
ID_CONDITIONID,
ID_NPCANDID_0,
ID_NPCANDSTATUS_0,
ID_NPCANDID_1,
ID_NPCANDSTATUS_1,
ID_NPCANDID_2,
ID_NPCANDSTATUS_2,
ID_NPCANDID_3,
ID_NPCANDSTATUS_3,
ID_NPCORID_0,
ID_NPCORSTATUS_0,
ID_NPCORID_1,
ID_NPCORSTATUS_1,
ID_NPCORID_2,
ID_NPCORSTATUS_2,
ID_SCLUEREQAND_0,
ID_SCLUEREQAND_1,
ID_SCLUEREQAND_2,
ID_SCLUEREQAND_3,
ID_SCLUEREQAND_4,
ID_SCLUEREQOR_0,
ID_SCLUEREQOR_1,
ID_SCLUEREQOR_2,
ID_OBJECTIVEANDTHOUGHT_0,
ID_OBJECTIVEANDSELECTINDEX_0,
ID_OBJECTIVEANDDESC_0,
ID_OBJECTIVEANDTHOUGHT_1,
ID_OBJECTIVEANDSELECTINDEX_1,
ID_OBJECTIVEANDDESC_1,
ID_OBJECTIVEANDTHOUGHT_2,
ID_OBJECTIVEANDSELECTINDEX_2,
ID_OBJECTIVEANDDESC_2,
ID_OBJECTIVEORTHOUGHT_0,
ID_OBJECTIVEORSELECTINDEX_0,
ID_OBJECTIVEORDESC_0,
ID_OBJECTIVEORTHOUGHT_1,
ID_OBJECTIVEORSELECTINDEX_1,
ID_OBJECTIVEORDESC_1,
ID_OBJECTIVEORTHOUGHT_2,
ID_OBJECTIVEORSELECTINDEX_2,
ID_OBJECTIVEORDESC_2,
ID_PLACEHOLDER,
ID_ACTIONID,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_ActionId;
 public int ActionId { get{ return m_ActionId;}}

private int m_AudioId;
 public int AudioId { get{ return m_AudioId;}}

private int m_ClueReq;
 public int ClueReq { get{ return m_ClueReq;}}

private int m_ConditionId;
 public int ConditionId { get{ return m_ConditionId;}}

public int getHintCount() { return 3; } 
 private string[] m_Hint = new string[3];
 public string GetHintbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_Hint[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> Hints { get {
  
return Array.AsReadOnly(m_Hint);
}} 

private int m_Id;
 public int Id { get{ return m_Id;}}

public int getNpcAndIdCount() { return 4; } 
 private int[] m_NpcAndId = new int[4];
 public int GetNpcAndIdbyIndex(int idx) {
 if(idx>=0 && idx<4) {
 return m_NpcAndId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> NpcAndIds { get {
  
return Array.AsReadOnly(m_NpcAndId);
}} 

public int getNpcAndStatusCount() { return 4; } 
 private int[] m_NpcAndStatus = new int[4];
 public int GetNpcAndStatusbyIndex(int idx) {
 if(idx>=0 && idx<4) {
 return m_NpcAndStatus[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> NpcAndStatuss { get {
  
return Array.AsReadOnly(m_NpcAndStatus);
}} 

public int getNpcOrIdCount() { return 3; } 
 private int[] m_NpcOrId = new int[3];
 public int GetNpcOrIdbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_NpcOrId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> NpcOrIds { get {
  
return Array.AsReadOnly(m_NpcOrId);
}} 

public int getNpcOrStatusCount() { return 3; } 
 private int[] m_NpcOrStatus = new int[3];
 public int GetNpcOrStatusbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_NpcOrStatus[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> NpcOrStatuss { get {
  
return Array.AsReadOnly(m_NpcOrStatus);
}} 

public int getObjectiveandDescCount() { return 3; } 
 private string[] m_ObjectiveandDesc = new string[3];
 public string GetObjectiveandDescbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_ObjectiveandDesc[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> ObjectiveandDescs { get {
  
return Array.AsReadOnly(m_ObjectiveandDesc);
}} 

public int getObjectiveandSelectIndexCount() { return 3; } 
 private int[] m_ObjectiveandSelectIndex = new int[3];
 public int GetObjectiveandSelectIndexbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_ObjectiveandSelectIndex[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> ObjectiveandSelectIndexs { get {
  
return Array.AsReadOnly(m_ObjectiveandSelectIndex);
}} 

public int getObjectiveandThoughtCount() { return 3; } 
 private int[] m_ObjectiveandThought = new int[3];
 public int GetObjectiveandThoughtbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_ObjectiveandThought[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> ObjectiveandThoughts { get {
  
return Array.AsReadOnly(m_ObjectiveandThought);
}} 

public int getObjectiveorDescCount() { return 3; } 
 private string[] m_ObjectiveorDesc = new string[3];
 public string GetObjectiveorDescbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_ObjectiveorDesc[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> ObjectiveorDescs { get {
  
return Array.AsReadOnly(m_ObjectiveorDesc);
}} 

public int getObjectiveorSelectIndexCount() { return 3; } 
 private int[] m_ObjectiveorSelectIndex = new int[3];
 public int GetObjectiveorSelectIndexbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_ObjectiveorSelectIndex[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> ObjectiveorSelectIndexs { get {
  
return Array.AsReadOnly(m_ObjectiveorSelectIndex);
}} 

public int getObjectiveorThoughtCount() { return 3; } 
 private int[] m_ObjectiveorThought = new int[3];
 public int GetObjectiveorThoughtbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_ObjectiveorThought[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> ObjectiveorThoughts { get {
  
return Array.AsReadOnly(m_ObjectiveorThought);
}} 

private int m_PlaceHolder;
 public int PlaceHolder { get{ return m_PlaceHolder;}}

private string m_Rank;
 public string Rank { get{ return m_Rank;}}

private int m_Reward;
 public int Reward { get{ return m_Reward;}}

private int m_RewardPreview;
 public int RewardPreview { get{ return m_RewardPreview;}}

private int m_Rule;
 public int Rule { get{ return m_Rule;}}

public int getSclueReqAndCount() { return 5; } 
 private int[] m_SclueReqAnd = new int[5];
 public int GetSclueReqAndbyIndex(int idx) {
 if(idx>=0 && idx<5) {
 return m_SclueReqAnd[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> SclueReqAnds { get {
  
return Array.AsReadOnly(m_SclueReqAnd);
}} 

public int getSclueReqOrCount() { return 3; } 
 private int[] m_SclueReqOr = new int[3];
 public int GetSclueReqOrbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_SclueReqOr[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> SclueReqOrs { get {
  
return Array.AsReadOnly(m_SclueReqOr);
}} 

public static bool LoadTable(Dictionary<int, List<Tab_StoryChapterEnding> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_StoryChapterEnding SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_StoryChapterEnding _values = new Tab_StoryChapterEnding();
 _values.m_ActionId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ACTIONID] as string);
_values.m_AudioId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AUDIOID] as string);
_values.m_ClueReq =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CLUEREQ] as string);
_values.m_ConditionId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CONDITIONID] as string);
_values.m_Hint [ 0 ] =  valuesList[(int)_ID.ID_HINT_0] as string;
_values.m_Hint [ 1 ] =  valuesList[(int)_ID.ID_HINT_1] as string;
_values.m_Hint [ 2 ] =  valuesList[(int)_ID.ID_HINT_2] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_NpcAndId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NPCANDID_0] as string);
_values.m_NpcAndId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NPCANDID_1] as string);
_values.m_NpcAndId [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NPCANDID_2] as string);
_values.m_NpcAndId [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NPCANDID_3] as string);
_values.m_NpcAndStatus [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NPCANDSTATUS_0] as string);
_values.m_NpcAndStatus [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NPCANDSTATUS_1] as string);
_values.m_NpcAndStatus [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NPCANDSTATUS_2] as string);
_values.m_NpcAndStatus [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NPCANDSTATUS_3] as string);
_values.m_NpcOrId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NPCORID_0] as string);
_values.m_NpcOrId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NPCORID_1] as string);
_values.m_NpcOrId [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NPCORID_2] as string);
_values.m_NpcOrStatus [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NPCORSTATUS_0] as string);
_values.m_NpcOrStatus [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NPCORSTATUS_1] as string);
_values.m_NpcOrStatus [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NPCORSTATUS_2] as string);
_values.m_ObjectiveandDesc [ 0 ] =  valuesList[(int)_ID.ID_OBJECTIVEANDDESC_0] as string;
_values.m_ObjectiveandDesc [ 1 ] =  valuesList[(int)_ID.ID_OBJECTIVEANDDESC_1] as string;
_values.m_ObjectiveandDesc [ 2 ] =  valuesList[(int)_ID.ID_OBJECTIVEANDDESC_2] as string;
_values.m_ObjectiveandSelectIndex [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_OBJECTIVEANDSELECTINDEX_0] as string);
_values.m_ObjectiveandSelectIndex [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_OBJECTIVEANDSELECTINDEX_1] as string);
_values.m_ObjectiveandSelectIndex [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_OBJECTIVEANDSELECTINDEX_2] as string);
_values.m_ObjectiveandThought [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_OBJECTIVEANDTHOUGHT_0] as string);
_values.m_ObjectiveandThought [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_OBJECTIVEANDTHOUGHT_1] as string);
_values.m_ObjectiveandThought [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_OBJECTIVEANDTHOUGHT_2] as string);
_values.m_ObjectiveorDesc [ 0 ] =  valuesList[(int)_ID.ID_OBJECTIVEORDESC_0] as string;
_values.m_ObjectiveorDesc [ 1 ] =  valuesList[(int)_ID.ID_OBJECTIVEORDESC_1] as string;
_values.m_ObjectiveorDesc [ 2 ] =  valuesList[(int)_ID.ID_OBJECTIVEORDESC_2] as string;
_values.m_ObjectiveorSelectIndex [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_OBJECTIVEORSELECTINDEX_0] as string);
_values.m_ObjectiveorSelectIndex [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_OBJECTIVEORSELECTINDEX_1] as string);
_values.m_ObjectiveorSelectIndex [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_OBJECTIVEORSELECTINDEX_2] as string);
_values.m_ObjectiveorThought [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_OBJECTIVEORTHOUGHT_0] as string);
_values.m_ObjectiveorThought [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_OBJECTIVEORTHOUGHT_1] as string);
_values.m_ObjectiveorThought [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_OBJECTIVEORTHOUGHT_2] as string);
_values.m_PlaceHolder =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PLACEHOLDER] as string);
_values.m_Rank =  valuesList[(int)_ID.ID_RANK] as string;
_values.m_Reward =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REWARD] as string);
_values.m_RewardPreview =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REWARDPREVIEW] as string);
_values.m_Rule =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_RULE] as string);
_values.m_SclueReqAnd [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SCLUEREQAND_0] as string);
_values.m_SclueReqAnd [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SCLUEREQAND_1] as string);
_values.m_SclueReqAnd [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SCLUEREQAND_2] as string);
_values.m_SclueReqAnd [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SCLUEREQAND_3] as string);
_values.m_SclueReqAnd [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SCLUEREQAND_4] as string);
_values.m_SclueReqOr [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SCLUEREQOR_0] as string);
_values.m_SclueReqOr [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SCLUEREQOR_1] as string);
_values.m_SclueReqOr [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SCLUEREQOR_2] as string);

 return _values; }


}
}

