namespace OnlineBookStore
{
    partial class BookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
            this.name = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.Label();
            this.publisher = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.Label();
            this.price1 = new System.Windows.Forms.Label();
            this.price2 = new System.Windows.Forms.Label();
            this.page = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbAddCart = new System.Windows.Forms.PictureBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.lblInc = new System.Windows.Forms.Label();
            this.lblDec = new System.Windows.Forms.Label();
            this.mtQuantity = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.name.Location = new System.Drawing.Point(27, 265);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(179, 20);
            this.name.TabIndex = 1;
            this.name.Text = "Name";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // author
            // 
            this.author.BackColor = System.Drawing.Color.Transparent;
            this.author.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.author.Location = new System.Drawing.Point(27, 300);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(179, 16);
            this.author.TabIndex = 2;
            this.author.Text = "Author";
            this.author.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // publisher
            // 
            this.publisher.BackColor = System.Drawing.Color.Transparent;
            this.publisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.publisher.ForeColor = System.Drawing.Color.Black;
            this.publisher.Location = new System.Drawing.Point(27, 331);
            this.publisher.Name = "publisher";
            this.publisher.Size = new System.Drawing.Size(179, 16);
            this.publisher.TabIndex = 3;
            this.publisher.Text = "Publisher";
            this.publisher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // category
            // 
            this.category.BackColor = System.Drawing.Color.Transparent;
            this.category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.category.ForeColor = System.Drawing.Color.Black;
            this.category.Location = new System.Drawing.Point(27, 362);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(179, 16);
            this.category.TabIndex = 4;
            this.category.Text = "Category";
            this.category.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // price1
            // 
            this.price1.BackColor = System.Drawing.Color.Transparent;
            this.price1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.price1.ForeColor = System.Drawing.Color.Black;
            this.price1.Location = new System.Drawing.Point(27, 424);
            this.price1.Name = "price1";
            this.price1.Size = new System.Drawing.Size(92, 20);
            this.price1.TabIndex = 5;
            this.price1.Text = "Price";
            this.price1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // price2
            // 
            this.price2.BackColor = System.Drawing.Color.Transparent;
            this.price2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.price2.Location = new System.Drawing.Point(125, 419);
            this.price2.Name = "price2";
            this.price2.Size = new System.Drawing.Size(116, 25);
            this.price2.TabIndex = 6;
            this.price2.Text = "Discounted Price";
            this.price2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // page
            // 
            this.page.BackColor = System.Drawing.Color.Transparent;
            this.page.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.page.Location = new System.Drawing.Point(27, 393);
            this.page.Name = "page";
            this.page.Size = new System.Drawing.Size(179, 16);
            this.page.TabIndex = 7;
            this.page.Text = "Page";
            this.page.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(232, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Description";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(235, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 352);
            this.label2.TabIndex = 11;
            this.label2.Text = "Description";
            // 
            // pbAddCart
            // 
            this.pbAddCart.BackColor = System.Drawing.Color.Transparent;
            this.pbAddCart.BackgroundImage = global::OnlineBookStore.Properties.Resources.cart;
            this.pbAddCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbAddCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAddCart.Location = new System.Drawing.Point(529, 384);
            this.pbAddCart.Name = "pbAddCart";
            this.pbAddCart.Size = new System.Drawing.Size(64, 64);
            this.pbAddCart.TabIndex = 10;
            this.pbAddCart.TabStop = false;
            this.pbAddCart.Click += new System.EventHandler(this.pbAddCart_Click);
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.Transparent;
            this.picBox.Location = new System.Drawing.Point(27, 12);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(179, 241);
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // lblInc
            // 
            this.lblInc.BackColor = System.Drawing.Color.Transparent;
            this.lblInc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblInc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInc.Location = new System.Drawing.Point(489, 404);
            this.lblInc.Name = "lblInc";
            this.lblInc.Size = new System.Drawing.Size(26, 31);
            this.lblInc.TabIndex = 30;
            this.lblInc.Text = "+";
            this.lblInc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInc.Click += new System.EventHandler(this.lblInc_Click);
            // 
            // lblDec
            // 
            this.lblDec.BackColor = System.Drawing.Color.Transparent;
            this.lblDec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDec.Location = new System.Drawing.Point(422, 404);
            this.lblDec.Name = "lblDec";
            this.lblDec.Size = new System.Drawing.Size(26, 31);
            this.lblDec.TabIndex = 29;
            this.lblDec.Text = "-";
            this.lblDec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDec.Click += new System.EventHandler(this.lblDec_Click);
            // 
            // mtQuantity
            // 
            this.mtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtQuantity.Location = new System.Drawing.Point(450, 404);
            this.mtQuantity.Mask = "00";
            this.mtQuantity.Name = "mtQuantity";
            this.mtQuantity.Size = new System.Drawing.Size(34, 31);
            this.mtQuantity.TabIndex = 28;
            this.mtQuantity.TabStop = false;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OnlineBookStore.Properties.Resources.bookbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(605, 460);
            this.Controls.Add(this.lblInc);
            this.Controls.Add(this.lblDec);
            this.Controls.Add(this.mtQuantity);
            this.Controls.Add(this.pbAddCart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.page);
            this.Controls.Add(this.price2);
            this.Controls.Add(this.price1);
            this.Controls.Add(this.category);
            this.Controls.Add(this.publisher);
            this.Controls.Add(this.author);
            this.Controls.Add(this.name);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "7";
            ((System.ComponentModel.ISupportInitialize)(this.pbAddCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label author;
        private System.Windows.Forms.Label publisher;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.Label price1;
        private System.Windows.Forms.Label price2;
        private System.Windows.Forms.Label page;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbAddCart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInc;
        private System.Windows.Forms.Label lblDec;
        private System.Windows.Forms.MaskedTextBox mtQuantity;
    }
}