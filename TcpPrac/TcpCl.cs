//// TcpChatClient.cs
//using System;
//using System.Net.Sockets;
//using System.Text;
//using System.Threading;

//namespace TcpClPrac
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            TcpClient client = new TcpClient("127.0.0.1", 9000);
//            Console.WriteLine("서버에 접속됨.");

//            NetworkStream stream = client.GetStream();

//            // 수신 스레드
//            Thread receiveThread = new Thread(() =>
//            {
//                byte[] buffer = new byte[1024];
//                while (true)
//                {
//                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
//                    if (bytesRead == 0) break;

//                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
//                    Console.WriteLine($"\n[수신] {message}\n입력> ");
//                }
//            });
//            receiveThread.Start();

//            // 송신 루프
//            while (true)
//            {
//                Console.Write("입력> ");
//                string message = Console.ReadLine();
//                if (string.IsNullOrWhiteSpace(message)) continue;

//                byte[] data = Encoding.UTF8.GetBytes(message);
//                stream.Write(data, 0, data.Length);
//            }

//            // 종료 시 처리 (사실상 여긴 도달 못함)
//            stream.Close();
//            client.Close();
//        }
//    }
//}
