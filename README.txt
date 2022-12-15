-------------------------------------------------
如何生成部署文件?
1. 编辑当前目录下的部署配置文件   Main\Server\Robot\deploylist.txt（可使用excel编辑）
2.执行 make_deploy.cmd
3.执行 deploymaker\DeployMaker.exe
4.生成的shell脚本，在\deploy目录下
-------------------------------------------------
注意事项
RobotClient项目：
1. 使用vs2019编译
2. vs的debug模式，默认添加了命令行参数，调试的时候确保正确即可
-batch 1 -robotIdx 8000000 -serverId 107 -aiType 14 -robotNum 10 -isLog True -initId 1 -ExeCDTime 1 -arg0 15000 -arg1 10 -arg2 0
3. vs输出路径： Main\Server\Robot\
3. 由于需要加载table文件，目前是将table文件全部放在了Server\Robot目录里面作为程序运行资源
4. GlobeVar.cs记录了一些参数
  (1)m_ProgramVersion   服务器版本对不上，则不能登陆
  (2)m_IsEnableLogConsole 控制台日志   m_IsEnableLogFile 写入日志文件
5. Program.cs文件中有 framecount 字段，如果本地调试的话，最好将 (framecount >= 1000) 的注释打开；
6. 确保需要测试的服务器id，在 Robot\robotclient\serverlist.txt 表中存在对应配置
-------------------------------------------------------



如果打包后，运行exe闪退，请检查日志；
最可能的原因是，配置填写的serverID，在serverlist.txt中找不到

-------------------------------------------------
如何打包?
Unity编辑器->菜单->Robot->打包
生成的exe程序在Bin/robot/SecretRobot.exe

-------------------------------------------------
如何生成部署文件?
1.编辑当前目录下的部署配置文件 deploylist.txt（可使用excel编辑）
2.执行convert_deploylist.cmd
3.Unity编辑器->菜单->Robot->生成部署命令
4.生成的cmd在deploy目录下

-------------------------------------------------
以命令行方式启动机器人
举例：
    start SecretRobot.exe -robotIdx 111 -serverId 1001 -aiType 0 -robotNum 2000 -isLog false -initId 1 -arg0 1000 -arg1 0 -arg2 0

机器人序号
-robotIdx 111

服务器id, region模式下用作regionid
-serverId 1001 

是否连接登录服务器 （取serverlist.txt数据 代码：StateConnectLoginServer.cs）
-useLoginServer true

是否大区模式（取region.txt数据 代码：StateConnectLoginServer.cs）
-isRegionLogin true

AI类型，见下表
-aiType 0

机器人数量
-robotNum 2000

是否打开日志
-isLog false

机器人初始id
-initId 1

参数0
-arg0 1000 

参数1
-arg1 0

参数2
-arg2 0

--------------------------------
可选的AI类型
0 进入游戏（主场景）
1 章节（主线/暗线）
2 传闻调查
3 故事
4 城市
5 时间回溯
6 商铺
7 抽卡
8 物品
9 卡牌
10 任务
11 邮件
12 好友
13 时装
14 调查
15 好友赠领
16 随机上行消息
17 随机消息体
18 随机字节

------------------------------------
Centos运行机器人环境
参考	https://www.mono-project.com/download/stable/#download-lin-centos
安装mono		yum install mono-devel




