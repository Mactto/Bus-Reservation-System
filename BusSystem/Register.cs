using System.Windows.Forms;

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
                Main.id.Add(textBox2.Text);
                Main.pw.Add(textBox3.Text);
                Main.point.Add(3000);
                DialogResult = DialogResult.OK;
                MessageBox.Show("회원가입 성공!");
            }
            else
            {
                MessageBox.Show("필수 입력란을 모두 기입해주세요");
            }
        }
    }
}
