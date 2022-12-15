using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.OC_TRANSPORT_PACK)]
public class OC_TRANSPORT_PACK_Handler : MessageHandler<OC_TRANSPORT_PACK>
{
    protected override void Execute(Robot curRobot, OC_TRANSPORT_PACK message)
    {
        
    }
}
