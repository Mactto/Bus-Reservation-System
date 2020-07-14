using System.Windows.Forms;
using System;

namespace BusSystem
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                if (textBox3.Text == textBox4.Text) MessageBox.Show("비밀번호가 일치하지 않습니다.");
                else if(!(Main.id.Contains(textBox2.Text)))
                {
                    Main.id.Add(textBox2.Text);
                    Main.pw.Add(textBox3.Text);
                    Main.point.Add(3000);
                    DialogResult = DialogResult.OK;
                    MessageBox.Show("회원가입 성공!");
                }
                else
                    MessageBox.Show("이미 존재하는 ID 입니다.");
            }
            else
            {
                MessageBox.Show("필수 입력란을 모두 기입해주세요");
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
