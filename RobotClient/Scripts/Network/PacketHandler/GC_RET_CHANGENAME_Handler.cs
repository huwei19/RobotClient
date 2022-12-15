using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_RET_CHANGENAME)]
public class GC_RET_CHANGENAME_Handler : MessageHandler<GC_RET_CHANGENAME>
{
    protected override void Execute(Robot curRobot, GC_RET_CHANGENAME message)
    {
        
    }
}
