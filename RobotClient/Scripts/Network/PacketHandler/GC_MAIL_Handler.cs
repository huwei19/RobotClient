using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_MAIL)]
public class GC_MAIL_Handler : MessageHandler<GC_MAIL>
{
    protected override void Execute(Robot curRobot, GC_MAIL message)
    {
        curRobot.TransEnd(TransEvent.MailSend2Self, RESULT.SUCCESS);
        //curRobot.m_mail.Clear();
        foreach (var item in message.mails)
        {
            if (curRobot.m_mail.Contains(item.guid))
                continue;
            curRobot.m_mail.Add(item.guid);
        }
    }
}
