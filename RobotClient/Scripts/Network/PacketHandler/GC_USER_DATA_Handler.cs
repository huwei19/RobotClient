using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_USER_DATA)]
public class GC_USER_DATA_Handler : MessageHandler<GC_USER_DATA>
{
    protected override void Execute(Robot curRobot, GC_USER_DATA message)
    {
        if (message.user == null)
            return;

        if (!message.user.Has_guid) {
            return;
        }

        curRobot.mainPlayer.Guid = message.user.guid;
        curRobot.mainPlayer.Name = message.user.name;
        curRobot.mainPlayer.Signature = message.user.signature;
        if (message.user.Has_level)
            curRobot.mainPlayer.Level = message.user.level;
        if (message.user.Has_create_time)
            curRobot.mainPlayer.CreateTime = message.user.create_time;
        if (message.user.Has_cardid)
            curRobot.mainPlayer.CardId = message.user.cardid;
        if (message.Has_isNonage)
            curRobot.mainPlayer.isNonage = message.isNonage == 1;
        if (message.Has_openNumeralTime)
            curRobot.mainPlayer.OpenNumeralTime = message.openNumeralTime;
        if (message.Has_firstLogin)
            curRobot.mainPlayer.IsFirstLogin = message.firstLogin;
        //curRobot.mainPlayer.guideId = message.user.guideid;
    }
}
