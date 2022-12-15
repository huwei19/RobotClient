//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_DrawCardNormal
{ private const string TAB_FILE_DATA = "table/DrawCardNormal.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_POTTYPE=2,
ID_POTID,
ID_POTWEIGHT,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_PotId;
 public int PotId { get{ return m_PotId;}}

private int m_PotType;
 public int PotType { get{ return m_PotType;}}

private int m_PotWeight;
 public int PotWeight { get{ return m_PotWeight;}}

public static bool LoadTable(Dictionary<int, List<Tab_DrawCardNormal> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_DrawCardNormal SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_DrawCardNormal _values = new Tab_DrawCardNormal();
 _values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_PotId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_POTID] as string);
_values.m_PotType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_POTTYPE] as string);
_values.m_PotWeight =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_POTWEIGHT] as string);

 return _values; }


}
}

