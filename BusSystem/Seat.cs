using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BusSystem
{
    public partial class Seat : Form
    {
        public static List<Button> selected_buttons = new List<Button>();
        public static List<string> seat_num1 = new List<string>();
        public static List<string> seat_num2 = new List<string>();
        public static int[] price = { 0, 0 };
        private int count;
        private int m_count;

        public Seat()
        {
            InitializeComponent();
            label1.Text = "가는 날 " + Main.go_day;
            if (Main.away_day == "") label2.Visible = false;
            else label2.Text = "오는 날 " + Main.away_day;
            label3.Text = Main.go_city;
            label4.Text = Main.away_city;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public void updown_Click(object sender, System.EventArgs e)
        {
            int adult = Convert.ToInt32(numericUpDown1.Value);
            int youth = Convert.ToInt32(numericUpDown2.Value);
            int child = Convert.ToInt32(numericUpDown3.Value);
            count = (adult + youth + child);

            if (count < m_count)
            {
                MessageBox.Show("인원을 감소시킬 수 없습니다.");
                ((NumericUpDown)sender).Value++;
            }
            else
            {
                string check = s_Ticketing.grade;
                if (s_Ticketing.rt == true) check = a_Ticketing.grade;

                switch (check)
                {
                    case "프리미엄":
                        label7.Text = ((adult * 30300) + (youth * 25000) + (child * 20000)).ToString();
                        break;
                    case "우등":
                        label7.Text = ((adult * 27500) + (youth * 20000) + (child * 12000)).ToString();
                        break;
                    case "고속":
                        label7.Text = ((adult * 18600) + (youth * 12000) + (child * 8000)).ToString();
                        break;
                    case "심야프리미엄":
                        label7.Text = ((adult * 33000) + (youth * 25700) + (child * 15700)).ToString();
                        break;
                    case "심야우등":
                        label7.Text = ((adult * 30200) + (youth * 21700) + (child * 13700)).ToString();
                        break;
                }
                if (s_Ticketing.rt == false) price[0] = Convert.ToInt32(label7.Text);
                else price[1] = Convert.ToInt32(label7.Text);
            }
        }

        public void button_Click(object sender, System.EventArgs e)
        {
            if (((Button)sender).FlatAppearance.BorderSize == 1)
            {
                selected_buttons.Remove((Button)sender);
                ((Button)sender).FlatAppearance.BorderSize = 0;
                m_count--;
                if (s_Ticketing.rt == false) seat_num1.Remove(((Button)sender).Text);
                else seat_num2.Remove(((Button)sender).Text);
            }
            else
            {
                if (count == 0 || m_count >= count) MessageBox.Show("탑승 인원을 먼저 선택해주세요.");
                else
                {
                    selected_buttons.Add((Button)sender);
                    ((Button)sender).FlatAppearance.BorderColor = Color.Blue;
                    ((Button)sender).FlatAppearance.BorderSize = 1;
                    m_count++;
                    if (s_Ticketing.rt == false) seat_num1.Add(((Button)sender).Text.ToString());
                    else seat_num2.Add(((Button)sender).Text.ToString());
                }
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (count > 0 && count == m_count)
            {
                this.DialogResult = DialogResult.OK;
            }
            else MessageBox.Show("인원과 좌석 수를 선택해주세요.");
        }

        private void Seat_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            count = 0;
            m_count = 0;
            foreach (Button b in selected_buttons)
            {
                b.Enabled = false;
                b.BackgroundImage = ((Image)(Properties.Resources.캡처4));
            }
        }
    }
}
