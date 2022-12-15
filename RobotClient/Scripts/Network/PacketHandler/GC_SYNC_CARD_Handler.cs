using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SYNC_CARD)]
public class GC_SYNC_CARD_Handler : MessageHandler<GC_SYNC_CARD>
{
    protected override void Execute(Robot curRobot, GC_SYNC_CARD message)
    {
        if (curRobot.BehaviorType == Robot.RobotType.TYPE_CARD)
        {
            if (message.CardBag.Cards.Count > 0)
            {
                curRobot.mainPlayer.CardBag.Cards = message.CardBag.Cards;
            }
            if (message.CardBag.CardPieces.Count > 0)
            {
                curRobot.mainPlayer.CardBag.CardPieces = message.CardBag.CardPieces;
            }
            if (message.CardBag.Cards.Count > 0 || message.CardBag.CardPieces.Count > 0 || message.CardBag.CardTickets.Count > 0)
            {
                for (int i = 0; i< message.CardBag.Cards.Count; ++i)
                {
                    ////----档案解锁成功后没有对应返回消息  只会返回卡牌同步
                    ///-----所以需要分析卡牌
                    if (message.CardBag.Cards[i].CardId == curRobot.m_statcard_fileunlock_id)
                    {
                        for (int ilevel = 9; ilevel >= 0; --ilevel)
                        {
                            int ltemp = (message.CardBag.Cards[i].FileUnlockFlag & (1 << ilevel));
                            if (ltemp != 0 && !curRobot.m_statcard_fileunlock_finish[ilevel])
                            {
                                curRobot.m_statcard_fileunlock_finish[ilevel] = true;
                                //curRobot.LogFormat("Card:{0} Fileunlock Count:{1}", curRobot.m_statcard_fileunlock_id, ilevel);
                            }
                           
                        }
                    }
                    ////----档案强化成功后没有对应返回消息  只会返回卡牌同步
                    ///-----所以需要分析卡牌
                    if (message.CardBag.Cards[i].CardId == curRobot.m_statcard_enhance_id)
                    {
                        if (message.CardBag.Cards[i].EnhanceLevel > curRobot.m_statcard_enhance_finish)
                        {
                            //curRobot.LogFormat("Card:{0} Enhance Count:{1}", curRobot.m_statcard_enhance_id, curRobot.m_statcard_enhance_finish++);
                        }
                    }
                    
                }
               
                for (int i = 0; i < message.CardBag.CardTickets.Count; ++i)
                {
                    ////----卡牌转化成功后没有对应返回消息  只会返回卡牌同步
                    ///-----所以需要分析卡牌
                    ///entity.SendCMD("card,4,100,1,1");//陆林深-	陆林深-比海更深
                    if (message.CardBag.CardTickets[i].CardId == curRobot.m_statcard_resolve_id)
                    {
                        //curRobot.LogFormat("Card:{0} Resolve Count:{1}", curRobot.m_statcard_resolve_id, curRobot.m_statcard_resolve_finish++);
                    }
                }

            }
        }

    }
}
