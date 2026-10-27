namespace OliveBranchBakes.Forms
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();

            // load the logo from the Assets folder
            string logoPath = Path.Combine(AppContext.BaseDirectory, "Assets", "logo.png");
            if (File.Exists(logoPath))
            {
                picLogo.Image = Image.FromFile(logoPath);
            }
        }

        private void btnStartOrder_Click(object sender, EventArgs e)
        {
            CustomerOrderForm orderForm = new CustomerOrderForm();
            this.Hide();
            orderForm.ShowDialog();
            this.Show();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            FormNavigation.ShowPlannedForm("Customer Login / Account");
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FormNavigation.ShowPlannedForm("Administrator Login");
        }

        private void lnkAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProjectInfoForm infoForm = new ProjectInfoForm();
            infoForm.ShowDialog();
        }
    }
}
