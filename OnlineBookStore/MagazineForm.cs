using System;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class MagazineForm : Form
    {
        Magazine magazine;
        public MagazineForm(Magazine magazine)
        {
            
            InitializeComponent();
            this.magazine = magazine;
            this.Text = magazine.name;

            picBox.Image = magazine.image;
            picBox.SizeMode = PictureBoxSizeMode.Zoom;
            mtQuantity.Text = "01";

            name.Text = magazine.name;
            issue.Text = magazine.Issue;
            category.Text = "Category:" + magazine.Category;

            if (magazine.Sale > 0 && magazine.Sale < 100)
                price1.Text = magazine.price + " TL  %" + magazine.Sale;
            else
                price1.Text = "";

            price2.Text = (magazine.price - magazine.price * (magazine.Sale / 100)) + " TL";
            lblDescription.Text = "";

            string[] descriptionText = magazine.Description.Split('$');
            for (int i = 0; i < descriptionText.Length; i++)
            {
                lblDescription.Text += descriptionText[i] + Environment.NewLine;
            }
        }

        private void pbAddCart_Click(object sender, EventArgs e)
        {

            Logger.logger(magazine.name+" Form Add Cart");
            foreach (var it in MainForm.shoppingCart.ItemsToPurchase)
            {
                if (it.Product == this.magazine)
                {
                    it.Quantity += int.Parse(mtQuantity.Text);

                    if (it.Quantity > 99)
                    {
                        MessageBox.Show("You have reached maximum capacity." + Environment.NewLine + "Max Capacity: 99", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        it.Quantity = 99;
                    }

                    MessageBox.Show(int.Parse(mtQuantity.Text) + " " + it.Product.name + " has been added to your shopping cart.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            if (mtQuantity.Text != "" && int.Parse(mtQuantity.Text) != 0)
            {
                ItemToPurchase item = new ItemToPurchase();
                item.Product = this.magazine;
                item.Quantity = int.Parse(mtQuantity.Text);
                MainForm.shoppingCart.ItemsToPurchase.Add(item);
                MessageBox.Show(item.Quantity + " " + item.Product.name + " has been added to your shopping cart.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lblDec_Click(object sender, EventArgs e)
        {

            Logger.logger(magazine.name + " Form Decrement");
            if (mtQuantity.Text == "")
                mtQuantity.Text = "01";
            int quantity = int.Parse(mtQuantity.Text);
            quantity--;
            if (quantity == 0)
                quantity = 1;
            if(quantity < 10)
                mtQuantity.Text = "0" + quantity.ToString();
            else
            mtQuantity.Text = quantity.ToString();
        }

        private void lblInc_Click(object sender, EventArgs e)
        {

            Logger.logger(magazine.name + " Form Increment");
            if (mtQuantity.Text == "")
                mtQuantity.Text = "01";
            int quantity = int.Parse(mtQuantity.Text);
            quantity++;
            if (quantity == 100)
            {
                quantity = 99;
            }
            if (quantity < 10)
                mtQuantity.Text = "0" + quantity.ToString();
            else
                mtQuantity.Text = quantity.ToString();
        }
    }
}
