using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_PARTICULARS_FRIEND)]
public class GC_PARTICULARS_FRIEND_Handler : MessageHandler<GC_PARTICULARS_FRIEND>
{
    protected override void Execute(Robot curRobot, GC_PARTICULARS_FRIEND message)
    {
        //查看朋友详情
        //curRobot.LogFormat("{0}:Particulars Friend:{1}", curRobot.Name, message.name);
    }
}
