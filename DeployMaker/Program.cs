//关键示例：
//nohup mono ../../../robotclient/RobotClient.exe -robotIdx8000000 -serverId 20201 -aiType 9 -robotNum 1500 -isLog False -initId 1 -ExeCDTime 1 -arg0 15000 -arg1 10 -arg2 0 >/dev/null 2>20201.log & echo $!>>$pid_file
///   主体结构：  nohup mono ./RobotClient.exe -param paramValue >/dev/null 2>20201.log & echo $! >> $pid_file
///             (1) nohup 与 后面的 "&" 代表 linux后台运行程序命令；
///             (2) -param paramValue 是带上数组参数，运行命令
///             (3) /dev/null  可以把/dev/null 可以看作"黑洞". 只能写入的文件，并且什么也读取不到；
///             (4) >/dev/null 由于重定向符号>默认是1，也即 1>/dev/null； 代表标准输出已经重定向到了 /dev/null
///             (5) 2>20201.log 标准错误重定向到20201.log
///             (6) "echo $!"命令，它是打印进程号的意思，echo $! >> pidfile.txt : 把进程号打印到pidfile.txt中

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DeployMaker
{
    public class DeployMaker
    {
        public static void Main(string[] args)
        {
            //重置部署目录
            string deployDir = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "../deploy");
            if (Directory.Exists(deployDir))
            {
                Directory.Delete(deployDir, true);
            }

            Console.WriteLine("----- 开始载入部署命令");
            //载入配置
            GlobalData.InitDeployListData();

            //生成配置
            foreach (var data in GlobalData.s_dicDeployList.Values)
            {
                if (!data.Enable)
                {
                    continue;
                }

                //创建文件目录
                string cmdFileName = string.Format("{0}_{1}_ID{2}_serverId{3}_{4}_group{5}_nums{6}.sh",
                    data.SvrName, data.DeployName, data.Id, data.ServerId, (Robot.RobotType)data.AIType, data.GroupNum, data.RobotNum);
                string cmdFilePath = string.Format("{0}/{1}/{2}/{3}",
                    deployDir, data.SvrName, data.ServerId, cmdFileName);

                DeleteFile(cmdFilePath);
                CheckTargetFilePath(cmdFilePath);

                //写入文件
                StringBuilder sb = new StringBuilder();
                sb.Append("# /usr/bin/sh \n");
                sb.Append("# 以下脚本由Robot工程自动生成，配置在deploylist.txt中 \n");
                sb.Append("\n");
                //sb.AppendLine(); -------> \r\n ------->linux环境下无\r，不能用AppendLine方法

                sb.Append("# --------------------------------- \n");
                sb.Append("# 部署Id(机器人序号):" + data.Id + "\n");
                sb.Append("# 服务器id:" + data.ServerId + "\n");
                sb.Append("# 组数:" + data.GroupNum + "\n");
                sb.Append("# AI类型:" + Robot.GetAIName(data.AIType) + "\n");
                sb.Append("# 机器人数量:" + data.RobotNum + "\n");
                sb.Append("# 是否打开日志:" + data.IsLog + "\n");
                sb.Append("# 机器人初始id:" + data.InitId + "\n");
                sb.Append("# 机器人执行发消息包的CD时间(秒)(默认1秒):" + data.ExeCDTime + "\n");
                sb.Append("# 参数0:" + data.Arg0 + "\n");
                sb.Append("# 参数1:" + data.Arg1 + "\n");
                sb.Append("# 参数2:" + data.Arg2 + "\n");

                sb.Append("\n");
                sb.Append("erro='请带上 -batch= 运行' \n");
                sb.Append("str_param1=$1 \n");
                sb.Append("str_batchParam=0 \n");
                sb.Append("if [[ $str_param1 == *-batch=* ]]; then \n");
                sb.Append("    echo '包含 - batch = ' \n");
                sb.Append("    str_batchParam=${str_param1:7} \n");
                sb.Append("else \n");
                sb.Append("    echo $erro \n");
                sb.Append("    exit 1 \n");
                sb.Append("fi \n");
                sb.Append("# --------------------------------- \n");
                sb.Append("pid_file=monitor.pid \n");

                sb.Append("\n");

                //将 mono 执行返回的进程id 保存进 $pid_file中，后面shutdown的时候使用
                //sb.Append("echo > $pid_file \n"); --剔除清空的代码


                for (int idx = 0; idx < data.GroupNum; idx++)
                {
                    //sb.AppendFormat("# 第{0}组\n", idx + 1);
                    sb.AppendFormat("nohup mono ../../../robotclient/RobotClient.exe -batch {0} -robotIdx {1} -serverId {2} -aiType {3} -robotNum {4} -isLog {5} -initId {6} -ExeCDTime {7} -arg0 {8} -arg1 {9} -arg2 {10} >/dev/null 2>{3}_{1}.log & echo $! >> $pid_file \n",
                        "$str_batchParam",
                        data.Id * 100 + idx,
                        data.ServerId,
                        data.AIType,
                        data.RobotNum,
                        data.IsLog,
                        data.InitId,
                        data.ExeCDTime,
                        data.Arg0,
                        data.Arg1,
                        data.Arg2
                        );
                }

                sb.Append("\n");
                sb.Append("echo 'start succ.done.'");
                sb.Append("\n");

                File.WriteAllText(cmdFilePath, sb.ToString());
            }

            //生成run脚本
            foreach (var data in GlobalData.s_dicDeployList.Values)
            {
                if (!data.Enable)
                {
                    continue;
                }

                //创建文件目录
                string cmdFileName = "run.sh";
                string cmdFilePath = string.Format("{0}/{1}/{2}/{3}",
                    deployDir, data.SvrName, data.ServerId, cmdFileName);
                if (File.Exists(cmdFilePath))
                {
                    continue;
                }

                CheckTargetFilePath(cmdFilePath);

                //写入文件
                StringBuilder sb = new StringBuilder();
                sb.Append("#/usr/bin/sh \n");
                sb.Append("# 生成全部开启的shell脚本 \n");

                sb.Append("\n");
                sb.Append("erro='请带上 -batch= 运行' \n");
                sb.Append("str_param1=$1 \n");
                sb.Append("str_batchParam=0 \n");
                sb.Append("if [[ $str_param1 == *-batch=* ]]; then \n");
                sb.Append("    echo '包含 - batch = ' \n");
                sb.Append("    str_batchParam=${str_param1:7} \n");
                sb.Append("else \n");
                sb.Append("    echo $erro \n");
                sb.Append("    exit 1 \n");
                sb.Append("fi \n");
                sb.Append("# --------------------------------- \n");
                sb.Append("\n");

                //查找本目录下 全部的shell脚本
                List<string> SHFilesInfoList = new List<string>();
                DirectoryInfo directory = new DirectoryInfo(string.Format("{0}/{1}/{2}/", deployDir, data.SvrName, data.ServerId));
                FileSystemInfo[] filesArray = directory.GetFileSystemInfos();
                foreach (var item in filesArray)
                {
                    //是sh文件
                    if (item.Extension == ".sh")
                    {
                        SHFilesInfoList.Add(item.FullName);
                        sb.AppendFormat("sh ./{0} -batch={1} \n",
                          item.Name,
                          "$str_batchParam"
                          );
                    }
                }
                sb.Append("\n");
                File.WriteAllText(cmdFilePath, sb.ToString());
            }

            //生成run_cha 脚本
            foreach (var data in GlobalData.s_dicDeployList.Values)
            {
                if (!data.Enable)
                {
                    continue;
                }

                //创建文件目录
                string cmdFileName = "run_cha.sh";
                string cmdFilePath = string.Format("{0}/{1}/{2}/{3}",
                    deployDir, data.SvrName, data.ServerId, cmdFileName);
                if (File.Exists(cmdFilePath))
                {
                    continue;
                }

                CheckTargetFilePath(cmdFilePath);

                //写入文件
                StringBuilder sb = new StringBuilder();
                sb.Append("#/usr/bin/sh \n");
                sb.Append("# 生成全部开启的shell脚本 \n");

                sb.Append("\n");
                sb.Append("erro='请带上 -batch= 运行' \n");
                sb.Append("str_param1=$1 \n");
                sb.Append("str_batchParam=0 \n");
                sb.Append("if [[ $str_param1 == *-batch=* ]]; then \n");
                sb.Append("    echo '包含 - batch = ' \n");
                sb.Append("    str_batchParam=${str_param1:7} \n");
                sb.Append("else \n");
                sb.Append("    echo $erro \n");
                sb.Append("    exit 1 \n");
                sb.Append("fi \n");
                sb.Append("# --------------------------------- \n");
                sb.Append("\n");

                //查找本目录下 全部的shell脚本
                List<string> SHFilesInfoList = new List<string>();
                DirectoryInfo directory = new DirectoryInfo(string.Format("{0}/{1}/{2}/", deployDir, data.SvrName, data.ServerId));
                FileSystemInfo[] filesArray = directory.GetFileSystemInfos();
                foreach (var item in filesArray)
                {
                    //是sh文件且为章节脚本
                    if (item.Extension == ".sh" && item.Name.Contains("CHAPTER"))
                    {
                        SHFilesInfoList.Add(item.FullName);
                        sb.AppendFormat("sh ./{0} -batch={1} \n",
                          item.Name,
                          "$str_batchParam"
                          );
                    }
                }
                sb.Append("\n");
                File.WriteAllText(cmdFilePath, sb.ToString());
            }

            //生成shundown.cmd
            foreach (var data in GlobalData.s_dicDeployList.Values)
            {
                if (!data.Enable)
                {
                    continue;
                }

                //创建文件目录
                string cmdFileName = "shutdown.sh";
                string cmdFilePath = string.Format("{0}/{1}/{2}/{3}",
                    deployDir, data.SvrName, data.ServerId, cmdFileName);
                if (File.Exists(cmdFilePath))
                {
                    continue;
                }

                CheckTargetFilePath(cmdFilePath);

                //写入文件
                StringBuilder sb = new StringBuilder();
                sb.Append("#/usr/bin/sh \n");
                sb.Append("# 将monitor文件中的进程id 关闭 \n");
                sb.Append("kill -9 `cat monitor.pid` \n");
                sb.Append("\n");
                File.WriteAllText(cmdFilePath, sb.ToString());
            }

            Console.WriteLine("--------- 生成部署命令 完成！");
            Console.ReadKey();
        }

        public static void DeleteFile(string path)
        {
            if (!File.Exists(path))
            {
                return;
            }
            System.IO.File.Delete(path);
        }

        // 拷贝一个路径下的文件，不包含子目录
        public static void CopyFile(string srcPath, string dstPath)
        {
            if (!File.Exists(srcPath))
            {
                Console.WriteLine("copy file failed.src file not exist.srcPath " + srcPath);
                return;
            }
            CheckTargetFilePath(dstPath);
            File.Copy(srcPath, dstPath, true);
        }

        //检查目录是否存在，不存在则创建对应路径
        public static void CheckTargetDirPath(string targetPath)
        {
            targetPath = targetPath.Replace('\\', '/');

            if (Directory.Exists(targetPath))
            {
                return;
            }

            string[] subPath = targetPath.Split('/');
            string curCheckPath = "";
            int subContentSize = subPath.Length;
            for (int i = 0; i < subContentSize; i++)
            {
                curCheckPath += subPath[i] + '/';
                if (!Directory.Exists(curCheckPath))
                {
                    Directory.CreateDirectory(curCheckPath);
                }
            }
        }

        //检查文件所在目录是否存在，不存在则创建对应路径
        public static void CheckTargetFilePath(string targetPath)
        {
            targetPath = targetPath.Replace('\\', '/');
            targetPath = Path.GetDirectoryName(targetPath);
            CheckTargetDirPath(targetPath);
        }
    }
}
