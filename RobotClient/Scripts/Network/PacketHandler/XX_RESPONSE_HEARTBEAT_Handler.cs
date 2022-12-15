using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.XX_RESPONSE_HEARTBEAT)]
public class XX_RESPONSE_HEARTBEAT_Handler : MessageHandler<XX_RESPONSE_HEARTBEAT>
{
    protected override void Execute(Robot curRobot, XX_RESPONSE_HEARTBEAT message)
    {
        
    }
}
