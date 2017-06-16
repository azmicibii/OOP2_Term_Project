using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class PurchasesForm : Form
    {
        ArrayList invoices;
        Customer cst;
        public PurchasesForm()
        {
            InitializeComponent();
            invoices = new ArrayList();
            cst = Customer.getInstance();

            for(int i =0; i< cst.PurchCount; i++) { 
                try
                {
                    invoices.Add(Image.FromFile(Application.StartupPath + @"\Resources\Invoices\" + cst.Username + i + ".png"));
                }
                catch (Exception)
                {
                }
            }
            pbInvoice0.SizeMode = PictureBoxSizeMode.Zoom;
            pbInvoice1.SizeMode = PictureBoxSizeMode.Zoom;
            pbInvoice2.SizeMode = PictureBoxSizeMode.Zoom;
            
        }

        int flag = 0;
        private void pbInvoice2_Click(object sender, EventArgs e)
        {

            Logger.logger("Purchases Form Next Image");
            if (flag < invoices.Count - 1)
            {
                flag++;
                pbInvoice0.Image = (Image)invoices[flag-1];
                pbInvoice1.Image = (Image)invoices[flag];
                if (flag == invoices.Count - 1)
                    pbInvoice2.Image = null;
                else
                    pbInvoice2.Image = (Image)invoices[flag + 1];
            }
        }

        private void pbInvoice0_Click(object sender, EventArgs e)
        {
            Logger.logger("Purchases Form Previous Image");
            if (flag > 0)
            {
                flag--;
                if (flag == 0)
                    pbInvoice0.Image = null;
                else
                    pbInvoice0.Image = (Image)invoices[flag - 1];
                pbInvoice1.Image = (Image)invoices[flag];
                pbInvoice2.Image = (Image)invoices[flag + 1];
            }
        }

        private void PurchasesForm_Load(object sender, EventArgs e)
        {
            if(invoices.Count == 0)
            {
                MessageBox.Show("There is no invoice available", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
            pbInvoice1.Image = (Image)invoices[0];
            if (invoices.Count > 1)
                pbInvoice2.Image = (Image)invoices[1];
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            MailSender.Send(Application.StartupPath + @"\Resources\Invoices\" + cst.Username + flag+".png");
        }
    }
}
