/*城市挂机 和 城市副本都会执行



*/

using System.Collections;
using System.Collections.Generic;
using ProtobufPacket;
using System;
using Games.Table;
using System.Linq;
using UnityEngine;

public class StateCity : FSMState<Robot>
{
    /// <summary>
    /// 城市副本 故事线
    /// </summary>
    /// <returns></returns>
    investigation m_investigation = new investigation();

    /// <summary>
    /// 当前 城市副本的楼层 每次执行完成后，会+1 向下一层
    /// </summary>
    Tab_CityCopyFloor currentCityFloor;

    /// <summary>
    /// 当前楼层是否 已经点击过 标识位
    /// </summary>
    public bool is_currentCityFloor_hasClicked = false;



    /// <summary>
    /// 从客户端表 取出的 楼层行数据
    /// </summary>
    /// <typeparam name="Tab_CityCopyFloor"></typeparam>
    /// <returns></returns>
    List<Tab_CityCopyFloor> l_floors = new List<Tab_CityCopyFloor>();

    public override string getName()
    {
        //
        return "City 城市挂机/ 城市副本";
    }

    public override void onEnter(Robot entity)
    {
        Dictionary<int, List<Tab_Card>> tabCard = TableManager.GetCard();
        Dictionary<int, List<Tab_CityWorkTask>> tabCityWorkTask = TableManager.GetCityWorkTask();
        int lpos = 0;
        foreach (var item in tabCard)
        {
            if (lpos < entity.tempCityWorkTask.Count)
            {
                Dictionary<int/*城市id*/, List<int/*卡牌id*/>> ltemp = entity.tempCityWorkTask.ElementAt(lpos).Value;
                if (ltemp.ElementAt(0).Value.Count >= 3)
                {
                    ++lpos;
                }
                else
                {
                    ltemp.ElementAt(0).Value.Add(item.Value[0].Id);
                }
            }
        }
        ////---删除没有卡牌的
        for (int i = entity.tempCityWorkTask.Count - 1; i > lpos; --i)
        {
            entity.tempCityWorkTask.Remove(entity.tempCityWorkTask.ElementAt(lpos).Key);
        }

        /////------- 增加城市挂机卡牌
        foreach (var item in tabCard)
        {
            if (item.Value.Count > 0)
            {
                entity.SendCMD("card," + item.Value[0].Id + ",1,60,4");
            }
        }

        //初始化 城市副本的 故事副本
        Init_investigation(entity);
    }

    /// <summary>
    /// 初始化 城市副本的 故事副本
    /// </summary>
    public void Init_investigation(Robot entity)
    {
        Dictionary<int, List<Tab_CityCopyFloor>> dic_floors = TableManager.GetCityCopyFloor();
        if (dic_floors != null && dic_floors.Count > 0)
        {
            //将本地的表数据 放入内存存储
            foreach (var item in dic_floors)
            {
                if (item.Value != null && item.Value.Count > 0)
                {
                    l_floors.Add(item.Value[0]);
                }
            }
            currentCityFloor = dic_floors.First().Value[0];
            m_investigation.init(entity, GetStoryChapterLevelIds_byCityFloor(entity, currentCityFloor));
            entity.Log("--------重置了一次 城市副本，当前currentCityFloor 楼层为:  " + currentCityFloor.Id);
        }
        else
        {
            entity.Log("--------找不到 城市副本数据------ ");
        }
    }

    /// <summary>
    /// 获取下一个楼层的表行数据 Tab_CityCopyFloor
    /// </summary>
    /// <returns></returns>
    public Tab_CityCopyFloor GetNextFloor()
    {
        Tab_CityCopyFloor newfloor = null;
        if (l_floors != null && l_floors.Count > 0)
        {
            newfloor = l_floors.Find(t => t.Index == currentCityFloor.Index + 1);
        }
        return newfloor;
    }

    /// <summary>
    /// 通过 城市副本楼层id 获取 该楼层所对应的 故事关卡
    /// </summary>
    /// <param name="cityCopyFloor"></param>
    /// <returns></returns>
    private List<int> GetStoryChapterLevelIds_byCityFloor(Robot entity, Tab_CityCopyFloor cityCopyFloor)
    {
        if (cityCopyFloor == null)
        {
            return null;
        }
        int cityCopyId = (int)Math.Floor((double)cityCopyFloor.Id / 100);
        Tab_CityCopy cityCopy = TableManager.GetCityCopyByID(cityCopyId);

        Dictionary<int, List<Tab_StoryChapterLevel>> dic_levels = TableManager.GetStoryChapterLevel();
        List<Tab_StoryChapterLevel> l_levels = new List<Tab_StoryChapterLevel>();

        if (l_floors == null || dic_levels == null || dic_levels.Count <= 0)
        {
            return null;
        }

        //循环本地 表数据 查找章节id和副本 一样
        foreach (var item in dic_levels)
        {
            if (item.Value != null && item.Value.Count > 0)
            {
                if (item.Value[0].StoryChapterId == cityCopy.StoryChaperId)
                {
                    l_levels.Add(item.Value[0]);
                }
            }
        }
        if (l_levels == null || l_levels.Count <= 0)
        {
            return null;
        }

        //用楼层索引排序
        l_levels = l_levels.OrderBy(t => t.Floor).ToList();
        List<int> l_temp = new List<int>();
        foreach (var level in l_levels)
        {
            l_temp.Add(level.Id);
        }

        entity.Log("-----取出的故事关卡个数为:  " + l_temp.Count);
        return l_temp;
    }

    //领取城市挂机奖励
    public void WorkAward(Robot entity)
    {
        entity.Log("---尝试领取挂机奖励 WorkAward---");
        foreach (var item in entity.tempCityWorkTaskAward)
        {
            CG_CITYWORK_GET_TASK packet = new CG_CITYWORK_GET_TASK();
            packet.cityId = item.Value;
            packet.taskId = item.Key;
            //entity.NetManager.SendMsg(packet);
            entity.SendMsg(packet);

            entity.TransStart(TransEvent.CityWorkGet);
            return;
        }
    }

    //开始挂机
    public void BeginOnHook(Robot entity)
    {
        entity.Log("--- 开始挂机 BeginOnHook--- task数量： " + entity.tempCityWorkTask.Count);
        if (entity.tempCityWorkTask.Count == 0)
        {
            return;
        }
        ////---随机选一个城市挂机
        System.Random rd = new System.Random();
        int val = rd.Next(0, entity.tempCityWorkTask.Count);
        var item = entity.tempCityWorkTask.ElementAt(val);
        CG_CITYWORK_RECEIVE_TASK packet = new CG_CITYWORK_RECEIVE_TASK();
        packet.cityId = item.Value.ElementAt(0).Key;
        packet.taskId = item.Key;
        foreach (var item2 in item.Value.ElementAt(0).Value)
        {
            packet.cardid.Add(item2);
        }
        //entity.NetManager.SendMsg(packet);
        entity.SendMsg(packet);
        entity.cityTaskId = item.Key;

        entity.TransStart(TransEvent.CityWorkReceiveTask);
        return;
    }

    /// <summary>
    /// 向服务器 发送楼层点击事件
    /// </summary>
    /// <param name="entity"></param>
    public void SendFloor_Click(Robot entity)
    {
        CG_FLOOR_CLICK packet = new CG_FLOOR_CLICK();
        packet.FloorId = currentCityFloor.Id;
        entity.SendMsg(packet);

        //标识位
        is_currentCityFloor_hasClicked = true;
    }

    /// <summary>
    /// 获取城市副本 礼物
    /// </summary>
    /// <param name="entity"></param>
    public void GetCityCopy_Reward(Robot entity)
    {
        CG_CITY_COPY_GET_FAST_AWARD packet1 = new CG_CITY_COPY_GET_FAST_AWARD();
        packet1.CopyId = currentCityFloor.Id;
        entity.SendMsg(packet1);

        CG_CITY_COPY_GET_COMMON_AWARD packet2 = new CG_CITY_COPY_GET_COMMON_AWARD();
        packet2.CopyId = currentCityFloor.Id;
        entity.SendMsg(packet2);
    }

    /// <summary>
    /// 随机种子，每次onExecute就+1     除以3的余数用来判定执行逻辑
    /// </summary>
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
            BeginOnHook(entity);
        }
        else if (m_num % 3 == 1)
        {
            WorkAward(entity);
        }
        else
        {
            //首先发送点击事件
            if (!is_currentCityFloor_hasClicked)
            {
                SendFloor_Click(entity);
            }

            //进入城市副本
            if (m_investigation.over())   //---------副本章节完成 需要进入新的楼层
            {
                //  章节执行完成后，尝试进入 下一个城市副本楼层
                Tab_CityCopyFloor temp_floor = GetNextFloor();

                if (temp_floor != null)
                {
                    //进入新楼层
                    currentCityFloor = temp_floor;

                    //重新初始化 城市副本
                    m_investigation.init(entity, GetStoryChapterLevelIds_byCityFloor(entity, currentCityFloor));
                }
                else
                {//------------>找不到下一楼层，说明 已经是最后一层
                    //城市副本领奖
                    GetCityCopy_Reward(entity);

                    //重置 城市副本 重新开始 楼层打关 --->里面会重置currentCityFloor
                    Init_investigation(entity);
                }
                entity.m_IsValid = true;

                //重置标识位为false
                is_currentCityFloor_hasClicked = false;
                return;
            }
            else
            {
                if (m_investigation.m_start)
                {
                    m_investigation.start(entity);
                    //start后，5-15分钟(随机)后发送finish
                    System.Random rd = new System.Random();
                    setInterval(rd.Next(5 * 60 * 1000, 15 * 60 * 1000));
                }
                else
                {
                    m_investigation.finish(entity);
                    //5s后执行下一关卡
                    setInterval(5000);
                }
            }
        }
        ++m_num;
        return;
    }
}