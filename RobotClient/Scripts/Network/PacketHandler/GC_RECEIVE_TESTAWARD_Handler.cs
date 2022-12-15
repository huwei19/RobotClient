using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_RECEIVE_TESTAWARD)]
public class GC_RECEIVE_TESTAWARD_Handler : MessageHandler<GC_RECEIVE_TESTAWARD>
{
    protected override void Execute(Robot curRobot, GC_RECEIVE_TESTAWARD message)
    {
        
    }
}
