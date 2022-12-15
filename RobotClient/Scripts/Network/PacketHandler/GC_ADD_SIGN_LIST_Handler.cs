using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_ADD_SIGN_LIST)]
public class GC_ADD_SIGN_LIST_Handler : MessageHandler<GC_ADD_SIGN_LIST>
{
    protected override void Execute(Robot curRobot, GC_ADD_SIGN_LIST message)
    {
        
    }
}
