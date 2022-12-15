using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_REQUEST_PURCHASE_INFO)]
public class GC_REQUEST_PURCHASE_INFO_Handler : MessageHandler<GC_REQUEST_PURCHASE_INFO>
{
    protected override void Execute(Robot curRobot, GC_REQUEST_PURCHASE_INFO message)
    {
        
    }
}
