using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TcpPrac
{
    internal class TcpClientExample
    {
        static void Main()
        {
            TcpClient client = new TcpClient("127.0.0.1", 9999);

            NetworkStream stream = client.GetStream();
            string message = "Hello, Server!";
            byte[] data = Encoding.Default.GetBytes(message);

            stream.Write(data, 0, data.Length);
            Console.WriteLine("메시지 전송 완료");

            stream.Close();
            client.Close();
        }
    }
}
