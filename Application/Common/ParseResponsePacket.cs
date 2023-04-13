public class ParseResponsePacket
{
    private byte[] responseBytes;

    public ParseResponsePacket(byte[] responseBytes)
    {
        this.responseBytes = responseBytes;
    }

    public MtpPayload Payload { get; internal set; }
}