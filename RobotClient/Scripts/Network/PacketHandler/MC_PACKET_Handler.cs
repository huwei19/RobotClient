using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.MC_PACKET)]
public class MC_PACKET_Handler : MessageHandler<MC_PACKET>
{
    protected override void Execute(Robot curRobot, MC_PACKET message)
    {
        
    }
}
