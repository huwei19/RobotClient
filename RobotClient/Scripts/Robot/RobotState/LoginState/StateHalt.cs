/********************************************************************
	purpose:	停止状态
*********************************************************************/

using UnityEngine;
using System.Collections;

public class StateHalt : FSMState<Robot>
{
    public override string getName()
    {
        return "Halt";
    }
    public override void onEnter(Robot entity)
    {
        entity.LogError("Halt ---- Shut onEnter --- " + entity.Name);
        entity.Shut();
    }
}
