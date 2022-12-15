using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_CARD_STAR_LEVELUP)]
public class GC_CARD_STAR_LEVELUP_Handler : MessageHandler<GC_CARD_STAR_LEVELUP>
{
    protected override void Execute(Robot curRobot, GC_CARD_STAR_LEVELUP message)
    {
        curRobot.m_statcard_star = message.Star;
        //curRobot.LogFormat("Card:{0} Star Level Up Star:{1}", message.CardId, message.Star);
    }
}
