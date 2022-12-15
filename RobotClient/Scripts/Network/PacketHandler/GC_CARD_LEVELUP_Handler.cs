using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_CARD_LEVELUP)]
public class GC_CARD_LEVELUP_Handler : MessageHandler<GC_CARD_LEVELUP>
{
    protected override void Execute(Robot curRobot, GC_CARD_LEVELUP message)
    {
        if (message.CardId == curRobot.m_statcard_id)
        {
            if (message.Level != curRobot.m_statcard_lv || curRobot.m_statcard_exp != message.Exp)
            {
                curRobot.m_statcard_lv = message.Level;
                curRobot.m_statcard_exp = message.Exp;
                //curRobot.LogFormat("Card:{0} Level Up lv:{1} exp:{2}", message.CardId, message.Level, message.Exp);
            }
        }
    }
}
