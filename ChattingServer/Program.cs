using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ChatServer
{
    class Program
    {
        static Dictionary<TcpClient, string> clients = new Dictionary<TcpClient, string>();
        static object lockObj = new object();
        static void Main(string[] args)

        {
            TcpListener server = new TcpListener(IPAddress.Any, 8080);
            server.Start();
            Console.WriteLine("서버 시작됨. 클라이언트 접속 대기 중...");

            while (true)
            {
                TcpClient client = server.AcceptTcpClient();
                Console.WriteLine("클라이언트 접속: " + client.Client.RemoteEndPoint);

                Thread t = new Thread(() => HandleClient(client));
                t.Start();
            }
        }

        static void HandleClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            int byteCount;

            try
            {
                // 1. 첫 메시지는 닉네임
                byteCount = stream.Read(buffer, 0, buffer.Length);
                string nickname = Encoding.UTF8.GetString(buffer, 0, byteCount).Trim();

                lock (lockObj)
                {
                    clients[client] = nickname;
                }

                Console.WriteLine($"[{nickname}] 님이 입장했습니다.");
                Broadcast($"💬 [{nickname}] 님이 입장했습니다.", client);

                // 2. 이후 메시지 처리
                while ((byteCount = stream.Read(buffer, 0, buffer.Length)) != 0)
                {
                    string message = Encoding.UTF8.GetString(buffer, 0, byteCount).Trim();
                    Console.WriteLine($"[{nickname}] {message}");
                    Broadcast($"[{nickname}] {message}", client);
                }
            }
            catch
            {
                // 연결 끊김
            }
            finally
            {
                lock (lockObj)
                {
                    if (clients.ContainsKey(client))
                    {
                        Console.WriteLine($"[{clients[client]}] 님이 퇴장했습니다.");
                        Broadcast($"❌ [{clients[client]}] 님이 퇴장했습니다.", client);
                        clients.Remove(client);
                    }
                }
                client.Close();
            }
        }

        static void Broadcast(string message, TcpClient sender)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            lock (lockObj)
            {
                foreach (var kvp in clients)
                {
                    TcpClient client = kvp.Key;
                    if (client != sender)
                    {
                        try
                        {
                            client.GetStream().Write(data, 0, data.Length);
                        }
                        catch { }
                    }
                }
            }
        }
    }
}
