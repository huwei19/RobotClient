using System.Collections;
using System.Collections.Generic;
using ProtobufPacket;
using System;
using Games.Table;
using LiteNet;
using System.IO;

public class StatisticsData
{
    //              protocolnum     rebotid    time         
    private static Dictionary<MessageID, Dictionary<int, List<float>>> m_data = new Dictionary<MessageID, Dictionary<int, List<float>>>();
    private static Dictionary<MessageID, Dictionary<int, float>> m_rundata = new Dictionary<MessageID, Dictionary<int, float>>();
    private static Dictionary<MessageID, List<MessageID>> m_matching = new Dictionary<MessageID, List<MessageID>>();
    private static List<MessageID> m_have = new List<MessageID>();//需要统计的

    private static bool m_isInit = false;


    public static void init()
    {
        //MessageID.CG_PERSONALITY_LEVELUP
        ////----
        m_matching.Add(MessageID.GC_PERSONALITY_LEVELUP,new List<MessageID>());
        m_matching[MessageID.GC_PERSONALITY_LEVELUP].Add(MessageID.GC_PERSONALITY_LEVELUP);
        m_have.Add(MessageID.GC_PERSONALITY_LEVELUP);
        ////-----
        m_matching.Add(MessageID.GC_CARD_MAKE, new List<MessageID>());
        m_matching[MessageID.GC_CARD_MAKE].Add(MessageID.CG_CARD_MAKE);
        m_have.Add(MessageID.CG_CARD_MAKE);
        ////-----
        m_matching.Add(MessageID.GC_CARD_STAR_LEVELUP, new List<MessageID>());
        m_matching[MessageID.GC_CARD_STAR_LEVELUP].Add(MessageID.CG_CARD_STAR_LEVELUP);
        m_have.Add(MessageID.CG_CARD_STAR_LEVELUP);

        /////CG_CARD_RESOLVE
        m_matching.Add(MessageID.GC_SYNC_CARD, new List<MessageID>());
        m_matching[MessageID.GC_SYNC_CARD].Add(MessageID.CG_CARD_RESOLVE);
        m_have.Add(MessageID.CG_CARD_RESOLVE);

        m_matching.Add(MessageID.GC_VISUAL_CARD, new List<MessageID>());
        m_matching[MessageID.GC_VISUAL_CARD].Add(MessageID.CG_VISUAL_CARD);
        m_have.Add(MessageID.CG_VISUAL_CARD);

        //
        m_matching[MessageID.GC_SYNC_CARD].Add(MessageID.CG_CARD_FILE_UNLOCK);
        m_have.Add(MessageID.CG_CARD_FILE_UNLOCK);

        m_matching[MessageID.GC_SYNC_CARD].Add(MessageID.CG_CARD_FILE_AWARD);
        m_have.Add(MessageID.CG_CARD_FILE_AWARD);

        m_matching[MessageID.GC_SYNC_CARD].Add(MessageID.CG_CARD_ENHANCE);
        m_have.Add(MessageID.CG_CARD_ENHANCE);
        //CG_CARD_CHANGE_FACE

        m_matching.Add(MessageID.GC_CARD_CHANGE_FACE, new List<MessageID>());
        m_matching[MessageID.GC_CARD_CHANGE_FACE].Add(MessageID.CG_CARD_CHANGE_FACE);
        m_have.Add(MessageID.CG_CARD_CHANGE_FACE);


        m_matching.Add(MessageID.GC_STORY_LEVEL_START, new List<MessageID>());
        m_matching[MessageID.GC_STORY_LEVEL_START].Add(MessageID.CG_STORY_LEVEL_START);
        m_have.Add(MessageID.CG_STORY_LEVEL_START);

        m_matching.Add(MessageID.GC_STORY_LEVEL_FINISH, new List<MessageID>());
        m_matching[MessageID.GC_STORY_LEVEL_FINISH].Add(MessageID.CG_STORY_LEVEL_FINISH);
        m_have.Add(MessageID.CG_STORY_LEVEL_FINISH);

        //CG_CITYWORK_RECEIVE_TASK
        m_matching.Add(MessageID.GC_CITYWORK_RECEIVE_TASK, new List<MessageID>());
        m_matching[MessageID.GC_CITYWORK_RECEIVE_TASK].Add(MessageID.CG_CITYWORK_RECEIVE_TASK);
        m_have.Add(MessageID.CG_CITYWORK_RECEIVE_TASK);

        //CG_CITYWORK_GET_TASK
        m_matching.Add(MessageID.GC_CITYWORK_GET_TASK, new List<MessageID>());
        m_matching[MessageID.GC_CITYWORK_GET_TASK].Add(MessageID.CG_CITYWORK_GET_TASK);
        m_have.Add(MessageID.CG_CITYWORK_GET_TASK);

        //CG_DRAW_CARD
        m_matching.Add(MessageID.GC_DRAW_CARD, new List<MessageID>());
        m_matching[MessageID.GC_DRAW_CARD].Add(MessageID.CG_DRAW_CARD);
        m_have.Add(MessageID.CG_DRAW_CARD);

        //CG_DRAW_CARD_AWARD
        m_matching.Add(MessageID.GC_SYNC_DRAW_CARD, new List<MessageID>());
        m_matching[MessageID.GC_SYNC_DRAW_CARD].Add(MessageID.CG_DRAW_CARD_AWARD);
        m_have.Add(MessageID.CG_DRAW_CARD_AWARD);

        //CG_DRAW_CARD_SWITCH
        m_matching.Add(MessageID.GC_DRAW_CARD_SWITCH, new List<MessageID>());
        m_matching[MessageID.GC_DRAW_CARD_SWITCH].Add(MessageID.CG_DRAW_CARD_SWITCH);
        m_have.Add(MessageID.CG_DRAW_CARD_SWITCH);

        //CG_SKIN_UNLOCK
        m_matching.Add(MessageID.GC_SYNC_FATELINE, new List<MessageID>());
        m_matching[MessageID.GC_SYNC_FATELINE].Add(MessageID.CG_SKIN_UNLOCK);
        m_have.Add(MessageID.CG_SKIN_UNLOCK);

        //CG_DRESS_UNLOCK
       // m_matching.Add(MessageID.GC_SYNC_FATELINE, new List<MessageID>());
        m_matching[MessageID.GC_SYNC_FATELINE].Add(MessageID.CG_DRESS_UNLOCK);
        m_have.Add(MessageID.CG_DRESS_UNLOCK);

        //CG_DRESSUP
        //m_matching.Add(MessageID.GC_SYNC_FATELINE, new List<MessageID>());
        m_matching[MessageID.GC_SYNC_FATELINE].Add(MessageID.CG_DRESSUP);
        m_have.Add(MessageID.CG_DRESSUP);

        //CG_ACCEPT_FRIEND
        m_matching.Add(MessageID.GC_SYNC_FRIEND, new List<MessageID>());
        m_matching[MessageID.GC_SYNC_FRIEND].Add(MessageID.CG_ACCEPT_FRIEND);
        m_have.Add(MessageID.CG_ACCEPT_FRIEND);

        //CG_REFUSE_FRIEND 没有返回

        //CG_DEL_FRIEND
        m_matching.Add(MessageID.GC_DEL_FRIEND, new List<MessageID>());
        m_matching[MessageID.GC_DEL_FRIEND].Add(MessageID.CG_DEL_FRIEND);
        m_have.Add(MessageID.CG_DEL_FRIEND);

        //CG_SEARCH_FRIEND
        m_matching.Add(MessageID.GC_SEARCH_FRIEND, new List<MessageID>());
        m_matching[MessageID.GC_SEARCH_FRIEND].Add(MessageID.CG_SEARCH_FRIEND);
        m_have.Add(MessageID.CG_SEARCH_FRIEND);

        //CG_STORY_CHAPTER_REWIND
        m_matching.Add(MessageID.GC_STORY_CHAPTER_REWIND, new List<MessageID>());
        m_matching[MessageID.GC_STORY_CHAPTER_REWIND].Add(MessageID.CG_STORY_CHAPTER_REWIND);
        m_have.Add(MessageID.CG_STORY_CHAPTER_REWIND);

        //CG_SHOP_BUY
        m_matching.Add(MessageID.GC_SHOP_BUY, new List<MessageID>());
        m_matching[MessageID.GC_SHOP_BUY].Add(MessageID.CG_SHOP_BUY);
        m_have.Add(MessageID.CG_SHOP_BUY);
    }

    public static void Push(int arebotid, MessageID amsgid, float ats)
    {
        if (!m_data.ContainsKey(amsgid))
        {
            m_data.Add(amsgid, new Dictionary<int, List<float>>());
        }
        Dictionary<int, List<float>> ltemp = m_data[amsgid];
        if (!ltemp.ContainsKey(arebotid))
        {
            ltemp.Add(arebotid, new List<float>());
        }
        List<float> ls = ltemp[arebotid];
        ls.Add(ats);
    }

    public static void StatisticsSend(int arebotid, MessageID amsgid)
    {
        if (!m_isInit)
        {
            m_isInit = true;
            init();
        }
        if (!m_have.Contains(amsgid))
        {
            return;
        }
        float curTime = (float)Utils.GetTimeStamp();
        if (!m_rundata.ContainsKey(amsgid))
        {
            m_rundata.Add(amsgid,new Dictionary<int, float>());
        }
        Dictionary<int, float> ltemp = m_rundata[amsgid];
        if (ltemp.ContainsKey(arebotid))
        {///----超时 
            Push(arebotid, amsgid, curTime - ltemp[arebotid]);
            ltemp.Remove(arebotid);
        }
        ltemp.Add(arebotid,curTime);
        //MessageID.CG_PERSONALITY_LEVELUP
        //CG_PERSONALITY_LEVELUP
    }

    
    public static void StatisticsRecv(int arebotid, MessageID amsgid)
    {
        if (!m_matching.ContainsKey(amsgid))
        {
            return;
        }
        if (m_matching.ContainsKey(amsgid))
        {
            float curTime = (float)Utils.GetTimeStamp();
            foreach (var item in m_matching[amsgid])
            {
                if (m_rundata.ContainsKey(item))
                {
                    Dictionary<int, float> ltemp = m_rundata[item];
                    if (ltemp.ContainsKey(arebotid))
                    {
                        Push(arebotid, amsgid, curTime-ltemp[arebotid]);
                        ltemp.Remove(arebotid);
                    }
                }
            }
        }
    }


    static float m_LastCheckValidTime = 0;
    static float m_CheckValidInterval = 60;

    public static void log()
    {
        //---
        float curTime = (float)Utils.GetTimeStamp();
        if (m_LastCheckValidTime == 0)
        {
            m_LastCheckValidTime = curTime;
            return;
        }

        if (curTime - m_LastCheckValidTime < m_CheckValidInterval)
        {
            return;
        }

        m_LastCheckValidTime = curTime;

        System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(@"log");
        di.Create();

        string tempTimeStr = DateTime.Now.Year.ToString() +DateTime.Now.Month.ToString().PadLeft(2, '0')
             + DateTime.Now.Day.ToString().PadLeft(2, '0') + DateTime.Now.Hour.ToString().PadLeft(2, '0')
             + DateTime.Now.Minute.ToString().PadLeft(2, '0') + DateTime.Now.Second.ToString().PadLeft(2, '0');


        FileStream fsw = new FileStream("./log/" + tempTimeStr + ".txt", FileMode.OpenOrCreate);

        fsw.Seek(0, SeekOrigin.Begin);

        //Dictionary<MessageID, Dictionary<int, List<float>>> m_data;
        string logtemp = "";
        foreach (var item1 in m_data)
        {
            foreach (var item2 in item1.Value)
            {
                float lsum = 0;
                foreach (var item3 in item2.Value)
                {
                    lsum += item3;
                }
                logtemp += string.Format("MsgId:{0} RebotId:{1} avetime:{2}\n", item1.Key, item2.Key, lsum / item2.Value.Count);
            }
        }
        m_data.Clear();
        byte[] byteArray = System.Text.Encoding.Default.GetBytes(logtemp);
        int byteLen = System.Text.Encoding.Default.GetByteCount(logtemp);
        fsw.Write(byteArray, 0, byteLen);

        fsw.Close();
    }
}