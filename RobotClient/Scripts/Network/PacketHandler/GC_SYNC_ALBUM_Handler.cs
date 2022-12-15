using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SYNC_ALBUM)]
public class GC_SYNC_ALBUM_Handler : MessageHandler<GC_SYNC_ALBUM>
{
    protected override void Execute(Robot curRobot, GC_SYNC_ALBUM message)
    {
        
    }
}
