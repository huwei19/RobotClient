using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SIGN_INFO)]
public class GC_SIGN_INFO_Handler : MessageHandler<GC_SIGN_INFO>
{
    protected override void Execute(Robot curRobot, GC_SIGN_INFO message)
    {
        
    }
}
