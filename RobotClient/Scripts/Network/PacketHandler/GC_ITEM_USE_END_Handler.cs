using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_ITEM_USE_END)]
public class GC_ITEM_USE_END_Handler : MessageHandler<GC_ITEM_USE_END>
{
    protected override void Execute(Robot curRobot, GC_ITEM_USE_END message)
    {
        
    }
}
