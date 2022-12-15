using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SAVEPOINT)]
public class GC_SAVEPOINT_Handler : MessageHandler<GC_SAVEPOINT>
{
    protected override void Execute(Robot curRobot, GC_SAVEPOINT message)
    {
        //var state = curRobot.FSM.CurState() as StateStoryEx;
        //if (state != null)
        //{
        //    state.OnReceiveMessage(curRobot, message);
        //}

        var stateChapter = curRobot.FSM.CurState() as StateChapter;
        if (stateChapter != null)
        {
            stateChapter.OnReceiveMessage(curRobot, message);
        }
    }
}
