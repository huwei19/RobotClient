using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_DRAW_CARD_SWITCH)]
public class GC_DRAW_CARD_SWITCH_Handler : MessageHandler<GC_DRAW_CARD_SWITCH>
{
    protected override void Execute(Robot curRobot, GC_DRAW_CARD_SWITCH message)
    {
        //curRobot.LogFormat("Draw Card SwitchType:{0}", message.SwitchType);
    }
}
