using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_CITY_COPY_AWARD_PANEL)]
public class GC_CITY_COPY_AWARD_PANEL_Handler : MessageHandler<GC_CITY_COPY_AWARD_PANEL>
{
    protected override void Execute(Robot curRobot, GC_CITY_COPY_AWARD_PANEL message)
    {
        
    }
}
