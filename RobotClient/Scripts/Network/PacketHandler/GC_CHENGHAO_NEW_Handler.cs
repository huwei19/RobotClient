using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_CHENGHAO_NEW)]
public class GC_CHENGHAO_NEW_Handler : MessageHandler<GC_CHENGHAO_NEW>
{
    protected override void Execute(Robot curRobot, GC_CHENGHAO_NEW message)
    {
        
    }
}
