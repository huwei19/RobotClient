using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_NPCTASK_COMPLETE)]
public class GC_NPCTASK_COMPLETE_Handler : MessageHandler<GC_NPCTASK_COMPLETE>
{
    protected override void Execute(Robot curRobot, GC_NPCTASK_COMPLETE message)
    {
        
    }
}
