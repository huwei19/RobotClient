using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SYNC_CHARGE_AMT)]
public class GC_SYNC_CHARGE_AMT_Handler : MessageHandler<GC_SYNC_CHARGE_AMT>
{
    protected override void Execute(Robot curRobot, GC_SYNC_CHARGE_AMT message)
    {
        
    }
}
