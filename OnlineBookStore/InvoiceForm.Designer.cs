namespace OnlineBookStore
{
    partial class InvoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceForm));
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblCompInf = new System.Windows.Forms.Label();
            this.lblCustInf = new System.Windows.Forms.Label();
            this.lblShip = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pnlInvoice = new System.Windows.Forms.Panel();
            this.pnlInvoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(301, 30);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(140, 23);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCompany
            // 
            this.lblCompany.Font = new System.Drawing.Font("Stencil Std", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(3, 9);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(131, 64);
            this.lblCompany.TabIndex = 1;
            this.lblCompany.Text = "OBS";
            this.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCompInf
            // 
            this.lblCompInf.Location = new System.Drawing.Point(140, 10);
            this.lblCompInf.Name = "lblCompInf";
            this.lblCompInf.Size = new System.Drawing.Size(152, 63);
            this.lblCompInf.TabIndex = 2;
            this.lblCompInf.Text = "Company information";
            this.lblCompInf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustInf
            // 
            this.lblCustInf.Location = new System.Drawing.Point(12, 85);
            this.lblCustInf.Name = "lblCustInf";
            this.lblCustInf.Size = new System.Drawing.Size(170, 92);
            this.lblCustInf.TabIndex = 3;
            this.lblCustInf.Text = "Customer information";
            // 
            // lblShip
            // 
            this.lblShip.Location = new System.Drawing.Point(271, 85);
            this.lblShip.Name = "lblShip";
            this.lblShip.Size = new System.Drawing.Size(170, 92);
            this.lblShip.TabIndex = 4;
            this.lblShip.Text = "Shipment information";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.name,
            this.quantity,
            this.uPrice,
            this.tPrice});
            this.listView1.Enabled = false;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(15, 180);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(426, 289);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "ID";
            this.Id.Width = 39;
            // 
            // name
            // 
            this.name.Text = "Product";
            this.name.Width = 199;
            // 
            // quantity
            // 
            this.quantity.Text = "Quantity";
            this.quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // uPrice
            // 
            this.uPrice.Text = "Unit Price";
            this.uPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tPrice
            // 
            this.tPrice.Text = "Total Price";
            this.tPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tPrice.Width = 63;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalPrice.Location = new System.Drawing.Point(374, 472);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(67, 20);
            this.lblTotalPrice.TabIndex = 7;
            this.lblTotalPrice.Text = "Price";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotal.Location = new System.Drawing.Point(320, 472);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(48, 20);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total:";
            // 
            // pnlInvoice
            // 
            this.pnlInvoice.Controls.Add(this.listView1);
            this.pnlInvoice.Controls.Add(this.lblCompInf);
            this.pnlInvoice.Controls.Add(this.lblTotal);
            this.pnlInvoice.Controls.Add(this.lblShip);
            this.pnlInvoice.Controls.Add(this.lblTotalPrice);
            this.pnlInvoice.Controls.Add(this.lblCustInf);
            this.pnlInvoice.Controls.Add(this.lblCompany);
            this.pnlInvoice.Controls.Add(this.lblDate);
            this.pnlInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInvoice.Location = new System.Drawing.Point(0, 0);
            this.pnlInvoice.Name = "pnlInvoice";
            this.pnlInvoice.Size = new System.Drawing.Size(453, 508);
            this.pnlInvoice.TabIndex = 8;
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(453, 508);
            this.Controls.Add(this.pnlInvoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InvoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InvoiceForm";
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            this.pnlInvoice.ResumeLayout(false);
            this.pnlInvoice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblCompInf;
        private System.Windows.Forms.Label lblCustInf;
        private System.Windows.Forms.Label lblShip;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ColumnHeader uPrice;
        private System.Windows.Forms.ColumnHeader tPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel pnlInvoice;
    }
}