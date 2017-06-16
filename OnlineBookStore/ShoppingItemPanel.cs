using System;
using System.Drawing;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public class ShoppingItemPanel:Panel
    {
        Label lblItemName;
        Label lblItemType;
        Label lblPrice;
        Button btnRemoveItem;
        ComboBox cbQuantity;
        PictureBox pbThumbnail;
        public  ItemToPurchase item;
        public  ShoppingItemPanel(ItemToPurchase item)
        {
            this.item = item;
            this.Size = new Size(460, 85);
            this.BorderStyle = BorderStyle.FixedSingle;

            lblItemName = new Label();
            lblItemName.AutoSize = false;
            lblItemName.Size= new Size(200, 20);
            lblItemName.Text = item.Product.name;
            lblItemName.BackColor = Color.Transparent;
            lblItemName.Font = new Font("Microsoft Sans Serif", (float)11.25, FontStyle.Italic);
            this.Controls.Add(lblItemName);

            lblItemType = new Label();
            lblItemType.AutoSize = false;
            lblItemType.Size = new Size(200, 15);
            lblItemType.Font = new Font("Microsoft Sans Serif", (float)10.25, FontStyle.Italic);
            if (item.Product is Book)
                lblItemType.Text = "Book";
            else if (item.Product is Magazine)
                lblItemType.Text = "Magazine";
            else
                lblItemType.Text = "Music CD";
            lblItemType.BackColor = Color.Transparent;
            this.Controls.Add(lblItemType);

            lblPrice = new Label();
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Microsoft Sans Serif", (float)10.25,FontStyle.Regular);
            lblPrice.Text = item.Product.discountedPrice * item.Quantity + " TL";
            lblPrice.BackColor = Color.Transparent;
            this.Controls.Add(lblPrice);

            cbQuantity = new ComboBox();
            for(int i = 1; i <= 100; i++)
            {
                cbQuantity.Items.Add(i.ToString());
            }
            cbQuantity.SelectedIndex = item.Quantity-1;
            cbQuantity.SelectedIndexChanged += new EventHandler(cbChange);
            cbQuantity.Size = new Size(61, 21);
            cbQuantity.IntegralHeight = false;
            cbQuantity.DropDownStyle = ComboBoxStyle.DropDownList;
            cbQuantity.MaxDropDownItems = 6;
            this.Controls.Add(cbQuantity);

            pbThumbnail = new PictureBox();
            pbThumbnail.Image = item.Product.image;
            pbThumbnail.SizeMode = PictureBoxSizeMode.Zoom;
            pbThumbnail.Size = new Size(59, 78);
            pbThumbnail.BackColor = Color.Transparent;
            this.Controls.Add(pbThumbnail);

            btnRemoveItem = new Button();
            btnRemoveItem.Text = "Remove Item";
            btnRemoveItem.TextAlign = ContentAlignment.MiddleRight;
            btnRemoveItem.Size = new Size(100, 25);
            btnRemoveItem.FlatStyle = FlatStyle.Flat;
            btnRemoveItem.BackColor = Color.Snow;
            btnRemoveItem.Click += new EventHandler(butonClick);
            btnRemoveItem.Image = Properties.Resources.removeitem;
            btnRemoveItem.ImageAlign = ContentAlignment.MiddleLeft;
            this.Controls.Add(btnRemoveItem);

            this.Controls[0].Location = new Point(63, 24);// Name label 
            this.Controls[0].BringToFront();
            this.Controls[1].Location = new Point(63, 54);// Type label
            this.Controls[1].BringToFront();
            this.Controls[2].Location = new Point(366, 26);// Price label
            this.Controls[2].BringToFront();
            this.Controls[3].Location = new Point(276, 24);//  Combobox
            this.Controls[3].BringToFront();
            this.Controls[4].Location = new Point(3, 3);// picturebox
            this.Controls[4].BringToFront();
            this.Controls[5].Location = new Point(340, 55);//Button
           
        }
        void butonClick(object sender,EventArgs e)
        {
            Logger.logger("Shopping Cart Product Remove");
            MainForm.shoppingCart.removeProduct(this.item);
        }
        void cbChange(object sender,EventArgs e)
        {
            item.Quantity = cbQuantity.SelectedIndex + 1;
            lblPrice.Text = item.Product.discountedPrice * item.Quantity + " TL";
            MainForm.shoppingCart.refreshPanel();
        }
    }
}
