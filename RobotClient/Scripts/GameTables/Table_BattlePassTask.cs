//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_BattlePassTask
{ private const string TAB_FILE_DATA = "Table/BattlePassTask.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NAME=2,
ID_BATTLEPASSID,
ID_TYPE,
ID_PARAMETER1,
ID_PARAMETER2,
ID_PARAMETER3,
ID_NORMALDROPID,
ID_NORMALDROPPREVIEW,
ID_HIGHDROPID,
ID_HIGHDROPPREVIEW,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_BattlePassId;
 public int BattlePassId { get{ return m_BattlePassId;}}

private int m_HighDropId;
 public int HighDropId { get{ return m_HighDropId;}}

private int m_HighDropPreview;
 public int HighDropPreview { get{ return m_HighDropPreview;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private int m_NormalDropId;
 public int NormalDropId { get{ return m_NormalDropId;}}

private int m_NormalDropPreview;
 public int NormalDropPreview { get{ return m_NormalDropPreview;}}

public int getParameterCount() { return 3; } 
 private int[] m_Parameter = new int[3];
 public int GetParameterbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_Parameter[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> Parameters { get {
  
return Array.AsReadOnly(m_Parameter);
}} 

private int m_Type;
 public int Type { get{ return m_Type;}}

public static bool LoadTable(Dictionary<int, List<Tab_BattlePassTask> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_BattlePassTask SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_BattlePassTask _values = new Tab_BattlePassTask();
 _values.m_BattlePassId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_BATTLEPASSID] as string);
_values.m_HighDropId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HIGHDROPID] as string);
_values.m_HighDropPreview =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HIGHDROPPREVIEW] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_NormalDropId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NORMALDROPID] as string);
_values.m_NormalDropPreview =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_NORMALDROPPREVIEW] as string);
_values.m_Parameter [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PARAMETER1] as string);
_values.m_Parameter [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PARAMETER2] as string);
_values.m_Parameter [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PARAMETER3] as string);
_values.m_Type =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TYPE] as string);

 return _values; }


}
}

