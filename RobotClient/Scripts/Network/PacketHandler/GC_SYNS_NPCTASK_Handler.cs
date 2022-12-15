using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SYNS_NPCTASK)]
public class GC_SYNS_NPCTASK_Handler : MessageHandler<GC_SYNS_NPCTASK>
{
    protected override void Execute(Robot curRobot, GC_SYNS_NPCTASK message)
    {
        
    }
}
