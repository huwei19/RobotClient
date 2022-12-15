using UnityEngine;
using System.Collections;

public class StateEnterGame : FSMState<Robot>
{
    public enum State
    {
        NONE,
        SUCCESS,
        FAIL,
    }

    public override string getName()
    {
        return "Enter Game";
    }

    public override void onEnter(Robot entity)
    {
        entity.LogFormat("enter game, name:{0} guid:{1:X8}", entity.mainPlayer.Name, entity.mainPlayer.Guid);
        entity.IsQueuing = false;
        //entity.GameState = (int)State.NONE;
    }
    /// <summary>
    /// 这里ChangeState会触发一次 各个state的onEnter事件 如StateDrawCard.onEnter
    /// </summary>
    /// <param name="entity"></param>
    public override void onExecute(Robot entity)
    {
        if (entity.GameState == (int)State.NONE)
        {
            return;
        }

        if (entity.GameState == (int)State.FAIL)
        {
            entity.Log("enter game fail:");
            entity.FSM.ChangeState(new StateExit());
            return;
        }

        //entity.Log("--------机器人执行一次onExecute entity.BehaviorType为 " + entity.BehaviorType);

        entity.IsInScene = true;
        if (entity.BehaviorType == Robot.RobotType.TYPE_SCENE_MAIN)
        {
            StateSceneMain state = new StateSceneMain();
            state.setInterval(1000);
            entity.FSM.ChangeState(state);
        }
        else if (entity.BehaviorType == Robot.RobotType.TYPE_CHAPTER)
        {
            StateChapter state = new StateChapter();
            state.setInterval(1000);
            entity.FSM.ChangeState(state);
        }
        else if (entity.BehaviorType == Robot.RobotType.TYPE_RUMOR)
        {
            StateRumor state = new StateRumor();
            state.setInterval(1000);
            entity.FSM.ChangeState(state);
        }
        else if (entity.BehaviorType == Robot.RobotType.TYPE_STORY)
        {
            StateStory state = new StateStory();
            state.setInterval(1000);
            entity.FSM.ChangeState(state);
        }
        else if (entity.BehaviorType == Robot.RobotType.TYPE_REWIND)
        {
            StateRewind state = new StateRewind();
            state.setInterval(15 * 1000);
            entity.FSM.ChangeState(state);
        }
        else if (entity.BehaviorType == Robot.RobotType.TYPE_CITY)
        {
            StateCity state = new StateCity();
            state.setInterval(15 * 1000);
            entity.FSM.ChangeState(state);
        }
        else if (entity.BehaviorType == Robot.RobotType.TYPE_SHOP)
        {
            StateShop state = new StateShop();
            state.setInterval(15 * 1000);
            entity.FSM.ChangeState(state);
        }
        else if (entity.BehaviorType == Robot.RobotType.TYPE_DRAWCARD)
        {
            StateDrawCard state = new StateDrawCard();
            state.setInterval(15 * 1000);
            entity.FSM.ChangeState(state);
        }
        else if (entity.BehaviorType == Robot.RobotType.TYPE_ITEM)
        {
            StateItem state = new StateItem();
            state.setInterval(15 * 1000);
            entity.FSM.ChangeState(state);
        }
        else if (entity.BehaviorType == Robot.RobotType.TYPE_CARD)
        {
            StateCard state = new StateCard();
            state.setInterval(15 * 1000);
            entity.FSM.ChangeState(state);
        }
        else if (entity.BehaviorType == Robot.RobotType.TYPE_MAIL)
        {
            StateMail state = new StateMail();
            state.setInterval(15 * 1000);
            entity.FSM.ChangeState(state);
        }
        else if (entity.BehaviorType == Robot.RobotType.TYPE_FRIEND)
        {
            StateFriend state = new StateFriend();
            state.setInterval(1000);
            entity.FSM.ChangeState(state);
        }
        else if (entity.BehaviorType == Robot.RobotType.TYPE_DRESSUP)
        {
            StateDressUp state = new StateDressUp();
            state.setInterval(15 * 1000);
            entity.FSM.ChangeState(state);
        }
        else if (entity.BehaviorType == Robot.RobotType.TYPE_RANDOMCG)
        {
            StateRandomCG state = new StateRandomCG();
            state.setInterval(15 * 1000);
            entity.FSM.ChangeState(state);
        }
        else if (entity.BehaviorType == Robot.RobotType.TYPE_RANDOMMSG)
        {
            StateRandomMsg state = new StateRandomMsg();
            state.setInterval(15 * 1000);
            entity.FSM.ChangeState(state);
        }
        else if (entity.BehaviorType == Robot.RobotType.TYPE_RANDOMBYTE)
        {
            StateRandomByte state = new StateRandomByte();
            state.setInterval(15 * 1000);
            entity.FSM.ChangeState(state);
        }
        else if (entity.BehaviorType == Robot.RobotType.TYPE_STORY_EX)
        {
            StateStoryEx state = new StateStoryEx();
            state.setInterval(100);
            entity.FSM.ChangeState(state);
        }
        else if (entity.BehaviorType == Robot.RobotType.TYPE_HALT)
        {
            StateHalt state = new StateHalt();
            state.setInterval(1000);
            entity.FSM.ChangeState(state);
        }
        else if (entity.BehaviorType == Robot.RobotType.TYPE_FRIEND_GIVE)
        {
            StateFriendGive state = new StateFriendGive();
            state.setInterval(15000);
            entity.FSM.ChangeState(state);
        }
        else if (entity.BehaviorType == Robot.RobotType.TYPE_TASK)
        {
            StateTask state = new StateTask();
            state.setInterval(15000);
            entity.FSM.ChangeState(state);
        }
        else
        {
            entity.Log("EnterGame:behavior fail: " + entity.BehaviorType);
        }

        return;
    }
}
