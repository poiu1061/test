// TcpChatServer.cs
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace TcpChatServer
{
    internal class Program
    {
        static TcpListener listener;
        static List<TcpClient> clients = new List<TcpClient>();
        static object lockObj = new object();

        static void Main(string[] args)
        {
            listener = new TcpListener(IPAddress.Any, 9000);
            listener.Start();
            Console.WriteLine("서버 시작. 클라이언트 접속 대기 중...");

            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                lock (lockObj)
                {
                    clients.Add(client);
                }
                Console.WriteLine("클라이언트 접속됨.");
                Thread thread = new Thread(() => HandleClient(client));
                thread.Start();
            }
        }

        static void HandleClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];

            try
            {
                while (true)
                {
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0) break;

                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    Console.WriteLine($"수신: {message}");

                    Broadcast(message, client);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"오류: {ex.Message}");
            }
            finally
            {
                lock (lockObj)
                {
                    clients.Remove(client);
                }
                stream.Close();
                client.Close();
                Console.WriteLine("클라이언트 연결 종료됨.");
            }
        }

        static void Broadcast(string message, TcpClient sender)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);

            lock (lockObj)
            {
                foreach (TcpClient client in clients)
                {
                    if (client != sender)
                    {
                        try
                        {
                            NetworkStream stream = client.GetStream();
                            stream.Write(data, 0, data.Length);
                        }
                        catch
                        {
                            // 실패한 클라이언트는 무시
                        }
                    }
                }
            }
        }
    }
}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Sockets;
//using System.Text;
//using System.Threading.Tasks;

//namespace TcpPrac
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            TcpClient client = new TcpClient("127.0.0.1", 9000);
//            Console.WriteLine("접속완료");

//            NetworkStream stream = client.GetStream();
//            while (true)
//            {
//                byte[] recieveBuffer = new byte[1024];
//                int bytesRead = stream.Read(recieveBuffer, 0, recieveBuffer.Length);
//                if (bytesRead == 0) break;
//                String ClientMessage = Encoding.UTF8.GetString(recieveBuffer, 0, bytesRead);
//                Console.WriteLine($"서버: {ClientMessage}");

//                Console.Write("입력>");
//                String message = Console.ReadLine();
//                byte[] buffer = Encoding.UTF8.GetBytes(message);
//                stream.Write(buffer, 0, buffer.Length);


//            }

//            stream.Close();
//            client.Close();
//        }
//    }
//}