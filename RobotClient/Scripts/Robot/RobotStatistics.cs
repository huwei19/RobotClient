/***********************************
 * 事务统计（需要手动埋点，事务开始点和事务结束点）：
 * 用于统计：
 * 1 一段时间内的事务次数
 * 2 一段时间内的事务平均用时
 * 3 一段时间内的事务最小用时
 * 4 一段时间内的事务最大用时
 * *********************************************/

using System.Collections;
using System.Collections.Generic;
using LiteNet;
using ProtobufPacket;
using System.Text;
using System.IO;
using System;

///需要统计的事务类型 需要手动埋点（开始/结束）
public enum TransEvent
{
    Login,
    CreateRole,
    CardMake,
    CardDraw_Nomal,
    CardDraw_NomalMulti,
    CardDraw_Advance,
    CardDraw_AdvanceMulti,
    CardDraw_AdvanceUp,
    CardDraw_AdvanceUpMulti,
    CardDraw_Activity,
    CardDraw_ActivityMulti,
    StartLevel,
    FinishLevel,
    SavePoint,
    ShopBuy,
    FriendSearch, //好友搜索
    FriendDel,    //好友删除
    FriendGive,   //好友赠送
    FriendGiveOneKey, //好友赠送 一键赠送
    DressUnlock,
    DressUp,
    MailRead,
    MailGetAllItem,
    MailDel,
    MailSend2Self, //发邮件给自己 到收到邮件算一次事务
    AddItem,
    CityWorkGet,
    CityWorkReceiveTask,
}

public partial class Robot
{
    /// <summary>
    /// 一般调用SendMsg后，立即会调用这个函数 （也就是向服务器发送包后，立即调用这个接口）
    /// </summary>
    /// <param name="ID"></param>
    public void TransStart(TransEvent ID)
    {
        //entity.Log("--------- TransStart 一次：ID：" + ID);
        m_StartTimes[ID] = (float)Utils.GetTimeStamp();
        LogFormat("trans start: {0}", ID);
    }

    /// <summary>
    /// 这里会在 gcxxx_xxx_handle时调用，也就是 服务器返回消息时调用 
    /// </summary>
    /// <param name="ID"></param>
    /// <param name="ret"></param>
    public void TransEnd(TransEvent ID, ProtobufPacket.RESULT ret)
    {
        //entity.Log("---------TransEnd一次：ID：" + ID);
        if (!m_StartTimes.ContainsKey(ID))
            return;
        float fCostTime = (float)Utils.GetTimeStamp() - m_StartTimes[ID];
        StatisticLogic.TransEvent(ID, ret, fCostTime, Name);
        LogFormat("trans end: {0}, cost:{1:F4}", ID, fCostTime);
    }

    /// <summary>
    /// 获取抽卡 事件类型
    /// </summary>
    /// <param name="drawType"></param>
    /// <param name="isMulti"></param>
    /// <returns></returns>
    public TransEvent GetDrawEvent(int drawType, bool isMulti)
    {
        TransEvent temEvent;
        switch (drawType)
        {
            case (int)CG_DRAW_CARD.DRAWTYPE.ACTIVITY: //活动抽卡
                if (isMulti)
                {
                    temEvent = TransEvent.CardDraw_ActivityMulti;
                }
                else
                {
                    temEvent = TransEvent.CardDraw_Activity;
                }
                break;

            case (int)CG_DRAW_CARD.DRAWTYPE.ADVANCEUP: //概率up抽卡

                if (isMulti)
                {
                    temEvent = TransEvent.CardDraw_AdvanceUpMulti;
                }
                else
                {
                    temEvent = TransEvent.CardDraw_AdvanceUp;
                }
                break;

            case (int)CG_DRAW_CARD.DRAWTYPE.ADVANCE:    //高级抽卡
                if (isMulti)
                {
                    temEvent = TransEvent.CardDraw_AdvanceMulti;
                }
                else
                {
                    temEvent = TransEvent.CardDraw_Advance;
                }
                break;

            default:  //NOMAL 普通抽卡
                if (isMulti)
                {
                    temEvent = TransEvent.CardDraw_NomalMulti;
                }
                else
                {
                    temEvent = TransEvent.CardDraw_Nomal;
                }
                break;
        }
        return temEvent;
    }

    //发包开始时间 只记录最后一次发包时间（因此发包频率大于事务处理时间时，统计不再准确）
    private Dictionary<TransEvent, float> m_StartTimes = new Dictionary<TransEvent, float>();
}

//一次事务只一次发包匹配到一次收包所用时间 
public class TransStatistic
{
    public int Count { get; set; } //事务次数
    public int CountLimit { get; set; } //事务时长超过一定阈值的次数
    public float CostTimeAll { get; set; } // 事务总耗时
    public float CostTimeMin { get; set; } // 事务最小耗时
    public float CostTimeMax { get; set; } // 事务最大耗时
    public string CostTimeMaxAccount { get; set; } //最大耗时事务对应账号 方便查日志
    public long CostTimeMaxAns { get; set; } //最大耗时事务对应时间

    //事务平均耗时
    public float CostTimeAvg
    {
        get
        {
            if (Count <= 0)
                return 0;
            return CostTimeAll / Count;
        }
    }

    public void TransEvent(float fCostTime, string name)
    {
        if (CostTimeMin <= 0 || fCostTime < CostTimeMin)
            CostTimeMin = fCostTime;
        if (fCostTime > CostTimeMax)
        {
            CostTimeMax = fCostTime;
            CostTimeMaxAccount = name;
            CostTimeMaxAns = ServerTime.ServerAnsTime();
        }

        if (fCostTime > 0.5) //超过500ms 计数
            CountLimit++;
        CostTimeAll += fCostTime;
        Count++;
    }
    public void Clear()
    {
        Count = 0;
        CountLimit = 0;
        CostTimeAll = 0;
        CostTimeMin = 0;
        CostTimeMax = 0;
    }
}

/// <summary>
/// 事务统计信息
/// </summary>
public class TransactionInfo
{
    public TransactionInfo(TransEvent eID)
    {
        ID = eID;
    }
    public TransEvent ID { get; set; }
    public TransStatistic TransSucc = new TransStatistic(); //成功事务统计
    public TransStatistic TransFail = new TransStatistic(); //失败事务统计

    public void Log(StringBuilder logString)
    {
        //时间 t事务id   t成功or失败 最小时长    平均时长 最大时长    事务次数 慢事务次数   t成功or失败 最小时长    平均时长 最大时长    事务次数 慢事务次数
        // 时间\t事务id\t成功or失败\最小时长\平均时长\最大时长\事务次数\慢事务次数
        logString.AppendFormat("{0}\t{1}\t", DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss]"), ID);

        logString.Append("succ\t");
        logString.AppendFormat("{0:F4}\t", TransSucc.CostTimeMin);
        logString.AppendFormat("{0:F4}\t", TransSucc.CostTimeAvg);
        logString.AppendFormat("{0:F4}\t", TransSucc.CostTimeMax);
        logString.AppendFormat("{0}\t", TransSucc.Count);
        logString.AppendFormat("{0}\t", TransSucc.CountLimit);



        logString.Append("fail\t");
        logString.AppendFormat("{0:F4}\t", TransFail.CostTimeMin);
        logString.AppendFormat("{0:F4}\t", TransFail.CostTimeAvg);
        logString.AppendFormat("{0:F4}\t", TransFail.CostTimeMax);
        logString.AppendFormat("{0}\t", TransFail.Count);
        logString.AppendFormat("{0}\t", TransFail.CountLimit);


        logString.AppendFormat("{0}\t", TransSucc.CostTimeMaxAccount);
        logString.AppendFormat("{0}\t", ServerTime.GetServerAnsiDateTime(TransSucc.CostTimeMaxAns).ToString("[yyyy-MM-dd HH:mm:ss]"));

        logString.AppendFormat("{0}\t", TransFail.CostTimeMaxAccount);
        logString.AppendFormat("{0}", ServerTime.GetServerAnsiDateTime(TransFail.CostTimeMaxAns).ToString("[yyyy-MM-dd HH:mm:ss]"));

        logString.Append("\n");

    }

    public void Clear()
    {
        TransSucc.Clear();
        TransFail.Clear();
    }
}


public class StatisticLogic
{
    //收包次数统计
    private static Dictionary<MessageID, int> m_RecvCounts = new Dictionary<MessageID, int>();
    //发包次数统计
    private static Dictionary<MessageID, int> m_SendCounts = new Dictionary<MessageID, int>();

    //事务统计
    private static Dictionary<TransEvent, TransactionInfo> m_TransInfos = new Dictionary<TransEvent, TransactionInfo>();
    private const string m_LogPath = "./log";
    public static void TransEvent(TransEvent ID, RESULT ret, float fCostTime, string name)
    {
        if (!m_TransInfos.ContainsKey(ID))
            m_TransInfos[ID] = new TransactionInfo(ID);

        if (ret == RESULT.SUCCESS)
            m_TransInfos[ID].TransSucc.TransEvent(fCostTime, name);
        else
            m_TransInfos[ID].TransFail.TransEvent(fCostTime, name);

    }
    internal static void OnSendMessage(Robot robot, ref Package package)
    {
        MessageID messageId = (MessageID)package.header.msg;
        if (!m_SendCounts.ContainsKey(messageId))
            m_SendCounts[messageId] = 0;

        m_SendCounts[messageId]++;
    }
    internal static void OnReceiveMessage(Robot robot, ref Package package)
    {
        MessageID messageId = (MessageID)package.header.msg;
        if (!m_RecvCounts.ContainsKey(messageId))
            m_RecvCounts[messageId] = 0;

        m_RecvCounts[messageId]++;
    }
    internal static void CheckPath(string path)
    {
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
    }
}