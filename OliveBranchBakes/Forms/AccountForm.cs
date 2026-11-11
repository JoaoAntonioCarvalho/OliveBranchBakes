using OliveBranchBakes.Models;
using OliveBranchBakes.Services;

namespace OliveBranchBakes.Forms
{
    // create an account or sign in with the account email
    public partial class AccountForm : Form
    {
        private CustomerService customerService = new CustomerService();

        // the customer who signed in or created an account, null if nobody did
        public AccountCustomer? SignedInCustomer { get; private set; }

        public AccountForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                SignedInCustomer = customerService.CreateAccount(txtName.Text, txtPhone.Text, txtEmail.Text);
                MessageBox.Show("Your account was created. Welcome, " + SignedInCustomer.FullName + "!");
                this.DialogResult = DialogResult.OK;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Please type the email of your account.");
                return;
            }

            AccountCustomer? account = customerService.FindAccountByEmail(txtEmail.Text);
            if (account == null)
            {
                MessageBox.Show("No account was found with this email.");
                return;
            }

            SignedInCustomer = account;
            MessageBox.Show("Welcome back, " + account.FullName + "!");
            this.DialogResult = DialogResult.OK;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
