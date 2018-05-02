using System;
using System.Net;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (var stream = client.OpenRead("http://www.google.com"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
        private void pbLogin_Click(object sender, EventArgs e)
        {
            DataBaseHandler dh = DataBaseHandler.getInstance();
            Customer logined = Customer.getInstance();
            Customer customer = dh.CustomerHandler(txtUsername.Text,txtPassword.Text);
            if (customer != null)
            {
                this.Hide();
                logined = customer;
                Logger.logger("Login");
                MainForm mainform = new MainForm();
                mainform.ShowDialog();
                mainform = null;
                GC.Collect();
                txtUsername.Clear();
                txtPassword.Clear();
                this.Show();
            }
            else
                MessageBox.Show("Wrong Username or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

  

        private void pbShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
                txtPassword.PasswordChar ='\0';
        }

        private void pbShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void signUpLink(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signUp sign = new signUp();
            this.Hide();
            if(sign.ShowDialog() == DialogResult.OK)
                MessageBox.Show("Sign up successfully. You can use your new account.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Show();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                pbLogin_Click(this.pbLogin, null);               
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            if (!CheckForInternetConnection())
            {
                MessageBox.Show("You have no internet connection. Application will be closed now.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            MessageBox.Show("Welcome to our Online Book Store application. You can simply sign up and use. If you want to login as a root user.You can use our root account. Username:root Password:123","Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
