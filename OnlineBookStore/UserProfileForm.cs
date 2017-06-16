using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class UserProfileForm : Form
    {
        Customer cstmr;
        public UserProfileForm()
        {
            InitializeComponent();
        }

        private void UserProfileForm_Load(object sender, EventArgs e)
        {
            cstmr = Customer.getInstance();
            this.Text = cstmr.Name;
            txtName.Text = cstmr.Name;
            txtAddress.Text = cstmr.Adress;
            txtEmail.Text = cstmr.Email;
            txtPassword.Text = cstmr.Password;
            txtUsername.Text = cstmr.Username;
            proPic.Image = cstmr.Image;
            proPic.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtName.Text != cstmr.Name)
                btnUpdate.Enabled = true;
            else
                btnUpdate.Enabled = false;

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (txtAddress.Text != "" && txtAddress.Text != cstmr.Adress)
                btnUpdate.Enabled = true;
            else
                btnUpdate.Enabled = false;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (IsValidEmail(txtEmail.Text) && txtEmail.Text != cstmr.Email)
                btnUpdate.Enabled = true;
            else
                btnUpdate.Enabled = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "" && txtPassword.Text != cstmr.Password)
                btnUpdate.Enabled = true;
            else
                btnUpdate.Enabled = false;
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
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

   

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            Logger.logger("Profile Form Update");
            DataBaseHandler dh = DataBaseHandler.getInstance();

            cstmr.Name = txtName.Text;
            cstmr.Adress = txtAddress.Text;
            cstmr.Email = txtEmail.Text;
            cstmr.Password = txtPassword.Text;
            dh.CustomerUpdate(cstmr);
            MessageBox.Show("Your profile has been updated successfully.", "Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }

        private void pbShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        private void pbShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void btnChange_Click(object sender, EventArgs e)
        {

            Logger.logger("Profile Form Change");
            try
            {
                openFileDialog1.Multiselect = false;
                openFileDialog1.Filter = "All Files |*.png; *.jpeg;*.jpg| PNG Files (*.png)|*.png|JPEG Files (*.jpeg)|*.jpeg|JPG Files (*.jpg)|*.jpg";
                openFileDialog1.ShowDialog();
                string filepath = openFileDialog1.FileName;
                string destPath = Application.StartupPath + @"\Resources\ProfilePictures\" + cstmr.Username + ".png";

                if (openFileDialog1.SafeFileName.Contains("."))
                    cstmr.Image.Dispose();

                Directory.CreateDirectory(Application.StartupPath + @"\Resources\ProfilePictures\");
                File.Copy(filepath, destPath, true);

                cstmr.Image = Image.FromFile(filepath);

                proPic.Image = cstmr.Image;
            }
            catch (Exception)
            {

            }
        }
    }
}
