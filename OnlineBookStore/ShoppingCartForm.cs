using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class ShoppingCartForm : Form
    {
        List<ShoppingItemPanel> list;
        double totalPrice;
        Customer customer;
        public ShoppingCartForm(List<ShoppingItemPanel> list)
        {
            InitializeComponent();
            this.list = list;
            fillPanel();
            rbCreditCard.Checked = true;
            customer = MainForm.shoppingCart.Customer;
            lblCustName.Text = customer.Name;
            txtAddress.Text = customer.Adress;
            txtEmail.Text = customer.Email;
            dtpExpDate.MinDate = DateTime.Now;
            dtpExpDate.Value = DateTime.Now;
            dtpExpDate.MaxDate = DateTime.Now.AddYears(5);
        }
        public void fillPanel()
        {
            totalPrice = 0;
            pnlProducts.Controls.Clear();
            if (list.Count == 0)
            {
                MessageBox.Show("Your cart is empty. Add something.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            foreach (var item in list)
            {
                totalPrice += item.item.Product.discountedPrice * item.item.Quantity;
                pnlProducts.Controls.Add(item);
            }
            lblTotalPrice.Text = totalPrice + " TL";
            MainForm.shoppingCart.PaymentAmount = totalPrice;
        }

        private void rbCash_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control item in grpCreditCard.Controls)
            {
                item.Enabled = false;
            }
            btnOrder.Image = Properties.Resources.cash;
        }

        private void rbCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control item in grpCreditCard.Controls)
            {
                item.Enabled = true;
            }

            btnOrder.Image = Properties.Resources.creditcard;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {

            Logger.logger("Shopping Cart Previous");
            tabControl.SelectedIndex = 0;
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {

            Logger.logger("Shopping Cart Checkout");
            tabControl.SelectedIndex = 1;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

            Logger.logger("Shopping Cart Order");
            if (txtAddress.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("There are empty fields.", "Error");
            }
            else if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Invalid Email Address.", "Error");
            }

            else if(rbCreditCard.Checked && (txtCardOwner.Text == "" || !mtCardNumber.MaskFull || !mtCVC.MaskFull))
            {
                MessageBox.Show("There are empty fields.");
            }
            else
            {
                MainForm.shoppingCart.PlaceOrder(txtAddress.Text,txtEmail.Text);
            }

        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr=MessageBox.Show("Your order will be canceled.Do you want to proceed?", "Info", MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            if(dr==DialogResult.OK)
                MainForm.shoppingCart.CancelOrder();
        }
    }
}
