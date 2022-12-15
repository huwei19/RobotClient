using System.Collections;
using System.Collections.Generic;
using ProtobufPacket;
using System;
using LiteNet;
using System.IO;
using Games.Table;
using System.Linq;


public class StateTask : FSMState<Robot>
{
    public override string getName()
    {
        return "Task";
    }

    public override void onEnter(Robot entity)
    {
        entity.Log("Task: ");
    }

    public override void onExecute(Robot entity)
    {
        //时间冷却
        if (!isRun())
        {
            return;
        }

        if (entity.m_task == null)
        {
            return;
        }

        if (entity.m_task.Count < 0)
        {
            entity.m_IsValid = true;
            return;
        }
        else
        {
            _TaskData task = entity.m_task[0];
            if (task.taskType == 1)//未满足
            {

            }
            else if (task.taskType == 2)//未领取
            {

            }
            else
            {
                
            }

            Dictionary<int, List<Tab_Task>> tabTask = TableManager.GetTask();
            if (tabTask.ContainsKey(task.taskId))
            {
                
            }
        }
        return;
    }
}