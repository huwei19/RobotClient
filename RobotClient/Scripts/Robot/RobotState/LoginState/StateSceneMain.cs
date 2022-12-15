/********************************************************************
	purpose:	只保持在游戏中，什么操作都不做
*********************************************************************/

using UnityEngine;
using System.Collections;

public class StateSceneMain : FSMState<Robot>
{
    public bool IsSuper = true; //否要一键大号
    public override string getName()
    {
        return "SceneMain";
    }
    public override void onEnter(Robot entity)
    {
        entity.IsInScene = true;
        entity.Log("Enter Scene Main State");
    }

    public override void onExecute(Robot entity)
    {
        if (!isRun())
            return;


    }
}
