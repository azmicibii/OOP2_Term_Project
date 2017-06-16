using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class signUp : Form
    {
        public signUp()
        {
            InitializeComponent();
        }

        private void signUp_Load(object sender, EventArgs e)
        {
            rbMale.Checked = true;
            this.Text = "Sign Up";
        }

        private void pbSignUp_Click(object sender, EventArgs e)
        {
          if(string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtAddress.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("There are empty fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           else if (!IsValidEmail(txtEmail.Text)) { 
                MessageBox.Show("Invalid Email Address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          else if( txtPassword.Text != txtReType.Text)
            {
                MessageBox.Show("Passwords are not matched.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection con = new SqlConnection("Data Source = mssql5.gear.host; Initial Catalog = onlinebookstore; User Id = azmicibi; Password = 123456*"))
                {
                    con.Open();

                    bool exists = false;

                    // create a command to check if the username exists
                    using (SqlCommand cmd = new SqlCommand("select count(*) from [dbo].[Customer] where Username = @UserName", con))
                    {
                        cmd.Parameters.AddWithValue("UserName", txtUsername.Text);
                        exists = (int)cmd.ExecuteScalar() > 0;
                    }
                    if (exists)
                    {
                        MessageBox.Show("This username has been using by another user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                        
                    else
                    {
                       
                        using (SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Customer] ([Name] ,[Address],[Email],[Username] ,[Password],[Gender]) VALUES (@Name, @Address, @Email, @Username, @Password, @Gender)", con))       
                        {
                            cmd.Parameters.AddWithValue("Name", txtName.Text);
                            cmd.Parameters.AddWithValue("Address", txtAddress.Text);
                            cmd.Parameters.AddWithValue("Email", txtEmail.Text);
                            cmd.Parameters.AddWithValue("Username", txtUsername.Text);
                            cmd.Parameters.AddWithValue("Password", txtPassword.Text);
                            cmd.Parameters.AddWithValue("Gender", rbMale.Checked);
                     
                            cmd.ExecuteNonQuery();
                        }
                    }
                    con.Close();
                    DialogResult = DialogResult.OK;
                }
            }
 

        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) || System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1) 
            {
                e.Handled = true;
            }

        }
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) || System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }
    }
}
