using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SYN_ATTR)]
public class GC_SYN_ATTR_Handler : MessageHandler<GC_SYN_ATTR>
{
    protected override void Execute(Robot curRobot, GC_SYN_ATTR message)
    {
        if (message.Has_Diamond)
            curRobot.mainPlayer.Diamond = message.Diamond;
        if (message.Has_GoldCoin)
            curRobot.mainPlayer.GoldCoin = message.GoldCoin;
        if (message.Has_Stamina)
            curRobot.mainPlayer.Stamina = message.Stamina;
        if (message.Has_Confidence)
            curRobot.mainPlayer.Confidence = message.Confidence;
        if (message.Has_Level)
            curRobot.mainPlayer.Level = message.Level;
        if (message.Has_Exp)
            curRobot.mainPlayer.Exp = message.Exp;
        if (message.Has_GoldBuyTimes)
            curRobot.mainPlayer.GoldBuyTimes = message.GoldBuyTimes;
        if (message.Has_StaminaBuyTimes)
            curRobot.mainPlayer.StaminaBuyTimes = message.StaminaBuyTimes;
    }
}
