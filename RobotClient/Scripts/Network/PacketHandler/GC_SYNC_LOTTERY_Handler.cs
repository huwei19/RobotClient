﻿using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SYNC_LOTTERY)]
public class GC_SYNC_LOTTERY_Handler : MessageHandler<GC_SYNC_LOTTERY>
{
    protected override void Execute(Robot curRobot, GC_SYNC_LOTTERY message)
    {
        
    }
}
