using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UDPTest;
public static class UDPClientSend
{

    private static string _ipAddress = "127.0.0.1"; //IP Address to connect to
    private static IPAddress _ip = IPAddress.Parse(_ipAddress); //Parses the IP address and converts it to Big Endian format
    public static IPEndPoint _endPoint = new IPEndPoint(_ip, 1976);//End point specifies the IP address and port
    private static UdpClient _client = new UdpClient(_endPoint);
    private static string _stringToSend = "This message was sent over UDP";
    private static byte[] _dataBuffer = ASCIIEncoding.ASCII.GetBytes(_stringToSend);
    public static UdpClient Client => _client;
   
    
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
