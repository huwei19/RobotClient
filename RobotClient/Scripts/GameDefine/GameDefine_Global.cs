namespace Games.GlobeDefine
{
    [SLua.CustomLuaClass]
    public partial class GlobeVar
    {
        public static GameStruct_AutoGameConfig AutoGameConfig = new GameStruct_AutoGameConfig();
        public static GameStruct_AutoClientConfig AutoClientConfig = new GameStruct_AutoClientConfig();
        // 基础定义
        public const int INVALID_ID = -1;                                      //非法ID
        public const System.UInt64 INVALID_GUID = 0xFFFFFFFFFFFFFFFFul;        //非法GUID

        public static byte[] dataKeys = new byte[4] { 110, 50, 20, 100 };

        // 是否开启DebugMode
#if UNITY_IPHONE && !UNITY_EDITOR
        public const bool m_IsEnableDebugMode = true;
#elif UNITY_ANDROID && !UNITY_EDITOR
        public const bool m_IsEnableDebugMode = true;
#else
        public const bool m_IsEnableDebugMode = true;
#endif
        //强制进指定服务器 指定后不可选择服务器列表
        public const int ForceEnterServerId = -1;

        // 是否将日志写入控制台
        public const bool m_IsEnableLogConsole = true;
        // 是否将日志写入文件
        public const bool m_IsEnableLogFile = true;
        // 日志文件缓存大小
        public const int logFileCacheSize = 2048;
        // 日志文件刷新最小时间间隔 单位秒
        public const float logFileFlushInterval = 0.5f;
        // 日志文件刷新最小缓存大小比率
        public const float logFileFlushRate = 0.4f;
        // 日志文件名
        public const string logFilePath = "Game.log";

        // 调试开关
        public const bool showSkipBtn = true;
        public const bool investigateFastMode = false;
        public const bool enableFpsCounter = false;
        public const bool showIntro = false;
        public const bool skipCutScene = false;
        public const bool showDeviceInfo = false;

        // 目标帧率
        public const int targetFrameRate = 60;

        //audo
        public const int BGM_TANSUOKAISHI = 2;
        public const int SELFID = 9999; //代表自己, 对应的characterId

        public const int RECURSIVE_MAX = 5;
        public const int FILELEVEL_MAX = 10;
        public const int GENERALIZE_ID_OFFSET = 10000;

        public const int m_GameVersion = 0;
        public const int m_ProgramVersion = 13; //这个参数 登陆时会与服务器版本进行校验
        public const int m_ResVersion = 0;

    }

    public enum EAlbumStoryType
    {
        Story = 1,  //剧情图
        Ending = 2, //结局图
    }

    //与FunctionUnlock.txt对应
    [SLua.EnumLuaExport]
    public enum EFunctionUnlockId
    {
        CardLevelUp     = 1, // 卡牌升级
        Mission         = 2, // 网店
        VChat           = 3, // 手机聊天
        Shop            = 4, // 商城
        CardStarUp      = 5, // 卡牌升星
        Bag             = 6, // 背包
        city = 7,//雾城
        power = 8,//体力
        sign = 9,//每日签到
        draw = 10,//抽卡
        address = 11,//通讯录
        fate = 12,//命运
        Rumor = 13,//传闻
        StoryLevel = 14,//个人故事-主关卡
        CardFile = 15,//卡牌档案
        StoryDark = 16,//暗
    }

    //与Goto.txt对应
    [SLua.EnumLuaExport]
    public enum EGotoType
    {
        UIChouka = 1,   // 抽卡UI
    }

    [SLua.EnumLuaExport]
    public enum ActionType
    {
        None,
        Dialog = 1,
        DialogAvatar = 2,
        Camera = 3,
        Plot = 4,
        Audio = 5,
        Selection = 6,
        RemovePlot = 7,
        CameraShake = 8,
        ScreenFade = 9,
        CharacterIntro = 10,
        StopAudio = 11,
    }

    [SLua.EnumLuaExport]
    public enum ActionQueueType
    {
        Main = 0, //切到主场景后触发
        Mapscene = 1, //切到调查地图场景触发
        NodeInst = 2, //node触发
    }

    //与UI控制器对应
    [SLua.EnumLuaExport]
    public enum EStaminaState
    {
       
        full            = 0,    //可领取
        rePay           = 1,    //花钱可领取
        delivering      = 2,    //配送中
        empty           = 3,    //已领取
    }

    public enum AttrType
    {
        Obs = 0,    // 观察
        Com = 1,    // 沟通
        Res = 2,    // 研究
        Cbt = 3,    // 身法

        Max,
    }
}


