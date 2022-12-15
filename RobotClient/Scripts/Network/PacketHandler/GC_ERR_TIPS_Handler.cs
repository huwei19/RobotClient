using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_ERR_TIPS)]
public class GC_ERR_TIPS_Handler : MessageHandler<GC_ERR_TIPS>
{
    protected override void Execute(Robot curRobot, GC_ERR_TIPS message)
    {
        
    }
}
