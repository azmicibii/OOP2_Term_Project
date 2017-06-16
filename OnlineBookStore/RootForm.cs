using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace OnlineBookStore
{
    public partial class RootForm : Form
    {
        SqlConnection connection = new SqlConnection("Data Source =mssql5.gear.host; Initial Catalog = onlinebookstore;User Id=azmicibi;Password=123456*");
        DataSet dataset;
        SqlDataAdapter adapter;
        SqlCommand cmd;
        int index;
        static TextBox[] customerTextArray;
        static TextBox[] bookTextArray;
        static TextBox[] magazineTextArray;
        static TextBox[] musicCDTextArray;
        DataBaseHandler dh;

        bool demoSelected = false;
        string ImageDest;
        string DemoText;
        public void Refresh()
        {
            dataset.Clear();
            dh = DataBaseHandler.getInstance();
            cmd = new SqlCommand("SELECT * FROM [Book]; SELECT * FROM [Customer];SELECT * FROM [MusicCD];SELECT * FROM [Magazine];", connection);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataset);
        }
        public RootForm()
        {
            InitializeComponent();
            dh = DataBaseHandler.getInstance();
            dataset = new DataSet();
            cmd = new SqlCommand("SELECT * FROM [Book]; SELECT * FROM [Customer];SELECT * FROM [MusicCD];SELECT * FROM [Magazine];", connection);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataset);
            dtgBook.DataSource = dataset.Tables[0];
            dtgCustomer.DataSource = dataset.Tables[1];
            dtgMusicCd.DataSource = dataset.Tables[2];
            dtgMagazine.DataSource = dataset.Tables[3];
            dtgCustomer.SelectAll();
            customerTextArray = new TextBox[] {  txtCustomerName,txtAddress, txtEmail,txtUserName,  txtPassword };
            bookTextArray = new TextBox[] { txtBookName, txtAuthor, txtPublisher, txtPage, txtBookPrice, txtBookSale, txtBookCategory, txtBookDescription, txtImageName };
            magazineTextArray = new TextBox[] { txtMagazineName, txtMagazineCategory,txtMagazinePrice, txtMagazineSale, txtIssue, txtMagazineImage,txtMagazineDescription };
            musicCDTextArray = new TextBox[] { txtMusicName, txtSinger, txtMusicDescription, txtMusicPrice, txtMusicSale,txtMusicCategory,txtMusicImage,txtDemo };
            btnAddBook.Enabled = false;
            btnAddMagazine.Enabled = false;
            btnAddMusicCD.Enabled = false;
            btnBookUpdate.Enabled = false;
            btnBookDelete.Enabled = false;
            btnMagazineDelete.Enabled = false;
            btnUpdateMagazine.Enabled = false;
            btnMusicDelete.Enabled = false;
            btnMusicUpdate.Enabled = false;
            btnCustomerDelete.Enabled = false;
            btnCustUpdate.Enabled = false;
            btnBookImageChange.Enabled = false;
            btnMagazinemageChange.Enabled = false;
            btnMusicCDChangeImage.Enabled = false;
            btnAddDemo.Enabled = false;
        }
        
        private void dtgCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            index = e.RowIndex;
            btnCustomerDelete.Enabled = true;
            btnCustUpdate.Enabled = true;
            DataGridViewRow row = dtgCustomer.Rows[index];
                DataGridViewCellCollection cells = row.Cells;
                txtCustomerName.Text = cells[1].Value.ToString();
                txtAddress.Text = cells[2].Value.ToString();
                txtEmail.Text = cells[3].Value.ToString();
                txtUserName.Text = cells[4].Value.ToString();
                txtPassword.Text = cells[5].Value.ToString();
                if ((bool)cells[8].Value)
                    cbIsRoot.Checked = true;
                else
                    cbIsRoot.Checked = false;
            try
            {
                imgCustomer.Image = Image.FromFile(Application.StartupPath + @"\Resources\ProfilePictures\" + cells[4].Value + ".png");
            }
            catch (Exception)
            {
                if ((bool)cells[6].Value)
                    imgCustomer.Image = OnlineBookStore.Properties.Resources.male;
                else
                    imgCustomer.Image = OnlineBookStore.Properties.Resources.female;
            }

        }

        private void dtgBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            btnAddBook.Enabled = false;
            btnBookUpdate.Enabled = true;
            btnBookDelete.Enabled = true;
            btnBookImageChange.Enabled = false;
            if (index == dtgBook.RowCount - 1)
            {
                imgBook.Image = null;
                btnAddBook.Enabled = true;
                btnBookUpdate.Enabled = false;
                btnBookDelete.Enabled = false;
                btnBookImageChange.Enabled = true;
            }
            DataGridViewRow row = dtgBook.Rows[index];
            DataGridViewCellCollection cells = row.Cells;
            txtBookName.Text = cells[1].Value.ToString();
            txtAuthor.Text = cells[2].Value.ToString();
            txtPublisher.Text = cells[3].Value.ToString();
            txtPage.Text = cells[4].Value.ToString();
            txtBookPrice.Text = cells[5].Value.ToString();
            txtBookSale.Text = cells[6].Value.ToString();
            txtBookCategory.Text = cells[7].Value.ToString();
            txtBookDescription.Text = cells[8].Value.ToString();
            txtImageName.Text = cells[9].Value.ToString();
            if (index != dtgBook.RowCount - 1)
            {
                try
                {
                    imgBook.Image = Image.FromFile(Application.StartupPath + @"\Resources\BookPictures\" + txtImageName.Text + ".png");
                }
                catch (Exception)
                {
                    imgBook.Image = Properties.Resources.noimage;
                }
            }
               
        }

        private void dtgMagazines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            btnAddMagazine.Enabled = false;
            btnMagazineDelete.Enabled = true;
            btnUpdateMagazine.Enabled = true;
            btnMagazinemageChange.Enabled = false;
            if (index == dtgMagazine.RowCount - 1)
            {
                imgMagazine.Image = null;
                btnAddMagazine.Enabled = true;
                btnMagazineDelete.Enabled = false;
                btnUpdateMagazine.Enabled = false;
                btnMagazinemageChange.Enabled = true;
            }
            DataGridViewRow row = dtgMagazine.Rows[index];
            DataGridViewCellCollection cells = row.Cells;
            txtMagazineName.Text = cells[1].Value.ToString();
            txtMagazineCategory.Text = cells[2].Value.ToString();
            txtMagazinePrice.Text = cells[3].Value.ToString();
            txtMagazineSale.Text = cells[4].Value.ToString();
            txtIssue.Text = cells[5].Value.ToString();
            txtMagazineImage.Text = cells[6].Value.ToString();
            txtMagazineDescription.Text = cells[7].Value.ToString();
            if (index != dtgMagazine.RowCount - 1)
            {
                try
                {
                    imgMagazine.Image = Image.FromFile(Application.StartupPath + @"\Resources\MagazinePictures\" + txtMagazineImage.Text + ".png");
                }
                catch (Exception)
                {
                    imgMagazine.Image = Properties.Resources.noimage;
                }
            }
        }

        private void dtgMusicCd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            btnAddMusicCD.Enabled = false;
            btnMusicUpdate.Enabled = true;
            btnMusicDelete.Enabled = true;
            btnMusicCDChangeImage.Enabled = false;
            btnAddDemo.Enabled = false;
            if (index == dtgMusicCd.RowCount - 1)
            {
                imgMusicCD.Image = null;
                btnAddMusicCD.Enabled = true;
                btnMusicUpdate.Enabled = false;
                btnMusicDelete.Enabled = false;
                btnMusicCDChangeImage.Enabled = true;
                btnAddDemo.Enabled = true;
            }
            DataGridViewRow row = dtgMusicCd.Rows[index];
            DataGridViewCellCollection cells = row.Cells;
            txtMusicName.Text = cells[1].Value.ToString();
            txtSinger.Text = cells[2].Value.ToString();
            txtMusicDescription.Text = cells[3].Value.ToString();
            txtMusicPrice.Text = cells[4].Value.ToString();
            txtMusicSale.Text = cells[5].Value.ToString();
            txtMusicCategory.Text = cells[6].Value.ToString();
            txtMusicImage.Text = cells[7].Value.ToString();
            txtDemo.Text = cells[8].Value.ToString();
            if (index != dtgMusicCd.RowCount - 1)
            {
                try
                {
                    imgMusicCD.Image = Image.FromFile(Application.StartupPath + @"\Resources\MusicCdPictures\" + txtMusicImage.Text + ".png");
                }
                catch (Exception)
                {
                    imgMusicCD.Image = Properties.Resources.noimage;
                }
            }
            demoSelected = false;
        }

        private void btnCustUpdate_Click_1(object sender, EventArgs e)
        {
            if (!checkWhiteSpace(customerTextArray) || !IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("There are invalid data. Please fill all fields and/or enter a valid mail.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string kayit = "UPDATE Customer SET Name=@Name,Address=@Address,Email=@Email,Username=@Username,Password=@Password,Gender=@Gender,Purchases=@Purchases,IsRoot=@IsRoot where ID=@ID";
            connection.Open();
            SqlCommand cmd = new SqlCommand(kayit, connection);

            DataGridViewRow row = dtgCustomer.Rows[index];
            cmd.Parameters.AddWithValue("ID", row.Cells[0].Value);
            cmd.Parameters.AddWithValue("Name",txtCustomerName.Text);
            cmd.Parameters.AddWithValue("Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("Username", txtUserName.Text);
            cmd.Parameters.AddWithValue("Password", txtPassword.Text);
            cmd.Parameters.AddWithValue("Gender", row.Cells[6].Value);
            cmd.Parameters.AddWithValue("Purchases", row.Cells[7].Value);
            if(cbIsRoot.Checked)
                cmd.Parameters.AddWithValue("IsRoot", 1);
            else
                cmd.Parameters.AddWithValue("IsRoot", 0);
            cmd.ExecuteNonQuery();
            connection.Close();
            Refresh();
        }

        private void btnBookUpdate_Click(object sender, EventArgs e)
        {
            if (!checkWhiteSpace(bookTextArray))
            {
                MessageBox.Show("There are invalid data. Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataGridViewRow row = dtgBook.Rows[index];
            string kayit = "UPDATE Book SET Name=@1,Author=@2,Publisher=@3,Page=@4,Price=@5,Sale=@6,Category=@7,Description=@8,ImageName=@9 where ID=@0";
            string[] values = { row.Cells[0].Value.ToString(), txtBookName.Text, txtAuthor.Text, txtPublisher.Text, txtPage.Text, txtBookPrice.Text, txtBookSale.Text,
                txtBookCategory.Text, txtBookDescription.Text, txtImageName.Text };
            dh.DbUpdate(values, kayit);
            Refresh();
        }

        private void btnUpdateMagazine_Click(object sender, EventArgs e)
        {
            if (!checkWhiteSpace(magazineTextArray))
            {
                MessageBox.Show("There are invalid data. Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string kayit = "UPDATE Magazine SET Name=@1,Category=@2,Price=@3,Sale=@4,Issue=@5,Image=@6,Description=@7 where ID=@0";
            DataGridViewRow row = dtgMagazine.Rows[index];
            string[] values = { row.Cells[0].Value.ToString(), txtMagazineName.Text, txtMagazineCategory.Text, txtMagazinePrice.Text, txtMagazineSale.Text,
                txtIssue.Text, txtMagazineImage.Text, txtMagazineDescription.Text };
            dh.DbUpdate(values, kayit);
            Refresh();
        }

        private void btnMusicUpdate_Click(object sender, EventArgs e)
        {
            if (!checkWhiteSpace(musicCDTextArray))
            {
                MessageBox.Show("There are invalid data. Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string kayit = "UPDATE MusicCD SET Name=@1,Singer=@2,Description=@3,Sale=@4,Price=@5,Image=@6,Category=@7,Demo=@8 where ID=@0";
            DataGridViewRow row = dtgMusicCd.Rows[index];
            string[] values = { row.Cells[0].Value.ToString(), txtMusicName.Text, txtSinger.Text, txtMusicDescription.Text, txtMusicSale.Text, txtMusicPrice.Text,
                txtMusicImage.Text, txtMusicCategory.Text, txtDemo.Text };
            dh.DbUpdate(values, kayit);
            Refresh();
        }

        private void txtNameControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) || System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }

        }
        private void DeleteButton(object sender, EventArgs e)
        {
            string table="";
            string Id;
           
            var btn = sender as Button;
            if (btn.Name == "btnCustomerDelete")
            {
                Customer cstmr = Customer.getInstance();
                 table = "[Customer]";
                DataGridViewRow row = dtgCustomer.Rows[index];
                
                Id = row.Cells[0].Value.ToString();
                if(Id==cstmr.Id.ToString())
                {
                    MessageBox.Show("You can't delete yourself.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
               
            else if (btn.Name == "btnBookDelete")
            {
                table = "[Book]";
                DataGridViewRow row = dtgBook.Rows[index];
                Id = row.Cells[0].Value.ToString();
            }
            else if (btn.Name == "btnMusicDelete")
            {
                table = "[MusicCD]";
                DataGridViewRow row = dtgMusicCd.Rows[index];
                Id = row.Cells[0].Value.ToString();
            }
            else
            {
                table = "[Magazine]";
                DataGridViewRow row = dtgMagazine.Rows[index];
                Id = row.Cells[0].Value.ToString();
            }
            connection.Open();
            string command = "DELETE FROM " + table + " WHERE ID = '" + Id + "'";
            SqlCommand cmd = new SqlCommand(command, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            Refresh();

        }
        private void txtCharacterControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
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

        private bool checkWhiteSpace(TextBox[] array)
        {
            foreach (var item in array)
            {
                if (string.IsNullOrWhiteSpace(item.Text))
                    return false;
            }
            return true;
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (!checkWhiteSpace(bookTextArray))
            {
                MessageBox.Show("There are invalid data. Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string cmdString = "INSERT INTO Book (Name,Author,Publisher, Page, Price, Sale, Category, Description, ImageName) VALUES (@0, @1, @2, @3,@4, @5, @6, @7, @8)";
            string[] values = new string[bookTextArray.Length];
            for (int i = 0; i < bookTextArray.Length; i++)
            {
                values[i] = bookTextArray[i].Text;
            }
            if(ImageDest != null)
            {
                string destPath = Application.StartupPath + @"\Resources\BookPictures\" + txtImageName.Text + ".png";
                Directory.CreateDirectory(Application.StartupPath + @"\Resources\BookPictures\");
                File.Copy(ImageDest, destPath, true);
                ImageDest = null;
            }
            dh.DbUpdate(values, cmdString);
            Refresh();
        }

        private void btnAddMagazine_Click(object sender, EventArgs e)
        {
            if (!checkWhiteSpace(magazineTextArray))
            {
                MessageBox.Show("There are invalid data. Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string cmdString = "INSERT INTO Magazine (Name,Category,Price, Sale, Issue, Image, Description) VALUES (@0, @1, @2, @3,@4, @5, @6)";
            string[] values = new string[magazineTextArray.Length];
            for (int i = 0; i < magazineTextArray.Length; i++)
            {
                values[i] = magazineTextArray[i].Text;
            }
            if (ImageDest != null)
            {
                string destPath = Application.StartupPath + @"\Resources\MagazinePictures\" + txtMagazineImage.Text + ".png";
                Directory.CreateDirectory(Application.StartupPath + @"\Resources\MagazinePictures\");
                File.Copy(ImageDest, destPath, true);
                ImageDest = null;
            }
            dh.DbUpdate(values, cmdString);
            Refresh();
        }

        private void btnAddMusicCD_Click(object sender, EventArgs e)
        {
            if (!checkWhiteSpace(musicCDTextArray))
            {
                MessageBox.Show("There are invalid data. Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!demoSelected)
            {
                DialogResult dr = MessageBox.Show("You haven't select any demo. Do you want to select now?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    btnAddDemo.PerformClick();
                    return;
                }
            }
            string cmdString = "INSERT INTO MusicCD (Name, Singer, Description,Price, Sale, Category, Image,Demo) VALUES (@0, @1, @2, @3,@4, @5, @6, @7)";
            string[] values = new string[musicCDTextArray.Length];
            for (int i = 0; i < musicCDTextArray.Length; i++)
            {
                values[i] = musicCDTextArray[i].Text;
            }
            if (ImageDest != null)
            {
                string destPath = Application.StartupPath + @"\Resources\MusicCdPictures\" + txtMusicImage.Text + ".png";
                Directory.CreateDirectory(Application.StartupPath + @"\Resources\MusicCdPictures\");
                File.Copy(ImageDest, destPath, true);
                ImageDest = null;
            }

            if (DemoText != null)
            {
                string destPath = Application.StartupPath + @"\Resources\Demos\" + txtDemo.Text + ".wav";
                Directory.CreateDirectory(Application.StartupPath + @"\Resources\Demos\");
                File.Copy(DemoText, destPath, true);
                DemoText = null;
            }
            dh.DbUpdate(values, cmdString);
            demoSelected = false;
            Refresh();
        }

        private void btnImageChange_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Multiselect = false;
                openFileDialog1.Filter = "PNG Files (*.png) | *.png";
                openFileDialog1.ShowDialog();
                ImageDest = openFileDialog1.FileName;
                var btn = sender as Button;
                if (btn == btnBookImageChange)
                    imgBook.Image = Image.FromFile(ImageDest);
                else if(btn == btnMagazinemageChange)
                    imgMagazine.Image = Image.FromFile(ImageDest);
                else
                    imgMusicCD.Image = Image.FromFile(ImageDest);
            }
            catch (Exception)
            {

            }
        }

        private void btnAddDemo_Click(object sender, EventArgs e)
        {
            if (demoSelected)
            {
                DialogResult dr = MessageBox.Show("You have already selected a demo. Do you want to change it?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                    return;
            }
           
            try
            {
                openFileDialog1.Multiselect = false;
                openFileDialog1.Filter = "WAV Files (*.wav) | *.wav";
                openFileDialog1.ShowDialog();
                DemoText = openFileDialog1.FileName;
                demoSelected = true;
            }
            catch (Exception)
            {

            }
        }

        private void tbControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridViewCellEventArgs a = new DataGridViewCellEventArgs(0,0);
            
            if(tbControl.SelectedIndex == 0)
            {
                dtgCustomer.ClearSelection();
                dtgCustomer_CellClick(dtgCustomer, a);
            }
            else if (tbControl.SelectedIndex ==1)
            {
                dtgBook.ClearSelection();
                dtgBook_CellClick(dtgBook, a);
            }
            else if (tbControl.SelectedIndex == 2)
            {
                dtgMagazine.ClearSelection();
                dtgMagazines_CellClick(dtgMagazine, a);
            }
            else 
            {
                dtgMusicCd.ClearSelection();
                dtgMusicCd_CellClick(dtgMusicCd, a);
            }
        }

        private void DigitControl(object sender,KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void PageControl(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            
        }

        private void cbIsRoot_CheckedChanged(object sender, EventArgs e)
        {
            Customer cstmr = Customer.getInstance();

            if (txtUserName.Text == cstmr.Username && cbIsRoot.Checked==false)
            {
                DialogResult dr=MessageBox.Show("If you do this you will lose your root access. Do you want to proceed?.","Info",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    btnCustUpdate.PerformClick();
                    MainForm.Isroot = false;
                    this.Close();
                }
                else
                    cbIsRoot.Checked = true;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
