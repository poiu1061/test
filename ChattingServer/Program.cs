// Server.cs
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Server
{
    static void Main()
    {
        TcpListener server = new TcpListener(IPAddress.Any, 8080); //포트 8080열고 클라이언트 올 때 까지 대기
        server.Start();
        Console.WriteLine("서버 시작됨. 클라이언트 접속 대기 중...");

        TcpClient client = server.AcceptTcpClient();//클라이언트 오면 접속 허용
        Console.WriteLine("클라이언트 접속됨.");

        NetworkStream stream = client.GetStream(); //client와의 데이터 주고받을 통로 생성
        byte[] buffer = new byte[1024];

        while (true)
        {
            //stream.read 데이터 받기 배열 buffer에 데이터를 저장,인덱스 0부터 버퍼의 길이만큼
            int bytes = stream.Read(buffer, 0, buffer.Length);
            //buffer에 담긴 바이트 데이터를 문자열로 변환 
            string message = Encoding.UTF8.GetString(buffer, 0, bytes);
            Console.WriteLine("클라이언트: " + message);

            // 클라이언트에 응답 보내기
            string response = "서버가 받았어요: " + message; //클라이언트에게 보낼 응답 메세지 문자열로 작성
            byte[] responseData = Encoding.UTF8.GetBytes(response);//문자열을 바이트 배열로 변환
            stream.Write(responseData, 0, responseData.Length);
        }
    }
}
