using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;

public class GlobalData
{
    public enum HttpType
    {
        Http = 0,
        Https = 1,
    }

    public class ServerListData
    {
        public int serverID;
        public string ip;
        public int port;
        public int regionID;
        public HttpType httpType; 
    }

    public class RegionListData
    {
        public int regionID;
        public string loginServerUrl;
    }

    public class DeployData
    {
        public int Id;
        public string Desc;
        public bool Enable;
        public string DeployName;
        public string SvrName;
        public string PrivateIP;
        public string PublicIP;
        public int GroupNum;
        public int AIType;
        public int ServerId;
        public int RobotNum;
        public bool IsLog;
        public int InitId;
        public int ExeCDTime;
        public int Arg0;  //(禁止登陆模式：0无禁止，1禁止http登陆，2禁止https登陆)
        public int Arg1;
        public int Arg2;
    }

    //public static Dictionary<int, ServerListData> s_dicServerList = new Dictionary<int, ServerListData>();
    public static List<ServerListData> s_ServerList = new List<ServerListData>();

    public static Dictionary<int, RegionListData> s_dicRegionList = new Dictionary<int, RegionListData>();
    public static Dictionary<int, DeployData> s_dicDeployList = new Dictionary<int, DeployData>();

    public static void InitServerListData()
    {
        //GameLog.Log("--- 初始化了一次 服务器列表");
        s_ServerList.Clear();

        string filePath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "serverlist.txt");
        string serverListData = File.ReadAllText(filePath);
        if (null == serverListData)
        {
            Console.WriteLine("server list load error");
            return;
        }
        string[] lines = serverListData.Split('\n');
        for (int i = 0; i < lines.Length; i++)
        {
            if (lines[i].StartsWith("-"))
            {
                continue;
            }

            string[] serverDataInfo = lines[i].Split('\t');
            if (serverDataInfo.Length < 4)
            {
                continue;
            }

            ServerListData newData = new ServerListData();

            int.TryParse(serverDataInfo[0], out newData.serverID);
            newData.ip = serverDataInfo[1];
            int.TryParse(serverDataInfo[2], out newData.port);
            int.TryParse(serverDataInfo[3], out newData.regionID);

            //http 类型
            int typeTemp;
            int.TryParse(serverDataInfo[4], out typeTemp);
            if (typeTemp == 1)
            {
                newData.httpType = HttpType.Https;
            }
            else {
                newData.httpType = HttpType.Http;
            } 

            s_ServerList.Add(newData);
        }
        //GameLog.Log("--- 初始化了一次 服务器列表 完成 ---");
    }

    public static void InitDeployListData()
    {
        s_dicDeployList.Clear();
        string filePath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "deploylist.txt");
        string serverListData = File.ReadAllText(filePath);
        if (null == serverListData)
        {
            Console.WriteLine("deploy list load error");
            return;
        }
        string[] lines = serverListData.Split('\n');
        for (int i = 0; i < lines.Length; i++)
        {
            if (i <= 1 || string.IsNullOrEmpty(lines[i]) || lines[i].StartsWith("#"))
            {
                continue;
            }
            string[] serverDataInfo = lines[i].Split('\t');
            if (serverDataInfo.Length < 16)
            {
                continue;
            }

            DeployData newData = new DeployData();
            newData.Id = int.Parse(serverDataInfo[0]);
            newData.Desc = serverDataInfo[1];
            newData.Enable = (serverDataInfo[2] == "1");
            newData.DeployName = serverDataInfo[3];
            newData.SvrName = serverDataInfo[4];
            newData.PrivateIP = serverDataInfo[5];
            newData.PublicIP = serverDataInfo[6];
            newData.GroupNum = int.Parse(serverDataInfo[7]);
            newData.AIType = int.Parse(serverDataInfo[8]);
            newData.ServerId = int.Parse(serverDataInfo[9]);
            newData.RobotNum = int.Parse(serverDataInfo[10]);
            newData.IsLog = (serverDataInfo[11] == "1");
            newData.InitId = int.Parse(serverDataInfo[12]);
            newData.ExeCDTime = int.Parse(serverDataInfo[13]);
            newData.Arg0 = int.Parse(serverDataInfo[14]);
            newData.Arg1 = int.Parse(serverDataInfo[15]);
            newData.Arg2 = int.Parse(serverDataInfo[16]);


            s_dicDeployList.Add(newData.Id, newData);
        }
    }
}
