//Auto Created by Robot, Don't try to Modify
using System;
 using System.Collections.Generic;
 using System.Collections;
 using System.Collections.ObjectModel;

namespace Games.Table{

[Serializable]
 public class Tab_AccountAuthority
{ private const string TAB_FILE_DATA = "table/AccountAuthority.txt";
 enum _ID
 {
 INVLAID_INDEX=-1,
ID_ID,
ID_TYPE=2,
ID_TYPELEVEL,
ID_REALNAME,
ID_LOGINAUTHORITY,
ID_RECHARGEAUTHORITY,
ID_ADULT,
ID_FORBIDLOGINTIME,
ID_ONLINETIMELIMIT,
ID_ONLINETIMELIMITHOLIDAY,
ID_SINGLERECHARGELIMIT,
ID_SINGLERECHARGELIMITERRORTIPS,
ID_MONTHLYRECHARGELIMIT,
ID_MONTHLYRECHARGELIMITERRORTIPS,
MAX_RECORD
 }
 public static string GetInstanceFile(){return TAB_FILE_DATA; }

private int m_Adult;
 public int Adult { get{ return m_Adult;}}

private int m_ForbidLoginTime;
 public int ForbidLoginTime { get{ return m_ForbidLoginTime;}}

private int m_Id;
 public int Id { get{ return m_Id;}}

private int m_LoginAuthority;
 public int LoginAuthority { get{ return m_LoginAuthority;}}

private int m_MonthlyRechargeLimit;
 public int MonthlyRechargeLimit { get{ return m_MonthlyRechargeLimit;}}

private int m_MonthlyRechargeLimitErrorTips;
 public int MonthlyRechargeLimitErrorTips { get{ return m_MonthlyRechargeLimitErrorTips;}}

private int m_OnlineTimeLimit;
 public int OnlineTimeLimit { get{ return m_OnlineTimeLimit;}}

private int m_OnlineTimeLimitHoliday;
 public int OnlineTimeLimitHoliday { get{ return m_OnlineTimeLimitHoliday;}}

private int m_RealName;
 public int RealName { get{ return m_RealName;}}

private int m_RechargeAuthority;
 public int RechargeAuthority { get{ return m_RechargeAuthority;}}

private int m_SingleRechargeLimit;
 public int SingleRechargeLimit { get{ return m_SingleRechargeLimit;}}

private int m_SingleRechargeLimitErrorTips;
 public int SingleRechargeLimitErrorTips { get{ return m_SingleRechargeLimitErrorTips;}}

private int m_Type;
 public int Type { get{ return m_Type;}}

private int m_TypeLevel;
 public int TypeLevel { get{ return m_TypeLevel;}}

public static bool LoadTable(Dictionary<int, List<Tab_AccountAuthority> > _tab)
 {
 if(!TableManager.ReaderPList(GetInstanceFile(),SerializableTable,_tab))
 {
 throw TableException.ErrorReader("Load File{0} Fail!!!",GetInstanceFile());
 }
 return true;
 }
 public static Tab_AccountAuthority SerializableTable(string[] valuesList,int skey)
 {
 if ((int)_ID.MAX_RECORD!=valuesList.Length)
 {
 throw TableException.ErrorReader("Load {0} error as CodeSize:{1} not Equal DataSize:{2}", GetInstanceFile(),_ID.MAX_RECORD,valuesList.Length);
 }
 Tab_AccountAuthority _values = new Tab_AccountAuthority();
 _values.m_Adult =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ADULT] as string);
_values.m_ForbidLoginTime =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_FORBIDLOGINTIME] as string);
_values.m_Id =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ID] as string);
_values.m_LoginAuthority =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_LOGINAUTHORITY] as string);
_values.m_MonthlyRechargeLimit =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MONTHLYRECHARGELIMIT] as string);
_values.m_MonthlyRechargeLimitErrorTips =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_MONTHLYRECHARGELIMITERRORTIPS] as string);
_values.m_OnlineTimeLimit =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ONLINETIMELIMIT] as string);
_values.m_OnlineTimeLimitHoliday =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_ONLINETIMELIMITHOLIDAY] as string);
_values.m_RealName =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_REALNAME] as string);
_values.m_RechargeAuthority =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_RECHARGEAUTHORITY] as string);
_values.m_SingleRechargeLimit =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SINGLERECHARGELIMIT] as string);
_values.m_SingleRechargeLimitErrorTips =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_SINGLERECHARGELIMITERRORTIPS] as string);
_values.m_Type =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TYPE] as string);
_values.m_TypeLevel =  TableManager.ConvertToInt32(valuesList[(int)_ID.ID_TYPELEVEL] as string);

 return _values; }


}
}

