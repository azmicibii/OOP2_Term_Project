using System;

namespace OnlineBookStore
{
    public class MusicCD:Product
    {
        public String Singer; 
        public string Description;
        public string demo;

        public override void ShowProperties()
        {

            MusicForm musicForm = new MusicForm(this);
            musicForm.ShowDialog();
            musicForm.Dispose();
        }
    }
}
