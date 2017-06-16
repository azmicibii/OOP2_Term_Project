using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.ComponentModel;

namespace OnlineBookStore
{
    public partial class MainForm : Form
    {
        public static bool Isroot;
        public BackgroundWorker worker = new BackgroundWorker();
        LoadingForm loadForm;
        int bannerCount = 0;
        int timerCooldown = 0;
        WebClient wc = new WebClient();
        TopBanners topBanners = new TopBanners();
        Customer user;
        List<Product> booklist;
        List<Product> musiclist;
        List<Product> magazinelist;
        List<Product> CurrentProductList;
        FactoryPanelCreator panelCreator;
        ArrayList productList;
        ArrayList banners;
        public static ShoppingCart shoppingCart;
        public MainForm()
        {

            InitializeComponent();
            btnRoot.Visible = Isroot;
            shoppingCart = new ShoppingCart();
            user = Customer.getInstance();
            this.Text +=" - "+user.Name;
            shoppingCart.Customer = user;
            picBox.Image = user.Image;
            picBox.SizeMode = PictureBoxSizeMode.Zoom;
            CurrentProductList = new List<Product>();
            lbl_customer.Text = user.Name;     
            pnlBanner.BackgroundImageLayout = ImageLayout.Stretch;
            banners = new ArrayList();
            cbOrder.SelectedIndex = 0;
            banners.Add(OnlineBookStore.Properties.Resources.ResourceManager.GetObject("banner") as Image);
            pnlBanner.BackgroundImage = (Image)banners[0];

        }

        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)//Product combobox selected index changed.
        {
            flPnlProduct.Controls.Clear();
            cbCategory.Items.Clear();
            switch (cbProduct.SelectedIndex)
            {
                case 0:
                    string[] category = new string[] { "All", "Adventure", "Horror", "Sci-Fi" };
                    cbCategory.Items.AddRange(category);
                    break;
                case 1:
                    category = new string[] { "All","History", "Science","Sport"};
                    cbCategory.Items.AddRange(category);
                    break;
                case 2:
                    category = new string[] { "All", "Blues","Folk", "Rock", "Pop" };
                    cbCategory.Items.AddRange(category);
                    break;
                default:
                    break;
            }

            cbCategory.SelectedIndex = 0;
            cbOrder.SelectedIndex = 0;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            panelCreator = new FactoryPanelCreator();
            DataBaseHandler dh = DataBaseHandler.getInstance();
            productList = new ArrayList();
            booklist = dh.BookLoader();
            CurrentProductList.AddRange(booklist);
            musiclist = dh.MusicCDLoader();
            magazinelist = dh.MagazineLoader();
            productList.Add(booklist);
            productList.Add(magazinelist);
            productList.Add(musiclist);
            cbProduct.SelectedIndex = 0;
            worker.DoWork += new DoWorkEventHandler(Worker_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Worker_RunWorkerCompleted);
            worker.ProgressChanged += Worker_ProgressChanged;

        }
        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            loadForm.ProgressBarValue = e.ProgressPercentage;
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (loadForm != null && loadForm.Visible)
                loadForm.Dispose();

            this.Show();

        }
        void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            
            topBanners.BannerParser();
            foreach (string link in topBanners.Link)
            {
                byte[] bytes = wc.DownloadData("http:" + link);
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    Image banner = Image.FromStream(ms);
                    banners.Add(banner);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timerCooldown % 4 == 0)
            {
                bannerCount++;
                pnlBanner.BackgroundImage = (Image)banners[bannerCount % banners.Count];
                timerCooldown = 1;
            }
            timerCooldown++;
            if (shoppingCart.ItemsToPurchase.Count == 0)
            {
                this.btnCart.Text = "Shopping Cart";
            }
            else
            {
                this.btnCart.Text = "Shopping Cart(" + shoppingCart.ItemsToPurchase.Count + ")";
            }
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)//Category selection
        {


            flPnlProduct.Controls.Clear();
            CurrentProductList.Clear();

            foreach (var item in (List<Product>)productList[cbProduct.SelectedIndex])
            {
                if (item.Category == cbCategory.SelectedItem.ToString())
                {
                    CurrentProductList.Add(item);
                    ProductPanel pnl = panelCreator.CreatePanel(item);
                    flPnlProduct.Controls.Add(pnl);
                }
                else if (cbCategory.SelectedItem.ToString() == "All")
                {
                    CurrentProductList.Add(item);
                    ProductPanel pnl = panelCreator.CreatePanel(item);
                    flPnlProduct.Controls.Add(pnl);
                }
            }
            cbOrder.SelectedIndex = 0;
        }
        
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
            user = null;
            booklist.Clear();
            musiclist.Clear();
            magazinelist.Clear();
            CurrentProductList.Clear();
            banners = null;
            this.Dispose();
        }

        private void pnlBanner_Click(object sender, EventArgs e)
        {

            Logger.logger( " Main Form Banner Panel");
            string url = topBanners.Hrefs[bannerCount % banners.Count];
            if (url[0] == '/')
                url = "www.idefix.com" + url;
            DialogResult dr = MessageBox.Show("You are directing to: " + url + " Do you want to proceed?", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
                System.Diagnostics.Process.Start(url);
        }

        private void cbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbOrder.SelectedIndex)
            {
                case 1:
                    CurrentProductList = CurrentProductList.OrderBy(o => o.name).ToList();
                    break;

                case 2:
                    CurrentProductList = CurrentProductList.OrderByDescending(o => o.name).ToList();
                    break;

                case 3:
                    CurrentProductList = CurrentProductList.OrderBy(o => o.discountedPrice).ToList();
                    break;

                case 4:
                    CurrentProductList = CurrentProductList.OrderByDescending(o => o.discountedPrice).ToList();
                    break;

                default:
                    break;
            }
            flPnlProduct.Controls.Clear();
            foreach (Product item in CurrentProductList)//Create panels
            {
                ProductPanel pnl = panelCreator.CreatePanel(item);
                flPnlProduct.Controls.Add(pnl);
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            worker.RunWorkerAsync();
            loadForm = new LoadingForm();
            this.Hide();
            loadForm.ShowDialog();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

            Logger.logger(" Main Form My Profile");
            user.ShowCustomerDetails();
            picBox.Image = user.Image;
            lbl_customer.Text = user.Name;
        }

        private void btnCart_Click(object sender, EventArgs e)
        {

            Logger.logger("Main Form Shopping Cart");
            shoppingCart.ShowProducts();
        }

        private void btnPurc_Click(object sender, EventArgs e)
        {

            Logger.logger("Main Form Previous Purchases");
            shoppingCart.ShowInvoices();
        }

        private void lblPrevious_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Logger.logger(" Main Form Previous Banner");
            bannerCount--;
            if (bannerCount == -1)
                bannerCount = banners.Count - 1;
            pnlBanner.BackgroundImage = (Image)banners[bannerCount % banners.Count];
            timerCooldown = 1;
        }

        private void lblNext_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Logger.logger(" Main Form Next Banner");
            bannerCount++;
            pnlBanner.BackgroundImage = (Image)banners[bannerCount % banners.Count];
            timerCooldown = 1;
        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            Logger.logger(" Main Form Root");
            DataBaseHandler dh = DataBaseHandler.getInstance();
            RootForm root = new RootForm();
            root.ShowDialog();
            booklist.Clear();
            musiclist.Clear();
            magazinelist.Clear();
            CurrentProductList.Clear();
            booklist = dh.BookLoader();
            CurrentProductList.AddRange(booklist);

            musiclist = dh.MusicCDLoader();
            magazinelist = dh.MagazineLoader();
            productList.Clear();
            productList.Add(booklist);
            productList.Add(magazinelist);
            productList.Add(musiclist);

            btnRoot.Visible = Isroot;
            cbProduct_SelectedIndexChanged(cbProduct, null);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            
        }
    }
}
