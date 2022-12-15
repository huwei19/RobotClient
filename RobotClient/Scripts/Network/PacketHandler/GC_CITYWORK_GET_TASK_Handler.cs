using LiteNet;
using UnityEngine;
using ProtobufPacket;
using System.Collections.Generic;

[MessageHandler(MessageID.GC_CITYWORK_GET_TASK)]
public class GC_CITYWORK_GET_TASK_Handler : MessageHandler<GC_CITYWORK_GET_TASK>
{
    protected override void Execute(Robot curRobot, GC_CITYWORK_GET_TASK message)
    {
        //curRobot.LogFormat("City Work Aware:{0} oldTaskId:{1} taskId:{2}", message.cityId, message.oldTaskId, message.taskId);

        curRobot.TransEnd(TransEvent.CityWorkGet, RESULT.SUCCESS);
        if (curRobot.tempCityWorkTask.ContainsKey(message.oldTaskId))
        {
            if (message.taskId > 100)
            {
                curRobot.Log("--------GC_CITYWORK_GET_TASK_Handler  增加tempCityWorkTask----------");
                curRobot.tempCityWorkTask.Add(message.taskId, new Dictionary<int, List<int>>(curRobot.tempCityWorkTask[message.oldTaskId]));
            }
            curRobot.tempCityWorkTask.Remove(message.oldTaskId);
        }

        curRobot.tempCityWorkTaskAward.Remove(message.oldTaskId);

    }
}
