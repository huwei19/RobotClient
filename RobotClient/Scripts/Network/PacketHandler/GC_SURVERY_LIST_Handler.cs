using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SURVERY_LIST)]
public class GC_SURVERY_LIST_Handler : MessageHandler<GC_SURVERY_LIST>
{
    protected override void Execute(Robot curRobot, GC_SURVERY_LIST message)
    {
        
    }
}
