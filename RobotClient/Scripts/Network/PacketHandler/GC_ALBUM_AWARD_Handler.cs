using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_ALBUM_AWARD)]
public class GC_ALBUM_AWARD_Handler : MessageHandler<GC_ALBUM_AWARD>
{
    protected override void Execute(Robot curRobot, GC_ALBUM_AWARD message)
    {
        
    }
}
