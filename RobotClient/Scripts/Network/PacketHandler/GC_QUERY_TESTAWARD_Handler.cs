using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_QUERY_TESTAWARD)]
public class GC_QUERY_TESTAWARD_Handler : MessageHandler<GC_QUERY_TESTAWARD>
{
    protected override void Execute(Robot curRobot, GC_QUERY_TESTAWARD message)
    {
        
    }
}
