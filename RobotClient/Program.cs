using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RobotClient
{
    class Program
    {
        static DateTime tickStartDateTime = new DateTime();
        static DateTime tickEndDateTime = new DateTime();

        static void Main(string[] args)
        {
            GameLog.Log("------ Main ------开始");

            MainUILogic.Instance().Start();
            CoroutineManager.Instance.Start(MainUILogic.Instance().StartByCommand());

            //模拟Update
            int framecount = 0;

            //模拟当前帧数,当前time下，deltaMilTime(100ms) 执行一次
            while (true)
            {
                tickStartDateTime = DateTime.Now;
                //Console.WriteLine("[Main] cur framecount:<" + framecount + "> CoroutineManager.Instance.UpdateCoroutine");
                CoroutineManager.Instance.UpdateCoroutine();

                //模拟unity的update
                Thread.Sleep(ParamTime.deltaMilTime);  //等待deltaMilTime 10ms 执行一次

                framecount++;

                //if (framecount >= 10000)
                //    break;

                //添加实际需要UpDate执行的函数
                MainUILogic.Instance().Update();

                tickEndDateTime = DateTime.Now;

                //展示客户端总览信息  每50次Update  打印一次客户端信息
                if (framecount >= 10)
                {
                    ShowClientInfo();
                    framecount = 0;
                }
            }

            GameLog.Log("------ Main ------ 结束");
            Console.ReadKey();
        }


        /// <summary>
        /// 展示客户端当前所有的机器人信息
        /// </summary>
        public static void ShowClientInfo()
        {
            List<Robot> robotList = MainUILogic.Instance().RobotList;
            int onlineCount = 0;
            int offlineCount = 0;
            int ingamePlayer = 0;
            int queuePlayer = 0;
            int runningPlayer = 0;
            int noServerInfoPlayer = 0;

            foreach (Robot curRobot in robotList)
            {
                if (curRobot.IsRunning)
                {
                    runningPlayer++;
                }
                if (curRobot.IsConnected)
                {
                    onlineCount++;
                }
                else
                {
                    offlineCount++;
                }
                if (curRobot.ServerInfo == null)
                {
                    noServerInfoPlayer++;
                }
                if (curRobot.IsInScene)
                {
                    ingamePlayer++;
                }
                if (curRobot.IsQueuing)
                {
                    queuePlayer++;
                }
            }
            string clientInfo = string.Format("总数:{0} 在线:{1} 离线:{2}  无GS信息:{7}  游戏内:{3} 排队中:{4} , tick:{5}到{6}",
                robotList.Count,
                onlineCount, offlineCount,
                ingamePlayer, queuePlayer,
                tickStartDateTime.ToString("T"), tickEndDateTime.ToString("T"),
                noServerInfoPlayer
                ); ;

            //打印到 console
            GameLog.Log(clientInfo);
            //Console.WriteLine(clientInfo);
        }
    }
}
