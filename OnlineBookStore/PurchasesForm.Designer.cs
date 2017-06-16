namespace OnlineBookStore
{
    partial class PurchasesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchasesForm));
            this.btnSendMail = new System.Windows.Forms.Button();
            this.pbInvoice0 = new System.Windows.Forms.PictureBox();
            this.pbInvoice1 = new System.Windows.Forms.PictureBox();
            this.pbInvoice2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbInvoice0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInvoice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInvoice2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSendMail
            // 
            this.btnSendMail.BackColor = System.Drawing.Color.White;
            this.btnSendMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendMail.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.btnSendMail.Image = global::OnlineBookStore.Properties.Resources.mail;
            this.btnSendMail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendMail.Location = new System.Drawing.Point(699, 473);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(194, 42);
            this.btnSendMail.TabIndex = 4;
            this.btnSendMail.Text = "Email This Invoice";
            this.btnSendMail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSendMail.UseVisualStyleBackColor = false;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // pbInvoice0
            // 
            this.pbInvoice0.Location = new System.Drawing.Point(-119, 12);
            this.pbInvoice0.Name = "pbInvoice0";
            this.pbInvoice0.Size = new System.Drawing.Size(307, 539);
            this.pbInvoice0.TabIndex = 3;
            this.pbInvoice0.TabStop = false;
            this.pbInvoice0.Click += new System.EventHandler(this.pbInvoice0_Click);
            // 
            // pbInvoice1
            // 
            this.pbInvoice1.Location = new System.Drawing.Point(194, 12);
            this.pbInvoice1.Name = "pbInvoice1";
            this.pbInvoice1.Size = new System.Drawing.Size(499, 539);
            this.pbInvoice1.TabIndex = 0;
            this.pbInvoice1.TabStop = false;
            // 
            // pbInvoice2
            // 
            this.pbInvoice2.Location = new System.Drawing.Point(699, 12);
            this.pbInvoice2.Name = "pbInvoice2";
            this.pbInvoice2.Size = new System.Drawing.Size(307, 539);
            this.pbInvoice2.TabIndex = 2;
            this.pbInvoice2.TabStop = false;
            this.pbInvoice2.Click += new System.EventHandler(this.pbInvoice2_Click);
            // 
            // PurchasesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 562);
            this.Controls.Add(this.btnSendMail);
            this.Controls.Add(this.pbInvoice0);
            this.Controls.Add(this.pbInvoice1);
            this.Controls.Add(this.pbInvoice2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PurchasesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Invoices";
            this.Load += new System.EventHandler(this.PurchasesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbInvoice0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInvoice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInvoice2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbInvoice1;
        private System.Windows.Forms.PictureBox pbInvoice2;
        private System.Windows.Forms.PictureBox pbInvoice0;
        private System.Windows.Forms.Button btnSendMail;
    }
}