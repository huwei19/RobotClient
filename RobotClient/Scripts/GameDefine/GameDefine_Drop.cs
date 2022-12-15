using System;
using System.Collections.Generic;

namespace Games.GlobeDefine
{
    public partial class GlobeVar
    {
       
    }

    [SLua.EnumLuaExport]
    public enum DROP_CHANNEL
    {
        //必须和服务器端值保持一致！！
        DROP_CHANNEL_INVALID = -1,
        DROP_CHANNEL_GM,            //GM
        DROP_CHANNEL_COMMON,        //t通用
        DROP_CHANNEL_GIFT,          //礼包
        DROP_CHANNEL_QUESTION,      //答题
        DROP_CHANNEL_FATELEVE,      //renge
        DROP_CHANNEL_MIS_COMMIT,      //renge
        DROP_CHANNEL_LEVEL,      //renge
        DROP_CHANNEL_RUMOR_REDUCE,      //renge
        DROP_CHANNEL_RUMOR_BURST,      //renge
        DROP_CHANNEL_RESOLVE_RUMOR,    //传闻推理
        DROP_CHANNEL_DRAWCARD_ADVANCE,      //高级抽卡
        DROP_CHANNEL_DRAWCARD_ADVANCE_AWARD,      //高级抽卡累计N次奖励

        //关卡奖励相关
        DROP_CHANNEL_LEVEL_LEVELSUCC,  
        DROP_CHANNEL_LEVEL_CUSTOM,     
        DROP_CHANNEL_LEVEL_DEGREEOFCOMPLETION,    
        DROP_CHANNEL_LEVEL_BEHAVIORHUGESUCC,     
        DROP_CHANNEL_LEVEL_PUZZLECOMPLETION,     
        DROP_CHANNEL_LEVEL_CHAPTERENDING,
        DROP_CHANNEL_COMMON_EX,                 //通用 只有货币型奖励只飘字，否则弹通用窗
        DROP_CHANNEL_GUIDE_PLOT_FINISH      = 19,//新手剧情奖励
        DROP_CHANNEL_TASK_AWARD = 20,//任务
        DROP_CHANNEL_TASK_EVERY_AWARD = 21,//任务 每日 每周任务
        DROP_CHANNEL_CDKEY            = 22,//cdkey兑换奖励
        DROP_CHANNEL_PERSONAL_STORY_AWARD = 23,//个人故事章节奖励
        DROP_CHANNEL_SCENEEVENT_ONCE_AWARD = 24,//一次性奖励行为
        DROP_CHANNEL_SIGN_AWARD = 25,//签到奖励
        DROP_CHANNEL_SHOP_AWARD = 26,//商城购买
        DROP_CHANNEL_ADDSIGN_AWARD = 27,//累积登录奖励
        DROP_CHANNEL_FRIEND_GIVE = 28,//好友领取
        DROP_CHANNEL_FRIEND_GIVE_ONE = 29,//一键领取赠送
        DROP_CHANNEL_HEARTBEAT = 30,//心动功能奖励领取
    }
}
