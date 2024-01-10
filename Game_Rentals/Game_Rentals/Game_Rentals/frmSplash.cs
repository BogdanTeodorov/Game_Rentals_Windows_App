namespace Game_Rentals
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblProduct.Text = Application.ProductName;
            lblVersion.Text = Application.ProductVersion;
            lblCompany.Text = Application.CompanyName;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (prgLoading.Value < 100)
                prgLoading.Increment(2);
            else
            {
                timer1.Enabled = false;
                frmMDIGameRentals f = new();

                f.Show();


                f.FormClosed += mdiClose;
                this.Hide();
            }
        }

        private void mdiClose(object? sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
