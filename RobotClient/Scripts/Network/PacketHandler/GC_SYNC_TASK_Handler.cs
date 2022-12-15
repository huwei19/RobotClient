using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SYNC_TASK)]
public class GC_SYNC_TASK_Handler : MessageHandler<GC_SYNC_TASK>
{
    protected override void Execute(Robot curRobot, GC_SYNC_TASK message)
    {
        curRobot.m_task = message.taskList;
    }
}
