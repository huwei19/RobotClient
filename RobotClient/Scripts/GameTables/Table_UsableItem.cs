//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_UsableItem
{ private const string TAB_FILE_DATA = "table/UsableItem.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_NAME=2,
ID_USETYPE,
ID_CONSUMEFLAG,
ID_COOLDOWNID,
ID_USEPARAMA,
ID_USEPARAMB,
ID_USEPARAMC,
ID_USEPARAMD,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_ConsumeFlag;
 public int ConsumeFlag { get{ return m_ConsumeFlag;}}

private int m_CoolDownId;
 public int CoolDownId { get{ return m_CoolDownId;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private int m_UseParamA;
 public int UseParamA { get{ return m_UseParamA;}}

private int m_UseParamB;
 public int UseParamB { get{ return m_UseParamB;}}

private int m_UseParamC;
 public int UseParamC { get{ return m_UseParamC;}}

private int m_UseParamD;
 public int UseParamD { get{ return m_UseParamD;}}

private int m_UseType;
 public int UseType { get{ return m_UseType;}}

public static bool LoadTable(Dictionary<int, List<Tab_UsableItem> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_UsableItem SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_UsableItem _values = new Tab_UsableItem();
 _values.m_ConsumeFlag =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CONSUMEFLAG] as string);
_values.m_CoolDownId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_COOLDOWNID] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_UseParamA =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_USEPARAMA] as string);
_values.m_UseParamB =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_USEPARAMB] as string);
_values.m_UseParamC =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_USEPARAMC] as string);
_values.m_UseParamD =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_USEPARAMD] as string);
_values.m_UseType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_USETYPE] as string);

 return _values; }


}
}

