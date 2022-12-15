using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_MAIL_OPERATION)]
public class GC_MAIL_OPERATION_Handler : MessageHandler<GC_MAIL_OPERATION>
{
    protected override void Execute(Robot curRobot, GC_MAIL_OPERATION message)
    {
        //curRobot.LogFormat("{0}:Mail Operation type{1}", curRobot.Name, (int)message.OperationType);

        switch(message.OperationType)
        {
            case (int)GC_MAIL_OPERATION.OPTYPE.OP_GETITEM:
                curRobot.TransEnd(TransEvent.MailGetAllItem, RESULT.SUCCESS);
                break;
            case (int)GC_MAIL_OPERATION.OPTYPE.OP_SETREAD:
                curRobot.TransEnd(TransEvent.MailRead, RESULT.SUCCESS);
                break;
            case (int)GC_MAIL_OPERATION.OPTYPE.OP_DEL:
                curRobot.TransEnd(TransEvent.MailDel, RESULT.SUCCESS);
                foreach(var v in message.MailGuids)
                {
                    curRobot.m_mail.Remove(v);
                }
                break;
        }
    }
}
