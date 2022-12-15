//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_Example
{ private const string TAB_FILE_DATA = "Table/Example.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_P1=2,
ID_P2,
ID_P3,
ID_STRUCTA_X,
ID_STRUCTA_Y,
ID_STRUCTA_Z,
ID_LISTA_0,
ID_LISTA_1,
ID_LISTA_2,
ID_ELEA_0,
ID_ELEB_0,
ID_ELEC_0,
ID_ELEA_1,
ID_ELEB_1,
ID_ELEC_1,
ID_ELEA_2,
ID_ELEB_2,
ID_ELEC_2,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

public int getEleACount() { return 3; } 
 private int[] m_EleA = new int[3];
 public int GetEleAbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_EleA[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> EleAs { get {
  
return Array.AsReadOnly(m_EleA);
}} 

public int getEleBCount() { return 3; } 
 private float[] m_EleB = new float[3];
 public float GetEleBbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_EleB[idx]; }
 return 0.0f;
 }
 public ReadOnlyCollection <float> EleBs { get {
  
return Array.AsReadOnly(m_EleB);
}} 

public int getEleCCount() { return 3; } 
 private string[] m_EleC = new string[3];
 public string GetEleCbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_EleC[idx]; }
 return "";
 }
 public ReadOnlyCollection <string> EleCs { get {
  
return Array.AsReadOnly(m_EleC);
}} 

private int m_Id;
 public int Id { get{ return m_Id;}}

public int getListACount() { return 3; } 
 private int[] m_ListA = new int[3];
 public int GetListAbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_ListA[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> ListAs { get {
  
return Array.AsReadOnly(m_ListA);
}} 

public int getPCount() { return 3; } 
 private int[] m_P = new int[3];
 public int GetPbyIndex(int idx) {
 if(idx>=0 && idx<3) {
 return m_P[idx]; }
 return -1;
 }
 public ReadOnlyCollection <int> Ps { get {
  
return Array.AsReadOnly(m_P);
}} 

private int m_StructAX;
 public int StructAX { get{ return m_StructAX;}}

private float m_StructAY;
 public float StructAY { get{ return m_StructAY;}}

private string m_StructAZ;
 public string StructAZ { get{ return m_StructAZ;}}

public static bool LoadTable(Dictionary<int, List<Tab_Example> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_Example SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_Example _values = new Tab_Example();
 _values.m_EleA [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ELEA_0] as string);
_values.m_EleA [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ELEA_1] as string);
_values.m_EleA [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ELEA_2] as string);
_values.m_EleB [ 0 ] =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_ELEB_0] as string );
_values.m_EleB [ 1 ] =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_ELEB_1] as string );
_values.m_EleB [ 2 ] =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_ELEB_2] as string );
_values.m_EleC [ 0 ] =  valuesList[(int)_ID.ID_ELEC_0] as string;
_values.m_EleC [ 1 ] =  valuesList[(int)_ID.ID_ELEC_1] as string;
_values.m_EleC [ 2 ] =  valuesList[(int)_ID.ID_ELEC_2] as string;
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_ListA [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LISTA_0] as string);
_values.m_ListA [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LISTA_1] as string);
_values.m_ListA [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LISTA_2] as string);
_values.m_P [ 0 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_P1] as string);
_values.m_P [ 1 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_P2] as string);
_values.m_P [ 2 ] =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_P3] as string);
_values.m_StructAX =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_STRUCTA_X] as string);
_values.m_StructAY =  TableManager.ConvertToSingle(valuesList[(int)_ID.ID_STRUCTA_Y] as string );
_values.m_StructAZ =  valuesList[(int)_ID.ID_STRUCTA_Z] as string;

 return _values; }


}
}

