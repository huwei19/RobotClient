using System;
using System.Collections.Generic;

namespace Games.GlobeDefine
{
    public partial class GlobeVar
    {
        // 网络连接
        public const float connTimeout = 5.0f;//连接超时时间
        public const int connTryMaxCnt = 6;//最大重连次数
        public const int connTryAutoCnt = 3;//最大重连次数
        public const float connTryInterval = 10.0f;//重连间隔时间(随重试次数增大)
        public const float connTryIntervalRate = 2.0f;//重连间隔放大倍数

        //服务器数据
        public const int defaultServerId = 100;
        public const string defaultIp = "";
        public const int defaultPort = -1;

        public const bool checkVersionEnable = false;
        public const string checkVersionUrl = "http://49.235.83.130:80/verification";
        public const string checkVersionKey = "DEAD078E94";

        public const int cndRequestTimeout = 5;
        public const int createRoleActionId_2 = 3086;

        //是否开启公告面板
        public const bool enablePostPanel = true;

        // 大区登录服务器
        public const string RedisSecurityKey = "Qu17jJNcEang8N7k";
        public const string LoginSvrUrlHttp = "http://{0}:{1}/LoginServer/";
        public const string LoginSvrUrlHttps = "https://{0}:{1}/LoginServer/";
        public const string PostRefix_RegionLogin = "LoginServer.php?account={0}&region={1}&salt={2}&sign={3}";
        public const string PostRefix_ServerLogin = "LoginServer.php?account={0}&server={1}&salt={2}&sign={3}";
        public const string PostRefix_QuaryMyRole = "QuaryMyRole.php?account={0}&region={1}&salt={2}&sign={3}";

    }
}
