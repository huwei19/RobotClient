using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_VISUAL_CARD)]
public class GC_VISUAL_CARD_Handler : MessageHandler<GC_VISUAL_CARD>
{
    protected override void Execute(Robot curRobot, GC_VISUAL_CARD message)
    {
        ++curRobot.m_statcard_visual_finish;
        //curRobot.LogFormat("Card:{0} Visual Count:{1}", curRobot.m_statcard_visual_id, curRobot.m_statcard_visual_finish);

        if (curRobot.m_statcard_visual_id == 11)
        {
            curRobot.m_statcard_visual_id = 19;
        }
        else
        {
            curRobot.m_statcard_visual_id = 11;
        }

        if (message.Has_CardId) {
            curRobot.mainPlayer.CardId = message.CardId;
        }
    }
}
