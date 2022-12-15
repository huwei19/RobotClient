using UnityEngine;
using System.Collections;

public enum RELIVE_TYPE
{
    RELIVE_ORIGINAL = 1,     //原地复活
    RELIVE_ENTRY,           //入口复活
    RELIVE_CITY,            //主城复活
}

public class CharacterDefine
{
    public enum CharacterAnimState
    {
        Idle = 0,
        Walk = 1,
        Attack = 9,
        Hit = 10,
        Knockback_01 = 11,
        Knockback_02 = 12,
        Die = 13,
        PlayerHit = 14,
        RIDE_STAND = 15,
        RIDE_RUN = 16,

    }

    //角色之间的关系
    public enum REPUTATION_TYPE
    {
        REPUTATION_INVALID = -1,
        REPUTATION_FRIEND,
        REPUTATION_NEUTRAL,
        REPUTATION_HOSTILE,
    }

    //角色AI状态类型
    public enum AI_STATE_TYPE
    {
        AI_STATE_NORMAL,            //非战斗型AI
        AI_STATE_COMBAT,            //战斗型AI
        AI_STATE_WALK,            //战斗型AI
        AI_STATE_DEAD,              //死亡型AI
    }

    //角色具体AI类型
    public enum AI_TYPE
    {
        AI_TYPE_INVALID = -1,      //非法类型
        AI_TYPE_PATROL,             //普通巡逻AI
        AI_TYPE_COMBAT,             //普通战斗AI
    }

    //主角点选目标状态
    public enum SELECT_TARGET_TYPE
    {
        SELECT_TARGET_NONE,         //未选中
        SELECT_TARGET_CHAT,         //选中可对话目标
        SELECT_TARGET_ATK,          //选中可攻击状态
    }

    //玩家职业列表
    public enum PROFESSION
    {
        SHAOLIN,
        TIANSHAN,
        DALI,
        XIAOYAO,
        MAX,
    }

    public static int[] PROFESSION_DICNUM = 
        {
            1178, // (SHAOLIN)
            1179, // (DALI)
            1180, // (TIANSHAN)
            1181, // (XIAOYAO)
        };
    //PK模式
    public enum PKMODLE
    {
        NORMAL = 0,
        KILL,
        MAX,
    }
}
