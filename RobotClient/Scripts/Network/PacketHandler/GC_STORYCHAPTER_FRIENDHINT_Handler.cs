using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_STORYCHAPTER_FRIENDHINT)]
public class GC_STORYCHAPTER_FRIENDHINT_Handler : MessageHandler<GC_STORYCHAPTER_FRIENDHINT>
{
    protected override void Execute(Robot curRobot, GC_STORYCHAPTER_FRIENDHINT message)
    {
        
    }
}
