using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SHOP_BUY)]
public class GC_SHOP_BUY_Handler : MessageHandler<GC_SHOP_BUY>
{
    protected override void Execute(Robot curRobot, GC_SHOP_BUY message)
    {
        curRobot.TransEnd(TransEvent.ShopBuy, RESULT.SUCCESS);
    }
}
