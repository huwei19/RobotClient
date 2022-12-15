using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_CARD_MAKE)]
public class GC_CARD_MAKE_Handler : MessageHandler<GC_CARD_MAKE>
{
    protected override void Execute(Robot curRobot, GC_CARD_MAKE message)
    {
        curRobot.TransEnd(TransEvent.CardMake, RESULT.SUCCESS);
        ++curRobot.m_statcard_make_finish;
        //curRobot.LogFormat("Card:{0} Make Count:{1}", message.CardId, curRobot.m_statcard_make_finish);
    }
}
