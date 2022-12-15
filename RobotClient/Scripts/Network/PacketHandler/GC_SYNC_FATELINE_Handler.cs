using LiteNet;
using UnityEngine;
using ProtobufPacket;
using System.Collections.Generic;
using Games.Table;

[MessageHandler(MessageID.GC_SYNC_FATELINE)]
public class GC_SYNC_FATELINE_Handler : MessageHandler<GC_SYNC_FATELINE>
{
    protected override void Execute(Robot curRobot, GC_SYNC_FATELINE message)
    {
        if (curRobot.BehaviorType == Robot.RobotType.TYPE_DRESSUP)
        {
            ////已解锁
            ///
            for (int i = 0; i < message.FateLine.UnLockDressIds.Count; ++i)
            {
                Dictionary<int, List<Tab_Dressup>> tabDressup = TableManager.GetDressup();
                if (tabDressup.ContainsKey(message.FateLine.UnLockDressIds[i]))
                {
                    if (!curRobot.skindId.ContainsKey(message.FateLine.UnLockDressIds[i]))
                    {

                        Tab_Dressup tab = tabDressup[message.FateLine.UnLockDressIds[i]][0];
                        curRobot.dressId.Add(message.FateLine.UnLockDressIds[i], tab);
                        //curRobot.LogFormat("Dress Unlock Dress:{0}", message.FateLine.UnLockDressIds[i]);
                    }
                }
            }

            for (int i = 0; i < message.FateLine.UnLockSkinIds.Count; ++i)
            {
                Dictionary<int, List<Tab_SkinData>> tabSkinData = TableManager.GetSkinData();
                if (tabSkinData.ContainsKey(message.FateLine.UnLockSkinIds[i]))
                {
                    if (!curRobot.skindId.ContainsKey(message.FateLine.UnLockSkinIds[i]))
                    {
                        Tab_SkinData tab = tabSkinData[message.FateLine.UnLockSkinIds[i]][0];
                        curRobot.skindId.Add(message.FateLine.UnLockSkinIds[i], tab);
                        //curRobot.LogFormat("Skin Unlock SkinId:{0}", message.FateLine.UnLockSkinIds[i]);
                    }
                }
            }

            


            if (message.FateLine.DressInfo != null)
            {
                for (int i = 0; i < message.FateLine.DressInfo.HangingIds.Count; ++i)
                {
                    Dictionary<int, List<Tab_Dressup>> tabDressup = TableManager.GetDressup();
                    if (tabDressup.ContainsKey(message.FateLine.DressInfo.HangingIds[i]))
                    {
                        if (!curRobot.dressId.ContainsKey(message.FateLine.DressInfo.HangingIds[i]))
                        {
                            Tab_Dressup tab = tabDressup[message.FateLine.DressInfo.HangingIds[i]][0];
                            curRobot.dressId.Add(message.FateLine.DressInfo.HangingIds[i], tab);
                            //curRobot.LogFormat("Dress Unlock Dress:{0}", message.FateLine.DressInfo.HangingIds[i]);
                        }
                    }
                }

                Dictionary<int, List<Tab_SkinData>> tabSkinData = TableManager.GetSkinData();
                if (tabSkinData.ContainsKey(message.FateLine.DressInfo.SkinId))
                {
                    if (!curRobot.skindId.ContainsKey(message.FateLine.DressInfo.SkinId))
                    {
                        Tab_SkinData tab = tabSkinData[message.FateLine.DressInfo.SkinId][0];
                        curRobot.skindId.Add(message.FateLine.DressInfo.SkinId, tab);
                        //curRobot.LogFormat("Skin Unlock SkinId:{0}", message.FateLine.DressInfo.SkinId);
                    }
                }

                string HangingIds = "";
                for (int i = 0; i < message.FateLine.DressInfo.HangingIds.Count; ++i)
                {
                    HangingIds += message.FateLine.DressInfo.HangingIds[i];
                    HangingIds += ",";
                }
                //curRobot.LogFormat("Dress Up FateLineId:{0} SkinId:{1} HangingIds:{2}", message.FateLine.Guid, message.FateLine.DressInfo.SkinId, HangingIds);
            }

        }
    }
}
