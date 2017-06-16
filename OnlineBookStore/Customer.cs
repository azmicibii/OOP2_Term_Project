using System.Drawing;

namespace OnlineBookStore
{
    public class Customer
    {
        private long id;
        private string name;
        private string adress;
        private string email;
        private string username;
        private string password;
        private bool gender;
        private Image image;
        private int purchCount;

        private static Customer instance;

        private Customer() { }

        public static Customer getInstance()
        {
            if (instance == null)
                instance = new Customer();
            return instance;
        }
        
        public long PurchCount
        {
            get { return purchCount; }
            set { purchCount = (int)value; }
        }

        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public bool Gender
        {
            get { return gender; }
            set { gender = value; }           
        }

        public Image Image
        {
            get { return image; }
            set { image = value; }
        }

        public void ShowCustomerDetails()
        {
            UserProfileForm userForm = new UserProfileForm();
            userForm.ShowDialog();
            userForm.Dispose();
        }

    }

}
