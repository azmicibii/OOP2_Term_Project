using System;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class MusicForm : Form
    {
        MusicCD musicCD;
        public MusicForm(MusicCD musicCD)
        {
            this.musicCD = musicCD;
            InitializeComponent();
            this.Text = musicCD.name;
            picBox.Image = musicCD.image;
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            name.Text = musicCD.name;
            singer.Text = musicCD.Singer;
            category.Text = "Category:" + musicCD.Category;
            if (musicCD.Sale > 0 && musicCD.Sale < 100)
                price1.Text = musicCD.price + " TL  %" + musicCD.Sale;
            else
                price1.Text = "";
            price2.Text = (musicCD.price - musicCD.price * (musicCD.Sale / 100)) + " TL";
            string[] descriptionText = musicCD.Description.Split('$');
            lblDescription.Text = "";
            for (int i =0; i < descriptionText.Length; i++)
            {
                lblDescription.Text += descriptionText[i] + Environment.NewLine;
            }
            mtQuantity.Text = "01";
            picBox.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void pbPlay_Click(object sender, EventArgs e)
        {

            Logger.logger(musicCD.name + " Form Play");
            try
            {
                using (System.Media.SoundPlayer player = new System.Media.SoundPlayer(Application.StartupPath + @"\Resources\Demos\" + this.musicCD.demo + ".wav"))
                {
                    player.Play();
                }
            }
            catch (System.IO.FileNotFoundException )
            {
                MessageBox.Show(@"\Resources\Demos\" + this.musicCD.demo + ".wav NOT FOUND", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbAddCart_Click(object sender, EventArgs e)
        {

            Logger.logger(musicCD.name + " Form Add Cart");
            if (mtQuantity.Text != "" && int.Parse(mtQuantity.Text) != 0)
            {
                foreach (var it in MainForm.shoppingCart.ItemsToPurchase)
                {
                    if (it.Product == this.musicCD)
                    {
                        it.Quantity += int.Parse(mtQuantity.Text);

                        if (it.Quantity > 99) {
                            MessageBox.Show("You have reached maximum capacity."+Environment.NewLine+"Max Capacity: 99", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            it.Quantity = 99;
                        }
                        else 
                        MessageBox.Show(int.Parse(mtQuantity.Text) + " " + it.Product.name + " has been added to your shopping cart.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);                        
                        return;
                    }
                }
                ItemToPurchase item = new ItemToPurchase();
                item.Product = this.musicCD;
                item.Quantity = int.Parse(mtQuantity.Text);
                MainForm.shoppingCart.ItemsToPurchase.Add(item);
                MessageBox.Show(item.Quantity + " " + item.Product.name + " has been added to your shopping cart.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void incLabel (object sender, EventArgs e)
        {

            Logger.logger(musicCD.name + " Form Inc Label");
            if (mtQuantity.Text == "")
                mtQuantity.Text = "01";
            int quantity =int.Parse(mtQuantity.Text);
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

        private void decLabel(object sender, EventArgs e)
        {
            Logger.logger(musicCD.name + " Form Dec Label");
            if (mtQuantity.Text == "")
                mtQuantity.Text = "01";
            int quantity = int.Parse(mtQuantity.Text);
            quantity--;
            if (quantity == 0)
            {
                quantity = 1;
            }
            if (quantity < 10)
                mtQuantity.Text = "0" + quantity.ToString();
            else
                mtQuantity.Text = quantity.ToString();
        }
    }
}
