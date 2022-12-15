using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Games.GlobeDefine;

//服务器时间
[SLua.CustomLuaClass]
public class ServerTime 
{
    private static DateTime m_startTime = new System.DateTime(1970, 1, 1);
    public static long ServerAnsTime()
    {
        return (DateTime.Now.Ticks - m_clientTicks) / 10000000L + m_serverAnsTime;
    }

    //下次跨天的anstime 目前以05:00为一天起点,即下一个凌晨5点对应的时间戳
    public static long ServerAnsTimeNextDay()
    {
        if (m_serverAnsTime <= 0)
            return 0;
        var serverAnsTime = ServerAnsTime();
        var curDate = GetServerAnsiDateTime(serverAnsTime);
        int offset = GlobeVar.AutoGameConfig.DayOffset > 0 ? GlobeVar.AutoGameConfig.DayOffset % 24 : 0;
        long nextday = serverAnsTime - curDate.Hour * 3600 - curDate.Minute * 60 - curDate.Second + offset * 3600; //今日凌晨5点
        if (curDate.Hour < offset)
        {
            return nextday;
        }
        else
        {
            return nextday + 86400; //下一个凌晨5点
        }
    }

    //开服第几天了
    public static int ServerOpenDays(Robot robot)
    {
        var curDate = GetServerAnsiDateTime(ServerAnsTime());
        var openDate = GetNumeralDateTime(robot.mainPlayer.OpenNumeralTime);

        return DiffDay(GlobeVar.AutoGameConfig.DayOffset, curDate, openDate);
    }

    [SLua.DoNotToLua]
    public static void UpdateServerTime(long serverAnsTime)
    {
        m_serverAnsTime = serverAnsTime;
        m_clientTicks = DateTime.Now.Ticks;
    }

    [SLua.DoNotToLua]
    public static DateTime GetServerAnsiDateTime(long server_ansi_time)
    {
        int offset = GlobeVar.AutoGameConfig.LocalTimeImplTimeZone * 3600; //时区
        server_ansi_time += offset;
        DateTime date = new DateTime(server_ansi_time * 10000000L + m_startTime.Ticks, DateTimeKind.Unspecified);
        return date;
    }

    /// <summary>
    /// 将一个时间戳转化为DayTime 年月日 eg: 20200527
    /// 会算上dayoffset的偏移，目前以05:00为一天起点
    /// 20200527 05:00  得到20200527
    /// 20200527 04:59  得到20200526 
    /// </summary>
    /// <param name="server_ansi_time"></param>
    /// <returns></returns>
    public static int GetServerDayTimeWithOffset(long server_ansi_time)
    {
        int offset = Games.GlobeDefine.GlobeVar.AutoGameConfig.DayOffset * 3600;
        long ansitime = server_ansi_time - offset;
        DateTime date = GetServerAnsiDateTime(ansitime);
        int ret = date.Year * 10000 + date.Month * 100 + date.Day;
        return ret;
    }
    public static int GetServerDayTimeWithOffset()
    {
        return GetServerDayTimeWithOffset(ServerAnsTime());
    }

    public static int GetServerHourTime()
    {
        DateTime date = GetServerAnsiDateTime(ServerAnsTime());
        int ret = date.Hour * 100 + date.Minute;
        return ret;
    }

    [SLua.DoNotToLua]
    public static DateTime GetNumeralDateTime(long numeraltime)
    {
        if (numeraltime <= 0)
            return m_startTime;
        int year = (int)(numeraltime / 10000000000);
        int month = (int)(numeraltime / 100000000 % 100);
        int day = (int)(numeraltime / 1000000 % 100);
        int hour = (int)(numeraltime / 10000 % 100);
        int minute = (int)(numeraltime / 100 % 100);
        int second = (int)(numeraltime % 100);

        DateTime date = new DateTime(year, month, day, hour, minute, second);
        return date;
    }

    [SLua.DoNotToLua]
    //eg 20181001
    public static DateTime GetFormatDateTime(int nDate)
    {
        int nYear = nDate / 10000;
        int nMonth = (nDate % 10000) / 100;
        int nDay = nDate % 100;

        nYear = Math.Max(1970, nYear);
        nMonth = Mathf.Clamp(nMonth, 1, 12);
        nDay = Mathf.Clamp(nDay, 1, DateTime.DaysInMonth(nYear, nMonth));

        return new DateTime(nYear, nMonth, nDay);
    }

    [SLua.DoNotToLua]

    //eg 20190101 233000
    public static DateTime GetFormatDateTime(int nDate, int nTime)
    {
        int nYear = nDate / 10000;
        int nMonth = (nDate % 10000) / 100;
        int nDay = nDate % 100;

        int nHour = nTime / 10000;
        int nMin = (nTime % 10000) / 100;
        int nSec = nTime % 100;

        nYear = Math.Max(1970, nYear);
        nMonth = Mathf.Clamp(nMonth, 1, 12);
        nDay = Mathf.Clamp(nDay, 1, DateTime.DaysInMonth(nYear, nMonth));

        nHour = Mathf.Clamp(nHour, 0, 23);
        nMin = Mathf.Clamp(nMin, 0, 59);
        nSec = Mathf.Clamp(nSec, 0, 59);
        return new DateTime(nYear, nMonth, nDay, nHour, nMin, nSec);
    }


    //给定两个时间相差几天  以nHour为每日分界 目前为凌晨05:00
    //eg: 20200628 04:59:59 20200628 05:00:00 返回1
    //始终返回正整数
    [SLua.DoNotToLua]
    public static int DiffDay(int nHour, DateTime date1, DateTime date2)
    {
        nHour = nHour < 0 ? 0 : nHour % 24;
        if (date1 == null || date2 == null)
            return 0;

        if(date1.Hour < nHour) 
        {
            //回到上一个分界点
            date1 = new DateTime(date1.Year, date1.Month, date1.Day);
            date1 = date1.AddDays(-1);
            date1 = date1.AddHours(nHour);
        }
        else
        {
            date1 = new DateTime(date1.Year, date1.Month, date1.Day, nHour, 0, 0);
        }
        if (date2.Hour < nHour)
        {
            //回到上一个分界点
            date2 = new DateTime(date2.Year, date2.Month, date2.Day);
            date2 = date2.AddDays(-1);
            date2 = date2.AddHours(nHour);
        }
        else
        {
            date2 = new DateTime(date2.Year, date2.Month, date2.Day, nHour, 0, 0);
        }
        var timespan = date1 - date2;
        int days = (int)Math.Ceiling(Math.Abs( timespan.TotalDays));
        return days;
    }

    private static long m_serverAnsTime;
    private static long m_clientTicks;
}
