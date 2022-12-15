using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_CONTACTS_REMARK)]
public class GC_CONTACTS_REMARK_Handler : MessageHandler<GC_CONTACTS_REMARK>
{
    protected override void Execute(Robot curRobot, GC_CONTACTS_REMARK message)
    {
        
    }
}
