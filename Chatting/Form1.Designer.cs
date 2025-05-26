namespace Chatting
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.textMessage = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.Chat_log = new System.Windows.Forms.ListBox();
            this.Enter_nic = new System.Windows.Forms.TextBox();
            this.Enter_IP = new System.Windows.Forms.TextBox();
            this.Enter_chat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(29, 437);
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(294, 28);
            this.textMessage.TabIndex = 1;
            // 
            // Send
            // 
            this.Send.Enabled = false;
            this.Send.Location = new System.Drawing.Point(348, 437);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 28);
            this.Send.TabIndex = 2;
            this.Send.Text = "전송";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Chat_log
            // 
            this.Chat_log.FormattingEnabled = true;
            this.Chat_log.ItemHeight = 18;
            this.Chat_log.Location = new System.Drawing.Point(29, 103);
            this.Chat_log.Name = "Chat_log";
            this.Chat_log.Size = new System.Drawing.Size(394, 328);
            this.Chat_log.TabIndex = 3;
            // 
            // Enter_nic
            // 
            this.Enter_nic.Location = new System.Drawing.Point(29, 54);
            this.Enter_nic.Name = "Enter_nic";
            this.Enter_nic.Size = new System.Drawing.Size(100, 28);
            this.Enter_nic.TabIndex = 4;
            this.Enter_nic.Text = "닉네임 입력";
            // 
            // Enter_IP
            // 
            this.Enter_IP.Location = new System.Drawing.Point(150, 54);
            this.Enter_IP.Name = "Enter_IP";
            this.Enter_IP.Size = new System.Drawing.Size(173, 28);
            this.Enter_IP.TabIndex = 5;
            this.Enter_IP.Text = "IP 입력";
            // 
            // Enter_chat
            // 
            this.Enter_chat.Location = new System.Drawing.Point(348, 52);
            this.Enter_chat.Name = "Enter_chat";
            this.Enter_chat.Size = new System.Drawing.Size(75, 28);
            this.Enter_chat.TabIndex = 6;
            this.Enter_chat.Text = "입장";
            this.Enter_chat.UseVisualStyleBackColor = true;
            this.Enter_chat.Click += new System.EventHandler(this.Enter_chat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 574);
            this.Controls.Add(this.Enter_chat);
            this.Controls.Add(this.Enter_IP);
            this.Controls.Add(this.Enter_nic);
            this.Controls.Add(this.Chat_log);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.textMessage);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.ListBox Chat_log;
        private System.Windows.Forms.TextBox Enter_nic;
        private System.Windows.Forms.TextBox Enter_IP;
        private System.Windows.Forms.Button Enter_chat;
    }
}

