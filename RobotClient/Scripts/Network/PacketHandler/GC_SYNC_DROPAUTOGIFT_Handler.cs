using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SYNC_DROPAUTOGIFT)]
public class GC_SYNC_DROPAUTOGIFT_Handler : MessageHandler<GC_SYNC_DROPAUTOGIFT>
{
    protected override void Execute(Robot curRobot, GC_SYNC_DROPAUTOGIFT message)
    {
        
    }
}
