using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_SEE_CHAPTER)]
public class GC_SEE_CHAPTER_Handler : MessageHandler<GC_SEE_CHAPTER>
{
    protected override void Execute(Robot curRobot, GC_SEE_CHAPTER message)
    {
        
    }
}
