﻿using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SYNC_QUESTION_ANSWER)]
public class GC_SYNC_QUESTION_ANSWER_Handler : MessageHandler<GC_SYNC_QUESTION_ANSWER>
{
    protected override void Execute(Robot curRobot, GC_SYNC_QUESTION_ANSWER message)
    {
        
    }
}
