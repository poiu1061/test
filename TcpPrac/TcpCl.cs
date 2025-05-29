//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Sockets;
//using System.Text;
//using System.Threading.Tasks;

//namespace TcpPrac
//{
//    internal class TcpCl
//    {
//        static void Main()
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
