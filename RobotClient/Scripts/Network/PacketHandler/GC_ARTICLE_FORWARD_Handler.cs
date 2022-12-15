using LiteNet;
using UnityEngine;
using ProtobufPacket;

[MessageHandler(MessageID.GC_ARTICLE_FORWARD)]
public class GC_ARTICLE_FORWARD_Handler : MessageHandler<GC_ARTICLE_FORWARD>
{
    protected override void Execute(Robot curRobot, GC_ARTICLE_FORWARD message)
    {
        
    }
}
