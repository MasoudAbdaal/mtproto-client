public class MtpPacket
{
    // Packet header fields
    public long AuthKeyId { get; set; }
    public long MessageId { get; set; }
    public int MessageSequence { get; set; }
    public byte Flags { get; set; }

    // Packet body
    public MtpPayload Payload { get; set; }

    // Deserialization constructor
    public MtpPacket(byte[] data)
    {
        // TODO: Parse packet data into fields
    }

    // Serialization method
    public byte[] Serialize()
    {
        // TODO: Generate byte array representation of packet data
        return new byte[0];
    }

    internal class Builder
    {
        public Builder()
        {
        }

        internal MtpPayload Build()
        {
            throw new NotImplementedException();
        }

        internal void SetAuthKeyId(long v)
        {
            throw new NotImplementedException();
        }

        internal void SetMessageId(long ticks)
        {
            throw new NotImplementedException();
        }
        internal byte[] Serialize()
        {
            throw new NotImplementedException();
        }

        internal void SetMessageSequence(int v)
        {
            throw new NotImplementedException();
        }

        internal void SetPayload(MtpSerializedPayload mtpSerializedPayload)
        {
            throw new NotImplementedException();
        }

        internal void SetFlags(byte message)
        {
            throw new NotImplementedException();
        }
    }
    public static byte[] BuildPacket(long authKeyId, long messageId, int messageSequence, byte flags, MtpPayload payload)
    {
        using (MemoryStream ms = new MemoryStream())
        {
            BinaryWriter writer = new BinaryWriter(ms);

            byte[] serializedPayload = payload.Serialize();

            writer.Write(authKeyId);
            writer.Write(messageId);
            writer.Write(messageSequence);
            writer.Write((byte)serializedPayload.Length);
            writer.Write(flags);
            writer.Write(serializedPayload);

            return ms.ToArray();
        }
    }

    public static byte[] BuildInitAuthKeyPacket()
    {
        byte[] gBSerialized = new byte[]{
        0x95, 0x2d, 0x06, 0x18, 0x9e, 0x49, 0xe2, 0x26,
        0xe4, 0x5d, 0x2f, 0x4a, 0x6f, 0x8a, 0xd3, 0x3c,
        0xb8, 0x7d, 0x33, 0x1d, 0x3f, 0x7b, 0x99, 0xdb,
        0xcd, 0x90, 0x5a, 0x9b, 0x41, 0xa4, 0xe2, 0x32,
        0x60, 0x83, 0x79, 0xce, 0x27, 0x54, 0x1e, 0x0b,
        0x1b, 0xf3, 0x12, 0x7f, 0x2a, 0x36, 0xce, 0x65,
        0x8d, 0x6f, 0x5c, 0x6c, 0x47, 0xc4, 0x00, 0x59,
        0x23, 0xe8, 0xc9, 0xab, 0x8c, 0x50, 0xd1, 0x1f,
        0xdf, 0xde, 0xcf, 0x02, 0xb0, 0x6f, 0x53, 0xae,
        0xb2, 0x66, 0x41, 0x0e, 0xe9, 0x80, 0xca, 0x86,
        0x7a, 0x39, 0x62, 0xb7, 0x4b, 0x6c, 0x3f, 0x2f,
        0x9f, 0xee, 0xfb, 0xbf, 0xa1, 0xe5, 0xcf, 0xe2,
        0xff, 0xa4, 0x67, 0x3d, 0xcd, 0xa8, 0x6d, 0xd1,
        0x36, 0x80, 0x1d, 0xdf, 0x88, 0x2b, 0x8a, 0x23,
        0x22, 0xd9, 0x28, 0xed, 0x52, 0x2b, 0xc7, 0xbe,
        0x70, 0x7c, 0x8a, 0x21, 0x22, 0xac, 0xdf, 0xc3
    };
        var request = new MtpInitConnectionRequest(gBSerialized).Serialize();
        return BuildPacket(0L, DateTime.UtcNow.Ticks, 0, 1, new MtpPayload(new MtpInitConnectionRequest(), request));
    }
}