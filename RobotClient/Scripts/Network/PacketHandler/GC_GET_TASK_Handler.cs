using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_GET_TASK)]
public class GC_GET_TASK_Handler : MessageHandler<GC_GET_TASK>
{
    protected override void Execute(Robot curRobot, GC_GET_TASK message)
    {
        
    }
}
