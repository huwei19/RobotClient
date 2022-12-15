using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_ALBUM_ACTIVE_CARD)]
public class GC_ALBUM_ACTIVE_CARD_Handler : MessageHandler<GC_ALBUM_ACTIVE_CARD>
{
    protected override void Execute(Robot curRobot, GC_ALBUM_ACTIVE_CARD message)
    {
        
    }
}
