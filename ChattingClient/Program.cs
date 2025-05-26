using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;

class ChatClient
{
    static TcpClient client;
    static NetworkStream stream;
    static string nickname;

    static void Main(string[] args)
    {
        Console.Write("서버 IP를 입력하세요 (예: 127.0.0.1): ");
        string serverIp = Console.ReadLine();

        Console.Write("닉네임을 입력하세요: ");
        nickname = Console.ReadLine();

        client = new TcpClient();
        client.Connect(serverIp, 8080); // 서버에 연결

        stream = client.GetStream();

        // 닉네임 전송
        byte[] nameData = Encoding.UTF8.GetBytes(nickname);
        stream.Write(nameData, 0, nameData.Length);

        // 메시지 수신 스레드 시작
        Thread receiveThread = new Thread(ReceiveMessages);
        receiveThread.Start();

        // 메시지 전송 루프
        while (true)
        {
            Console.Write("> ");
            string message = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(message))
            {
                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);

                // 내 메시지를 로컬에도 표시
                Console.WriteLine($"[나] {message}");
            }
        }
    }

    static void ReceiveMessages()
    {
        byte[] buffer = new byte[1024];
        int byteCount;

        while ((byteCount = stream.Read(buffer, 0, buffer.Length)) > 0)
        {
            string message = Encoding.UTF8.GetString(buffer, 0, byteCount);

            // 입력 커서 위치 초기화 후 출력
            Console.WriteLine("\n" + message);
        }
    }
}
