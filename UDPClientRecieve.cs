using System.Text;

namespace UDPTest;
public static class UDPClientReceive
{

   
    public static void ReceiveMessage()
    {
        try
        {
            byte[] byteRecieved = UDPClientSend.Client.Receive(ref UDPClientSend._endPoint);
            string messageRecieved = Encoding.ASCII.GetString(byteRecieved);
            Console.WriteLine(messageRecieved);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

}
