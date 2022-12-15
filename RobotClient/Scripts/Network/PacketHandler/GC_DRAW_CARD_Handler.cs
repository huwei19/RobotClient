using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_DRAW_CARD)]
public class GC_DRAW_CARD_Handler : MessageHandler<GC_DRAW_CARD>
{
    protected override void Execute(Robot curRobot, GC_DRAW_CARD message)
    {
        curRobot.TransEnd(curRobot.GetDrawEvent(message.DrawType, message.CardIds.Count >1), message.CardIds.Count > 0 ? RESULT.SUCCESS: RESULT.FAIL_VALIDATEPROCESS);
        string lcardidstr = "";
        foreach (int cardid in message.CardIds)
        {
            lcardidstr += cardid;
            lcardidstr += ",";
        }
        //curRobot.LogFormat("Draw Card DrawType:{0} Card:[{1}]", message.DrawType, lcardidstr);

        if (message.DrawType == (int)CG_DRAW_CARD.DRAWTYPE.ADVANCE)
        {
            curRobot.m_statdrawcard_advance_count += message.CardIds.Count;
        }

    }
}
