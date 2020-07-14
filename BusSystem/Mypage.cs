using System;
using System.Windows.Forms;

namespace BusSystem
{
    public partial class Mypage : Form
    {
        public static int index;

        public Mypage()
        {
            InitializeComponent();
        }

        private void Mypage_Load(object sender, EventArgs e)
        {
            label6.Text = Main.id[Main.user_num].ToString();
            label7.Text = Main.pw[Main.user_num].ToString();
            label8.Text = Main.point[Main.user_num].ToString();

            if (Main.tc.Count != 0)
            {
                foreach (string s in Main.tc)
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add(s);
                }
            }
            else
            {
                listBox1.Items.Add("예매 내역이 없습니다.");
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            index = ((ListBox)sender).SelectedIndex;
            T_cancel can = new T_cancel();
            switch(can.ShowDialog())
            {
                case DialogResult.OK:
                    this.Close();
                    break;
                case DialogResult.Cancel:
                    this.Close();
                    break;
            }
        }
    }
}
