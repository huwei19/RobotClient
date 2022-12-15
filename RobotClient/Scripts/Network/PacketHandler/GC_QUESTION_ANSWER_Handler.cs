using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_QUESTION_ANSWER)]
public class GC_QUESTION_ANSWER_Handler : MessageHandler<GC_QUESTION_ANSWER>
{
    protected override void Execute(Robot curRobot, GC_QUESTION_ANSWER message)
    {
        
    }
}
