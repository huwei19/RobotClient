//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_Enviroment
{ private const string TAB_FILE_DATA = "Table/Enviroment.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_SCENE=2,
ID_NAME,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Id;
 public int Id { get{ return m_Id;}}

private string m_Name;
 public string Name { get{ return m_Name;}}

private string m_Scene;
 public string Scene { get{ return m_Scene;}}

public static bool LoadTable(Dictionary<int, List<Tab_Enviroment> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_Enviroment SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_Enviroment _values = new Tab_Enviroment();
 _values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Name =  valuesList[(int)_ID.ID_NAME] as string;
_values.m_Scene =  valuesList[(int)_ID.ID_SCENE] as string;

 return _values; }


}
}

