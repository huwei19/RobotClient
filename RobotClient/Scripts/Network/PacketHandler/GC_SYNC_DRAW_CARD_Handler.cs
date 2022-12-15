using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SYNC_DRAW_CARD)]
public class GC_SYNC_DRAW_CARD_Handler : MessageHandler<GC_SYNC_DRAW_CARD>
{
    protected override void Execute(Robot curRobot, GC_SYNC_DRAW_CARD message)
    {
        //curRobot.LogFormat("Draw Card AdvanceAwardCount:{0}", message.DrawInfo.AdvanceAwardCount);
        curRobot.m_statdrawcard_advance_count -= 50;
    }
}
