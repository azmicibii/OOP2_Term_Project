using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel.Syndication;
using System.Xml;
using System.Text.RegularExpressions;
using System.Net;

namespace OnlineBookStore
{
    public partial class BookForm : Form
    {
        Book book;
        public BookForm(Book book)
        {
            this.book = book;
            InitializeComponent();
            this.Text = book.name;
            
            name.Text = book.name;
            author.Text = book.Author;
            publisher.Text = book.Publisher;
            category.Text = "Category:" + book.Category;
            page.Text = "Page:" + book.Page;
            if (book.Sale > 0 && book.Sale < 100)
                price1.Text = book.price + " TL  %" + book.Sale;
            else
                price1.Text = "";
            price2.Text = (book.price - book.price * (book.Sale / 100)) + " TL";
            label2.Text = book.Description;
            picBox.Image = book.image;
            picBox.SizeMode = PictureBoxSizeMode.Zoom;
            mtQuantity.Text = "01";
        }

        private void pbAddCart_Click(object sender, EventArgs e)
        {

            Logger.logger(book.name + " Form Addcart");
            if (mtQuantity.Text != "" && int.Parse(mtQuantity.Text) != 0)
            {
                foreach (var it in MainForm.shoppingCart.ItemsToPurchase)
                {
                    if (it.Product == this.book) {
                        it.Quantity += int.Parse(mtQuantity.Text);

                        if (it.Quantity > 99)
                        {
                            MessageBox.Show("You have reached maximum capacity." + Environment.NewLine + "Max Capacity: 99", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            it.Quantity = 99;
                        }

                        MessageBox.Show(int.Parse(mtQuantity.Text) + " " + it.Product.name + " has been added to your shopping cart.", "Info");
                        return;
                    }
                }
                ItemToPurchase item = new ItemToPurchase();
                item.Product = this.book;
                item.Quantity = int.Parse(mtQuantity.Text);
                MainForm.shoppingCart.ItemsToPurchase.Add(item);
                MessageBox.Show(item.Quantity + " " + item.Product.name + " has been added to your shopping cart.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lblInc_Click(object sender, EventArgs e)
        {

            Logger.logger(book.name + " Form Increment");
            if (mtQuantity.Text == "")
                mtQuantity.Text = "01";
               
                int quantity = int.Parse(mtQuantity.Text);
                quantity++;
                if (quantity == 100)
                {
                    quantity = 99;
                }
                mtQuantity.Text = quantity.ToString();
            if (quantity < 10)
                mtQuantity.Text = "0" + quantity.ToString();
            else
                mtQuantity.Text = quantity.ToString();
        }

        private void lblDec_Click(object sender, EventArgs e)
        {

            Logger.logger(book.name + " Form Decrement");
            if (mtQuantity.Text == "")
                mtQuantity.Text = "01";
            int quantity = int.Parse(mtQuantity.Text);
            quantity--;
            if (quantity == 0)
                quantity = 1;
            if (quantity < 10)
                mtQuantity.Text = "0" + quantity.ToString();
            else
                mtQuantity.Text = quantity.ToString();
        }
    }
}
