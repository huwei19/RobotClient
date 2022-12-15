using System.Collections;
using System.Collections.Generic;
using ProtobufPacket;
using System;
using System.Net;

public class StateMail : FSMState<Robot>
{
    public override string getName()
    {
        return "Mail";
    }


    public override void onEnter(Robot entity)
    {
    }


    Random rd = new Random();

    void sendMail(Robot entity)
    {
        //300������ 5��һ��
        //12Сʱһ��
        //if (rd.Next(0, 2592000) == 0)
        //{
        //    //����ȫ���ʼ�
        //    string lcmd = "scm,1,1,1000,1";
        //    entity.SendCMD(lcmd);
        //}
        //else 
        {
            //�����ʼ�
            string lcmd = "mail," + rd.Next(0, 4)/*�ʼ�id*/ + "," + entity.mainPlayer.guideId;
            entity.SendCMD(lcmd);
            entity.TransStart(TransEvent.MailSend2Self);
        }

    }

    void readMail(Robot entity)
    {
        if (entity.m_mail.Count > 0)
        {
            CG_MAIL_OPERATION packet = new CG_MAIL_OPERATION();
            packet.OperationType = (int)CG_MAIL_OPERATION.OPTYPE.OP_SETREAD;
            packet.MailGuid = entity.m_mail[rd.Next(0, entity.m_mail.Count)];
            //entity.NetManager.SendMsg(packet);
            entity.SendMsg(packet);
            entity.TransStart(TransEvent.MailRead);
        }        
    }

    void getitemMail(Robot entity)
    {
        CG_MAIL_OPERATION packet = new CG_MAIL_OPERATION();
        packet.OperationType = (int)CG_MAIL_OPERATION.OPTYPE.OP_GETALLITEM;
        //entity.NetManager.SendMsg(packet);
        entity.SendMsg(packet);
        entity.TransStart(TransEvent.MailGetAllItem);
    }

    void delMail(Robot entity)
    {
        CG_MAIL_OPERATION packet = new CG_MAIL_OPERATION();
        packet.OperationType = (int)CG_MAIL_OPERATION.OPTYPE.OP_DELALL;
        //entity.NetManager.SendMsg(packet);
        entity.SendMsg(packet);

        entity.TransStart(TransEvent.MailDel);
    }
    int m_num = 0;
    public override void onExecute(Robot entity)
    {
        //时间冷却
        if (!isRun())
        {
            return;
        }
       
        int lnum = m_num % 4;
        if (lnum == 0)
        {
            sendMail(entity);
        }
        else if (lnum == 1)
        {
            getitemMail(entity);
        }
        else if (lnum == 2)
        {
            delMail(entity);
        }
        else 
        {
            readMail(entity);
        }
        ++m_num;
        return;
    }
}