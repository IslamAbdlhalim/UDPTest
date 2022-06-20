using UDPTest;

Thread _sendingThread = new Thread(UDPClientSend.SendMessage);
Thread _receivingThread = new Thread(UDPClientReceive.ReceiveMessage);

UDPClientSend.ConnectClient();
_receivingThread.Start();
_sendingThread.Start();








