//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_FateLineAvatar
{ private const string TAB_FILE_DATA = "Table/FateLineAvatar.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_AVATARSTATE_0=2,
ID_AVATARID_0,
ID_AVATARSTATE_1,
ID_AVATARID_1,
ID_AVATARSTATE_2,
ID_AVATARID_2,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

public int getAvatarIdCount() { return 3; } 
 private int[] m_AvatarId = new int[3];
 public int GetAvatarIdbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_AvatarId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> AvatarIds { get {
  
return Array.AsReadOnly(m_AvatarId);
}} 

public int getAvatarStateCount() { return 3; } 
 private int[] m_AvatarState = new int[3];
 public int GetAvatarStatebyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_AvatarState[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> AvatarStates { get {
  
return Array.AsReadOnly(m_AvatarState);
}} 

private int m_Id;
 public int Id { get{ return m_Id;}}

public static bool LoadTable(Dictionary<int, List<Tab_FateLineAvatar> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_FateLineAvatar SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_FateLineAvatar _values = new Tab_FateLineAvatar();
 _values.m_AvatarId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AVATARID_0] as string);
_values.m_AvatarId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AVATARID_1] as string);
_values.m_AvatarId [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AVATARID_2] as string);
_values.m_AvatarState [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AVATARSTATE_0] as string);
_values.m_AvatarState [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AVATARSTATE_1] as string);
_values.m_AvatarState [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AVATARSTATE_2] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);

 return _values; }


}
}

