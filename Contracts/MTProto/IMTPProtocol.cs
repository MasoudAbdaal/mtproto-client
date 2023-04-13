public interface IMTPROTOProtocol
{
    void Connect(string serverAddress, int serverPort);
    void Authenticate(string secretKey);
    byte[] SendMessage(byte[] messageData);
}
