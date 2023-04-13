public class MtpPayload
{
    private MtpInitConnectionRequest mtpInitConnectionRequest;
    private byte[] request;

    public MtpSerializedPayload.Type PayloadType { get; set; }
    public byte[] Data { get; set; }

    public MtpPayload(MtpSerializedPayload.Type type, byte[] data)
    {
        PayloadType = type;
        Data = data;
    }

    public MtpPayload(MtpInitConnectionRequest mtpInitConnectionRequest, byte[] request)
    {
        this.mtpInitConnectionRequest = mtpInitConnectionRequest;
        this.request = request;
    }

    // Code for serializing the payload to a byte array
    public byte[] Serialize()
    {
      // Code for serializing the payload data
      throw new NotImplementedException();
    }
}