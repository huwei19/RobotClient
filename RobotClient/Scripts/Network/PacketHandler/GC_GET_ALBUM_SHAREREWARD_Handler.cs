using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_GET_ALBUM_SHAREREWARD)]
public class GC_GET_ALBUM_SHAREREWARD_Handler : MessageHandler<GC_GET_ALBUM_SHAREREWARD>
{
    protected override void Execute(Robot curRobot, GC_GET_ALBUM_SHAREREWARD message)
    {
        
    }
}
