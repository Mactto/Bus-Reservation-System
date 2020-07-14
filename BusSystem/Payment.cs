using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BusSystem
{
    public partial class Payment : Form
    {
        private int discount;

        public Payment()
        {
            InitializeComponent();
            discount = 0;
            label2.Text = Main.go_city;
            label3.Text = Main.away_city;
            label5.Text = Main.away_city;
            label4.Text = Main.go_city;
            label14.Text = s_Ticketing.company;
            label15.Text = s_Ticketing.grade;
            label19.Text = a_Ticketing.company;
            label18.Text = a_Ticketing.grade;
            label20.Text = Main.go_day + " / " + s_Ticketing.s_time;
            label21.Text = Main.away_day + " / " + a_Ticketing.s_time;
            label39.Text = Main.point[Main.user_num].ToString();
            foreach (string s in Seat.seat_num1) label16.Text += s + "번, ";
            foreach (string s in Seat.seat_num2) label17.Text += s + "번, ";
            if (Main.m_go.Equals("편도"))
            {
                panel3.Visible = false;
                label33.Text = Seat.price[0].ToString();
            }
            else
            {
                label33.Text = (Seat.price[0] + Seat.price[1]).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "√ 모바일 티켓 발권";
            button1.ForeColor = Color.White;
            button1.BackColor = Color.DarkViolet;

            button2.Text = "일반 티켓 발권";
            button2.ForeColor = Color.DarkGray;
            button2.BackColor = Color.Gainsboro;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Text = "모바일 티켓 발권";
            button1.ForeColor = Color.DarkGray;
            button1.BackColor = Color.Gainsboro;

            button2.Text = "√ 일반 티켓 발권";
            button2.ForeColor = Color.White;
            button2.BackColor = Color.DarkViolet;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
                MessageBox.Show("카드사를 선택해주세요.");
            else if (textBox1.TextLength != textBox1.MaxLength || textBox2.TextLength != textBox2.MaxLength)
                MessageBox.Show("카드 번호를 제대로 기입해주세요.");
            else if (textBox3.TextLength != textBox3.MaxLength || textBox4.TextLength != textBox4.MaxLength)
                MessageBox.Show("카드번호를 제대로 기입해주세요.");
            else if (textBox5.TextLength != textBox5.MaxLength || textBox6.TextLength != textBox6.MaxLength)
                MessageBox.Show("유효기간을 제대로 기입해주세요.");
            else if (textBox7.TextLength != textBox7.MaxLength)
                MessageBox.Show("카드 비밀 번호를 입력해주세요.");
            else
            {
                MessageBox.Show("결제가 완료되었습니다! 이용해주셔서 감사합니다.");
                Main.tc.Add(Main.m_go + " / " + Main.go_city + "→" + Main.away_city + " / " + Main.go_day + " " + s_Ticketing.s_time);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main.point[Main.user_num] += discount;
            if (textBox9.Text == "") textBox9.Text = "0";
            if (Convert.ToInt32(textBox9.Text) > Main.point[Main.user_num])
                MessageBox.Show("보유한 포인트를 초과하여 사용할 수 없습니다.");
            else
            {
                discount = Convert.ToInt32(textBox9.Text);
                Main.point[Main.user_num] -= discount;
                if (Main.m_go.Equals("편도"))
                {
                    panel3.Visible = false;
                    label33.Text = (Seat.price[0] - discount).ToString();
                }
                else
                {
                    label33.Text = ((Seat.price[0] + Seat.price[1] - discount)).ToString();
                }
                label39.Text = Main.point[Main.user_num].ToString();
            }
        }

        private void textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
