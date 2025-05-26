// Client.cs
using System;
using System.Net.Sockets;
using System.Text;

class Client
{
    static void Main()
    {
        Console.Write("서버 IP 입력 (예: 127.0.0.1): ");
        string serverIP = Console.ReadLine();

        TcpClient client = new TcpClient(serverIP, 8080);
        NetworkStream stream = client.GetStream();

        while (true)
        {
            Console.Write("보낼 메시지: ");
            string message = Console.ReadLine();

            byte[] data = Encoding.UTF8.GetBytes(message); //메세지를 utf-8로 저장하려면 바이트로 변환해야함
            stream.Write(data, 0, data.Length); 

            // 서버로부터 응답 받기
            byte[] responseBuffer = new byte[1024];
            int responseBytes = stream.Read(responseBuffer, 0, responseBuffer.Length);
            string response = Encoding.UTF8.GetString(responseBuffer, 0, responseBytes);
            Console.WriteLine("서버 응답: " + response);
        }
    }
}
