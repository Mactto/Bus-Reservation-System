using System;
using System.Windows.Forms;

namespace BusSystem
{
    public partial class s_Ticketing : Form
    {
        public static string s_time;
        public static string company;
        public static string grade;
        public static bool rt = false;
        private string classfy;
        public int[] seat_num;
        private int i;
        Seat seat;
        Random rand = new Random();

        public s_Ticketing()
        {
            InitializeComponent();
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            label1.Text = "가는 날 " + Main.go_day;
            if (Main.away_day == "") label2.Visible = false;
            else label2.Text = "오는 날 " + Main.away_day;
            label3.Text = Main.go_city;
            label4.Text = Main.away_city;
            label6.Text = Main.go_day;

            for(int i=0; i<Main.sn.Length; i++)
                Main.sn[i] = rand.Next(0, 36);
        }

        private void listView1_DoubleClick(object sender, System.EventArgs e)
        {
            if (listView1.SelectedItems[0].SubItems[3].Text == "0") MessageBox.Show("잔여석이 없습니다.");
            else
            {
                s_time = listView1.SelectedItems[0].SubItems[0].Text.ToString();
                company = listView1.SelectedItems[0].SubItems[1].Text.ToString();
                grade = listView1.SelectedItems[0].SubItems[2].Text.ToString();

                if (Main.m_go.Equals("편도"))
                {
                    seat = new Seat();
                    switch (seat.ShowDialog())
                    {
                        case DialogResult.OK:
                            ListView.SelectedIndexCollection idx = listView1.SelectedIndices;
                            string[] n = listView1.SelectedItems[0].SubItems[3].Text.Split(' ');
                            n[0] = (Convert.ToInt32(n[0]) - 1).ToString();
                            listView1.SelectedItems[0].SubItems[3].Text = n[0] + " 석";
                            this.Close();
                            Payment payment = new Payment();
                            switch (payment.ShowDialog())
                            {
                                case DialogResult.OK:
                                    break;
                                case DialogResult.Cancel:
                                    break;
                            }
                            break;
                        case DialogResult.Cancel:
                            this.Close();
                            break;
                    }
                }
                // 왕복일 때
                else
                {
                    seat = new Seat();
                    switch (seat.ShowDialog())
                    {
                        case DialogResult.OK:
                            int n = Convert.ToInt32(listView1.SelectedItems[0].SubItems[3].Text.Split(' '));
                            listView1.SelectedItems[0].SubItems[3].Text = n.ToString() + " 석";
                            this.Close();
                            a_Ticketing ticketing = new a_Ticketing();
                            switch (ticketing.ShowDialog())
                            {
                                case DialogResult.OK:
                                    rt = true;
                                    switch (seat.ShowDialog())
                                    {
                                        case DialogResult.OK:
                                            Payment payment = new Payment();
                                            switch (payment.ShowDialog())
                                            {
                                                case DialogResult.OK:
                                                    break;
                                                case DialogResult.Cancel:
                                                    this.DialogResult = DialogResult.OK;
                                                    this.Close();
                                                    break;
                                            }
                                            break;
                                        case DialogResult.Cancel:
                                            this.Close();
                                            break;
                                    }
                                    break;
                                case DialogResult.Cancel:
                                    break;
                            }
                            break;
                        case DialogResult.Cancel:
                            this.Close();
                            break;
                    }
                }
            }
        }

        private void s_Ticketing_Load(object sender, EventArgs e)
        {
            for(int i=0; i<Main.sn.Length; i++)
                listView1.Items[i].SubItems[3].Text = Main.sn[i].ToString() + " 석";

            classfy = Main.grade;
            if (classfy.Equals("우등"))
            {
                for (i = 0; i < listView1.Items.Count; i++)
                {
                    if (!(listView1.Items[i].SubItems[2].Text.Equals("우등")) && !(listView1.Items[i].SubItems[2].Text.Equals("심야우등")))
                    {
                        listView1.Items.RemoveAt(i);
                        i--;
                    }
                }
            }
            else if (classfy.Equals("프리미엄"))
            {
                for (i = 0; i < listView1.Items.Count; i++)
                {
                    if (!(listView1.Items[i].SubItems[2].Text.Equals("프리미엄")) && !(listView1.Items[i].SubItems[2].Text.Equals("심야프리미엄")))
                    {
                        listView1.Items.RemoveAt(i);
                        i--;
                    }
                }
            }
            else if (classfy.Equals("고속"))
            {
                for (i = 0; i < listView1.Items.Count; i++)
                {
                    if (!(listView1.Items[i].SubItems[2].Text.Equals("고속")))
                    {
                        listView1.Items.RemoveAt(i);
                        i--;
                    }
                }
            }
        }
    }
}
