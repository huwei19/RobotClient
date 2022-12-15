using UnityEngine;
using System.Collections;
using System;
using GCGame.Table;
using Games.Table;

public enum ItemClass
{
    EQUIP = 1,          //装备
    MATERIAL,           //材料    
    STRENGTHEN,         //强化道具
    PRIZE,              //奖励物品
    MEDIC,              //药品
    MISSION,            //任务道具
    FASHION,            //时装
    MOUNT,              //坐骑
    FELLOW,             //伙伴令牌
    BELLE,              //美人
    SWORDSMAN,          //侠客
}

public class GameItemData
{
    public int m_ItemId;
    public UInt64 m_ItemGuid;
    public int m_ProfessionType;
    public int m_ItemPosition;
}
