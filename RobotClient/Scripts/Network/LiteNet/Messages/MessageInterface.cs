namespace LiteNet
{
    public interface IMessage
    {
    }

    public interface IRequest : IMessage
    {
        int rpcid { get; set; }
    }

    public interface IResponse : IMessage
    {
        int rpcid { get; }
    }

    public interface ISyncData
    {
    }
}
