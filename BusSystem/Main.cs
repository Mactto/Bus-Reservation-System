using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace BusSystem
{
    public partial class Main : Form
    {
        Login loginForm;
        Register registerForm;
        Route routeForm;

        public static List<string> id;
        public static List<string> pw;
        public static List<int> point;
        public static List<string> tc;

        public static string username;
        private static bool login_state = false;
        public static string go_day;
        public static string away_day;
        public static string go_city;
        public static string away_city;
        public static string m_go = "편도";
        public static string grade = "전체";
        public static int user_num;

        public Main()
        {
            InitializeComponent();
            loginBtn.FlatAppearance.BorderSize = 0;
            registerBtn.FlatAppearance.BorderSize = 0;
            mypageBtn.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.BorderSize = 0;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            panel8.BackgroundImageLayout = ImageLayout.Stretch;
            id = new List<string>();
            id.Add("root");
            pw = new List<string>();
            pw.Add("1234");
            point = new List<int>();
            point.Add(3000);
            go_day = "";
            away_day = "";
            dateTimePicker2.MinDate = DateTime.Today;
            dateTimePicker3.MinDate = DateTime.Today;
        }

        //================= 수단 이벤트 ================================

        // 직통 클릭 이벤트
        public void direct_Click(object sender, EventArgs e)
        {
            direct.Font = new Font("굴림", 10, FontStyle.Bold);
            transfer.Font = new Font("굴림", 10, FontStyle.Regular);
            direct.Text = "직통 √";
            transfer.Text = "환승";
        }

        // 환승 클릭 이벤트
        public void transfer_Click(object sender, EventArgs e)
        {
            direct.Font = new Font("굴림", 10, FontStyle.Regular);
            transfer.Font = new Font("굴림", 10, FontStyle.Bold);
            direct.Text = "직통";
            transfer.Text = "환승 √";
        }

        // 편도 클릭 이벤트
        public void oneway_Click(object sender, EventArgs e)
        {
            direct.Visible = true;
            transfer.Visible = true;
            roundtrip.Text = "↔ 왕복";
            roundtrip.ForeColor = Color.DimGray;
            oneway.Text = "→ 편도 √";
            oneway.ForeColor = Color.LightSeaGreen;
            panel6.Visible = false;
            panel7.Size = new Size(286, 109);
            m_go = "편도";
        }

        // 왕복 클릭 이벤트
        public void roundtrip_Click(object sender, EventArgs e)
        {
            direct.Visible = false;
            transfer.Visible = false;
            roundtrip.Text = "↔ 왕복 √";
            roundtrip.ForeColor = Color.LightSeaGreen;
            oneway.Text = "→ 편도";
            oneway.ForeColor = Color.DimGray;
            panel6.Visible = true;
            panel7.Size = new Size(135, 109);
            m_go = "왕복";
        }

        //================= 등급 이벤트 ================================

        // 전체 클릭 이벤트
        public void all_Click(object sender, EventArgs e)
        {
            all.Font = new Font("굴림", 10, FontStyle.Bold);
            all.Text = "전체 √";
            premium.Font = new Font("굴림", 10, FontStyle.Regular);
            premium.Text = "프리미엄";
            honor.Font = new Font("굴림", 10, FontStyle.Regular);
            honor.Text = "우등";
            regular.Font = new Font("굴림", 10, FontStyle.Regular);
            regular.Text = "일반";
            grade = "전체";
        }

        // 프리미엄 클릭 이벤트
        public void premium_Click(object sender, EventArgs e)
        {
            all.Font = new Font("굴림", 10, FontStyle.Regular);
            all.Text = "전체";
            premium.Font = new Font("굴림", 10, FontStyle.Bold);
            premium.Text = "프리미엄 √";
            honor.Font = new Font("굴림", 10, FontStyle.Regular);
            honor.Text = "우등";
            regular.Font = new Font("굴림", 10, FontStyle.Regular);
            regular.Text = "일반";
            grade = "프리미엄";
        }

        // 우등 클릭 이벤트
        public void honor_Click(object sender, EventArgs e)
        {
            all.Font = new Font("굴림", 10, FontStyle.Regular);
            all.Text = "전체";
            premium.Font = new Font("굴림", 10, FontStyle.Regular);
            premium.Text = "프리미엄";
            honor.Font = new Font("굴림", 10, FontStyle.Bold);
            honor.Text = "우등 √";
            regular.Font = new Font("굴림", 10, FontStyle.Regular);
            regular.Text = "일반";
            grade = "우등";
        }

        // 일반 클릭 이벤트
        public void regular_Click(object sender, EventArgs e)
        {
            all.Font = new Font("굴림", 10, FontStyle.Regular);
            all.Text = "전체";
            premium.Font = new Font("굴림", 10, FontStyle.Regular);
            premium.Text = "프리미엄";
            honor.Font = new Font("굴림", 10, FontStyle.Regular);
            honor.Text = "우등";
            regular.Font = new Font("굴림", 10, FontStyle.Bold);
            regular.Text = "일반 √";
            grade = "고속";
        }

        //================= 버튼 이벤트 ================================

        // 로그인 버튼 클릭 이벤트
        private void loginBtn_Click(object sender, EventArgs e)
        {
            loginForm = new Login();
            switch(loginForm.ShowDialog())
            {
                case DialogResult.OK:
                    loginBtn.Visible = false;
                    registerBtn.Visible = false;
                    button2.Visible = true;
                    label4.Text = username + "님 안녕하세요!";
                    login_state = true;
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }
        // 회원가입 버튼클릭 이벤트
        private void registerBtn_Click(object sender, EventArgs e)
        {
            registerForm = new Register();
            switch(registerForm.ShowDialog())
            {
                case DialogResult.OK:
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }

        // 출발지 or 도착지 클릭 이벤트
        private void panel2_Click(object sender, EventArgs e)
        {
            routeForm = new Route();
            switch (routeForm.ShowDialog())
            {
                case DialogResult.OK:
                    sp.Text = routeForm.getStartPoint;
                    ap.Text = routeForm.getArrivePoint;
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginBtn.Visible = true;
            registerBtn.Visible = true;
            button2.Visible = false;
            label4.Visible = false;
            login_state = false;
        }

        private void mypageBtn_Click(object sender, EventArgs e)
        {
            if (login_state == false)
            {
                registerForm = new Register();
                switch (registerForm.ShowDialog())
                {
                    case DialogResult.OK:
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }
            else
            {
                Mypage mp = new Mypage();
                switch(mp.ShowDialog())
                {
                    case DialogResult.OK:
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (login_state == true)
            {
                if (sp.Text != "선택" && ap.Text != "선택")
                {
                    go_day = dateTimePicker2.Value.ToString("yyyy. MM. dd");
                    if (panel6.Visible == true) away_day = dateTimePicker3.Value.ToString("yyyy. MM. dd");
                    else away_day = "";
                    go_city = sp.Text;
                    away_city = ap.Text;

                    s_Ticketing tt = new s_Ticketing();
                    switch (tt.ShowDialog())
                    {
                        case DialogResult.OK:
                            break;
                        case DialogResult.Cancel:
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("입력하지 않은 요소가 있습니다.");
                }
            }
            else MessageBox.Show("로그인을 해주세요.");
        }
    }
}
