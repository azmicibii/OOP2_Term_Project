namespace OnlineBookStore
{
    partial class MusicForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicForm));
            this.pbAddCart = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.price2 = new System.Windows.Forms.Label();
            this.price1 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.Label();
            this.singer = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pbPlay = new System.Windows.Forms.PictureBox();
            this.mtQuantity = new System.Windows.Forms.MaskedTextBox();
            this.lblDec = new System.Windows.Forms.Label();
            this.lblInc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAddCart
            // 
            this.pbAddCart.BackColor = System.Drawing.Color.Transparent;
            this.pbAddCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbAddCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAddCart.Image = global::OnlineBookStore.Properties.Resources.cart;
            this.pbAddCart.Location = new System.Drawing.Point(492, 334);
            this.pbAddCart.Name = "pbAddCart";
            this.pbAddCart.Size = new System.Drawing.Size(64, 64);
            this.pbAddCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddCart.TabIndex = 21;
            this.pbAddCart.TabStop = false;
            this.pbAddCart.Click += new System.EventHandler(this.pbAddCart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(273, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Songs";
            // 
            // price2
            // 
            this.price2.BackColor = System.Drawing.Color.Transparent;
            this.price2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.price2.Location = new System.Drawing.Point(33, 353);
            this.price2.Name = "price2";
            this.price2.Size = new System.Drawing.Size(197, 25);
            this.price2.TabIndex = 17;
            this.price2.Text = "price2";
            this.price2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // price1
            // 
            this.price1.BackColor = System.Drawing.Color.Transparent;
            this.price1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.price1.ForeColor = System.Drawing.Color.Black;
            this.price1.Location = new System.Drawing.Point(33, 315);
            this.price1.Name = "price1";
            this.price1.Size = new System.Drawing.Size(197, 26);
            this.price1.TabIndex = 16;
            this.price1.Text = "price1";
            this.price1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // category
            // 
            this.category.BackColor = System.Drawing.Color.Transparent;
            this.category.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.category.ForeColor = System.Drawing.Color.Black;
            this.category.Location = new System.Drawing.Point(33, 281);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(197, 22);
            this.category.TabIndex = 15;
            this.category.Text = "category";
            this.category.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // singer
            // 
            this.singer.BackColor = System.Drawing.Color.Transparent;
            this.singer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.singer.Location = new System.Drawing.Point(33, 248);
            this.singer.Name = "singer";
            this.singer.Size = new System.Drawing.Size(197, 21);
            this.singer.TabIndex = 13;
            this.singer.Text = "singer";
            this.singer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.name.Location = new System.Drawing.Point(33, 216);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(197, 20);
            this.name.TabIndex = 12;
            this.name.Text = "name";
            this.name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.Transparent;
            this.picBox.Location = new System.Drawing.Point(32, 12);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(197, 192);
            this.picBox.TabIndex = 11;
            this.picBox.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDescription.Location = new System.Drawing.Point(273, 59);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(283, 297);
            this.lblDescription.TabIndex = 23;
            this.lblDescription.Text = "Songs";
            // 
            // pbPlay
            // 
            this.pbPlay.BackColor = System.Drawing.Color.Transparent;
            this.pbPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPlay.Image = global::OnlineBookStore.Properties.Resources.play;
            this.pbPlay.Location = new System.Drawing.Point(276, 334);
            this.pbPlay.Name = "pbPlay";
            this.pbPlay.Size = new System.Drawing.Size(64, 64);
            this.pbPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlay.TabIndex = 24;
            this.pbPlay.TabStop = false;
            this.pbPlay.Click += new System.EventHandler(this.pbPlay_Click);
            // 
            // mtQuantity
            // 
            this.mtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtQuantity.Location = new System.Drawing.Point(406, 350);
            this.mtQuantity.Mask = "00";
            this.mtQuantity.Name = "mtQuantity";
            this.mtQuantity.Size = new System.Drawing.Size(34, 31);
            this.mtQuantity.TabIndex = 25;
            this.mtQuantity.TabStop = false;
            // 
            // lblDec
            // 
            this.lblDec.BackColor = System.Drawing.Color.Transparent;
            this.lblDec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDec.Location = new System.Drawing.Point(378, 350);
            this.lblDec.Name = "lblDec";
            this.lblDec.Size = new System.Drawing.Size(26, 31);
            this.lblDec.TabIndex = 26;
            this.lblDec.Text = "-";
            this.lblDec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDec.Click += new System.EventHandler(this.decLabel);
            // 
            // lblInc
            // 
            this.lblInc.BackColor = System.Drawing.Color.Transparent;
            this.lblInc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblInc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInc.Location = new System.Drawing.Point(445, 350);
            this.lblInc.Name = "lblInc";
            this.lblInc.Size = new System.Drawing.Size(26, 31);
            this.lblInc.TabIndex = 27;
            this.lblInc.Text = "+";
            this.lblInc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInc.Click += new System.EventHandler(this.incLabel);
            // 
            // MusicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OnlineBookStore.Properties.Resources.musicbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(568, 410);
            this.Controls.Add(this.lblInc);
            this.Controls.Add(this.lblDec);
            this.Controls.Add(this.mtQuantity);
            this.Controls.Add(this.pbPlay);
            this.Controls.Add(this.pbAddCart);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.name);
            this.Controls.Add(this.singer);
            this.Controls.Add(this.category);
            this.Controls.Add(this.price1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.price2);
            this.Controls.Add(this.lblDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MusicForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MusicForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbAddCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAddCart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label price2;
        private System.Windows.Forms.Label price1;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.Label singer;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.PictureBox pbPlay;
        private System.Windows.Forms.MaskedTextBox mtQuantity;
        private System.Windows.Forms.Label lblDec;
        private System.Windows.Forms.Label lblInc;
    }
}