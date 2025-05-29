//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Net;
//using System.Net.Sockets;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;

//namespace TcpPrac
//{
//    internal class TcpServ
//    {
//        public void Server()
//        {
//            TcpListener server = new TcpListener(IPAddress.Any, 9000);
//            server.Start();
//            Console.WriteLine("서버 시작 클라이언트 접속 대기중");


//            TcpClient client = server.AcceptTcpClient();
//            Console.WriteLine("클라이언트 접속");
//            NetworkStream stream = client.GetStream();

//            while (true)
//            {
//                byte[] recieveBuffer = new byte[1024];
//                int bytesRead = stream.Read(recieveBuffer, 0, recieveBuffer.Length);
//                if (bytesRead == 0) break;

//                String ClientMessage = Encoding.UTF8.GetString(recieveBuffer, 0, bytesRead);
//                Console.WriteLine($"클라이언트: {ClientMessage}");

//                Console.Write("입력 > ");
//                string message = Console.ReadLine();
//                byte[] buffer = Encoding.UTF8.GetBytes(message);
//                stream.Write(buffer, 0, buffer.Length);
//            }
//            stream.Close();
//            client.Close();
//            server.Stop();
//        }

//    }
//}
