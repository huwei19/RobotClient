using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_DAILY_STAMINA)]
public class GC_DAILY_STAMINA_Handler : MessageHandler<GC_DAILY_STAMINA>
{
    protected override void Execute(Robot curRobot, GC_DAILY_STAMINA message)
    {
        
    }
}
