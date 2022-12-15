using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SAVEPOINT_GET)]
public class GC_SAVEPOINT_GET_Handler : MessageHandler<GC_SAVEPOINT_GET>
{
    protected override void Execute(Robot curRobot, GC_SAVEPOINT_GET message)
    {
        
    }
}
