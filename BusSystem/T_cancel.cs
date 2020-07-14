using System;
using System.Windows.Forms;

namespace BusSystem
{
    public partial class T_cancel : Form
    {
        public T_cancel()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main.point[Main.user_num] =Main.point[Main.user_num] + (3000 - Main.point[Main.user_num]);
            MessageBox.Show("취소 처리 되었습니다.");
            Main.tc.RemoveAt(Mypage.index);
            this.DialogResult = DialogResult.OK;
        }
    }
}
