using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_CITY_COPY_GET_FAST_AWARD)]
public class GC_CITY_COPY_GET_FAST_AWARD_Handler : MessageHandler<GC_CITY_COPY_GET_FAST_AWARD>
{
    protected override void Execute(Robot curRobot, GC_CITY_COPY_GET_FAST_AWARD message)
    {
        
    }
}
