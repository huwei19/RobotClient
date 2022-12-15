using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_INTERFLOW_SELECT)]
public class GC_INTERFLOW_SELECT_Handler : MessageHandler<GC_INTERFLOW_SELECT>
{
    protected override void Execute(Robot curRobot, GC_INTERFLOW_SELECT message)
    {
        
    }
}
