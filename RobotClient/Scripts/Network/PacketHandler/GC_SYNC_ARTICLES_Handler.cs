using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SYNC_ARTICLES)]
public class GC_SYNC_ARTICLES_Handler : MessageHandler<GC_SYNC_ARTICLES>
{
    protected override void Execute(Robot curRobot, GC_SYNC_ARTICLES message)
    {
        
    }
}
