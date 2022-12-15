/********************************************************************
	purpose:	退出状态
*********************************************************************/

using UnityEngine;
using System.Collections;

public class StateExit : FSMState<Robot>
{
    public override string getName()
    {
        return "Exit";
    }
    public override void onEnter(Robot entity)
    {
        entity.LogError("Exit ---- Shut  onEnter --- " + entity.Name);
        entity.Shut();
        entity.Reconnect();
    }
}
