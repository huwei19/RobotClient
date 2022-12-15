using System.Collections;
using System.Collections.Generic;
using ProtobufPacket;
using System;

public class StateDrawCard : FSMState<Robot>
{
    private int m_chouka_1;
    private int m_chouka_2;
    Random rd = new Random();
    public override string getName()
    {
        return "Draw Card 抽卡";
    }

    public override void onEnter(Robot entity)
    {
        entity.Log(string.Format("<color=red>{0}</color>", "onEnter 事件"));

        entity.SendCMD("item,121,1000000");//??????????????????
        entity.SendCMD("item,122,1000000");//??????????????????
        entity.SendCMD("item,1,100000");
        entity.SendCMD("item,2,100000");
    }

    public void init(Robot entity)
    {
        entity.Log(string.Format("<color=red>{0}</color>", "init 事件"));
        entity.SendCMD("item,121,1000");//??????????????????
        entity.SendCMD("item,122,1000");//??????????????????
        entity.SendCMD("item,1,1000");
        entity.SendCMD("item,2,1000");
    }


    /// <summary>
    /// 发送抽卡 消息包
    /// </summary>
    /// <param name="entity"></param>
    private void draw(Robot entity)
    {
        CG_DRAW_CARD packet = new CG_DRAW_CARD();

        int drawType = rd.Next(0, 3);
        if (drawType == 0)
        {
            packet.DrawType = (int)CG_DRAW_CARD.DRAWTYPE.NOMAL;  //普通抽卡
        }
        else if (drawType == 1)
        {
            packet.DrawType = (int)CG_DRAW_CARD.DRAWTYPE.ADVANCE;//高级抽卡
        }
        else if (drawType == 2)
        {
            packet.DrawType = (int)CG_DRAW_CARD.DRAWTYPE.ADVANCEUP;//概率up抽卡
        }
        else
        {
            packet.DrawType = (int)CG_DRAW_CARD.DRAWTYPE.ACTIVITY;//活动抽卡
        }

        if (rd.Next(0, 2) == 0)
        {
            packet.IsMulti = true;
        }
        else
        {
            packet.IsMulti = false;
        }
        //entity.NetManager.SendMsg(packet);
        entity.SendMsg(packet);

        entity.TransStart(entity.GetDrawEvent(packet.DrawType, packet.IsMulti));
    }

    private void drawaward(Robot entity)
    {
        if (entity.m_statdrawcard_advance_count % 50 > 0)
        {
            CG_DRAW_CARD_AWARD packet = new CG_DRAW_CARD_AWARD();
            //entity.NetManager.SendMsg(packet);
            entity.SendMsg(packet);
        }
    }

    private void drawswitch(Robot entity)
    {
        CG_DRAW_CARD_SWITCH packet = new CG_DRAW_CARD_SWITCH();
        packet.SwitchType = rd.Next(0, 4);
        //entity.NetManager.SendMsg(packet);
        entity.SendMsg(packet);
    }

    int m_num = 0;
    public override void onExecute(Robot entity)
    {
        //时间冷却
        if (!isRun())
        {
            return;
        }

        if (rd.Next(0, 100) == 0)
        {
            init(entity);
        }

        //切换卡池
        if (m_num % 100 == 0)
        {
            drawswitch(entity);
        }

        draw(entity);
        drawaward(entity);
        ++m_num;
        return;
    }
}