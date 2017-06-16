using System;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class LoadingForm : Form
    {
        int counter = 0;
        public LoadingForm()
        {
            InitializeComponent();
            loadingTimer.Interval = 100;
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            loadingTimer.Start();
        }

        public int ProgressBarValue
        {
            get { return (this.loadingBar.Value); }
            set { this.loadingBar.Value = value; }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter += 7;
            if (counter > 100) counter = 100;
            loadingBar.Value = counter;
        }
    }
}
