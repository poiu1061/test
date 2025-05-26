using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TcpPrac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TcpListener server = new TcpListener(IPAddress.Any, 9999);
            server.Start();
            Console.WriteLine("서버 시작됨. 클라이언트 연결 대기 중...");

            TcpClient client = server.AcceptTcpClient();
            Console.WriteLine("클라이언트 연결됨.");

            NetworkStream stream = client.GetStream();

            byte[] buffer = new byte[1024];
            int bytes = stream.Read(buffer, 0, buffer.Length);
            string message = Encoding.Default.GetString(buffer, 0, bytes);

            Console.WriteLine("수신 메시지: " + message);

            stream.Close();
            client.Close();
            server.Stop();
        }
    }
}
