namespace CalPractice
{
    partial class 계산기
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
            this.display = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.Btn_1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.display2 = new System.Windows.Forms.Label();
            this.equal = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.res = new System.Windows.Forms.Button();
            this.HexNum = new System.Windows.Forms.Label();
            this.DecNum = new System.Windows.Forms.Label();
            this.OctNum = new System.Windows.Forms.Label();
            this.BinNum = new System.Windows.Forms.Label();
            this.BIN = new System.Windows.Forms.Label();
            this.OCT = new System.Windows.Forms.Label();
            this.DEC = new System.Windows.Forms.Label();
            this.HEX = new System.Windows.Forms.Label();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonF = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.display.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.display.Location = new System.Drawing.Point(17, 112);
            this.display.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(523, 34);
            this.display.TabIndex = 0;
            this.display.Text = "0";
            this.display.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(251, 589);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(388, 589);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 589);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(115, 528);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 34);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(251, 528);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 34);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(388, 528);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(107, 34);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Btn_1
            // 
            this.Btn_1.Location = new System.Drawing.Point(115, 465);
            this.Btn_1.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_1.Name = "Btn_1";
            this.Btn_1.Size = new System.Drawing.Size(107, 34);
            this.Btn_1.TabIndex = 7;
            this.Btn_1.Text = "7";
            this.Btn_1.UseVisualStyleBackColor = true;
            this.Btn_1.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(251, 465);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(107, 34);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(388, 465);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(107, 34);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(251, 644);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(107, 34);
            this.button10.TabIndex = 10;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(515, 644);
            this.add.Margin = new System.Windows.Forms.Padding(4);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(107, 34);
            this.add.TabIndex = 11;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // display2
            // 
            this.display2.AutoSize = true;
            this.display2.Location = new System.Drawing.Point(503, 63);
            this.display2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.display2.Name = "display2";
            this.display2.Size = new System.Drawing.Size(0, 18);
            this.display2.TabIndex = 12;
            this.display2.Click += new System.EventHandler(this.display2_Click);
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(515, 703);
            this.equal.Margin = new System.Windows.Forms.Padding(4);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(107, 34);
            this.equal.TabIndex = 13;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(511, 589);
            this.sub.Margin = new System.Windows.Forms.Padding(4);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(107, 34);
            this.sub.TabIndex = 14;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // mul
            // 
            this.mul.Location = new System.Drawing.Point(506, 528);
            this.mul.Margin = new System.Windows.Forms.Padding(4);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(107, 34);
            this.mul.TabIndex = 15;
            this.mul.Text = "*";
            this.mul.UseVisualStyleBackColor = true;
            this.mul.Click += new System.EventHandler(this.mul_Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(506, 465);
            this.div.Margin = new System.Windows.Forms.Padding(4);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(107, 34);
            this.div.TabIndex = 16;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.button11_Click_1);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(388, 407);
            this.Clear.Margin = new System.Windows.Forms.Padding(4);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(107, 34);
            this.Clear.TabIndex = 17;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.button11_Click_2);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(506, 407);
            this.cancel.Margin = new System.Windows.Forms.Padding(4);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(107, 34);
            this.cancel.TabIndex = 18;
            this.cancel.Text = "X";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // CE
            // 
            this.CE.Location = new System.Drawing.Point(251, 407);
            this.CE.Margin = new System.Windows.Forms.Padding(4);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(107, 34);
            this.CE.TabIndex = 19;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = true;
            this.CE.Click += new System.EventHandler(this.CE_Click);
            // 
            // res
            // 
            this.res.Location = new System.Drawing.Point(115, 407);
            this.res.Margin = new System.Windows.Forms.Padding(4);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(107, 34);
            this.res.TabIndex = 20;
            this.res.Text = "%";
            this.res.UseVisualStyleBackColor = true;
            this.res.Click += new System.EventHandler(this.res_Click);
            // 
            // HexNum
            // 
            this.HexNum.AutoSize = true;
            this.HexNum.Location = new System.Drawing.Point(96, 194);
            this.HexNum.Name = "HexNum";
            this.HexNum.Size = new System.Drawing.Size(18, 18);
            this.HexNum.TabIndex = 25;
            this.HexNum.Text = "0";
            // 
            // DecNum
            // 
            this.DecNum.AutoSize = true;
            this.DecNum.Location = new System.Drawing.Point(96, 241);
            this.DecNum.Name = "DecNum";
            this.DecNum.Size = new System.Drawing.Size(18, 18);
            this.DecNum.TabIndex = 26;
            this.DecNum.Text = "0";
            // 
            // OctNum
            // 
            this.OctNum.AutoSize = true;
            this.OctNum.Location = new System.Drawing.Point(96, 288);
            this.OctNum.Name = "OctNum";
            this.OctNum.Size = new System.Drawing.Size(18, 18);
            this.OctNum.TabIndex = 27;
            this.OctNum.Text = "0";
            // 
            // BinNum
            // 
            this.BinNum.AutoSize = true;
            this.BinNum.Location = new System.Drawing.Point(96, 333);
            this.BinNum.Name = "BinNum";
            this.BinNum.Size = new System.Drawing.Size(18, 18);
            this.BinNum.TabIndex = 28;
            this.BinNum.Text = "0";
            // 
            // BIN
            // 
            this.BIN.AutoSize = true;
            this.BIN.Location = new System.Drawing.Point(19, 333);
            this.BIN.Name = "BIN";
            this.BIN.Size = new System.Drawing.Size(34, 18);
            this.BIN.TabIndex = 24;
            this.BIN.Text = "BIN";
            this.BIN.Click += new System.EventHandler(this.BIN_Click);
            // 
            // OCT
            // 
            this.OCT.AutoSize = true;
            this.OCT.Location = new System.Drawing.Point(19, 288);
            this.OCT.Name = "OCT";
            this.OCT.Size = new System.Drawing.Size(43, 18);
            this.OCT.TabIndex = 23;
            this.OCT.Text = "OCT";
            this.OCT.Click += new System.EventHandler(this.OCT_Click);
            // 
            // DEC
            // 
            this.DEC.AutoSize = true;
            this.DEC.Location = new System.Drawing.Point(19, 241);
            this.DEC.Name = "DEC";
            this.DEC.Size = new System.Drawing.Size(42, 18);
            this.DEC.TabIndex = 21;
            this.DEC.Text = "DEC";
            this.DEC.Click += new System.EventHandler(this.DEC_Click);
            // 
            // HEX
            // 
            this.HEX.AutoSize = true;
            this.HEX.Location = new System.Drawing.Point(19, 194);
            this.HEX.Name = "HEX";
            this.HEX.Size = new System.Drawing.Size(41, 18);
            this.HEX.TabIndex = 22;
            this.HEX.Text = "HEX";
            this.HEX.Click += new System.EventHandler(this.HEX_Click);
            // 
            // buttonA
            // 
            this.buttonA.Enabled = false;
            this.buttonA.Location = new System.Drawing.Point(0, 407);
            this.buttonA.Margin = new System.Windows.Forms.Padding(4);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(107, 34);
            this.buttonA.TabIndex = 34;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = true;
            // 
            // buttonB
            // 
            this.buttonB.Enabled = false;
            this.buttonB.Location = new System.Drawing.Point(0, 465);
            this.buttonB.Margin = new System.Windows.Forms.Padding(4);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(107, 34);
            this.buttonB.TabIndex = 33;
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = true;
            // 
            // buttonC
            // 
            this.buttonC.Enabled = false;
            this.buttonC.Location = new System.Drawing.Point(0, 528);
            this.buttonC.Margin = new System.Windows.Forms.Padding(4);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(107, 34);
            this.buttonC.TabIndex = 32;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.button13_Click);
            // 
            // buttonD
            // 
            this.buttonD.Enabled = false;
            this.buttonD.Location = new System.Drawing.Point(5, 589);
            this.buttonD.Margin = new System.Windows.Forms.Padding(4);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(107, 34);
            this.buttonD.TabIndex = 31;
            this.buttonD.Text = "D";
            this.buttonD.UseVisualStyleBackColor = true;
            // 
            // buttonF
            // 
            this.buttonF.Enabled = false;
            this.buttonF.Location = new System.Drawing.Point(9, 703);
            this.buttonF.Margin = new System.Windows.Forms.Padding(4);
            this.buttonF.Name = "buttonF";
            this.buttonF.Size = new System.Drawing.Size(107, 34);
            this.buttonF.TabIndex = 30;
            this.buttonF.Text = "F";
            this.buttonF.UseVisualStyleBackColor = true;
            // 
            // buttonE
            // 
            this.buttonE.Enabled = false;
            this.buttonE.Location = new System.Drawing.Point(9, 644);
            this.buttonE.Margin = new System.Windows.Forms.Padding(4);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(107, 34);
            this.buttonE.TabIndex = 29;
            this.buttonE.Text = "E";
            this.buttonE.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(532, 35);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(107, 34);
            this.button7.TabIndex = 35;
            this.button7.Text = "0";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // 계산기
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 766);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonF);
            this.Controls.Add(this.buttonE);
            this.Controls.Add(this.BinNum);
            this.Controls.Add(this.OctNum);
            this.Controls.Add(this.DecNum);
            this.Controls.Add(this.HexNum);
            this.Controls.Add(this.BIN);
            this.Controls.Add(this.OCT);
            this.Controls.Add(this.HEX);
            this.Controls.Add(this.DEC);
            this.Controls.Add(this.res);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.display2);
            this.Controls.Add(this.add);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.Btn_1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.display);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "계산기";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label display;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button Btn_1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label display2;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button res;
        private System.Windows.Forms.Label HexNum;
        private System.Windows.Forms.Label DecNum;
        private System.Windows.Forms.Label OctNum;
        private System.Windows.Forms.Label BinNum;
        private System.Windows.Forms.Label BIN;
        private System.Windows.Forms.Label OCT;
        private System.Windows.Forms.Label DEC;
        private System.Windows.Forms.Label HEX;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonF;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Button button7;
    }
}

