
namespace OnlineBookStore
{
    public class ItemToPurchase
    {
        private Product product;
        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public Product Product
        {
            get { return product; }
            set { product = value; }
        }
    }
}
