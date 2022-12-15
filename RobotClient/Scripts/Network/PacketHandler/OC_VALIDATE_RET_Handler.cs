using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.OC_VALIDATE_RET)]
public class OC_VALIDATE_RET_Handler : MessageHandler<OC_VALIDATE_RET>
{
    protected override void Execute(Robot curRobot, OC_VALIDATE_RET message)
    {
        
    }
}
