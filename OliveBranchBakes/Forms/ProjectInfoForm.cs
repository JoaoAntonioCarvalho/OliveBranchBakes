using OliveBranchBakes.Services;

namespace OliveBranchBakes.Forms
{
    public partial class ProjectInfoForm : Form
    {
        public ProjectInfoForm()
        {
            InitializeComponent();

            lblProjectNameValue.Text = "Olive Branch Bakes Order System";
            lblStudentNameValue.Text = "Joao Antonio Carvalho";
            lblPhaseValue.Text = "Checkpoint 3D - Final Release";
            lblClassValue.Text = "Object Oriented Programming";
            lblDateValue.Text = DateTime.Today.ToString("MMMM d, yyyy");
            lblDescriptionValue.Text = "A Windows app for Olive Branch Bakes. Olivia can record orders in one place, " +
                "save allergy information on every order, manage the menu, and follow the status of each order. " +
                "Customers can order as a guest or create an account.";
        }

        // runs T1 to T13 from docs/TestCases.md on the real pricing and scheduling code
        private void btnTests_Click(object sender, EventArgs e)
        {
            TestRunner runner = new TestRunner();
            List<TestResult> results = runner.RunAll();

            int passed = 0;
            string text = "";
            foreach (TestResult result in results)
            {
                string mark = result.Passed ? "PASS" : "FAIL";
                if (result.Passed)
                {
                    passed++;
                }
                text += result.Id + "  " + mark + "  " + result.Description +
                    "  (expected " + result.Expected + ", got " + result.Actual + ")" + Environment.NewLine;
            }
            text += Environment.NewLine + passed + " of " + results.Count + " tests passed.";

            MessageBox.Show(text, "Final tests T1 to T13");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
