using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_CARD_RESOLVE)]
public class GC_CARD_RESOLVE_Handler : MessageHandler<GC_CARD_RESOLVE>
{
    protected override void Execute(Robot curRobot, GC_CARD_RESOLVE message)
    {
        ++curRobot.m_statcard_resolve_finish;
        //curRobot.LogFormat("Card:{0} Resolve Count:{1}", curRobot.m_statcard_resolve_id, curRobot.m_statcard_resolve_finish);
    }
}
