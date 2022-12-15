//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_DropPreview
{ private const string TAB_FILE_DATA = "Table/DropPreview.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_DROPPREVIEW_0=2,
ID_DROPPREVIEWNUM_0,
ID_DROPPREVIEWTYPE_0,
ID_DROPPREVIEWINFO_0,
ID_DROPPREVIEW_1,
ID_DROPPREVIEWNUM_1,
ID_DROPPREVIEWTYPE_1,
ID_DROPPREVIEWINFO_1,
ID_DROPPREVIEW_2,
ID_DROPPREVIEWNUM_2,
ID_DROPPREVIEWTYPE_2,
ID_DROPPREVIEWINFO_2,
ID_DROPPREVIEW_3,
ID_DROPPREVIEWNUM_3,
ID_DROPPREVIEWTYPE_3,
ID_DROPPREVIEWINFO_3,
ID_DROPPREVIEW_4,
ID_DROPPREVIEWNUM_4,
ID_DROPPREVIEWTYPE_4,
ID_DROPPREVIEWINFO_4,
ID_DROPPREVIEW_5,
ID_DROPPREVIEWNUM_5,
ID_DROPPREVIEWTYPE_5,
ID_DROPPREVIEWINFO_5,
ID_DROPPREVIEW_6,
ID_DROPPREVIEWNUM_6,
ID_DROPPREVIEWTYPE_6,
ID_DROPPREVIEWINFO_6,
ID_DROPPREVIEW_7,
ID_DROPPREVIEWNUM_7,
ID_DROPPREVIEWTYPE_7,
ID_DROPPREVIEWINFO_7,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

public int getDropPreviewInfoCount() { return 8; } 
 private int[] m_DropPreviewInfo = new int[8];
 public int GetDropPreviewInfobyIndex(int idx) {
 if(idx>=0 && idx<8) {
 return m_DropPreviewInfo[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> DropPreviewInfos { get {
  
return Array.AsReadOnly(m_DropPreviewInfo);
}} 

public int getDropPreviewNumCount() { return 8; } 
 private int[] m_DropPreviewNum = new int[8];
 public int GetDropPreviewNumbyIndex(int idx) {
 if(idx>=0 && idx<8) {
 return m_DropPreviewNum[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> DropPreviewNums { get {
  
return Array.AsReadOnly(m_DropPreviewNum);
}} 

public int getDropPreviewTypeCount() { return 8; } 
 private int[] m_DropPreviewType = new int[8];
 public int GetDropPreviewTypebyIndex(int idx) {
 if(idx>=0 && idx<8) {
 return m_DropPreviewType[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> DropPreviewTypes { get {
  
return Array.AsReadOnly(m_DropPreviewType);
}} 

public int getDropPreviewCount() { return 8; } 
 private int[] m_DropPreview = new int[8];
 public int GetDropPreviewbyIndex(int idx) {
 if(idx>=0 && idx<8) {
 return m_DropPreview[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> DropPreviews { get {
  
return Array.AsReadOnly(m_DropPreview);
}} 

private int m_Id;
 public int Id { get{ return m_Id;}}

public static bool LoadTable(Dictionary<int, List<Tab_DropPreview> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_DropPreview SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_DropPreview _values = new Tab_DropPreview();
 _values.m_DropPreviewInfo [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPREVIEWINFO_0] as string);
_values.m_DropPreviewInfo [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPREVIEWINFO_1] as string);
_values.m_DropPreviewInfo [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPREVIEWINFO_2] as string);
_values.m_DropPreviewInfo [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPREVIEWINFO_3] as string);
_values.m_DropPreviewInfo [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPREVIEWINFO_4] as string);
_values.m_DropPreviewInfo [ 5 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPREVIEWINFO_5] as string);
_values.m_DropPreviewInfo [ 6 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPREVIEWINFO_6] as string);
_values.m_DropPreviewInfo [ 7 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPREVIEWINFO_7] as string);
_values.m_DropPreviewNum [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPREVIEWNUM_0] as string);
_values.m_DropPreviewNum [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPREVIEWNUM_1] as string);
_values.m_DropPreviewNum [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPREVIEWNUM_2] as string);
_values.m_DropPreviewNum [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPREVIEWNUM_3] as string);
_values.m_DropPreviewNum [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPREVIEWNUM_4] as string);
_values.m_DropPreviewNum [ 5 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPREVIEWNUM_5] as string);
_values.m_DropPreviewNum [ 6 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPREVIEWNUM_6] as string);
_values.m_DropPreviewNum [ 7 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPREVIEWNUM_7] as string);
_values.m_DropPreviewType [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPREVIEWTYPE_0] as string);
_values.m_DropPreviewType [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPREVIEWTYPE_1] as string);
_values.m_DropPreviewType [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPREVIEWTYPE_2] as string);
_values.m_DropPreviewType [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPREVIEWTYPE_3] as string);
_values.m_DropPreviewType [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPREVIEWTYPE_4] as string);
_values.m_DropPreviewType [ 5 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPREVIEWTYPE_5] as string);
_values.m_DropPreviewType [ 6 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPREVIEWTYPE_6] as string);
_values.m_DropPreviewType [ 7 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPREVIEWTYPE_7] as string);
_values.m_DropPreview [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPREVIEW_0] as string);
_values.m_DropPreview [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPREVIEW_1] as string);
_values.m_DropPreview [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPREVIEW_2] as string);
_values.m_DropPreview [ 3 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPREVIEW_3] as string);
_values.m_DropPreview [ 4 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPREVIEW_4] as string);
_values.m_DropPreview [ 5 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPREVIEW_5] as string);
_values.m_DropPreview [ 6 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPREVIEW_6] as string);
_values.m_DropPreview [ 7 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DROPPREVIEW_7] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);

 return _values; }


}
}

