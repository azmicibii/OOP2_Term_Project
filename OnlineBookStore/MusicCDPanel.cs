using System;
using System.Drawing;
using System.Windows.Forms;

namespace OnlineBookStore
{
    class MusicCDPanel:ProductPanel
    {
        public Label Singer;
        public Label Type;
        public Label Price1;
        public Label Price2;
        public MusicCD musicCD;
        public PictureBox playBtn;

        public MusicCDPanel(MusicCD item)
        {
            musicCD = item;
            this.BackColor = Color.Transparent;
            this.Size = new Size(290, 190);
            this.BorderStyle = BorderStyle.FixedSingle;
            

            picBox = new PictureBox();
            picBox.Size = new Size(105, 160);
            picBox.BackgroundImage = item.image;
            picBox.BackgroundImageLayout = ImageLayout.Zoom;


            magnifier = new PictureBox();
            magnifier.Size = new Size(32, 32);
            magnifier.BackgroundImage = Properties.Resources.magnifier;
            magnifier.BackgroundImageLayout = ImageLayout.Zoom;
            magnifier.Cursor = Cursors.Hand;
            magnifier.Click += new EventHandler(panelClick);

            name = new Label();
            name.AutoSize = true;
            name.Text = item.name;
            name.TextAlign = ContentAlignment.MiddleLeft;
            name.Font = new Font("Microsoft Sans Serif", (float)9.75, FontStyle.Italic);
            this.Controls.Add(name);

            Singer = new Label();
            Singer.AutoSize = true;
            Singer.Text = item.Singer;
            Singer.Font = new Font("Microsoft Sans Serif", (float)8.25);
            this.Controls.Add(Singer);

            Type = new Label();
            Type.AutoSize = true;
            Type.Text = item.Category;
            Type.Font = new Font("Microsoft Sans Serif", (float)8.25);
            Type.ForeColor = Color.DarkGray;
            this.Controls.Add(Type);

            Price1 = new Label();
            Price1.AutoSize = true;
            if (item.Sale > 0 && item.Sale <100)
                Price1.Text = item.price + "TL  %" + item.Sale;
            else
                Price1.Text = "";
            Price1.Font = new Font("Microsoft Sans Serif", (float)11.25, FontStyle.Strikeout | FontStyle.Italic);
            Price1.ForeColor = Color.DarkGray;
            this.Controls.Add(Price1);

            Price2 = new Label();
            Price2.AutoSize = true;
            Price2.Text = item.discountedPrice + " TL";
            Price2.Font = new Font("Microsoft Sans Serif", (float)11.25, FontStyle.Bold);
            this.Controls.Add(Price2);

            playBtn = new PictureBox();
            playBtn.Size = new Size(32, 32);
            playBtn.BackgroundImage = Properties.Resources.pnlPlay;
            playBtn.BackgroundImageLayout = ImageLayout.Zoom;
            playBtn.Cursor = Cursors.Hand;
            playBtn.Click += new EventHandler(playBtnClick);
            this.Controls.Add(playBtn);

            picAdd = new PictureBox();
            picAdd.Size = new Size(32, 32);
            picAdd.BackgroundImage = Properties.Resources.addcart;
            picAdd.BackgroundImageLayout = ImageLayout.Zoom;
            picAdd.Cursor = Cursors.Hand;
            picAdd.Click += new EventHandler(addCart);

            this.Controls[0].Location = new Point(125, 20);// Name label 
            this.Controls[0].BringToFront();
            this.Controls[1].Location = new Point(125, 50);// Singer label
            this.Controls[1].BringToFront();
            this.Controls[2].Location = new Point(125, 80);// Type label
            this.Controls[2].BringToFront();
            this.Controls[3].Location = new Point(125, 110);//  Price1 label
            this.Controls[3].BringToFront();
            this.Controls[4].Location = new Point(210, 110);// Price2 label
            this.Controls[4].BringToFront();
            this.Controls[5].Location = new Point(120, 140);// Play demo button
            this.Controls[5].BringToFront();
            this.Controls.Add(picBox);
            this.Controls[6].Location = new Point(10, 15); //Picturebox
            this.Controls.Add(magnifier);
            this.Controls[7].Location = new Point(175, 140);//Magnifier image
            this.Controls.Add(picAdd);
            this.Controls[8].Location = new Point(225, 140); //Add to cart image
        }

        private void panelClick(object sender, EventArgs e)
        {
            Logger.logger(musicCD.name + " Panel Magnifier");
            musicCD.ShowProperties();
        
        }

        void playBtnClick(object sender, EventArgs e)
        {

            Logger.logger(musicCD.name + " Panel Play");
            try
            {
                using (System.Media.SoundPlayer player = new System.Media.SoundPlayer(Application.StartupPath+@"\Resources\Demos\"+this.musicCD.demo+".wav")) {                 
                player.Play();             
            }
            }
            catch(System.IO.FileNotFoundException)
            {
                MessageBox.Show(@"\Resources\Demos\" + this.musicCD.demo + ".wav NOT FOUND", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        void addCart(object sender, EventArgs e)
        {

            Logger.logger(musicCD.name + " Add Cart");
            foreach (var it in MainForm.shoppingCart.ItemsToPurchase)
            {
                if (it.Product == this.musicCD)
                {
                    it.Quantity++;
                    MessageBox.Show(it.Product.name + " has been added to your shopping cart.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            ItemToPurchase item = new ItemToPurchase();
            item.Product = this.musicCD;
            item.Quantity = 1;
            MainForm.shoppingCart.ItemsToPurchase.Add(item);
            MessageBox.Show(item.Product.name + " has been added to your shopping cart.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
