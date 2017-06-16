namespace OnlineBookStore
{
    partial class MagazineForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MagazineForm));
            this.label1 = new System.Windows.Forms.Label();
            this.price2 = new System.Windows.Forms.Label();
            this.price1 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.Label();
            this.issue = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.pbAddCart = new System.Windows.Forms.PictureBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblInc = new System.Windows.Forms.Label();
            this.lblDec = new System.Windows.Forms.Label();
            this.mtQuantity = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(261, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Top topics of this month:";
            // 
            // price2
            // 
            this.price2.BackColor = System.Drawing.Color.Transparent;
            this.price2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.price2.Location = new System.Drawing.Point(20, 354);
            this.price2.Name = "price2";
            this.price2.Size = new System.Drawing.Size(201, 25);
            this.price2.TabIndex = 27;
            this.price2.Text = "price2";
            this.price2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // price1
            // 
            this.price1.BackColor = System.Drawing.Color.Transparent;
            this.price1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.price1.ForeColor = System.Drawing.Color.Black;
            this.price1.Location = new System.Drawing.Point(21, 320);
            this.price1.Name = "price1";
            this.price1.Size = new System.Drawing.Size(201, 20);
            this.price1.TabIndex = 26;
            this.price1.Text = "price1";
            this.price1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // category
            // 
            this.category.BackColor = System.Drawing.Color.Transparent;
            this.category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.category.ForeColor = System.Drawing.Color.Black;
            this.category.Location = new System.Drawing.Point(21, 290);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(201, 16);
            this.category.TabIndex = 25;
            this.category.Text = "category";
            this.category.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // issue
            // 
            this.issue.BackColor = System.Drawing.Color.Transparent;
            this.issue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.issue.Location = new System.Drawing.Point(21, 260);
            this.issue.Name = "issue";
            this.issue.Size = new System.Drawing.Size(201, 16);
            this.issue.TabIndex = 24;
            this.issue.Text = "issue";
            this.issue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.name.Location = new System.Drawing.Point(21, 226);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(201, 20);
            this.name.TabIndex = 23;
            this.name.Text = "name";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbAddCart
            // 
            this.pbAddCart.BackColor = System.Drawing.Color.Transparent;
            this.pbAddCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbAddCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAddCart.Image = global::OnlineBookStore.Properties.Resources.cart;
            this.pbAddCart.Location = new System.Drawing.Point(562, 316);
            this.pbAddCart.Name = "pbAddCart";
            this.pbAddCart.Size = new System.Drawing.Size(64, 64);
            this.pbAddCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddCart.TabIndex = 30;
            this.pbAddCart.TabStop = false;
            this.pbAddCart.Click += new System.EventHandler(this.pbAddCart_Click);
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.Transparent;
            this.picBox.Location = new System.Drawing.Point(25, 12);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(197, 192);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 22;
            this.picBox.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDescription.Location = new System.Drawing.Point(261, 67);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(354, 312);
            this.lblDescription.TabIndex = 31;
            this.lblDescription.Text = "Top topics of this month:";
            // 
            // lblInc
            // 
            this.lblInc.BackColor = System.Drawing.Color.Transparent;
            this.lblInc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblInc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInc.Location = new System.Drawing.Point(527, 333);
            this.lblInc.Name = "lblInc";
            this.lblInc.Size = new System.Drawing.Size(26, 31);
            this.lblInc.TabIndex = 34;
            this.lblInc.Text = "+";
            this.lblInc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInc.Click += new System.EventHandler(this.lblInc_Click);
            // 
            // lblDec
            // 
            this.lblDec.BackColor = System.Drawing.Color.Transparent;
            this.lblDec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDec.Location = new System.Drawing.Point(460, 333);
            this.lblDec.Name = "lblDec";
            this.lblDec.Size = new System.Drawing.Size(26, 31);
            this.lblDec.TabIndex = 33;
            this.lblDec.Text = "-";
            this.lblDec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDec.Click += new System.EventHandler(this.lblDec_Click);
            // 
            // mtQuantity
            // 
            this.mtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtQuantity.Location = new System.Drawing.Point(488, 333);
            this.mtQuantity.Mask = "00";
            this.mtQuantity.Name = "mtQuantity";
            this.mtQuantity.Size = new System.Drawing.Size(34, 31);
            this.mtQuantity.TabIndex = 32;
            this.mtQuantity.TabStop = false;
            // 
            // MagazineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OnlineBookStore.Properties.Resources.magazinebackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(638, 392);
            this.Controls.Add(this.lblInc);
            this.Controls.Add(this.lblDec);
            this.Controls.Add(this.mtQuantity);
            this.Controls.Add(this.pbAddCart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.price2);
            this.Controls.Add(this.price1);
            this.Controls.Add(this.category);
            this.Controls.Add(this.issue);
            this.Controls.Add(this.name);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.lblDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MagazineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MagazineForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbAddCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAddCart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label price2;
        private System.Windows.Forms.Label price1;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.Label issue;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblInc;
        private System.Windows.Forms.Label lblDec;
        private System.Windows.Forms.MaskedTextBox mtQuantity;
    }
}