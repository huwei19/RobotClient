using System.Collections;
using System.Collections.Generic;
using ProtobufPacket;
using System;
using Games.Table;

public class StateItem : FSMState<Robot>
{
    private int m_Interval = 5000;     //���ʱ�䣬��λ����

    private int m_ItemId = 0;       //��ǰ��ƷID
    private int m_ItemIdMax = 9999; //�����Ʒid

    private int m_AddCnt = 0;       //���������ۼ�
    private int m_AddCntMax = 500;  //�����������ޣ���Ҫ��ձ�����

    public override string getName()
    {
        return "Item";
    }

    public override void onEnter(Robot entity)
    {
        m_AddCnt = 0;
        ClearItems(entity);
    }

    public override void onExecute(Robot entity)
    {
        //时间冷却
        if (!isRun())
        {
            return;
        }
       
        //�������޺����
        if (m_AddCnt > m_AddCntMax) {
            m_AddCnt = 0;
            ClearItems(entity);
            return;
        }

        //ÿ֡����һ����Ʒ
        while (m_ItemId < m_ItemIdMax) {
            Tab_Item tabItem = TableManager.GetItemByID(m_ItemId);
            if (tabItem != null) {
                AddItem(entity, m_ItemId, 1);
                m_AddCnt++;
                m_ItemId = (++m_ItemId) % m_ItemIdMax;
                break;
            } else {
                m_ItemId = (++m_ItemId) % m_ItemIdMax;
            }
        }
        return;
    }

    private void ClearItems(Robot entity)
    {
        entity.SendCMD("cb");
        //entity.Log("clear items");
    }

    private void AddItem(Robot entity, int itemId, int count)
    {
        entity.SendCMD("item," + itemId + "," + count);
        //entity.LogFormat("add item {0} count {1}", itemId, count);
        entity.TransStart(TransEvent.AddItem);
    }
}