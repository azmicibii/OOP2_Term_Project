using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace OnlineBookStore
{
    class DataBaseHandler
    {
        static private DataBaseHandler dh;
        private DataBaseHandler() { }
        public static DataBaseHandler getInstance()
        {
            if (dh == null)
                dh = new DataBaseHandler();
            return dh;
        }

        SqlConnection connection = new SqlConnection("Data Source = mssql5.gear.host; Initial Catalog = onlinebookstore; User Id=azmicibi; Password=123456*");
        public void CustomerUpdate(Customer cstmr)
        {
            string kayit = "UPDATE Customer SET Name=@Name,Address=@Address,Email=@Email,Username=@Username,Password=@Password,Gender=@Gender,Purchases=@Purchases where ID=@ID";
            dh.connection.Open();
            SqlCommand cmd = new SqlCommand(kayit, connection);
            cmd.Parameters.AddWithValue("ID", cstmr.Id);
            cmd.Parameters.AddWithValue("Name", cstmr.Name);
            cmd.Parameters.AddWithValue("Address", cstmr.Adress);
            cmd.Parameters.AddWithValue("Email", cstmr.Email);
            cmd.Parameters.AddWithValue("Username", cstmr.Username);
            cmd.Parameters.AddWithValue("Password", cstmr.Password);
            cmd.Parameters.AddWithValue("Gender", cstmr.Gender);
            cmd.Parameters.AddWithValue("Purchases", cstmr.PurchCount);
            cmd.ExecuteNonQuery();
            dh.connection.Close();
        }
        public Customer CustomerHandler(string username, string password)
        {
            Customer customer = null;
            try
            {
                dh.connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Customer] where Username = @UserName", connection);
                command.Parameters.AddWithValue("UserName", username);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (password == (string)reader["Password"])
                {
                    customer = Customer.getInstance();
                    customer.Id = (int)reader["ID"];
                    customer.Name = (string)reader["Name"];
                    customer.Adress = (string)reader["Address"];
                    customer.Email = (string)reader["Email"];
                    customer.Username = (string)reader["Username"];
                    customer.Password = (string)reader["Password"];
                    customer.Gender = (bool)reader["Gender"];
                    if(!DBNull.Value.Equals(reader["Purchases"]))
                        customer.PurchCount = (int)reader["Purchases"];
                    if ((bool)reader["Isroot"])
                        MainForm.Isroot = true;
                    else
                        MainForm.Isroot = false;
                    try
                    {
                        customer.Image = Image.FromFile(Application.StartupPath + @"\Resources\ProfilePictures\" + customer.Username + ".png");
                    }
                    catch (Exception)
                    {
                        if (customer.Gender)
                            customer.Image = OnlineBookStore.Properties.Resources.male;
                        else
                            customer.Image = OnlineBookStore.Properties.Resources.female;
                    }

                }
            }
            catch (InvalidOperationException)
            {
                    //Do nothing
            }
            catch (Exception ex)
            {
                MessageBox.Show("Server Connection Crashed, Please try again. \n" + ex.Message, "Connection Crashed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dh.connection.Close();
            return customer;
        }

        public List<Product> BookLoader()
        {
            List<Product> booklist = new List<Product>();
            dh.connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Book]", connection);
            SqlDataReader reader = command.ExecuteReader();
            Book bk;
            while (reader.Read())
            {
                bk = new Book();
                bk.ProductID = (int)reader["ID"];
                bk.name = (string)reader["Name"];
                bk.Author = (string)reader["Author"];
                bk.Publisher = (string)reader["Publisher"];
                bk.Page = (int)reader["Page"];
                bk.price = (double)reader["Price"];
                bk.Sale = (double)reader["Sale"];

                if (bk.Sale <= 0 || bk.Sale >= 100)
                    bk.discountedPrice = bk.price;
                else
                    bk.discountedPrice = bk.price - (bk.price * bk.Sale) / 100;

                bk.Category = (string)reader["Category"];
                bk.Description = (string)reader["Description"];
                try
                {
                    bk.image = Image.FromFile(Application.StartupPath + @"\Resources\BookPictures\" + (string)reader["ImageName"] + ".png");
                }
                catch (Exception)
                {
                    bk.image = Properties.Resources.noimage;
                }
                booklist.Add(bk);
            }
            dh.connection.Close();
            return booklist;
            
        }
        public List<Product> MusicCDLoader()
        {
            List<Product> musiclist = new List<Product>();
            dh.connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[MusicCD]", connection);
            SqlDataReader reader = command.ExecuteReader();
            MusicCD mc;
            while (reader.Read())
            {
                mc = new MusicCD();
                mc.ProductID = (int)reader["ID"];
                mc.name = (string)reader["Name"];
                mc.Singer = (string)reader["Singer"];
                mc.Description = (string)reader["Description"];
                mc.demo = (string)reader["Demo"];
                mc.price = (double)reader["Price"];
                mc.Sale = (double)reader["Sale"];

                if (mc.Sale <= 0 || mc.Sale >= 100)
                    mc.discountedPrice = mc.price;
                else
                    mc.discountedPrice = mc.price-(mc.price * mc.Sale) / 100;

                mc.Category = (string)reader["Category"];
                try
                {
                    mc.image = Image.FromFile(Application.StartupPath + @"\Resources\MusicCdPictures\" + (string)reader["Image"] + ".png");
                }
                catch (Exception)
                {
                    mc.image = Properties.Resources.noimage;
                }              
                musiclist.Add(mc);
            }
            dh.connection.Close();
            return musiclist;

        }
        public List<Product> MagazineLoader()
        {
            List<Product> magazinelist = new List<Product>();
            dh.connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Magazine]", connection);
            SqlDataReader reader = command.ExecuteReader();
            Magazine mg;
            while (reader.Read())
            {
                mg = new Magazine();
                mg.ProductID = (int)reader["ID"];
                mg.name = (string)reader["Name"];           
                mg.Description = (string)reader["Description"];
                mg.Issue = "Issue: " + reader["Issue"];
                mg.price = (double)reader["Price"];
                mg.Sale = (double)reader["Sale"];

                if (mg.Sale <= 0 || mg.Sale >= 100)
                    mg.discountedPrice = mg.price;
                else
                    mg.discountedPrice = mg.price - (mg.price * mg.Sale) / 100;

                mg.Category = (string)reader["Category"];
                try
                {
                    mg.image = Image.FromFile(Application.StartupPath + @"\Resources\MagazinePictures\" + (string)reader["Image"] + ".png");
                }
                catch (Exception)
                {
                    mg.image = Properties.Resources.noimage;
                }
               
                magazinelist.Add(mg);
            }
            dh.connection.Close();
            return magazinelist;

        }

        public void DbUpdate(string[] values, string command)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand(command, connection);
            for (int i = 0; i < values.Length; i++)
            {
                cmd.Parameters.AddWithValue("" + i, values[i]);
            }
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
