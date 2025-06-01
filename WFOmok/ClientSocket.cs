using System;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WFOmok
{
    public class ClientSocket
    {
        private TcpClient client;
        private NetworkStream stream;

        public async Task Connect(string ip, int port)
        {
            client = new TcpClient();
            await client.ConnectAsync(ip, port);
            stream = client.GetStream();
            // 데이터 수신 대기 등 추가 구현 필요
        }

        public async Task Send(string message)
        {
            if (stream == null) return;
            byte[] data = Encoding.UTF8.GetBytes(message);
            await stream.WriteAsync(data, 0, data.Length);
        }

        public async Task<string> Receive()
        {
            if (stream == null) return null;
            byte[] buffer = new byte[1024];
            int bytes = await stream.ReadAsync(buffer, 0, buffer.Length);
            return Encoding.UTF8.GetString(buffer, 0, bytes);
        }

        public void Close()
        {
            stream?.Close();
            client?.Close();
        }
    }
}
