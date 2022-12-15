using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.XX_REQUEST_HEARTBEAT)]
public class XX_REQUEST_HEARTBEAT_Handler : MessageHandler<XX_REQUEST_HEARTBEAT>
{
    protected override void Execute(Robot curRobot, XX_REQUEST_HEARTBEAT message)
    {
        if (curRobot.NetManager != null) {
            curRobot.NetManager.OnHeartbeat(message.ansi_time);
        }
    }
}
