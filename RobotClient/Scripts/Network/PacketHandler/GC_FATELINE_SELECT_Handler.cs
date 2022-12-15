using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_FATELINE_SELECT)]
public class GC_FATELINE_SELECT_Handler : MessageHandler<GC_FATELINE_SELECT>
{
    protected override void Execute(Robot curRobot, GC_FATELINE_SELECT message)
    {
        
    }
}
