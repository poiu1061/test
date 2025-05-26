using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChattingServer
{
    internal class MyServer
    {
        public MyServer() { AsyncServerStart(); }

        private void AsyncServerStart()
        {
            // 서버 포트설정 및 시작
            TcpListener listener = new TcpListener(new IPEndPoint(IPAddress.Any, 8080));
            listener.Start();
            Console.WriteLine("서버를 시작합니다. 클라이언트의 접속을 기다립니다..");

            //클라이언트의 접속을 확인하면 스레드풀에서 해당 클라이언트의 메시지를 읽도록 대기시키고
            //while문을 통해 다시 클라이언트의 접속을 기다립니다.
            while (true)
            {
                TcpClient acceptClient = listener.AcceptTcpClient();

                ClientData clientData = new ClientData(acceptClient);

                clientData.client.GetStream().BeginRead(clientData.readByteData, 0, clientData.readByteData.Length, new AsyncCallback(DataReceived), clientData);
            }
        }


        private void DataReceived(IAsyncResult ar)
        {
           
            ClientData callbackClient = ar.AsyncState as ClientData;
            int bytesRead = callbackClient.client.GetStream().EndRead(ar);
            string readString = Encoding.Default.GetString(callbackClient.readByteData, 0, bytesRead);
            Console.WriteLine("{0}번 사용자 : {1}",callbackClient.client.GetStream().EndRead(ar));


            // 비동기서버에서 가장중요한 핵심입니다. 
            // 비동기서버는 while문을 돌리지않고 콜백메서드에서 다시 읽으라고 비동기명령을 내립니다.
            callbackClient.client.GetStream().BeginRead(callbackClient.readByteData, 0, callbackClient.readByteData.Length, new AsyncCallback(DataReceived), callbackClient);
        }
    }

    internal class ClientData
    {
        // 연결이 확인된 클라이언트를 넣어줄 클래스입니다.
        // readByteData는 stream데이터를 읽어올 객체입니다.
        public TcpClient client { get; set; }
        public byte[] readByteData { get; set; }
        public int clientNumber;

        public ClientData(TcpClient client)
        {
            this.client = client;
            this.readByteData = new byte[1024];

            string clientEndPoint = client.Client.LocalEndPoint.ToString();
            char[] point = { '.', ':' };
            string[] spliteData = clientEndPoint.Split(point);
            this.clientNumber = int.Parse(spliteData[3]);
            Console.WriteLine("{0}번 사용자 접속  성공", clientNumber);
            






































































































                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    
















        }
    }
}
