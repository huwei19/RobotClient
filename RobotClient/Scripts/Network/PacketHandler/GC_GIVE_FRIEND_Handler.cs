using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_GIVE_FRIEND)]
public class GC_GIVE_FRIEND_Handler : MessageHandler<GC_GIVE_FRIEND>
{
    protected override void Execute(Robot curRobot, GC_GIVE_FRIEND message)
    {
        
    }
}
