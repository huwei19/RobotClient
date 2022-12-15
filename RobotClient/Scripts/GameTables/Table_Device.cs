//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_Device
{ private const string TAB_FILE_DATA = "Table/Device.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_GPUNAME=2,
ID_LEVEL,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private string m_GPUName;
 public string GPUName { get{ return m_GPUName;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_Level;
 public int Level { get{ return m_Level;}}

public static bool LoadTable(Dictionary<int, List<Tab_Device> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_Device SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_Device _values = new Tab_Device();
 _values.m_GPUName =  valuesList[(int)_ID.ID_GPUNAME] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Level =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LEVEL] as string);

 return _values; }


}
}

