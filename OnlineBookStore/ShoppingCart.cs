using System;
using System.Collections.Generic;

namespace OnlineBookStore
{
    public class ShoppingCart
    {
        public List<ItemToPurchase> ItemsToPurchase;
        public Customer Customer;
        public double PaymentAmount;
        public int PaymentType;
        ShoppingCartForm shoppingForm;
        List<ShoppingItemPanel> list;
        public ShoppingCart()
        {
            ItemsToPurchase = new List<ItemToPurchase>();
        }
        public void PlaceOrder(string shipmentAdress,string email)
        {
            shoppingForm.Close();
            shoppingForm.Dispose();
            InvoiceForm invoice = new InvoiceForm(shipmentAdress,email);
            invoice.ShowDialog();
            ItemsToPurchase.Clear();
            list.Clear();
        }
        public void removeProduct(ItemToPurchase item)
        {
            ItemsToPurchase.Remove(item);
            foreach (var it in list)
            {
                if (it.item == item) { 
                    list.Remove(it);
                    break;
                }
            }
            refreshPanel();
        }
        public void refreshPanel()
        {
            shoppingForm.fillPanel();
        }
        public void ShowProducts()
        {
            list = new List<ShoppingItemPanel>();

            foreach (ItemToPurchase item in ItemsToPurchase)
            {
                ShoppingItemPanel pnl = new ShoppingItemPanel(item);
                list.Add(pnl);
            }
            shoppingForm = new ShoppingCartForm(list);
            if(list.Count!=0)
                shoppingForm.ShowDialog();

        }

        public void ShowInvoices()
        {
            PurchasesForm pForm = new PurchasesForm();
            pForm.ShowDialog();
        }

        public void CancelOrder()
        {
            ItemsToPurchase.Clear();
            list.Clear();
            PaymentAmount = 0;
            shoppingForm.Close();
            shoppingForm.Dispose();
        }
    }
}
