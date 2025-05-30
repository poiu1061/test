using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace OmokServer
{
    internal class Program
    {
        static TcpListener listener;
        static List<TcpClient> clients = new List<TcpClient>();
        static object lockObj = new object();

        static int[,] pan = new int[15, 15];
        static int turn = 1;
        static int size = 15;

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
                Console.WriteLine("클라이언트 접속!");

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
                    string[] dot = message.Split();
                    if (dot.Length < 2) continue;

                    int x = int.Parse(dot[0]);
                    int y = int.Parse(dot[1]);

                    lock (lockObj)
                    {
                        if (pan[x, y] != 0)
                        {
                            SendMessage(client, "이미 놓인 자리입니다.");
                            continue;
                        }

                        int currentPlayer = (turn % 2 == 1) ? 1 : 2;
                        pan[x, y] = currentPlayer;
                        turn++;

                        if (CheckWin(pan, size))
                        {
                            Broadcast((currentPlayer == 1 ? "흑 승" : "백 승"));
                            break;
                        }
                        Console.Clear();
                        makePan();
                    }
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

        static void makePan()
        {
            StringBuilder sb = new StringBuilder();
            // 수정된 라인 (자릿수 맞추기)
            sb.Append("    ");
            for (int i = 0; i < size; i++)
            {
                sb.Append(i.ToString().PadLeft(2) + " ");
            }
            sb.AppendLine();
            for (int i = 0; i < size; i++)
            {
                sb.Append(i < 10 ? i + " " : i.ToString());
                for (int j = 0; j < size; j++)
                {
                    if (pan[i, j] == 1)
                        sb.Append("○ ");
                    else if (pan[i, j] == 2)
                        sb.Append("● ");
                    else
                        sb.Append(". ");
                }
                sb.AppendLine();
            }
            sb.AppendLine($"현재 차례: {(turn % 2 == 1 ? "흑" : "백")}");
            Broadcast(sb.ToString());
        }

        static void Broadcast(string message)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            lock (lockObj)
            {
                foreach (TcpClient client in clients)
                {
                    try
                    {
                        NetworkStream stream = client.GetStream();
                        stream.Write(data, 0, data.Length);
                    }
                    catch
                    {
                        // 무시
                    }
                }
            }
        }

        static void SendMessage(TcpClient client, string message)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            try
            {
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);
            }
            catch { }
        }

        static bool CheckWin(int[,] pan, int size)
        {
            for (int i = 0; i < size; i++)
            {
                int count = 1;
                for (int j = 1; j < size; j++)
                {
                    if (pan[i, j] != 0 && pan[i, j] == pan[i, j - 1])
                    {
                        count++;
                    }
                    else
                    {
                        count = 1;
                    }

                    if (count == 5)
                    {
                        return true;
                    }
                }
            }

            // 세로
            for (int i = 0; i < size; i++)
            {
                int count = 1;
                for (int j = 1; j < size; j++)
                {
                    if (pan[j, i] != 0 && pan[j, i] == pan[j - 1, i])
                    {
                        count++;
                    }
                    else
                    {
                        count = 1;
                    }

                    if (count == 5)
                    {
                        return true;
                    }
                }
            }

            // 우하향 대각선
            for (int i = 0; i <= size - 5; i++)
            {
                for (int j = 0; j <= size - 5; j++)
                {
                    int count = 1;
                    for (int k = 1; k < 5; k++)
                    {
                        if (pan[i + k, j + k] != 0 && pan[i + k, j + k] == pan[i + k - 1, j + k - 1])
                        {
                            count++;
                        }
                        else
                        {
                            break;
                        }

                        if (count == 5)
                        {
                            return true;
                        }
                    }
                }
            }

            // 좌하향 대각선
            for (int i = 0; i <= size - 5; i++)
            {
                for (int j = 4; j < size; j++)
                {
                    int count = 1;
                    for (int k = 1; k < 5; k++)
                    {
                        if (pan[i + k, j - k] != 0 && pan[i + k, j - k] == pan[i + k - 1, j - k + 1])
                        {
                            count++;
                        }
                        else
                        {
                            break;
                        }

                        if (count == 5)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
    }
}
