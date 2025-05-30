using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace OmokClient
{
    internal class program
    {
        static void Main()
        {
            TcpClient client = new TcpClient("127.0.0.1", 9000);
            Console.WriteLine("서버에 접속했습니다.");

            NetworkStream stream = client.GetStream();

            // 서버 메시지 수신용 스레드
            Thread receiveThread = new Thread(() => ReceiveThread(stream));
            receiveThread.Start();

            // 좌표 입력 루프 
            while (true)
            {
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input)) continue;

                byte[] buffer = Encoding.UTF8.GetBytes(input);
                stream.Write(buffer, 0, buffer.Length);
            }
        }

        static void ReceiveThread(NetworkStream stream)
        {
            byte[] receiveBuffer = new byte[2048];
            while (true)
            {
                try
                {
                    int bytesRead = stream.Read(receiveBuffer, 0, receiveBuffer.Length);
                    if (bytesRead == 0) break;

                    string message = Encoding.UTF8.GetString(receiveBuffer, 0, bytesRead);
                    Console.Clear();
                    //Console.WriteLine("[서버 메시지]");
                    Console.WriteLine(message);
                    Console.Write("좌표 입력 (예: x y)> ");
                }
                catch
                {
                    Console.WriteLine("서버 연결이 종료되었습니다.");
                    break;
                }
            }
        }
    }
}
