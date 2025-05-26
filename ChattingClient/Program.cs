using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ChattingClient
{
    class Program
    {
        static TcpClient client;
        static NetworkStream stream;
        static string nickname;

        static void Main()
        {
            Console.Write("서버 IP 입력 (예: 127.0.0.1): ");
            string serverIp = Console.ReadLine();

            Console.Write("사용할 닉네임 입력: ");
            nickname = Console.ReadLine();

            try
            {
                client = new TcpClient();
                client.Connect(serverIp, 9000);
                stream = client.GetStream();

                // 닉네임 먼저 전송
                byte[] nameData = Encoding.UTF8.GetBytes(nickname);
                stream.Write(nameData, 0, nameData.Length);

                Console.WriteLine("서버에 연결되었습니다. 채팅을 시작하세요!");

                // 메시지 수신 쓰레드 시작
                Thread receiveThread = new Thread(ReceiveMessages);
                receiveThread.Start();

                // 메시지 전송 루프
                while (true)
                {
                    string message = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(message)) continue;

                    byte[] data = Encoding.UTF8.GetBytes(message);
                    stream.Write(data, 0, data.Length);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("오류 발생: " + ex.Message);
            }
        }

        static void ReceiveMessages()
        {
            try
            {
                byte[] buffer = new byte[1024];
                while (true)
                {
                    int bytes = stream.Read(buffer, 0, buffer.Length);
                    if (bytes == 0) break;

                    string message = Encoding.UTF8.GetString(buffer, 0, bytes);
                    Console.WriteLine(message);
                }
            }
            catch
            {
                Console.WriteLine("서버와의 연결이 끊어졌습니다.");
            }
            finally
            {
                stream.Close();
                client.Close();
            }
        }
    }
}
