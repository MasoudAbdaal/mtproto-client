public class MtpSerializedPayload 
{
    public enum Type
    {
        Message,
        RpcRequest,
        RpcResponse,
        ErrorResponse,
        Acknowledge,
        Confirmed,
        InitConnection,
        MsgsAck,
        BadServerSalt,
        BadMessageNotify
    }

    public Type PayloadType { get; set; }
    public byte[] Data { get; set; }

    public MtpSerializedPayload(Type type, byte[] data)
    {
        PayloadType = type;
        Data = data;
    }

    // Code for serializing the serialized payload to a byte array
    public byte[] Serialize()
    {
      // Code for serializing the serialized payload data
      throw new NotImplementedException();
    }
}