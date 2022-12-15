using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SYNC_DEBTPUNISHSTATE)]
public class GC_SYNC_DEBTPUNISHSTATE_Handler : MessageHandler<GC_SYNC_DEBTPUNISHSTATE>
{
    protected override void Execute(Robot curRobot, GC_SYNC_DEBTPUNISHSTATE message)
    {
        
    }
}
