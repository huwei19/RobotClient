using System.Collections;
using System.Collections.Generic;
using ProtobufPacket;
using System;
using Games.Table;
using System.Linq;

public class StateShop : FSMState<Robot>
{
    Random rd = new Random();
    int num = 1;
    public override string getName()
    {
        return "shop";
    }

    public override void onEnter(Robot entity)
    {
        entity.SendCMD("item,1,10000000");
        entity.SendCMD("item,2,10000000");
    }

    void buy(Robot entity)
    {
        CG_SHOP_BUY packet = new CG_SHOP_BUY();
        Dictionary<int, List<Tab_ShopCommon>> tabShopCommon = TableManager.GetShopCommon();
        int val = rd.Next(0, tabShopCommon.Count);
        packet.GoodsId = tabShopCommon.ElementAt(val).Value[0].Id;
        packet.BuyNum = 1;
        //entity.NetManager.SendMsg(packet);
        entity.SendMsg(packet);
        ++num;
        entity.TransStart(TransEvent.ShopBuy);
    }

    public override void onExecute(Robot entity)
    {
        //时间冷却
        if (!isRun())
        {
            return;
        }
       
        if (num % 1000 == 0)
        {
            entity.SendCMD("item,1,10000000");
            entity.SendCMD("item,2,10000000");
        }

        buy(entity);
        return;

    }
}