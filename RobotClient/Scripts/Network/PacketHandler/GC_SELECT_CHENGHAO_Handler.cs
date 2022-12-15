using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SELECT_CHENGHAO)]
public class GC_SELECT_CHENGHAO_Handler : MessageHandler<GC_SELECT_CHENGHAO>
{
    protected override void Execute(Robot curRobot, GC_SELECT_CHENGHAO message)
    {
        
    }
}
