using System.Collections;
using System.Collections.Generic;
using ProtobufPacket;
using System;
using Games.Table;
using System.IO;
using System.Linq;

public class StateDressUp : FSMState<Robot>
{
    static private List<int> m_ls;

    public override string getName()
    {
        return "DressUp";
    }

    public override void onEnter(Robot entity)
    {
        ////---
        ///
        entity.SendCMD("funlock,999");//功能开放 全部开启
        entity.SendCMD("item,1,1000000");
        entity.SendCMD("item,2,1000000");
        entity.SendCMD("fateu,10,1");

        Dictionary<int, List<Tab_Card>> tabCard = TableManager.GetCard();
        /////------- 增加卡牌
        foreach (var item in tabCard)
        {
            if (item.Value.Count > 0)
            {
                entity.SendCMD("card," + item.Value[0].Id + ",1,1,1");
            }
        }


        //CG_SKIN_UNLOCK packet2 = new CG_SKIN_UNLOCK();
        //packet2.SkinId = 1120;
        //packet2.FateLineId = 10;
        //entity.NetManager.SendMsg(packet2);

    }

    void UnLockSkine(Robot entity)
    {
        //SkinData
        Dictionary<int, List<Tab_SkinData>> tabSkinData = TableManager.GetSkinData();
        foreach (var item in tabSkinData)
        {
            Tab_SkinData tab = item.Value[0];
            if (tab.LockPrice == -1)
            {
                if (!entity.skindId.ContainsKey(tab.Id))
                {
                    entity.skindId.Add(tab.Id, tab);
                    continue;
                }
            }
            if (!entity.skindId.ContainsKey(tab.Id))
            {
                //skindId.Add(tab.Id,tab);
                CG_SKIN_UNLOCK packet = new CG_SKIN_UNLOCK();
                packet.SkinId = tab.Id;
                packet.FateLineId = tab.FateLineId;
                //entity.NetManager.SendMsg(packet);
                entity.SendMsg(packet);
                return;
            }
        }
    }

    void UnLockDress(Robot entity)
    {
        //SkinData
        Dictionary<int, List<Tab_Dressup>> tabDressup = TableManager.GetDressup();
        foreach (var item in tabDressup)
        {
            Tab_Dressup tab = item.Value[0];
            if (tab.LockPrice == -1)
            {
                if (!entity.dressId.ContainsKey(tab.Id))
                {
                    entity.dressId.Add(tab.Id, tab);
                    continue;
                }
            }

            if (entity.skindId.ContainsKey(tab.CardSkinId))
            {
                if (!entity.dressId.ContainsKey(tab.Id))
                {
                    //穿戴需要性格值
                    entity.SendCMD("prt,"+ tab.PersonalityId + ",300");
                    entity.dressId.Add(tab.Id, tab);
                    //dressId.Add(tab.Id, tab);
                    CG_DRESS_UNLOCK packet = new CG_DRESS_UNLOCK();
                    packet.DressId = tab.Id;
                    packet.FateLineId = entity.skindId[tab.CardSkinId].FateLineId;
                    //entity.NetManager.SendMsg(packet);
                    entity.SendMsg(packet);
                    entity.TransStart(TransEvent.DressUnlock);
                    return;
                }
            }
           
        }
    }

    void DressUp(Robot entity)
    {
        if (entity.skindId.Count > 0)
        {
            Random rd = new Random();
            int val = rd.Next(0, entity.skindId.Count);
            var item = entity.skindId.ElementAt(val);
            CG_DRESSUP packet = new CG_DRESSUP();
            packet.FateLineId = item.Value.FateLineId;
            packet.DressInfo = new _DressInfo();
            packet.DressInfo.SkinId = item.Value.Id;
            foreach (var itemdress in entity.dressId)
            {
                Tab_Dressup tab = itemdress.Value;
                if (tab.CardSkinId == packet.DressInfo.SkinId)
                {
                    if (rd.Next(0, 2) == 0)
                    {
                        packet.DressInfo.HangingIds.Add(tab.Id);
                    }
                }
            }
            //entity.NetManager.SendMsg(packet);
            entity.SendMsg(packet);
            entity.TransStart(TransEvent.DressUp);
        }
       
    }

    int m_num = 0;
    public override void onExecute(Robot entity)
    {
        //时间冷却
        if (!isRun())
        {
            return;
        }

        if (m_num % 3 == 0)
        {
            ///解锁
            UnLockSkine(entity);
        }
        else if (m_num % 3 == 1)
        {
            UnLockDress(entity);
        }
        else if (m_num % 3 == 2)
        {
            DressUp(entity);
        }

        ++m_num;
        return;
    }
}