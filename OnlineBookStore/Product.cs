using System;
using System.Drawing;

namespace OnlineBookStore
{
    public abstract class Product
    {  
        public String name;
        public double price;
        public int ProductID;
        public string Category;
        public Image image;
        public double Sale;
        public double discountedPrice;
        public abstract void ShowProperties();
    }
}
