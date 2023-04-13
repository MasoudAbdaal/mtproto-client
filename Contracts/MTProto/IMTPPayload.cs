public class MtpPayload
{
    public MtpPayload(object initConnection, byte[] request)
    {
        InitConnection = initConnection;
        Request = request;
    }

    public Type PayloadType { get; set; }
    public byte[] Data { get; set; }
    public object InitConnection { get; }
    public byte[] Request { get; }

    internal byte[] Serialize()
    {
        throw new NotImplementedException();
    }
}