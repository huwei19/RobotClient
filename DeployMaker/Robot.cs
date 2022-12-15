using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public partial class Robot
{
    public enum RobotType
    {
        //功能相关压测脚本
        TYPE_SCENE_MAIN = 0, //只进入，什么操作都不做
        //TYPE_RELOGIN,//重复登录
        TYPE_CHAPTER = 1,//章节（主线/暗线）
        TYPE_RUMOR = 2,//传闻调查
        TYPE_STORY = 3,//故事
        TYPE_CITY = 4,//城市
        TYPE_REWIND = 5,//时间回溯
        TYPE_SHOP = 6,//商铺
        TYPE_DRAWCARD = 7,//抽卡
        TYPE_ITEM = 8,//物品
        TYPE_CARD = 9,//卡牌
        TYPE_TASK = 10,//任务
        TYPE_MAIL = 11,//邮件
        TYPE_FRIEND = 12,//好友
        TYPE_DRESSUP = 13,//时装
        TYPE_STORY_EX = 14, //自动调查
        TYPE_FRIEND_GIVE = 15, //好友赠领

        //数据相关压测脚本
        TYPE_RANDOMCG = 16,
        TYPE_RANDOMMSG = 17,
        TYPE_RANDOMBYTE = 18,

        TYPE_HALT = 19,     //停止

        TYPE_NONE = -1,
    };

    public static string GetAIName(int aiType)
    {
        if (aiType == (int)Robot.RobotType.TYPE_SCENE_MAIN) { return "登陆"; }
        if (aiType == (int)Robot.RobotType.TYPE_CHAPTER) { return "章节主线暗线"; }
        if (aiType == (int)Robot.RobotType.TYPE_RUMOR) { return "传闻调查"; }
        if (aiType == (int)Robot.RobotType.TYPE_STORY) { return "故事"; }
        if (aiType == (int)Robot.RobotType.TYPE_CITY) { return "城市"; }
        if (aiType == (int)Robot.RobotType.TYPE_REWIND) { return "时间回溯"; }
        if (aiType == (int)Robot.RobotType.TYPE_SHOP) { return "商铺"; }
        if (aiType == (int)Robot.RobotType.TYPE_DRAWCARD) { return "抽卡"; }
        if (aiType == (int)Robot.RobotType.TYPE_ITEM) { return "物品"; }
        if (aiType == (int)Robot.RobotType.TYPE_CARD) { return "卡牌"; }
        if (aiType == (int)Robot.RobotType.TYPE_TASK) { return "任务"; }
        if (aiType == (int)Robot.RobotType.TYPE_MAIL) { return "邮件"; }
        if (aiType == (int)Robot.RobotType.TYPE_FRIEND) { return "好友"; }
        if (aiType == (int)Robot.RobotType.TYPE_DRESSUP) { return "时装"; }
        if (aiType == (int)Robot.RobotType.TYPE_STORY_EX) { return "自动调查"; }
        if (aiType == (int)Robot.RobotType.TYPE_FRIEND_GIVE) { return "好友赠领"; }

        return "";
    }

}
