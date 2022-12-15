using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_MONTHCARD_RECEIVEREWARD)]
public class GC_MONTHCARD_RECEIVEREWARD_Handler : MessageHandler<GC_MONTHCARD_RECEIVEREWARD>
{
    protected override void Execute(Robot curRobot, GC_MONTHCARD_RECEIVEREWARD message)
    {
        
    }
}
