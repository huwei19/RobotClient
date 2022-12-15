using LiteNet;
using UnityEngine;
using ProtobufPacket;
using System.Collections.Generic;

[MessageHandler(MessageID.GC_CITYWORK_RECEIVE_TASK)]
public class GC_CITYWORK_RECEIVE_TASK_Handler : MessageHandler<GC_CITYWORK_RECEIVE_TASK>
{
    protected override void Execute(Robot curRobot, GC_CITYWORK_RECEIVE_TASK message)
    {
        curRobot.TransEnd(TransEvent.CityWorkReceiveTask, RESULT.SUCCESS);
        //curRobot.LogFormat("City Work:{0} taskId:{1}", message.cityId, message.taskData.taskId);
        if (message.taskData.taskId > 100)
        {
            curRobot.tempCityWorkTaskAward.Add(message.taskData.taskId, message.cityId);
        }



    }
}
