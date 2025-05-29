using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ChattingServer
{
    class Program
    {
        static TcpListener server;
        static Dictionary<TcpClient, string> clients = new Dictionary<TcpClient, string>();
        static object lockObj = new object();

        static void Main()
        {
            server = new TcpListener(IPAddress.Any, 9000);  
            server.Start();
            Console.WriteLine("서버 시작됨. 클라이언트 기다리는 중...");

            Thread inputThread = new Thread(ServerInput);
            inputThread.Start();
            while (true)
            {
                TcpClient client = server.AcceptTcpClient();
                Console.WriteLine("클라이언트 연결됨");

                Thread clientThread = new Thread(() => HandleClient(client));
                clientThread.Start();
            }
        }

        static void HandleClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            string nickname = "알 수 없음";

            try
            {
                int nameBytes = stream.Read(buffer, 0, buffer.Length);
                nickname = Encoding.UTF8.GetString(buffer, 0, nameBytes).Trim();

                lock (lockObj)
                {
                    clients.Add(client, nickname);
                }

                Console.WriteLine($"{nickname} 님이 접속했습니다.");

                while (true)
                {
                    int bytes = stream.Read(buffer, 0, buffer.Length);
                    if (bytes == 0) break;

                    string message = Encoding.UTF8.GetString(buffer, 0, bytes);
                    Console.WriteLine($"{nickname}: {message}");

                    Broadcast($"{nickname}: {message}", client);
                }
            }
            catch
            {
                Console.WriteLine($"{nickname} 님 연결 종료됨");
            }
            finally
            {
                lock (lockObj)
                {
                    clients.Remove(client);
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
                        NetworkStream stream = client.GetStream();
                        stream.Write(data, 0, data.Length);
                    }
                }
            }
        }

        static void ServerInput()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    Broadcast($"[서버]: {input}", null);
                }
            }
        }
    }
}
