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
    public partial class Mypage : Form
    {
        public Mypage()
        {
            InitializeComponent();
            label6.Text = Main.id[Main.user_num].ToString();
            label7.Text = Main.pw[Main.user_num].ToString();
            label8.Text = Main.point[Main.user_num].ToString();
        }

        private void Mypage_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Main.tc.Count.ToString());
            if (Main.tc.Count == 0)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("예매 내역이 없습니다.");
            }
            else
            {
                foreach (string s in Main.tc)
                    listBox1.Items.Add(s);
            }
        }
    }
}
