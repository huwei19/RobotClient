using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_CARD_ABILITYUP)]
public class GC_CARD_ABILITYUP_Handler : MessageHandler<GC_CARD_ABILITYUP>
{
    protected override void Execute(Robot curRobot, GC_CARD_ABILITYUP message)
    {
        //收到回调
        curRobot.Log("-----收到卡牌提升回调 一次--- abilityLevel: "+ message.abilityLevel);
        ++curRobot.m_statcard_abilityup_finish;
    }
}
