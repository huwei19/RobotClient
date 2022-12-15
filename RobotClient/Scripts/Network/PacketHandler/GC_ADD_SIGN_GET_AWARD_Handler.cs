using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_ADD_SIGN_GET_AWARD)]
public class GC_ADD_SIGN_GET_AWARD_Handler : MessageHandler<GC_ADD_SIGN_GET_AWARD>
{
    protected override void Execute(Robot curRobot, GC_ADD_SIGN_GET_AWARD message)
    {
        
    }
}
