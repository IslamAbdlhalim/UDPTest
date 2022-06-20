using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UDPTest;

public static class UDPClientSend
{

    public static string _ipAddress = "127.0.0.1";
    public static IPAddress _ip = IPAddress.Parse(_ipAddress); // I'll be connecting to localhost so I'll be using an IPv4 length address
    public static IPEndPoint _endPoint = new IPEndPoint(_ip, 1976);
    public static UdpClient _client = new UdpClient(_endPoint);
    public static string _stringToSend = "This message was sent over UDP";
    public static byte[] _dataBuffer = ASCIIEncoding.ASCII.GetBytes(_stringToSend);

    public static void ConnectClient()
    {
        try
        {
            _client.Connect(_endPoint);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    public static void SendMessage()
    {
        try
        {
            int bytesSent = _client.Send(_dataBuffer, _dataBuffer.Length);
            Console.WriteLine($"Bytes sent: {bytesSent}");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

}
