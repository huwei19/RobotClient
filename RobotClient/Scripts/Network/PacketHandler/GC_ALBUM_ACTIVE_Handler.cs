using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_ALBUM_ACTIVE)]
public class GC_ALBUM_ACTIVE_Handler : MessageHandler<GC_ALBUM_ACTIVE>
{
    protected override void Execute(Robot curRobot, GC_ALBUM_ACTIVE message)
    {
        
    }
}
