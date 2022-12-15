//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_CardAsset
{ private const string TAB_FILE_DATA = "Table/CardAsset.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_PREIMAGETINY=2,
ID_PREIMAGEMINI,
ID_PREIMAGEBIG,
ID_PRELIVE2D,
ID_HEADICON,
ID_PROIMAGETINY,
ID_PROIMAGEMINI,
ID_PROIMAGEBIG,
ID_PROLIVE2D,
ID_PROICON,
ID_NORMALFRAME,
ID_ADVANCEFRAME,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private string m_AdvanceFrame;
 public string AdvanceFrame { get{ return m_AdvanceFrame;}}

private string m_HeadIcon;
 public string HeadIcon { get{ return m_HeadIcon;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_NormalFrame;
 public string NormalFrame { get{ return m_NormalFrame;}}

private string m_PreImageBig;
 public string PreImageBig { get{ return m_PreImageBig;}}

private string m_PreImageMini;
 public string PreImageMini { get{ return m_PreImageMini;}}

private string m_PreImageTiny;
 public string PreImageTiny { get{ return m_PreImageTiny;}}

private string m_PreLive2d;
 public string PreLive2d { get{ return m_PreLive2d;}}

private string m_ProIcon;
 public string ProIcon { get{ return m_ProIcon;}}

private string m_ProImageBig;
 public string ProImageBig { get{ return m_ProImageBig;}}

private string m_ProImageMini;
 public string ProImageMini { get{ return m_ProImageMini;}}

private string m_ProImageTiny;
 public string ProImageTiny { get{ return m_ProImageTiny;}}

private string m_ProLive2d;
 public string ProLive2d { get{ return m_ProLive2d;}}

public static bool LoadTable(Dictionary<int, List<Tab_CardAsset> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_CardAsset SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_CardAsset _values = new Tab_CardAsset();
 _values.m_AdvanceFrame =  valuesList[(int)_ID.ID_ADVANCEFRAME] as string;
_values.m_HeadIcon =  valuesList[(int)_ID.ID_HEADICON] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_NormalFrame =  valuesList[(int)_ID.ID_NORMALFRAME] as string;
_values.m_PreImageBig =  valuesList[(int)_ID.ID_PREIMAGEBIG] as string;
_values.m_PreImageMini =  valuesList[(int)_ID.ID_PREIMAGEMINI] as string;
_values.m_PreImageTiny =  valuesList[(int)_ID.ID_PREIMAGETINY] as string;
_values.m_PreLive2d =  valuesList[(int)_ID.ID_PRELIVE2D] as string;
_values.m_ProIcon =  valuesList[(int)_ID.ID_PROICON] as string;
_values.m_ProImageBig =  valuesList[(int)_ID.ID_PROIMAGEBIG] as string;
_values.m_ProImageMini =  valuesList[(int)_ID.ID_PROIMAGEMINI] as string;
_values.m_ProImageTiny =  valuesList[(int)_ID.ID_PROIMAGETINY] as string;
_values.m_ProLive2d =  valuesList[(int)_ID.ID_PROLIVE2D] as string;

 return _values; }


}
}

