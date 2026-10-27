namespace OliveBranchBakes.Forms
{
    public partial class ProjectInfoForm : Form
    {
        public ProjectInfoForm()
        {
            InitializeComponent();

            lblProjectNameValue.Text = "Olive Branch Bakes Order System";
            lblStudentNameValue.Text = "Joao Antonio Carvalho";
            lblPhaseValue.Text = "Checkpoint 3A - DataStore and Test Cases";
            lblClassValue.Text = "Object Oriented Programming";
            lblDateValue.Text = DateTime.Today.ToString("MMMM d, yyyy");
            lblDescriptionValue.Text = "A Windows app for Olive Branch Bakes. Olivia can record orders in one place, " +
                "save allergy information on every order, manage the menu, and follow the status of each order. " +
                "Customers can order as a guest or create an account.";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
