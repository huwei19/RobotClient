using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SIGNATURE)]
public class GC_SIGNATURE_Handler : MessageHandler<GC_SIGNATURE>
{
    protected override void Execute(Robot curRobot, GC_SIGNATURE message)
    {
        curRobot.mainPlayer.Signature = message.Signature;
    }
}
