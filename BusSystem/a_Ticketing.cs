using System;
using System.Windows.Forms;

namespace BusSystem
{
    public partial class a_Ticketing : Form
    {
        Random rand = new Random();
        public static string s_time;
        public static string company;
        public static string grade;

        public a_Ticketing()
        {
            InitializeComponent();
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            label1.Text = "가는 날 " + Main.go_day;
            if (Main.away_day == "") label2.Visible = false;
            else label2.Text = "오는 날 " + Main.away_day;
            label3.Text = Main.go_city;
            label4.Text = Main.away_city;
            label6.Text = Main.away_day;
            s_Ticketing.rt = true;
            for (int i = 0; i < Main.sn.Length; i++)
                Main.sn[i] = rand.Next(0, 36);
        }

        private void listView1_DoubleClick(object sender, System.EventArgs e)
        {
            s_time = listView1.SelectedItems[0].SubItems[0].Text.ToString();
            company = listView1.SelectedItems[0].SubItems[1].Text.ToString();
            grade = listView1.SelectedItems[0].SubItems[2].Text.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void a_Ticketing_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Main.sn.Length; i++)
                listView1.Items[i].SubItems[3].Text = Main.sn[i].ToString() + " 석";
        }
    }
}
