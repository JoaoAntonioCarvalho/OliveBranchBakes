using System.ComponentModel;
using OliveBranchBakes.Services;
using MenuItem = OliveBranchBakes.Models.MenuItem;

namespace OliveBranchBakes.Forms
{
    // for now this form only shows the saved menu. Later it will be part of the Admin Console.
    public partial class MenuDataForm : Form
    {
        private DataStore store = new DataStore();
        private BindingList<MenuItem> menuItems;

        public MenuDataForm()
        {
            InitializeComponent();
            lblPath.Text = "File: " + store.FilePath;
            menuItems = new BindingList<MenuItem>(store.LoadMenu());
            dgvMenu.DataSource = menuItems;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dgvMenu.EndEdit();
            store.SaveMenu(new List<MenuItem>(menuItems));
        }

        private void dgvMenu_DataError(object? sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Please type a number for the price.");
            e.ThrowException = false;
        }
    }
}
