using System;
using System.Drawing;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class InvoiceForm : Form
    {
        public InvoiceForm(string shipmentAdress,string email)
        {
            InitializeComponent();
            lblCompInf.Text = "Online Book Store" + Environment.NewLine + "Eskişehir - OGU" + Environment.NewLine + "Tel: 0222 222 22 22";
            lblDate.Text = DateTime.Now.ToLongDateString();
            Customer cust = Customer.getInstance();
            lblCustInf.Text = "Bill To:" + Environment.NewLine + cust.Name + Environment.NewLine + email + Environment.NewLine + cust.Adress;
            lblShip.Text = "Ship To:" + Environment.NewLine + shipmentAdress;
            foreach (var item in MainForm.shoppingCart.ItemsToPurchase)
            {
                ListViewItem l_item = new ListViewItem();
                if(item.Product is Book)
                    l_item.Text = "BO" + item.Product.ProductID.ToString();
                if (item.Product is Magazine)
                    l_item.Text = "MA" + item.Product.ProductID.ToString();
                if (item.Product is MusicCD)
                    l_item.Text = "MU" + item.Product.ProductID.ToString();
                l_item.SubItems.Add(item.Product.name.ToString());
                l_item.SubItems.Add(item.Quantity.ToString());
                l_item.SubItems.Add(item.Product.discountedPrice.ToString());
                l_item.SubItems.Add((item.Product.discountedPrice* item.Quantity).ToString());
                listView1.Items.Add(l_item);
            }
            lblTotalPrice.Text = MainForm.shoppingCart.PaymentAmount.ToString() + " TL";
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            using (var bitmap = new Bitmap(this.ClientSize.Width,this.ClientSize.Height))
            {
                Customer cust = Customer.getInstance();
                this.pnlInvoice.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
                System.IO.Directory.CreateDirectory(Application.StartupPath + @"\Resources\Invoices\");
                bitmap.Save(Application.StartupPath+@"\Resources\Invoices\"+cust.Username+ cust.PurchCount + ".png");
                cust.PurchCount++;
                DataBaseHandler dh = DataBaseHandler.getInstance();
                dh.CustomerUpdate(cust);
            }
        }
    }
}
