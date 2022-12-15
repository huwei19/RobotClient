using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SYNC_CARDFRAME_LIST)]
public class GC_SYNC_CARDFRAME_LIST_Handler : MessageHandler<GC_SYNC_CARDFRAME_LIST>
{
    protected override void Execute(Robot curRobot, GC_SYNC_CARDFRAME_LIST message)
    {
        
    }
}
