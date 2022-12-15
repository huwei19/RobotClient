using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_ENTER_CONTAINER)]
public class GC_ENTER_CONTAINER_Handler : MessageHandler<GC_ENTER_CONTAINER>
{
    protected override void Execute(Robot curRobot, GC_ENTER_CONTAINER message)
    {
        curRobot.GameState = (int)StateEnterGame.State.SUCCESS;
    }
}
