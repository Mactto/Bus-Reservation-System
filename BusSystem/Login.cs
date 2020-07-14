using System.Windows.Forms;

namespace BusSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            searchId.FlatAppearance.BorderSize = 0;
            searchPw.FlatAppearance.BorderSize = 0;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void loginBtn_Click(object sender, System.EventArgs e)
        {
            if (Main.id.Contains(textBox1.Text) && Main.pw.Contains(textBox2.Text))
            {
                this.DialogResult = DialogResult.OK;
                Main.username = textBox1.Text;
                Main.user_num = Main.id.IndexOf(textBox1.Text);
                MessageBox.Show("로그인 성공!");
            }
            else
            {
                MessageBox.Show("로그인에 실패하였습니다.");
            }
        }

        private void registerBtn_Click(object sender, System.EventArgs e)
        {
            Register registerForm = new Register();
            switch (registerForm.ShowDialog())
            {
                case DialogResult.OK:
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }

        private void search(object sender, System.EventArgs e)
        {
            Search search = new Search();
            switch (search.ShowDialog())
            {
                case DialogResult.OK:
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }
    }
}
