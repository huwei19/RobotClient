using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.OC_TRANSPORT_TO_CROSS)]
public class OC_TRANSPORT_TO_CROSS_Handler : MessageHandler<OC_TRANSPORT_TO_CROSS>
{
    protected override void Execute(Robot curRobot, OC_TRANSPORT_TO_CROSS message)
    {
        
    }
}
