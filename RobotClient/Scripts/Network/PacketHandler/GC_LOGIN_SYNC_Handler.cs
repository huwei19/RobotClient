using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_LOGIN_SYNC)]
public class GC_LOGIN_SYNC_Handler : MessageHandler<GC_LOGIN_SYNC>
{
    protected override void Execute(Robot curRobot, GC_LOGIN_SYNC message)
    {
        
    }
}
