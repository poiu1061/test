//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Sockets;
//using System.Text;
//using System.Threading.Tasks;

//namespace Chatting
//{
//    class Chatting
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("서버콘솔창 \n\n\n");

//            //TcpListener는 서버 소켓을 생성하는 클래스입니다.
//            //IPAddress.Any는 모든 IP 주소를 의미합니다.
//            //8080은 포트 번호입니다. 이 포트에서 클라이언트의 연결을 기다립니다.
//            TcpListener server = new TcpListener(IPAddress.Any, 8080);

//            //서버를 시작
//            server.Start();

//            //클라이언트 객체를 만들어 8080에 연결된 클라이언트를 받아옴
//            //클라이언트가 접속할때까지 서버는 해당구문에서 블락
//            TcpClient client = server.AcceptTcpClient();

//            //클라이언트와 연결된 스트림을 가져옴
//            NetworkStream ns = client.GetStream();

//            //소켓은 byte[]형식으로 데이터를 주고받으므로 byte[]형 변수선언
//            byte[] byteData = new byte[1024];

//            ns.Read(byteData, 0, byteData.Length);

//            //byte[]형식의 데이터를 string형식으로 변환
//            String stringData = Encoding.UTF8.GetString(byteData);

//            Console.WriteLine(stringData);

//            server.Stop(); //서버 종료
//            ns.Close(); //스트림 종료
//        }
//    }
//}
