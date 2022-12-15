using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_CARD_CHANGE_FACE)]
public class GC_CARD_CHANGE_FACE_Handler : MessageHandler<GC_CARD_CHANGE_FACE>
{
    protected override void Execute(Robot curRobot, GC_CARD_CHANGE_FACE message)
    {
        ++curRobot.m_statcard_enhance_finish;
    }
}
