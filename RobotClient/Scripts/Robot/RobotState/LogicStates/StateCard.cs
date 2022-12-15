using System.Collections;
using System.Collections.Generic;
using ProtobufPacket;
using System;
using Games.Table;
using UnityEngine.Analytics;

public class StateCard : FSMState<Robot>
{
    int m_fnish_count = 0;
    public override string getName()
    {
        return "Card";
    }

    public override void onEnter(Robot entity)
    {
        entity.SendCMD("ccb");//清空卡牌背包
        entity.SendCMD("funlock,999");//功能开放 全部开启
        entity.SendCMD("card,1,1,1,1"); //陆林深-拍卖风波  --------->升级 升星
        entity.SendCMD("item,23,100000");//添加经验药水
        entity.SendCMD("item,30,100000");//茉莉花
        entity.SendCMD("item,31,100000");//薰衣草
        entity.SendCMD("item,32,100000");//山茶花
        entity.SendCMD("item,33,100000");//铃兰
        entity.SendCMD("item,34,100000");//睡莲
        entity.SendCMD("item,35,100000");//兰花
        entity.SendCMD("item,1,10000000");//钻石
        entity.SendCMD("item,2,10000000");//金币

        entity.m_statcard_id = 1;   //陆林深-拍卖风波  --------->升级 升星
        entity.m_statcard_lv = 1;
        entity.m_statcard_exp = 0;
        entity.m_can_star_level_up.Clear();
        Dictionary<int, List<Tab_CardStar>> tabCardStar = TableManager.GetCardStar();
        entity.m_statcard_star = 1;

        //卡牌合成需要材料 
        entity.SendCMD("cpiece,2,100000");//陆林深-镜中水月
        entity.m_statcard_make_id = 2;
        entity.m_statcard_make_finish = 0;

        //卡牌转化需要的材料
        entity.SendCMD("card,4,100,1,1");//陆林深-	陆林深-比海更深
        entity.m_statcard_resolve_id = 4;
        entity.m_statcard_resolve_finish = 0;

        //看板主题切换
        entity.SendCMD("card,11,1,1,1");//11	闻灼-善恶之别
        entity.SendCMD("card,19,1,1,1");//19	风泽-雾仓诡事
        entity.m_statcard_visual_id = 11;
        entity.m_statcard_visual_finish = 0;

        //解锁档案 0-9
        entity.SendCMD("card,5,1,1,1");//5	陆林深-出场	
        entity.SendCMD("item,51,10000000");//回形针
        entity.SendCMD("item,52,10000000");//长尾夹
        entity.SendCMD("item,53,10000000");//订书机
        entity.m_statcard_fileunlock_id = 5;
        entity.m_statcard_fileunlock_finish.Clear();
        for (int i = 0; i < 10; ++i)
        {
            entity.m_statcard_fileunlock_finish.Add(false);
        }

        //档案分析
        entity.m_statcard_fileaward_id = 5;
        entity.m_statcard_fileaward_finish.Clear();
        for (int i = 0; i < 10; ++i)
        {
            entity.m_statcard_fileaward_finish.Add(false);
        }

        //档案强化
        entity.m_statcard_enhance_id = 5;
        entity.m_statcard_enhance_finish = 0;

        //修改卡面
        entity.m_statcard_changeface_id = 1;
        entity.m_statcard_changeface_finish = 0;

        //能力提升
        entity.SendCMD("item,3205,10000000");//银发晶(通用) 提升卡牌能力的道具
        entity.SendCMD("item,3203,10000000");//银发晶(研究) 提升卡牌能力的道具
        entity.m_statcard_abilityup_finish = 0;//服务器的回包次数

        //培训
        entity.SendCMD("item,101,10000000");//SR培训道具
        entity.SendCMD("item,102,10000000");//SSr培训道具
        entity.m_statcard_trainlevel_finish = 0;   //服务器的回包次数

    }


    void LevelUp(Robot entity)
    {
        CG_CARD_LEVELUP packet = new CG_CARD_LEVELUP();
        packet.CardId = entity.m_statcard_id;
        packet.ItemId.Add(23);
        packet.ItemCount.Add(1);
        //entity.NetManager.SendMsg(packet);
        entity.SendMsg(packet);
    }

    void LevelUpStar(Robot entity)
    {
        CG_CARD_STAR_LEVELUP packet = new CG_CARD_STAR_LEVELUP();
        packet.CardId = entity.m_statcard_id;

        //entity.NetManager.SendMsg(packet);
        entity.SendMsg(packet);
    }

    void Make(Robot entity)
    {
        CG_CARD_MAKE packet = new CG_CARD_MAKE();
        packet.CardId = 2;
        packet.MakeCount = 1;
        //entity.NetManager.SendMsg(packet);
        entity.SendMsg(packet);
        entity.TransStart(TransEvent.CardMake);
    }

    void Resolve(Robot entity)
    {
        CG_CARD_RESOLVE packet = new CG_CARD_RESOLVE();
        packet.CardId.Add(entity.m_statcard_resolve_id);
        packet.CardCount.Add(1);
        //entity.NetManager.SendMsg(packet);
        entity.SendMsg(packet);
    }

    void Visual(Robot entity)
    {
        CG_VISUAL_CARD packet = new CG_VISUAL_CARD();
        packet.CardId = entity.m_statcard_visual_id;
        //entity.NetManager.SendMsg(packet);
        entity.SendMsg(packet);
    }

    bool isAllUnlock(Robot entity)
    {
        for (int i = 0; i < entity.m_statcard_fileunlock_finish.Count; ++i)
        {
            if (!entity.m_statcard_fileunlock_finish[i])
            {
                return false;
            }
        }
        return true;
    }

    /// <summary>
    /// 向服务器发送 解锁档案 包
    /// </summary>
    /// <param name="entity"></param>
    void FileUnlock(Robot entity)
    {
        for (int i = 0; i < entity.m_statcard_fileunlock_finish.Count; ++i)
        {
            if (!entity.m_statcard_fileunlock_finish[i])
            {
                CG_CARD_FILE_UNLOCK packet = new CG_CARD_FILE_UNLOCK();
                packet.CardId = 5;
                packet.FileLevel = i;
                //entity.NetManager.SendMsg(packet);
                entity.SendMsg(packet);
                return;
            }
        }
    }
    /// <summary>
    /// 向服务器发送 提升能力 包
    /// </summary>
    /// <param name="entity"></param>
    void AbilityUp(Robot entity)
    {
        CG_CARD_ABILITYUP packet = new CG_CARD_ABILITYUP();
        packet.CardId = 1;
        packet.abilityId = 41;
        //entity.NetManager.SendMsg(packet);
        entity.SendMsg(packet);
        return;
    }

    /// <summary>
    /// 向服务器发送 培训 包
    /// </summary>
    /// <param name="entity"></param>
    void Trainlevel(Robot entity)
    {
        CG_CARD_TRAINLEVEL packet = new CG_CARD_TRAINLEVEL();
        packet.CardId = 1;
        //entity.NetManager.SendMsg(packet);
        entity.SendMsg(packet);
        return;
    }

    bool isAllAward(Robot entity)
    {
        for (int i = 0; i < entity.m_statcard_fileaward_finish.Count; ++i)
        {
            if (!entity.m_statcard_fileaward_finish[i])
            {
                return false;
            }
        }
        return true;
    }
    /// <summary>
    /// 向服务器发送 分析档案  包 
    /// </summary>
    /// <param name="entity"></param>
    void FileAward(Robot entity)
    {
        for (int i = 0; i < entity.m_statcard_fileaward_finish.Count; ++i)
        {
            if (!entity.m_statcard_fileaward_finish[i])
            {
                CG_CARD_FILE_AWARD packet = new CG_CARD_FILE_AWARD();
                packet.CardId = 5;
                packet.FileLevel = i;
                //entity.NetManager.SendMsg(packet);
                entity.SendMsg(packet);
            }
        }
    }

    /// <summary>
    ///  向服务器发送 档案强化  包 
    /// </summary>
    /// <param name="entity"></param>
    void Enhance(Robot entity)
    {
        CG_CARD_ENHANCE packet = new CG_CARD_ENHANCE();
        packet.CardId = 5;
        //entity.NetManager.SendMsg(packet);
        entity.SendMsg(packet);
    }

    /// <summary>
    /// 向服务器发送 切换卡面  包 
    /// </summary>
    /// <param name="entity"></param>
    void Changeface(Robot entity)
    {
        CG_CARD_CHANGE_FACE packet = new CG_CARD_CHANGE_FACE();
        packet.CardId = 601;

        Random rd = new Random();
        if (rd.Next(0, 2) == 0)
        {
            packet.IsAdvanceFace = true;
        }
        else
        {
            packet.IsAdvanceFace = false;
        }
        // entity.NetManager.SendMsg(packet);
        entity.SendMsg(packet);
    }

    public override void onExecute(Robot entity)
    {
        //时间冷却
        if (!isRun())
        {
            return;
        }

        if (entity.m_statcard_lv < 80)
        {//进行升级、进化 (升星)
         //1   1星  1   20
         //2   2星  10  40
         //3   3星  30  50
         //4   4星  45  60
         //5   5星  55  70
         //6   6星  65  80
            Dictionary<int, List<Tab_CardStar>> tabCardStar = TableManager.GetCardStar();
            List<Tab_CardStar> TabList = new List<Tab_CardStar>();
            if (tabCardStar.TryGetValue(entity.m_statcard_star + 1, out TabList))
            {

                if (TabList.Count > 0)
                {
                    if (entity.m_statcard_lv >= TabList[0].LevelMin)
                    {
                        LevelUpStar(entity);
                        return;
                    }
                }
            }

            LevelUp(entity);
            return;
        }
        else if (entity.m_statcard_trainlevel_finish <= 5)
        {//----卡牌培训   培训一般只有6次
            Trainlevel(entity);
        }
        else if (entity.m_statcard_abilityup_finish <= 9)
        {//----卡牌能力 强化
            AbilityUp(entity);
        }
        else if (entity.m_statcard_make_finish <= 10)
        { //----测试卡牌合成 10次
            Make(entity);
        }
        else if (entity.m_statcard_resolve_finish <= 10)
        {//----测试卡牌转化 10次
            Resolve(entity);
        }
        else if (entity.m_statcard_visual_finish <= 10)
        { //----测试看板主题切换 10次
            Visual(entity);
        }
        else if (!isAllUnlock(entity))
        { //----测试解锁档案
            FileUnlock(entity);
        }
        else if (!isAllAward(entity))
        {//----分析档案
            FileAward(entity);
        }
        else if (entity.m_statcard_enhance_finish <= 9)
        {//----档案强化 
            Enhance(entity);
        }
        else if (entity.m_statcard_enhance_finish <= 9)
        {//----切换卡面
            Changeface(entity);
        }
        else
        {
            ////---重新开始
            entity.m_IsValid = true;
        }
        return;
    }
}