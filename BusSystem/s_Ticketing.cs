using System;
using System.Globalization;
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
        private int i;
        Seat seat;

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
        }

        private void listView1_DoubleClick(object sender, System.EventArgs e)
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
                        break;
                    case DialogResult.Cancel:
                        this.Close();
                        break;
                }
                Payment payment = new Payment();
                switch (payment.ShowDialog())
                {
                    case DialogResult.OK:
                        break;
                    case DialogResult.Cancel:
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
                        break;
                    case DialogResult.Cancel:
                        this.Close();
                        break;
                }
                a_Ticketing ticketing = new a_Ticketing();
                switch (ticketing.ShowDialog())
                {
                    case DialogResult.OK:
                        rt = true;
                        break;
                    case DialogResult.Cancel:
                        break;
                }
                switch (seat.ShowDialog())
                {
                    case DialogResult.OK:
                        break;
                    case DialogResult.Cancel:
                        this.Close();
                        break;
                }
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
            }
        }

        private void s_Ticketing_Load(object sender, EventArgs e)
        {
            MessageBox.Show(listView1.Items.Count.ToString());
            classfy = Main.grade;
            if (classfy.Equals("우등"))
            {
                for (i = 0; i < listView1.Items.Count; i++)
                    if (!(listView1.Items[i].SubItems[2].Text.Equals("우등")))
                    {
                        MessageBox.Show(listView1.Items[i].Text + " " + listView1.Items[i].SubItems[2].Text);
                        listView1.Items[i].Remove();
                    }
            }
            else if (classfy.Equals("프리미엄"))
            {
                for (i = 0; i < listView1.Items.Count; i++)
                    if (!(listView1.Items[i].SubItems[2].Text.Equals("프리미엄")))
                    {
                        MessageBox.Show(listView1.Items[i].Text + " " + listView1.Items[i].SubItems[2].Text);
                        listView1.Items[i].Remove();
                    }
            }
            else if (classfy.Equals("고속"))
            {
                for (i = 0; i < listView1.Items.Count; i++)
                    if (!(listView1.Items[i].SubItems[2].Text.Equals("고속")))
                    {
                        MessageBox.Show(listView1.Items[i].Text + " " + listView1.Items[2].SubItems[1].Text);
                        listView1.Items[i].Remove();
                    }
            }
        }
    }
}
