using LiteNet;
using UnityEngine;
using ProtobufPacket;
using System.Collections.Generic;

[MessageHandler(MessageID.GC_SYNC_CITYWORK)]
public class GC_SYNC_CITYWORK_Handler : MessageHandler<GC_SYNC_CITYWORK>
{
    protected override void Execute(Robot curRobot, GC_SYNC_CITYWORK message)
    {
        if (curRobot.BehaviorType == Robot.RobotType.TYPE_CITY)
        {
            //先清空
            curRobot.tempCityWorkTask.Clear();

            foreach (var item in message.cityWorkData)
            {
                foreach (var item2 in item.taskData)
                {
                    if (!curRobot.tempCityWorkTask.ContainsKey(item2.taskId))
                    {
                        //curRobot.Log("--------GC_SYNC_CITYWORK_Handler  增加tempCityWorkTask----------");
                        curRobot.tempCityWorkTask.Add(item2.taskId, new Dictionary<int, List<int>>());
                    }
                    curRobot.tempCityWorkTask[item2.taskId].Add(item.cityId, new List<int>());
                }
            }
        }
    }
}
