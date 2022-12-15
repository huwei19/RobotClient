using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_CHENGHAO_LIST)]
public class GC_CHENGHAO_LIST_Handler : MessageHandler<GC_CHENGHAO_LIST>
{
    protected override void Execute(Robot curRobot, GC_CHENGHAO_LIST message)
    {
        
    }
}
