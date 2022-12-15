/*****************************************
 * 好友互赠模拟
 * 1 好友不满，尝试加好友 加本组机器人里随机的15个
 * 2 加完好友后，概率一键赠领 or 单人赠领
 * 3 回到1，重复
 * **************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Games.GlobeDefine;

public class StateFriendGive : FSMState<Robot>
{
    public enum STEP
    {
        NONE,
        BEGIN,              //初始
        PREPARE,             //准备
        AddFriend,          //请求加好友
        AcceptFriend,       //同意加好友
        GiveFriend,         //好友赠礼

    }
    private STEP m_nPreStep = STEP.NONE;
    private STEP m_nCurStep = STEP.NONE;
    private float m_fStepStartTime = 0;

    private int m_nOpCount = 0;
    public void SetStep(Robot entity, STEP nStep)
    {
        float fCostTime = (float)Utils.GetTimeStamp() - m_fStepStartTime;
        m_nPreStep = m_nCurStep;
        m_nCurStep = nStep;
        m_fStepStartTime = (float)Utils.GetTimeStamp();

        m_nOpCount = 0;

        entity.LogFormat("state:{0} step: {1}-->{2} cost:{3:F3}", getName(), m_nPreStep, m_nCurStep, fCostTime);
    }
    public override string getName()
    {
        return "FriendGive";
    }

    public override void onEnter(Robot entity)
    {
        entity.Log("Enter State FriendGive");
        SetStep(entity, STEP.BEGIN);
    }

    public override void onExecute(Robot entity)
    {
        //时间冷却
        if (!isRun()){
            return;
        }
           
        switch (m_nCurStep)
        {
            case STEP.BEGIN:
                {
                    if (entity.mFriendData.Friends.Count < GlobeVar.FriendMax)
                    {
                        //先加好友
                        //entity.RecommendFriend();
                        SetStep(entity, STEP.AddFriend);
                    }
                    else
                    {
                        SetStep(entity, STEP.GiveFriend);
                    }
                }
                break;
            case STEP.AddFriend:
                {
                    if ((float)Utils.GetTimeStamp() - m_fStepStartTime < 1)
                        break;

                    //加推荐列表里的人
                    //if(m_nOpCount >= 0 && m_nOpCount < entity.mFriendData.Recmmends.Count && m_nOpCount <15)
                    //{
                    //    //继续加好友
                    //    entity.FriendOp(entity.mFriendData.Recmmends[m_nOpCount].FriendId, EFriendOpType.Add_Friend);
                    //    m_nOpCount++;
                    //}

                    List<Robot> robotList = MainUILogic.Instance().RobotList;
                    if (m_nOpCount <robotList.Count && m_nOpCount < 15)
                    {
                        int idx = Random.Range(0, robotList.Count); //随机加本组机器人为好友
                        entity.FriendOp((long)robotList[idx].mainPlayer.Guid, EFriendOpType.Add_Friend);
                        m_nOpCount++;
                    }
                    else
                    {
                        // 下一步
                        SetStep(entity, STEP.AcceptFriend);
                        m_nOpCount = 0;
                    }
                }
                break;
            case STEP.AcceptFriend:
                {
                    if ((float)Utils.GetTimeStamp() - m_fStepStartTime < 1)
                        break;

                    //整个申请表都同意完了，或者同意大于15个人了
                    if (entity.mFriendData.Applys.Count <=0 || m_nOpCount >= 15) 
                    {
                        //没有好友  继续去加 有了就去赠送
                        if (entity.mFriendData.Friends.Count <= 0)
                            SetStep(entity, STEP.BEGIN);
                        else
                            SetStep(entity, STEP.GiveFriend);
                    }
                    else
                    {
                        //申请列表有人 同意
                        entity.FriendOp(entity.mFriendData.Applys[0].LFID, EFriendOpType.Acc_Friend);
                        m_nOpCount++;
                    }
                }
                break;
            case STEP.GiveFriend:
                {
                    if ((float)Utils.GetTimeStamp() - m_fStepStartTime < 1)
                        break;

                    if (entity.mFriendData.Friends.Count <=0)
                    {
                        SetStep(entity, STEP.BEGIN);
                        break;
                    }

                    int nSimple =UnityEngine.Random.Range(0, 1000);
                    entity.SendGive(entity.mFriendData.Friends[0].LFID, nSimple < 500);

                    //再尝试
                    SetStep(entity, STEP.BEGIN);
                }
                break;
        }

    }
}

