//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_ServerConfigList
{ private const string TAB_FILE_DATA = "table/ServerConfigList.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_WORLDNAME=2,
ID_WORLDTYPE,
ID_REGION,
ID_SELFIP,
ID_PUBLICIP,
ID_PUBLICIPV6,
ID_PORTFORCLIENT,
ID_SERVERTHREADCOUNT,
ID_DBTHREADCOUNT,
ID_HTTPTHREADCOUNT,
ID_DBIP,
ID_DBPORT,
ID_HTTPIP,
ID_HTTPPORT,
ID_HTTPSERVERFAKETOKENCHECKPORT,
ID_HTTPSERVERPAYPORT,
ID_HTTPSERVERREFUNDPORT,
ID_HTTPSERVERIDIPPORT,
ID_MYSQLIP,
ID_MYSQLPORT,
ID_DATABASENAME,
ID_DATABASEUSER,
ID_DATABASEPSW,
ID_MAXONLINEPLAYINGPLAYER,
ID_MAXONLINEQUEUINGPLAYER,
ID_MAXREGISTERPLAYER,
ID_MSDKCHANNEL,
ID_AREAID,
ID_PLATID,
ID_PARTITION,
ID_CROSSLISTENPORT,
ID_OPENREG,
ID_PORTFORGMI,
ID_CROSSWORLDID,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_AreaId;
 public int AreaId { get{ return m_AreaId;}}

private int m_CrossListenPort;
 public int CrossListenPort { get{ return m_CrossListenPort;}}

private int m_CrossWorldId;
 public int CrossWorldId { get{ return m_CrossWorldId;}}

private string m_DBIP;
 public string DBIP { get{ return m_DBIP;}}

private int m_DBPort;
 public int DBPort { get{ return m_DBPort;}}

private int m_DBThreadCount;
 public int DBThreadCount { get{ return m_DBThreadCount;}}

private string m_DataBaseName;
 public string DataBaseName { get{ return m_DataBaseName;}}

private string m_DataBasePsw;
 public string DataBasePsw { get{ return m_DataBasePsw;}}

private string m_DataBaseUser;
 public string DataBaseUser { get{ return m_DataBaseUser;}}

private string m_HttpIP;
 public string HttpIP { get{ return m_HttpIP;}}

private int m_HttpPort;
 public int HttpPort { get{ return m_HttpPort;}}

private int m_HttpServerFakeTokenCheckPort;
 public int HttpServerFakeTokenCheckPort { get{ return m_HttpServerFakeTokenCheckPort;}}

private int m_HttpServerIDIPPort;
 public int HttpServerIDIPPort { get{ return m_HttpServerIDIPPort;}}

private int m_HttpServerPayPort;
 public int HttpServerPayPort { get{ return m_HttpServerPayPort;}}

private int m_HttpServerRefundPort;
 public int HttpServerRefundPort { get{ return m_HttpServerRefundPort;}}

private int m_HttpThreadCount;
 public int HttpThreadCount { get{ return m_HttpThreadCount;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_MaxOnlinePlayingPlayer;
 public int MaxOnlinePlayingPlayer { get{ return m_MaxOnlinePlayingPlayer;}}

private int m_MaxOnlineQueuingPlayer;
 public int MaxOnlineQueuingPlayer { get{ return m_MaxOnlineQueuingPlayer;}}

private int m_MaxRegisterPlayer;
 public int MaxRegisterPlayer { get{ return m_MaxRegisterPlayer;}}

private int m_MsdkChannel;
 public int MsdkChannel { get{ return m_MsdkChannel;}}

private string m_MySQLIP;
 public string MySQLIP { get{ return m_MySQLIP;}}

private int m_MySQLPort;
 public int MySQLPort { get{ return m_MySQLPort;}}

private int m_OpenReg;
 public int OpenReg { get{ return m_OpenReg;}}

private int m_Partition;
 public int Partition { get{ return m_Partition;}}

private int m_PlatId;
 public int PlatId { get{ return m_PlatId;}}

private int m_PortForClient;
 public int PortForClient { get{ return m_PortForClient;}}

private int m_PortForGMI;
 public int PortForGMI { get{ return m_PortForGMI;}}

private string m_PublicIp;
 public string PublicIp { get{ return m_PublicIp;}}

private string m_PublicIpV6;
 public string PublicIpV6 { get{ return m_PublicIpV6;}}

private int m_Region;
 public int Region { get{ return m_Region;}}

private string m_SelfIp;
 public string SelfIp { get{ return m_SelfIp;}}

private int m_ServerThreadCount;
 public int ServerThreadCount { get{ return m_ServerThreadCount;}}

private string m_WorldName;
 public string WorldName { get{ return m_WorldName;}}

private int m_WorldType;
 public int WorldType { get{ return m_WorldType;}}

public static bool LoadTable(Dictionary<int, List<Tab_ServerConfigList> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_ServerConfigList SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_ServerConfigList _values = new Tab_ServerConfigList();
 _values.m_AreaId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_AREAID] as string);
_values.m_CrossListenPort =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CROSSLISTENPORT] as string);
_values.m_CrossWorldId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_CROSSWORLDID] as string);
_values.m_DBIP =  valuesList[(int)_ID.ID_DBIP] as string;
_values.m_DBPort =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DBPORT] as string);
_values.m_DBThreadCount =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_DBTHREADCOUNT] as string);
_values.m_DataBaseName =  valuesList[(int)_ID.ID_DATABASENAME] as string;
_values.m_DataBasePsw =  valuesList[(int)_ID.ID_DATABASEPSW] as string;
_values.m_DataBaseUser =  valuesList[(int)_ID.ID_DATABASEUSER] as string;
_values.m_HttpIP =  valuesList[(int)_ID.ID_HTTPIP] as string;
_values.m_HttpPort =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HTTPPORT] as string);
_values.m_HttpServerFakeTokenCheckPort =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HTTPSERVERFAKETOKENCHECKPORT] as string);
_values.m_HttpServerIDIPPort =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HTTPSERVERIDIPPORT] as string);
_values.m_HttpServerPayPort =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HTTPSERVERPAYPORT] as string);
_values.m_HttpServerRefundPort =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HTTPSERVERREFUNDPORT] as string);
_values.m_HttpThreadCount =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_HTTPTHREADCOUNT] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_MaxOnlinePlayingPlayer =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MAXONLINEPLAYINGPLAYER] as string);
_values.m_MaxOnlineQueuingPlayer =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MAXONLINEQUEUINGPLAYER] as string);
_values.m_MaxRegisterPlayer =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MAXREGISTERPLAYER] as string);
_values.m_MsdkChannel =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MSDKCHANNEL] as string);
_values.m_MySQLIP =  valuesList[(int)_ID.ID_MYSQLIP] as string;
_values.m_MySQLPort =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MYSQLPORT] as string);
_values.m_OpenReg =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_OPENREG] as string);
_values.m_Partition =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PARTITION] as string);
_values.m_PlatId =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PLATID] as string);
_values.m_PortForClient =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PORTFORCLIENT] as string);
_values.m_PortForGMI =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_PORTFORGMI] as string);
_values.m_PublicIp =  valuesList[(int)_ID.ID_PUBLICIP] as string;
_values.m_PublicIpV6 =  valuesList[(int)_ID.ID_PUBLICIPV6] as string;
_values.m_Region =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REGION] as string);
_values.m_SelfIp =  valuesList[(int)_ID.ID_SELFIP] as string;
_values.m_ServerThreadCount =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SERVERTHREADCOUNT] as string);
_values.m_WorldName =  valuesList[(int)_ID.ID_WORLDNAME] as string;
_values.m_WorldType =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_WORLDTYPE] as string);

 return _values; }


}
}

