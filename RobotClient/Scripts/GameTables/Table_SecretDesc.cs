//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_SecretDesc
{ private const string TAB_FILE_DATA = "Table/SecretDesc.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_BRIEFANALYSIS=2,
ID_DECRYPT,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private string m_BriefAnalysis;
 public string BriefAnalysis { get{ return m_BriefAnalysis;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_Decrypt;
 public string Decrypt { get{ return m_Decrypt;}}

public static bool LoadTable(Dictionary<int, List<Tab_SecretDesc> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_SecretDesc SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_SecretDesc _values = new Tab_SecretDesc();
 _values.m_BriefAnalysis =  valuesList[(int)_ID.ID_BRIEFANALYSIS] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Decrypt =  valuesList[(int)_ID.ID_DECRYPT] as string;

 return _values; }


}
}

