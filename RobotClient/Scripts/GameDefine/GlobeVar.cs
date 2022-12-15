/********************************************************************************
 *	文件名：	GlobeVar.cs
 *	全路径：	\Script\GlobeDefine\GlobeVar.cs
 *	创建人：	李嘉
 *	创建时间：2013-10-25
 *
 *	功能说明：全局变量定义。枚举请定义在GlobeDefine.cs中
 *	修改记录：
*********************************************************************************/
using System.Collections;

namespace Games.GlobeDefine
{
    public partial class GlobeVar
    {
        //Static 定义
        public static bool s_FirstInitGame = true;         //第一次进入游戏标示

        //Const 定义
        public const string characTorPath = "";

        //////////////////////////////////////////////////////////////////////////
        //队伍相关定义
        //////////////////////////////////////////////////////////////////////////
        public const int MAX_TEAM_MEMBER = 4;               //队伍最大人数

        //不同职业的头像信息
        public static string[] m_HeadIcon = new string[(int)CharacterDefine.PROFESSION.MAX] { "head-shaolin", "head-shaolin", "head-shaolin", "head-xiaoyao" };
        //不同职业的名称          
        public static string[] m_ProfessionName = new string[(int)CharacterDefine.PROFESSION.MAX] { "少林", "大理", "天山", "逍遥" };

        public const int MAX_LAST_SPEAKERS = 20;        // 聊天框上次发言玩家记录最大数量

        public const int MAX_FRIEND_NUM = 99;          // 玩家好友上限
        public const int MAX_BLACK_NUM = 99;           // 玩家黑名单上限
        public const int MAX_HTTP_FAILCOUNT = 2;           // 失败重置次数上限
    }

    public enum RANKTYPE
    {
        TYPE_CANGJINGGE = 1, //藏经阁副本
        TYPE_PRELIMINARYGUILDWARRANK = 2,//帮战海选排行
        TYPE_PRELIMINARYGUILDWARKILLRANK = 3,//帮战海选 击杀人数排行
        TYPE_HUASHANZHANJI = 4,//华山-战绩
        TYPE_HUASHANJINYAODAI = 5,//华山-金腰带
        TYPE_USERLEVELRANK = 6, //等级
        TYPE_USERCOMBATRANK = 7, //战斗力
        TYPE_USERHPRANK = 8,//血量
        TYPE_GUILDCOMBAT = 9,//帮会战斗力
        TYPE_HUASHANPOS = 10,//华山-排名
        TYPE_SHAOLINREPUTATION = 11, //少林大弟子
        TYPE_TIANSHANREPUTATION = 12,//天山大弟子
        TYPE_DALIREPUTATION = 13,//大理大弟子
        TYPE_XIAOYAOREPUTATION = 14,//逍遥大弟子
        TYPE_USERCOIN = 15,//金币
        TYPE_MASTER = 16,//宗师
        TYPE_USERCOSTYUANBAO = 17,//消费排行榜
        TYPE_ATTACK = 18,//攻击力排行榜
        TYPE_CHONGZHI = 19,//充值排行榜
        TYPE_MASTERAVTIVECOMBAT = 20,//师门战力排行榜
        TYPE_SHAOSHISHAN = 21,//少室山排行榜
        TYPE_TOTALONLINETIME = 22,//在线时间排行榜
    }
}
