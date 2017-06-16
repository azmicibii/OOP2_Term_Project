namespace OnlineBookStore
{
    partial class ShoppingCartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShoppingCartForm));
            this.lblAdet = new System.Windows.Forms.Label();
            this.pnlProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpShoppingList = new System.Windows.Forms.TabPage();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.tpOrderInfo = new System.Windows.Forms.TabPage();
            this.grpCreditCard = new System.Windows.Forms.GroupBox();
            this.txtCardOwner = new System.Windows.Forms.TextBox();
            this.mtCVC = new System.Windows.Forms.MaskedTextBox();
            this.lblCardOwner = new System.Windows.Forms.Label();
            this.lblCVC = new System.Windows.Forms.Label();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.dtpExpDate = new System.Windows.Forms.DateTimePicker();
            this.lbExpDate = new System.Windows.Forms.Label();
            this.mtCardNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.rbCreditCard = new System.Windows.Forms.RadioButton();
            this.lblCustName = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tpShoppingList.SuspendLayout();
            this.tpOrderInfo.SuspendLayout();
            this.grpCreditCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.BackColor = System.Drawing.Color.Transparent;
            this.lblAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdet.Location = new System.Drawing.Point(281, 14);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(68, 20);
            this.lblAdet.TabIndex = 0;
            this.lblAdet.Text = "Quantity";
            // 
            // pnlProducts
            // 
            this.pnlProducts.AutoScroll = true;
            this.pnlProducts.BackColor = System.Drawing.Color.Transparent;
            this.pnlProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProducts.Location = new System.Drawing.Point(3, 36);
            this.pnlProducts.Name = "pnlProducts";
            this.pnlProducts.Size = new System.Drawing.Size(481, 304);
            this.pnlProducts.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(36, 14);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Product";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.Location = new System.Drawing.Point(374, 14);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 20);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotal.Location = new System.Drawing.Point(342, 343);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(48, 20);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total:";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpShoppingList);
            this.tabControl.Controls.Add(this.tpOrderInfo);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(495, 427);
            this.tabControl.TabIndex = 5;
            // 
            // tpShoppingList
            // 
            this.tpShoppingList.Controls.Add(this.btnCancel);
            this.tpShoppingList.Controls.Add(this.btnCheckout);
            this.tpShoppingList.Controls.Add(this.lblTotalPrice);
            this.tpShoppingList.Controls.Add(this.lblTotal);
            this.tpShoppingList.Controls.Add(this.lblPrice);
            this.tpShoppingList.Controls.Add(this.lblAdet);
            this.tpShoppingList.Controls.Add(this.pnlProducts);
            this.tpShoppingList.Controls.Add(this.lblName);
            this.tpShoppingList.Location = new System.Drawing.Point(4, 22);
            this.tpShoppingList.Name = "tpShoppingList";
            this.tpShoppingList.Padding = new System.Windows.Forms.Padding(3);
            this.tpShoppingList.Size = new System.Drawing.Size(487, 401);
            this.tpShoppingList.TabIndex = 0;
            this.tpShoppingList.Text = "Shopping List";
            this.tpShoppingList.UseVisualStyleBackColor = true;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalPrice.Location = new System.Drawing.Point(396, 343);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(44, 20);
            this.lblTotalPrice.TabIndex = 5;
            this.lblTotalPrice.Text = "Price";
            // 
            // tpOrderInfo
            // 
            this.tpOrderInfo.Controls.Add(this.grpCreditCard);
            this.tpOrderInfo.Controls.Add(this.lblInfo);
            this.tpOrderInfo.Controls.Add(this.rbCash);
            this.tpOrderInfo.Controls.Add(this.rbCreditCard);
            this.tpOrderInfo.Controls.Add(this.lblCustName);
            this.tpOrderInfo.Controls.Add(this.txtAddress);
            this.tpOrderInfo.Controls.Add(this.txtEmail);
            this.tpOrderInfo.Controls.Add(this.lbAddress);
            this.tpOrderInfo.Controls.Add(this.lbEmail);
            this.tpOrderInfo.Controls.Add(this.lbName);
            this.tpOrderInfo.Controls.Add(this.btnPrev);
            this.tpOrderInfo.Controls.Add(this.btnOrder);
            this.tpOrderInfo.Location = new System.Drawing.Point(4, 22);
            this.tpOrderInfo.Name = "tpOrderInfo";
            this.tpOrderInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpOrderInfo.Size = new System.Drawing.Size(487, 401);
            this.tpOrderInfo.TabIndex = 1;
            this.tpOrderInfo.Text = "Order Information";
            this.tpOrderInfo.UseVisualStyleBackColor = true;
            // 
            // grpCreditCard
            // 
            this.grpCreditCard.Controls.Add(this.txtCardOwner);
            this.grpCreditCard.Controls.Add(this.mtCVC);
            this.grpCreditCard.Controls.Add(this.lblCardOwner);
            this.grpCreditCard.Controls.Add(this.lblCVC);
            this.grpCreditCard.Controls.Add(this.lblCardNumber);
            this.grpCreditCard.Controls.Add(this.dtpExpDate);
            this.grpCreditCard.Controls.Add(this.lbExpDate);
            this.grpCreditCard.Controls.Add(this.mtCardNumber);
            this.grpCreditCard.Location = new System.Drawing.Point(65, 220);
            this.grpCreditCard.Name = "grpCreditCard";
            this.grpCreditCard.Size = new System.Drawing.Size(343, 94);
            this.grpCreditCard.TabIndex = 20;
            this.grpCreditCard.TabStop = false;
            // 
            // txtCardOwner
            // 
            this.txtCardOwner.Location = new System.Drawing.Point(89, 10);
            this.txtCardOwner.Name = "txtCardOwner";
            this.txtCardOwner.Size = new System.Drawing.Size(210, 20);
            this.txtCardOwner.TabIndex = 15;
            // 
            // mtCVC
            // 
            this.mtCVC.Location = new System.Drawing.Point(271, 59);
            this.mtCVC.Mask = "000";
            this.mtCVC.Name = "mtCVC";
            this.mtCVC.Size = new System.Drawing.Size(28, 20);
            this.mtCVC.TabIndex = 19;
            // 
            // lblCardOwner
            // 
            this.lblCardOwner.AutoSize = true;
            this.lblCardOwner.Location = new System.Drawing.Point(15, 13);
            this.lblCardOwner.Name = "lblCardOwner";
            this.lblCardOwner.Size = new System.Drawing.Size(63, 13);
            this.lblCardOwner.TabIndex = 12;
            this.lblCardOwner.Text = "Card Owner";
            // 
            // lblCVC
            // 
            this.lblCVC.AutoSize = true;
            this.lblCVC.Location = new System.Drawing.Point(237, 62);
            this.lblCVC.Name = "lblCVC";
            this.lblCVC.Size = new System.Drawing.Size(28, 13);
            this.lblCVC.TabIndex = 18;
            this.lblCVC.Text = "CVC";
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(9, 37);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(69, 13);
            this.lblCardNumber.TabIndex = 13;
            this.lblCardNumber.Text = "Card Number";
            // 
            // dtpExpDate
            // 
            this.dtpExpDate.CustomFormat = "MM/yy";
            this.dtpExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpDate.Location = new System.Drawing.Point(89, 59);
            this.dtpExpDate.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtpExpDate.MinDate = new System.DateTime(2019, 12, 25, 23, 59, 59, 0);
            this.dtpExpDate.Name = "dtpExpDate";
            this.dtpExpDate.Size = new System.Drawing.Size(67, 20);
            this.dtpExpDate.TabIndex = 17;
            this.dtpExpDate.Value = new System.DateTime(2019, 12, 25, 23, 59, 59, 0);
            // 
            // lbExpDate
            // 
            this.lbExpDate.AutoSize = true;
            this.lbExpDate.Location = new System.Drawing.Point(-1, 62);
            this.lbExpDate.Name = "lbExpDate";
            this.lbExpDate.Size = new System.Drawing.Size(79, 13);
            this.lbExpDate.TabIndex = 14;
            this.lbExpDate.Text = "Expiration Date";
            // 
            // mtCardNumber
            // 
            this.mtCardNumber.Location = new System.Drawing.Point(89, 32);
            this.mtCardNumber.Mask = "0000-0000-0000-0000";
            this.mtCardNumber.Name = "mtCardNumber";
            this.mtCardNumber.Size = new System.Drawing.Size(210, 20);
            this.mtCardNumber.TabIndex = 16;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(157, 181);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(150, 13);
            this.lblInfo.TabIndex = 11;
            this.lblInfo.Text = "Choose your payment method.";
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Location = new System.Drawing.Point(254, 197);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(49, 17);
            this.rbCash.TabIndex = 10;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Cash";
            this.rbCash.UseVisualStyleBackColor = true;
            this.rbCash.CheckedChanged += new System.EventHandler(this.rbCash_CheckedChanged);
            // 
            // rbCreditCard
            // 
            this.rbCreditCard.AutoSize = true;
            this.rbCreditCard.Location = new System.Drawing.Point(171, 197);
            this.rbCreditCard.Name = "rbCreditCard";
            this.rbCreditCard.Size = new System.Drawing.Size(77, 17);
            this.rbCreditCard.TabIndex = 9;
            this.rbCreditCard.TabStop = true;
            this.rbCreditCard.Text = "Credit Card";
            this.rbCreditCard.UseVisualStyleBackColor = true;
            this.rbCreditCard.CheckedChanged += new System.EventHandler(this.rbCreditCard_CheckedChanged);
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(128, 16);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(35, 13);
            this.lblCustName.TabIndex = 5;
            this.lblCustName.Text = "Name";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(131, 59);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(210, 110);
            this.txtAddress.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(131, 33);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(210, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(75, 56);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(45, 13);
            this.lbAddress.TabIndex = 2;
            this.lbAddress.Text = "Address";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(88, 36);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 1;
            this.lbEmail.Text = "Email";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(85, 16);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Snow;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.btnCancel.Image = global::OnlineBookStore.Properties.Resources.cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(170, 343);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(156, 45);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "  Cancel Order";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.Snow;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.btnCheckout.Image = global::OnlineBookStore.Properties.Resources.proceed;
            this.btnCheckout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckout.Location = new System.Drawing.Point(8, 343);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(156, 45);
            this.btnCheckout.TabIndex = 6;
            this.btnCheckout.Text = " Check Out";
            this.btnCheckout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.Snow;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.btnPrev.Image = global::OnlineBookStore.Properties.Resources.prev;
            this.btnPrev.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrev.Location = new System.Drawing.Point(3, 347);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(148, 38);
            this.btnPrev.TabIndex = 7;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Snow;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.btnOrder.Image = global::OnlineBookStore.Properties.Resources.creditcard;
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.Location = new System.Drawing.Point(336, 347);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(148, 38);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // ShoppingCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 427);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShoppingCartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Shopping Cart";
            this.tabControl.ResumeLayout(false);
            this.tpShoppingList.ResumeLayout(false);
            this.tpShoppingList.PerformLayout();
            this.tpOrderInfo.ResumeLayout(false);
            this.tpOrderInfo.PerformLayout();
            this.grpCreditCard.ResumeLayout(false);
            this.grpCreditCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.FlowLayoutPanel pnlProducts;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpShoppingList;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TabPage tpOrderInfo;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.RadioButton rbCreditCard;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.GroupBox grpCreditCard;
        private System.Windows.Forms.TextBox txtCardOwner;
        private System.Windows.Forms.MaskedTextBox mtCVC;
        private System.Windows.Forms.Label lblCardOwner;
        private System.Windows.Forms.Label lblCVC;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.DateTimePicker dtpExpDate;
        private System.Windows.Forms.Label lbExpDate;
        private System.Windows.Forms.MaskedTextBox mtCardNumber;
        private System.Windows.Forms.Button btnCancel;
    }
}