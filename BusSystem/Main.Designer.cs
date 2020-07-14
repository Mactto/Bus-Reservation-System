namespace BusSystem
{
    partial class Main
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.roundtrip = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.transfer = new System.Windows.Forms.Label();
            this.direct = new System.Windows.Forms.Label();
            this.oneway = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sp = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mypageBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ap = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.regular = new System.Windows.Forms.Label();
            this.honor = new System.Windows.Forms.Label();
            this.premium = new System.Windows.Forms.Label();
            this.all = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BusSystem.Properties.Resources.underimage;
            this.pictureBox1.Location = new System.Drawing.Point(2, 387);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(809, 153);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.SkyBlue;
            this.panel8.BackgroundImage = global::BusSystem.Properties.Resources._98116466_243629543614270_6349452124837313405_n;
            this.panel8.Controls.Add(this.panel5);
            this.panel8.Controls.Add(this.panel1);
            this.panel8.Controls.Add(this.button2);
            this.panel8.Controls.Add(this.panel2);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.panel6);
            this.panel8.Controls.Add(this.loginBtn);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Controls.Add(this.mypageBtn);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Controls.Add(this.registerBtn);
            this.panel8.Controls.Add(this.panel3);
            this.panel8.Controls.Add(this.panel7);
            this.panel8.Controls.Add(this.panel4);
            this.panel8.Controls.Add(this.button1);
            this.panel8.Location = new System.Drawing.Point(2, -1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(820, 392);
            this.panel8.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.roundtrip);
            this.panel5.Location = new System.Drawing.Point(415, 118);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(287, 37);
            this.panel5.TabIndex = 5;
            this.panel5.Click += new System.EventHandler(this.oneway_Click);
            // 
            // roundtrip
            // 
            this.roundtrip.AutoSize = true;
            this.roundtrip.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.roundtrip.ForeColor = System.Drawing.Color.DimGray;
            this.roundtrip.Location = new System.Drawing.Point(8, 10);
            this.roundtrip.Name = "roundtrip";
            this.roundtrip.Size = new System.Drawing.Size(61, 16);
            this.roundtrip.TabIndex = 2;
            this.roundtrip.Text = "↔ 왕복";
            this.roundtrip.Click += new System.EventHandler(this.roundtrip_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.transfer);
            this.panel1.Controls.Add(this.direct);
            this.panel1.Controls.Add(this.oneway);
            this.panel1.Location = new System.Drawing.Point(122, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 37);
            this.panel1.TabIndex = 2;
            this.panel1.Click += new System.EventHandler(this.oneway_Click);
            // 
            // transfer
            // 
            this.transfer.AutoSize = true;
            this.transfer.Font = new System.Drawing.Font("굴림", 10F);
            this.transfer.Location = new System.Drawing.Point(227, 10);
            this.transfer.Name = "transfer";
            this.transfer.Size = new System.Drawing.Size(35, 14);
            this.transfer.TabIndex = 4;
            this.transfer.Text = "환승";
            this.transfer.Click += new System.EventHandler(this.transfer_Click);
            // 
            // direct
            // 
            this.direct.AutoSize = true;
            this.direct.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.direct.Location = new System.Drawing.Point(170, 10);
            this.direct.Name = "direct";
            this.direct.Size = new System.Drawing.Size(51, 14);
            this.direct.TabIndex = 3;
            this.direct.Text = "직통 √";
            this.direct.Click += new System.EventHandler(this.direct_Click);
            // 
            // oneway
            // 
            this.oneway.AutoSize = true;
            this.oneway.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.oneway.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.oneway.Location = new System.Drawing.Point(8, 10);
            this.oneway.Name = "oneway";
            this.oneway.Size = new System.Drawing.Size(74, 16);
            this.oneway.TabIndex = 2;
            this.oneway.Text = "→ 편도 √";
            this.oneway.Click += new System.EventHandler(this.oneway_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("굴림", 7F);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(679, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "로그아웃";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.sp);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(123, 162);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(135, 109);
            this.panel2.TabIndex = 3;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // sp
            // 
            this.sp.AutoSize = true;
            this.sp.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sp.Location = new System.Drawing.Point(7, 50);
            this.sp.Name = "sp";
            this.sp.Size = new System.Drawing.Size(54, 21);
            this.sp.TabIndex = 6;
            this.sp.Text = "선택";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "출발지";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(632, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 12);
            this.label4.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.dateTimePicker3);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Location = new System.Drawing.Point(567, 161);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(135, 109);
            this.panel6.TabIndex = 8;
            this.panel6.Visible = false;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(7, 51);
            this.dateTimePicker3.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker3.MinDate = new System.DateTime(2020, 6, 20, 0, 0, 0, 0);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(94, 21);
            this.dateTimePicker3.TabIndex = 7;
            this.dateTimePicker3.Value = new System.DateTime(2020, 6, 21, 2, 31, 36, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 6;
            this.label10.Text = "오는날";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Transparent;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("굴림", 7F);
            this.loginBtn.ForeColor = System.Drawing.Color.Black;
            this.loginBtn.Location = new System.Drawing.Point(634, 13);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(46, 23);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "로그인";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(360, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "노선조회";
            // 
            // mypageBtn
            // 
            this.mypageBtn.BackColor = System.Drawing.Color.Transparent;
            this.mypageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mypageBtn.Font = new System.Drawing.Font("굴림", 7F);
            this.mypageBtn.ForeColor = System.Drawing.Color.Black;
            this.mypageBtn.Location = new System.Drawing.Point(729, 13);
            this.mypageBtn.Name = "mypageBtn";
            this.mypageBtn.Size = new System.Drawing.Size(68, 23);
            this.mypageBtn.TabIndex = 2;
            this.mypageBtn.Text = "마이페이지";
            this.mypageBtn.UseVisualStyleBackColor = false;
            this.mypageBtn.Click += new System.EventHandler(this.mypageBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(266, 47);
            this.label1.TabIndex = 5;
            this.label1.Text = "고속버스 통합예매";
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.Transparent;
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBtn.Font = new System.Drawing.Font("굴림", 7F);
            this.registerBtn.ForeColor = System.Drawing.Color.Black;
            this.registerBtn.Location = new System.Drawing.Point(679, 13);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(56, 23);
            this.registerBtn.TabIndex = 1;
            this.registerBtn.Text = "회원가입";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.ap);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(274, 162);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(135, 109);
            this.panel3.TabIndex = 4;
            this.panel3.Click += new System.EventHandler(this.panel2_Click);
            // 
            // ap
            // 
            this.ap.AutoSize = true;
            this.ap.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ap.Location = new System.Drawing.Point(3, 50);
            this.ap.Name = "ap";
            this.ap.Size = new System.Drawing.Size(54, 21);
            this.ap.TabIndex = 7;
            this.ap.Text = "선택";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "도착지";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.dateTimePicker2);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Location = new System.Drawing.Point(416, 161);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(286, 109);
            this.panel7.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(10, 51);
            this.dateTimePicker2.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(2020, 6, 21, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(99, 21);
            this.dateTimePicker2.TabIndex = 6;
            this.dateTimePicker2.Value = new System.DateTime(2020, 6, 21, 0, 0, 0, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 5;
            this.label11.Text = "가는날";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.regular);
            this.panel4.Controls.Add(this.honor);
            this.panel4.Controls.Add(this.premium);
            this.panel4.Controls.Add(this.all);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(123, 277);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(286, 66);
            this.panel4.TabIndex = 5;
            this.panel4.Click += new System.EventHandler(this.honor_Click);
            // 
            // regular
            // 
            this.regular.AutoSize = true;
            this.regular.Font = new System.Drawing.Font("굴림", 10F);
            this.regular.Location = new System.Drawing.Point(226, 37);
            this.regular.Name = "regular";
            this.regular.Size = new System.Drawing.Size(35, 14);
            this.regular.TabIndex = 4;
            this.regular.Text = "일반";
            this.regular.Click += new System.EventHandler(this.regular_Click);
            // 
            // honor
            // 
            this.honor.AutoSize = true;
            this.honor.Font = new System.Drawing.Font("굴림", 10F);
            this.honor.Location = new System.Drawing.Point(169, 37);
            this.honor.Name = "honor";
            this.honor.Size = new System.Drawing.Size(35, 14);
            this.honor.TabIndex = 3;
            this.honor.Text = "우등";
            this.honor.Click += new System.EventHandler(this.honor_Click);
            // 
            // premium
            // 
            this.premium.AutoSize = true;
            this.premium.Font = new System.Drawing.Font("굴림", 10F);
            this.premium.Location = new System.Drawing.Point(78, 37);
            this.premium.Name = "premium";
            this.premium.Size = new System.Drawing.Size(63, 14);
            this.premium.TabIndex = 2;
            this.premium.Text = "프리미엄";
            this.premium.Click += new System.EventHandler(this.premium_Click);
            // 
            // all
            // 
            this.all.AutoSize = true;
            this.all.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.all.Location = new System.Drawing.Point(8, 37);
            this.all.Name = "all";
            this.all.Size = new System.Drawing.Size(51, 14);
            this.all.TabIndex = 1;
            this.all.Text = "전체 √";
            this.all.Click += new System.EventHandler(this.all_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "등급";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(416, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(286, 65);
            this.button1.TabIndex = 6;
            this.button1.Text = "조회하기";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(812, 540);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel8);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "20184067 컴퓨터공학과 최세환";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Button mypageBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label transfer;
        public System.Windows.Forms.Label direct;
        private System.Windows.Forms.Label oneway;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label regular;
        private System.Windows.Forms.Label honor;
        private System.Windows.Forms.Label premium;
        private System.Windows.Forms.Label all;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label roundtrip;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label sp;
        private System.Windows.Forms.Label ap;
    }
}

