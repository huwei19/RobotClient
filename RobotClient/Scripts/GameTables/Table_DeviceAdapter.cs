//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_DeviceAdapter
{ private const string TAB_FILE_DATA = "Table/DeviceAdapter.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_DEVICEMODEL_0=2,
ID_DEVICEMODEL_1,
ID_OFFSET,
ID_WATERDROP,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

public int getDeviceModelCount() { return 2; } 
 private string[] m_DeviceModel = new string[2];
 public string GetDeviceModelbyIndex(int idx) {
 if(idx>=0 && idx<2) {
 return m_DeviceModel[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> DeviceModels { get {
  
return Array.AsReadOnly(m_DeviceModel);
}} 

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_Offset;
 public int Offset { get{ return m_Offset;}}

private int m_WaterDrop;
 public int WaterDrop { get{ return m_WaterDrop;}}

public static bool LoadTable(Dictionary<int, List<Tab_DeviceAdapter> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_DeviceAdapter SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_DeviceAdapter _values = new Tab_DeviceAdapter();
 _values.m_DeviceModel [ 0 ] =  valuesList[(int)_ID.ID_DEVICEMODEL_0] as string;
_values.m_DeviceModel [ 1 ] =  valuesList[(int)_ID.ID_DEVICEMODEL_1] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_Offset =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_OFFSET] as string);
_values.m_WaterDrop =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_WATERDROP] as string);

 return _values; }


}
}

