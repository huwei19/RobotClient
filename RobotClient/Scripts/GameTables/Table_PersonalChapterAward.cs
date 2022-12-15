//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_PersonalChapterAward
{ private const string TAB_FILE_DATA = "Table/PersonalChapterAward.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_AWARDPERSONALITY_0=2,
ID_AWARDNEED_0,
ID_AWARDDROPID_0,
ID_AWARDDROPPREVIEW_0,
ID_AWARDPERSONALITY_1,
ID_AWARDNEED_1,
ID_AWARDDROPID_1,
ID_AWARDDROPPREVIEW_1,
ID_AWARDPERSONALITY_2,
ID_AWARDNEED_2,
ID_AWARDDROPID_2,
ID_AWARDDROPPREVIEW_2,
ID_AWARDPERSONALITY_3,
ID_AWARDNEED_3,
ID_AWARDDROPID_3,
ID_AWARDDROPPREVIEW_3,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

public int getAwardDropIdCount() { return 4; } 
 private int[] m_AwardDropId = new int[4];
 public int GetAwardDropIdbyIndex(int idx) {
 if(idx>=0 && idx<4) {
 return m_AwardDropId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> AwardDropIds { get {
  
return Array.AsReadOnly(m_AwardDropId);
}} 

public int getAwardDropPreviewCount() { return 4; } 
 private int[] m_AwardDropPreview = new int[4];
 public int GetAwardDropPreviewbyIndex(int idx) {
 if(idx>=0 && idx<4) {
 return m_AwardDropPreview[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> AwardDropPreviews { get {
  
return Array.AsReadOnly(m_AwardDropPreview);
}} 

public int getAwardNeedCount() { return 4; } 
 private int[] m_AwardNeed = new int[4];
 public int GetAwardNeedbyIndex(int idx) {
 if(idx>=0 && idx<4) {
 return m_AwardNeed[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> AwardNeeds { get {
  
return Array.AsReadOnly(m_AwardNeed);
}} 

public int getAwardPersonalityCount() { return 4; } 
 private int[] m_AwardPersonality = new int[4];
 public int GetAwardPersonalitybyIndex(int idx) {
 if(idx>=0 && idx<4) {
 return m_AwardPersonality[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> AwardPersonalitys { get {
  
return Array.AsReadOnly(m_AwardPersonality);
}} 

private int m_Id;
 public int Id { get{ return m_Id;}}

public static bool LoadTable(Dictionary<int, List<Tab_PersonalChapterAward> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_PersonalChapterAward SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_PersonalChapterAward _values = new Tab_PersonalChapterAward();
 _values.m_AwardDropId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AWARDDROPID_0] as string);
_values.m_AwardDropId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AWARDDROPID_1] as string);
_values.m_AwardDropId [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AWARDDROPID_2] as string);
_values.m_AwardDropId [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AWARDDROPID_3] as string);
_values.m_AwardDropPreview [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AWARDDROPPREVIEW_0] as string);
_values.m_AwardDropPreview [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AWARDDROPPREVIEW_1] as string);
_values.m_AwardDropPreview [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AWARDDROPPREVIEW_2] as string);
_values.m_AwardDropPreview [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AWARDDROPPREVIEW_3] as string);
_values.m_AwardNeed [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AWARDNEED_0] as string);
_values.m_AwardNeed [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AWARDNEED_1] as string);
_values.m_AwardNeed [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AWARDNEED_2] as string);
_values.m_AwardNeed [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AWARDNEED_3] as string);
_values.m_AwardPersonality [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AWARDPERSONALITY_0] as string);
_values.m_AwardPersonality [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AWARDPERSONALITY_1] as string);
_values.m_AwardPersonality [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AWARDPERSONALITY_2] as string);
_values.m_AwardPersonality [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AWARDPERSONALITY_3] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);

 return _values; }


}
}

