using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chatting
{
    public partial class Form1 : Form
    {
        TcpClient client;
        NetworkStream stream;
        Thread receiveThread;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Enter_chat_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            client.Connect(Enter_IP.Text, 9000);
            stream = client.GetStream();

            byte[] nameData = Encoding.UTF8.GetBytes(Enter_nic.Text);
            stream.Write(nameData,0,nameData.Length);

            //수신 스레드 시작
            receiveThread = new Thread(Receive);
            receiveThread.IsBackground = true;
            receiveThread.Start();

            Chat_log.Items.Add("서버에 연결됨.");
        }

        private void Send_Click(object sender, EventArgs e)
        {
            string message = textMessage.Text;

            byte[] data = Encoding.UTF8.GetBytes(message);
            stream.Write(data, 0, data.Length);

            Chat_log.Items.Add($"{Enter_nic.Text}: {message}");

            textMessage.Clear();
        }

        private void Receive()
        {
            byte[] buffer = new byte[1024];
            while (true)
            {
                int bytes = stream.Read(buffer, 0, buffer.Length);
                string message = Encoding.UTF8.GetString(buffer, 0, bytes);
                Invoke((MethodInvoker)(() => Chat_log.Items.Add(message)));
            }
        }
    }
}
