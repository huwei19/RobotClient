using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_MAIL_GET_ITEM)]
public class GC_MAIL_GET_ITEM_Handler : MessageHandler<GC_MAIL_GET_ITEM>
{
    protected override void Execute(Robot curRobot, GC_MAIL_GET_ITEM message)
    {
        
    }
}
