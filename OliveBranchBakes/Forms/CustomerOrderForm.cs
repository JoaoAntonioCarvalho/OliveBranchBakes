namespace OliveBranchBakes.Forms
{
    // Phase 2: prototype only, the buttons do not place orders yet
    public partial class CustomerOrderForm : Form
    {
        public CustomerOrderForm()
        {
            InitializeComponent();

            // sample items so we can see how the order list will look
            lvOrder.Items.Add(new ListViewItem(new string[] { "Chocolate Chip Cookies", "1", "$12.00" }));
            lvOrder.Items.Add(new ListViewItem(new string[] { "Cinnamon Rolls", "1", "$15.00" }));
            lvOrder.Items.Add(new ListViewItem(new string[] { "Pumpkin Bread", "1", "$9.00" }));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            FormNavigation.ShowPlannedForm("Customer Login / Account");
        }

        private void btnReviewOrder_Click(object sender, EventArgs e)
        {
            FormNavigation.ShowPlannedForm("Order Summary");
        }

        // menu buttons, Add to Order and Remove use this one
        private void PrototypeButton_Click(object sender, EventArgs e)
        {
            FormNavigation.ShowPrototypeMessage();
        }
    }
}
