using LiteNet;
using UnityEngine;
using ProtobufPacket;
using Games.GlobeDefine;

[MessageHandler(MessageID.GC_AUTO_SYNC_GAMECONFIG)]
public class GC_AUTO_SYNC_GAMECONFIG_Handler : MessageHandler<GC_AUTO_SYNC_GAMECONFIG>
{
    protected override void Execute(Robot curRobot, GC_AUTO_SYNC_GAMECONFIG message)
    {
        GlobeVar.AutoGameConfig = LitJson.JsonMapper.ToObject<GameStruct_AutoGameConfig>(message.jsonstr);
    }
}
