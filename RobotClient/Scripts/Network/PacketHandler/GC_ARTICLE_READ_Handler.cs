using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_ARTICLE_READ)]
public class GC_ARTICLE_READ_Handler : MessageHandler<GC_ARTICLE_READ>
{
    protected override void Execute(Robot curRobot, GC_ARTICLE_READ message)
    {
        
    }
}
