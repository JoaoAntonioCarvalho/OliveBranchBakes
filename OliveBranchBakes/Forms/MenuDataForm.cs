using System.ComponentModel;
using OliveBranchBakes.Services;
using MenuItem = OliveBranchBakes.Models.MenuItem;

namespace OliveBranchBakes.Forms
{
    // for now this form only shows the saved menu. Later it will be part of the Admin Console.
    public partial class MenuDataForm : Form
    {
        private DataStore store = new DataStore();
        private BindingList<MenuItem> menuItems = new BindingList<MenuItem>();

        public MenuDataForm()
        {
            InitializeComponent();
            lblPath.Text = "File: " + store.FilePath;
            LoadGrid(store.LoadMenu());
            ShowSource();
        }

        private void LoadGrid(List<MenuItem> items)
        {
            menuItems = new BindingList<MenuItem>(items);
            dgvMenu.DataSource = menuItems;
        }

        private void ShowSource()
        {
            if (store.LoadedFromFile)
            {
                lblSource.Text = "Data loaded from the saved file.";
            }
            else
            {
                lblSource.Text = "Data loaded from the seed menu.";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dgvMenu.EndEdit();
            store.SaveMenu(new List<MenuItem>(menuItems));
            lblSource.Text = "Saved at " + DateTime.Now.ToString("h:mm:ss tt") + ".";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadGrid(store.GetSeedMenu());
            lblSource.Text = "Seed menu is showing. Click Save to keep it.";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
