using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_CARD_TRAINLEVEL)]
public class GC_CARD_TRAINLEVEL_Handler : MessageHandler<GC_CARD_TRAINLEVEL>
{
    protected override void Execute(Robot curRobot, GC_CARD_TRAINLEVEL message)
    {
        //收到回调
        curRobot.Log("-----收到卡牌培训回调 一次--- trainLevel: "+ message.trainLevel);
        ++curRobot.m_statcard_trainlevel_finish;
    }
}
