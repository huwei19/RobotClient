using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_ACTIVITY_RIDDLECAGE_RECEIVEREWARD)]
public class GC_ACTIVITY_RIDDLECAGE_RECEIVEREWARD_Handler : MessageHandler<GC_ACTIVITY_RIDDLECAGE_RECEIVEREWARD>
{
    protected override void Execute(Robot curRobot, GC_ACTIVITY_RIDDLECAGE_RECEIVEREWARD message)
    {
        
    }
}
