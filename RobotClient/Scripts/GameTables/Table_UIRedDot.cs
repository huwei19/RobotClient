//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_UIRedDot
{ private const string TAB_FILE_DATA = "Table/UIRedDot.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_CHILDRENID_0=2,
ID_CHILDRENID_1,
ID_CHILDRENID_2,
ID_CHILDRENID_3,
ID_CHILDRENID_4,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

public int getChildrenIdCount() { return 5; } 
 private int[] m_ChildrenId = new int[5];
 public int GetChildrenIdbyIndex(int idx) {
 if(idx>=0 && idx<5) {
 return m_ChildrenId[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> ChildrenIds { get {
  
return Array.AsReadOnly(m_ChildrenId);
}} 

private int m_Id;
 public int Id { get{ return m_Id;}}

public static bool LoadTable(Dictionary<int, List<Tab_UIRedDot> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_UIRedDot SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_UIRedDot _values = new Tab_UIRedDot();
 _values.m_ChildrenId [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHILDRENID_0] as string);
_values.m_ChildrenId [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHILDRENID_1] as string);
_values.m_ChildrenId [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHILDRENID_2] as string);
_values.m_ChildrenId [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHILDRENID_3] as string);
_values.m_ChildrenId [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CHILDRENID_4] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);

 return _values; }


}
}

