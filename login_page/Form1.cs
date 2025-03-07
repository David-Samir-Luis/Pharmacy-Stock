using login_page.Models;

namespace login_page
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {

            pass_txt.PasswordChar = checkBox.Checked ? '\0' : '*';
        }

        private void login_bt_Click(object sender, EventArgs e)
        {
            if (pass_txt.Text == "" || user_txt.Text == "")
            {
                MessageBox.Show("Please fill all blank fields",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ///TODO:check if pass and user name are right 
            if (true)
            {
                this.Hide();
                main_Form main_Form = new();
                main_Form.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Wrong Username or Password",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void user_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pass_txt.Focus();
            }
        }

        private void pass_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_bt.PerformClick();
            }
        }

        private void login_form_Load(object sender, EventArgs e)
        {
            DbServices.Instance.LoadAllDataAsync();
        }
    }
}
