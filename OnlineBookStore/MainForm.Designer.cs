using System;
using System.Windows.Forms;

namespace OnlineBookStore
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tlMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlBannerProduct = new System.Windows.Forms.TableLayoutPanel();
            this.tlOptionsProduct = new System.Windows.Forms.TableLayoutPanel();
            this.flPnlProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.lblOrder = new System.Windows.Forms.Label();
            this.cbOrder = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.pnlBanner = new System.Windows.Forms.Panel();
            this.tlPreNext = new System.Windows.Forms.TableLayoutPanel();
            this.lblPrevious = new System.Windows.Forms.LinkLabel();
            this.lblNext = new System.Windows.Forms.LinkLabel();
            this.tlUserBackground = new System.Windows.Forms.TableLayoutPanel();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.btnRoot = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnPurc = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.lbl_customer = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tlMain.SuspendLayout();
            this.tlBannerProduct.SuspendLayout();
            this.tlOptionsProduct.SuspendLayout();
            this.pnlOptions.SuspendLayout();
            this.pnlBanner.SuspendLayout();
            this.tlPreNext.SuspendLayout();
            this.tlUserBackground.SuspendLayout();
            this.pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // tlMain
            // 
            this.tlMain.BackColor = System.Drawing.Color.Transparent;
            this.tlMain.ColumnCount = 2;
            this.tlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlMain.Controls.Add(this.tlBannerProduct, 1, 0);
            this.tlMain.Controls.Add(this.tlUserBackground, 0, 0);
            this.tlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlMain.Location = new System.Drawing.Point(0, 0);
            this.tlMain.Name = "tlMain";
            this.tlMain.RowCount = 1;
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlMain.Size = new System.Drawing.Size(1183, 666);
            this.tlMain.TabIndex = 0;
            // 
            // tlBannerProduct
            // 
            this.tlBannerProduct.BackColor = System.Drawing.Color.Transparent;
            this.tlBannerProduct.ColumnCount = 1;
            this.tlBannerProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlBannerProduct.Controls.Add(this.tlOptionsProduct, 0, 1);
            this.tlBannerProduct.Controls.Add(this.pnlBanner, 0, 0);
            this.tlBannerProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlBannerProduct.Location = new System.Drawing.Point(253, 3);
            this.tlBannerProduct.Name = "tlBannerProduct";
            this.tlBannerProduct.RowCount = 2;
            this.tlBannerProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlBannerProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlBannerProduct.Size = new System.Drawing.Size(927, 660);
            this.tlBannerProduct.TabIndex = 4;
            // 
            // tlOptionsProduct
            // 
            this.tlOptionsProduct.BackColor = System.Drawing.Color.White;
            this.tlOptionsProduct.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tlOptionsProduct.ColumnCount = 1;
            this.tlOptionsProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlOptionsProduct.Controls.Add(this.flPnlProduct, 0, 1);
            this.tlOptionsProduct.Controls.Add(this.pnlOptions, 0, 0);
            this.tlOptionsProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlOptionsProduct.Location = new System.Drawing.Point(3, 201);
            this.tlOptionsProduct.Name = "tlOptionsProduct";
            this.tlOptionsProduct.RowCount = 2;
            this.tlOptionsProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlOptionsProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlOptionsProduct.Size = new System.Drawing.Size(921, 456);
            this.tlOptionsProduct.TabIndex = 8;
            // 
            // flPnlProduct
            // 
            this.flPnlProduct.AutoScroll = true;
            this.flPnlProduct.BackColor = System.Drawing.Color.White;
            this.flPnlProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flPnlProduct.Location = new System.Drawing.Point(5, 42);
            this.flPnlProduct.Name = "flPnlProduct";
            this.flPnlProduct.Size = new System.Drawing.Size(911, 409);
            this.flPnlProduct.TabIndex = 0;
            // 
            // pnlOptions
            // 
            this.pnlOptions.BackColor = System.Drawing.Color.White;
            this.pnlOptions.Controls.Add(this.lblOrder);
            this.pnlOptions.Controls.Add(this.cbOrder);
            this.pnlOptions.Controls.Add(this.cbCategory);
            this.pnlOptions.Controls.Add(this.cbProduct);
            this.pnlOptions.Controls.Add(this.lblCategory);
            this.pnlOptions.Controls.Add(this.lblProduct);
            this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOptions.Location = new System.Drawing.Point(5, 5);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(911, 29);
            this.pnlOptions.TabIndex = 1;
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(385, 6);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(48, 13);
            this.lblOrder.TabIndex = 5;
            this.lblOrder.Text = "Order By";
            // 
            // cbOrder
            // 
            this.cbOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrder.Items.AddRange(new object[] {
            "Default",
            "A-Z",
            "Z-A",
            "Price Ascending",
            "Price Descending"});
            this.cbOrder.Location = new System.Drawing.Point(452, 3);
            this.cbOrder.Name = "cbOrder";
            this.cbOrder.Size = new System.Drawing.Size(121, 21);
            this.cbOrder.TabIndex = 4;
            this.cbOrder.SelectedIndexChanged += new System.EventHandler(this.cbOrder_SelectedIndexChanged);
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.SystemColors.Control;
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.Location = new System.Drawing.Point(246, 3);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 21);
            this.cbCategory.TabIndex = 2;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // cbProduct
            // 
            this.cbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Items.AddRange(new object[] {
            "Book",
            "Magazine",
            "MusicCd"});
            this.cbProduct.Location = new System.Drawing.Point(53, 3);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(121, 21);
            this.cbProduct.TabIndex = 0;
            this.cbProduct.SelectedIndexChanged += new System.EventHandler(this.cbProduct_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(191, 7);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(3, 7);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(44, 13);
            this.lblProduct.TabIndex = 3;
            this.lblProduct.Text = "Product";
            // 
            // pnlBanner
            // 
            this.pnlBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBanner.Controls.Add(this.tlPreNext);
            this.pnlBanner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlBanner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBanner.Location = new System.Drawing.Point(3, 3);
            this.pnlBanner.Name = "pnlBanner";
            this.pnlBanner.Size = new System.Drawing.Size(921, 192);
            this.pnlBanner.TabIndex = 9;
            this.pnlBanner.Click += new System.EventHandler(this.pnlBanner_Click);
            // 
            // tlPreNext
            // 
            this.tlPreNext.BackColor = System.Drawing.Color.Transparent;
            this.tlPreNext.ColumnCount = 2;
            this.tlPreNext.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlPreNext.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlPreNext.Controls.Add(this.lblPrevious, 0, 0);
            this.tlPreNext.Controls.Add(this.lblNext, 1, 0);
            this.tlPreNext.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlPreNext.Location = new System.Drawing.Point(0, 168);
            this.tlPreNext.Name = "tlPreNext";
            this.tlPreNext.RowCount = 1;
            this.tlPreNext.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPreNext.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlPreNext.Size = new System.Drawing.Size(919, 22);
            this.tlPreNext.TabIndex = 6;
            // 
            // lblPrevious
            // 
            this.lblPrevious.AutoSize = true;
            this.lblPrevious.BackColor = System.Drawing.Color.Transparent;
            this.lblPrevious.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblPrevious.LinkColor = System.Drawing.Color.Black;
            this.lblPrevious.Location = new System.Drawing.Point(396, 0);
            this.lblPrevious.Name = "lblPrevious";
            this.lblPrevious.Size = new System.Drawing.Size(60, 22);
            this.lblPrevious.TabIndex = 4;
            this.lblPrevious.TabStop = true;
            this.lblPrevious.Text = "<- Previous";
            this.lblPrevious.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblPrevious_LinkClicked);
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.BackColor = System.Drawing.Color.Transparent;
            this.lblNext.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNext.LinkColor = System.Drawing.Color.Black;
            this.lblNext.Location = new System.Drawing.Point(462, 0);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(41, 22);
            this.lblNext.TabIndex = 5;
            this.lblNext.TabStop = true;
            this.lblNext.Text = "Next ->";
            this.lblNext.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblNext_LinkClicked);
            // 
            // tlUserBackground
            // 
            this.tlUserBackground.ColumnCount = 1;
            this.tlUserBackground.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlUserBackground.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlUserBackground.Controls.Add(this.pnlUser, 0, 0);
            this.tlUserBackground.Controls.Add(this.pbBackground, 0, 1);
            this.tlUserBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlUserBackground.Location = new System.Drawing.Point(3, 3);
            this.tlUserBackground.Name = "tlUserBackground";
            this.tlUserBackground.RowCount = 2;
            this.tlUserBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 436F));
            this.tlUserBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlUserBackground.Size = new System.Drawing.Size(244, 660);
            this.tlUserBackground.TabIndex = 5;
            // 
            // pnlUser
            // 
            this.pnlUser.BackColor = System.Drawing.Color.White;
            this.pnlUser.BackgroundImage = global::OnlineBookStore.Properties.Resources.birds_corner;
            this.pnlUser.Controls.Add(this.btnRoot);
            this.pnlUser.Controls.Add(this.btnLogOut);
            this.pnlUser.Controls.Add(this.btnPurc);
            this.pnlUser.Controls.Add(this.btnCart);
            this.pnlUser.Controls.Add(this.btnProfile);
            this.pnlUser.Controls.Add(this.lbl_customer);
            this.pnlUser.Controls.Add(this.picBox);
            this.pnlUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUser.Location = new System.Drawing.Point(3, 3);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(238, 430);
            this.pnlUser.TabIndex = 3;
            // 
            // btnRoot
            // 
            this.btnRoot.BackColor = System.Drawing.Color.Snow;
            this.btnRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoot.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.btnRoot.Image = global::OnlineBookStore.Properties.Resources.dbicon;
            this.btnRoot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoot.Location = new System.Drawing.Point(-2, 387);
            this.btnRoot.Name = "btnRoot";
            this.btnRoot.Size = new System.Drawing.Size(244, 36);
            this.btnRoot.TabIndex = 15;
            this.btnRoot.Text = "     Administrator Interface";
            this.btnRoot.UseVisualStyleBackColor = false;
            this.btnRoot.Click += new System.EventHandler(this.btnRoot_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Snow;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.btnLogOut.Image = global::OnlineBookStore.Properties.Resources.logout;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(-4, 346);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(244, 36);
            this.btnLogOut.TabIndex = 14;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnPurc
            // 
            this.btnPurc.BackColor = System.Drawing.Color.Snow;
            this.btnPurc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurc.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.btnPurc.Image = global::OnlineBookStore.Properties.Resources.bill;
            this.btnPurc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurc.Location = new System.Drawing.Point(-4, 307);
            this.btnPurc.Name = "btnPurc";
            this.btnPurc.Size = new System.Drawing.Size(244, 36);
            this.btnPurc.TabIndex = 13;
            this.btnPurc.Text = "Prev. Purchases";
            this.btnPurc.UseVisualStyleBackColor = false;
            this.btnPurc.Click += new System.EventHandler(this.btnPurc_Click);
            // 
            // btnCart
            // 
            this.btnCart.BackColor = System.Drawing.Color.Snow;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.btnCart.Image = global::OnlineBookStore.Properties.Resources.shoppingcart;
            this.btnCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCart.Location = new System.Drawing.Point(-3, 268);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(244, 36);
            this.btnCart.TabIndex = 12;
            this.btnCart.Text = "Shopping Cart";
            this.btnCart.UseVisualStyleBackColor = false;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.Snow;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProfile.Image = global::OnlineBookStore.Properties.Resources.user;
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(-3, 231);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(244, 36);
            this.btnProfile.TabIndex = 11;
            this.btnProfile.Text = "My Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // lbl_customer
            // 
            this.lbl_customer.BackColor = System.Drawing.Color.Transparent;
            this.lbl_customer.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_customer.Location = new System.Drawing.Point(6, 185);
            this.lbl_customer.Name = "lbl_customer";
            this.lbl_customer.Size = new System.Drawing.Size(229, 43);
            this.lbl_customer.TabIndex = 5;
            this.lbl_customer.Text = "Customer Name";
            this.lbl_customer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.Transparent;
            this.picBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox.Location = new System.Drawing.Point(46, 62);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(146, 120);
            this.picBox.TabIndex = 4;
            this.picBox.TabStop = false;
            // 
            // pbBackground
            // 
            this.pbBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbBackground.BackgroundImage")));
            this.pbBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBackground.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbBackground.Location = new System.Drawing.Point(3, 439);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(238, 218);
            this.pbBackground.TabIndex = 4;
            this.pbBackground.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1183, 666);
            this.Controls.Add(this.tlMain);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1199, 705);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Online Book Store";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.tlMain.ResumeLayout(false);
            this.tlBannerProduct.ResumeLayout(false);
            this.tlOptionsProduct.ResumeLayout(false);
            this.pnlOptions.ResumeLayout(false);
            this.pnlOptions.PerformLayout();
            this.pnlBanner.ResumeLayout(false);
            this.tlPreNext.ResumeLayout(false);
            this.tlPreNext.PerformLayout();
            this.tlUserBackground.ResumeLayout(false);
            this.pnlUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.TableLayoutPanel tlMain;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label lbl_customer;
        private System.Windows.Forms.TableLayoutPanel tlBannerProduct;
        private System.Windows.Forms.TableLayoutPanel tlOptionsProduct;
        private System.Windows.Forms.FlowLayoutPanel flPnlProduct;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.Panel pnlBanner;
        private System.Windows.Forms.TableLayoutPanel tlPreNext;
        private System.Windows.Forms.LinkLabel lblPrevious;
        private System.Windows.Forms.LinkLabel lblNext;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.ComboBox cbOrder;
        private System.Windows.Forms.TableLayoutPanel tlUserBackground;
        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnPurc;
        private System.Windows.Forms.Button btnLogOut;
        public System.Windows.Forms.Button btnCart;
        private Button btnRoot;
    }
}

