using System;
namespace OnlineBookStore
{
    public class Magazine:Product
    {
        public String Issue;
        public string Description;

        public override void ShowProperties()
        {
            MagazineForm magazineForm = new MagazineForm(this);
            magazineForm.ShowDialog();
            magazineForm.Dispose();
        }
    }
}
