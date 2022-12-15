using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_ALBUM_LEVELUP)]
public class GC_ALBUM_LEVELUP_Handler : MessageHandler<GC_ALBUM_LEVELUP>
{
    protected override void Execute(Robot curRobot, GC_ALBUM_LEVELUP message)
    {
        
    }
}
