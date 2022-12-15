using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_CDKEY_AWARD)]
public class GC_CDKEY_AWARD_Handler : MessageHandler<GC_CDKEY_AWARD>
{
    protected override void Execute(Robot curRobot, GC_CDKEY_AWARD message)
    {
        
    }
}
