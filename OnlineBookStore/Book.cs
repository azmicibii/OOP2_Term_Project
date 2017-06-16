using System;

namespace OnlineBookStore
{
    public class Book:Product
    {
        public String Author;
        public String Publisher;
        public int Page;
        public string Description;

        public override void ShowProperties()
        {
            BookForm bookForm = new BookForm(this);
            bookForm.ShowDialog();
            bookForm.Dispose();
        }
    }
}
