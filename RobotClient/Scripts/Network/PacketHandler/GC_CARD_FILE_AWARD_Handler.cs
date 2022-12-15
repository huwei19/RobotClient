using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_CARD_FILE_AWARD)]
public class GC_CARD_FILE_AWARD_Handler : MessageHandler<GC_CARD_FILE_AWARD>
{
    protected override void Execute(Robot curRobot, GC_CARD_FILE_AWARD message)
    {
        curRobot.m_statcard_fileaward_finish[message.FileLevel] = true;
        //curRobot.LogFormat("Card:{0} File Award Count:{1}", message.CardId, message.FileLevel);
    }
}
