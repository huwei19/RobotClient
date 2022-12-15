using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_FUND_RECEIVELEVELREWARD)]
public class GC_FUND_RECEIVELEVELREWARD_Handler : MessageHandler<GC_FUND_RECEIVELEVELREWARD>
{
    protected override void Execute(Robot curRobot, GC_FUND_RECEIVELEVELREWARD message)
    {
        
    }
}
