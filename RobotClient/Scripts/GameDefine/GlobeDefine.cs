/********************************************************************************
 *	文件名：	GlobeDefine.cs
 *	全路径：	\Script\GlobeDefine\GlobeDefine.cs
 *	创建人：	李嘉
 *	创建时间：2013-10-25
 *
 *	功能说明：游戏全局常量定义
 *	         全局变量请定义在GlobeVar.cs中
 *	         挡功能较多的时候可以分开文件定义
 *	修改记录：
*********************************************************************************/
using UnityEngine;
using System.Collections;

namespace Games.GlobeDefine
{
    public class GameDefine_Globe
    {
        //枚举
        public enum GAMESTATUS					//游戏状态
        {
            GAMESTATUS_INVALID = -1,				//非法状态
            GAMESTATUS_LOGIN,					//登录状态
            GAMESTATUS_MAIN,					//主游戏状态
            GAMESTATUS_NUM,						//状态总数
        }

        public enum OBJ_TYPE                    //Obj类型
        {
            OBJ,
            OBJ_CHARACTER,
            OBJ_NPC,
            OBJ_FELLOW,
            OBJ_OTHER_PLAYER,
            OBJ_MAIN_PLAYER,
            OBJ_DROP_ITEM,
        }
        //obj状态 相关
        public enum OBJ_STATE
        {
            STATE_INVAILD= -1,
            STATE_NORMOR = 0,
            STATE_WALK,
            STATE_HIT,//受击
            STATE_ATTACKDOWN,//击倒
            STATE_DEATH,
        }
        public enum PACKET_DEFINE               //消息包类型定义，一定在最后添加
        {
        }

        public enum EVENT_DEFINE                //客户端事件，一定在最后添加
        {
            EVENT_INVALID = -1,                 //非法事件
            EVENT_ENTERGAME,                    //进入游戏事件
            EVENT_OPENDIALOG,                   //打开对话框
            EVENT_CHANGESCENE,                  //切换场景
            EVENT_CONNECT_SUCCESS,          // 连接服务器成功
            EVENT_CONNECT_FAIL,             // 连接服务器失败
        }

        public enum SCENE_DEFINE
        {
			SCENE_LOGIN = 0,						// 登录
			SCENE_YUQINGGONG = 1,					// 玉清宫
            SCENE_SHAOSHISHAN = 2,                  // 少室山
            SCENE_TIANSHAN = 4,                     // 天山
            SCENE_XINGZILIN = 5,                    // 杏子林
            SCENE_JIANHUGONG,                       // 剑湖宫
            SCENE_HUTOUZHANCHUAN,                   // 虎头战船
        }

        public enum DAMAGEBOARD_TYPE
        {
            PLAYER_TYPE_INVALID = -1,
            PLAYER_HP_UP = 0,
            PLAYER_HP_DOWN,
            PLAYER_XP_UP,
            PLAYER_XP_DOWN,
            PLAYER_MP_UP,
            PLAYER_MP_DOWN,
            TARGET_HPDOWN_PARTNER,
            TARGET_HPDOWN_PLAYER,
            PLAYER_ATTACK_MISS,
            TARGET_ATTACK_MISS,
            SKILL_NAME,
            DAMAGE_CRITICAL,
        }

        public enum CAMP_DEFINE
        {
            CAMP_INVALID = -1,
            CAMP_PLAYER = 0,
            CAMP_FRIENDLY,
            CAMP_ENEMY_NORMAL,
            CAMP_ENEMY_ATTACK,
        }

        public enum ITEM_QUALITY
        {
            QUALITY_INVALID = -1,
            QUALITY_TEST = 0,
            QUALITY_MAX,
        }

        public enum ITEM_CLASS
        {
            CLASS_INVALID = -1,
            CLASS_TEST = 0,
            CLASS_MAX,
        }

        public enum ITEM_SUBCLASS
        {
            SUBCLASS_INVALID = -1,
            SUBCLASS_TEST = 0,
            SUBCLASS_MAX,
        }

        public enum MESSAGEBOX_TYPE
        {
            TYPE_INVALID    = -1,
            TYPE_OK         = 0,
            TYPE_OKCANCEL   = 1,
            TYPE_WAIT       = 2,
            TYPE_MAX,
        }

        //玩家列表UI界面的分类类型
        public enum RELATION_TAB_TYPE
        {
            RELATION_TAB_INVALID = -1,
            RELATION_TAB_FRIEND,
            RELATION_TAB_MAIL,
            RELATION_TAB_TEAM,
        };

        //过滤字类型
        public enum STRFILTER_TYPE
        {
            STRFILTER_CHAT = 0,         //聊天
            STRFILTER_NAME,             //命名
            STRFILTER_MAIL,             //邮件
        }
        //复活类型
        public enum RELIVE_TYPE
        {
            RELIVE_ORIGINAL =1,     //原地复活
            RELIVE_ENTRY,           //入口复活
            RELIVE_CITY,            //主城复活
        }
        public enum SKILLDEFINE
        {
            MAX_SKILLNUM =7, //主角最大技能数
        }
    }
}
