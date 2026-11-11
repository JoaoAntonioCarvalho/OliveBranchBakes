using OliveBranchBakes.Models;
using OliveBranchBakes.Services;
using MenuItem = OliveBranchBakes.Models.MenuItem;

namespace OliveBranchBakes.Forms
{
    // Phase 3C: the menu and the order list work, customers can sign in,
    // and Review Order shows the summary and saves the order.
    public partial class CustomerOrderForm : Form
    {
        private MenuService menuService = new MenuService();
        private OrderService orderService = new OrderService();
        private Order order = new Order();
        private AccountCustomer? signedInCustomer;
        private MenuItem? selectedItem;

        public CustomerOrderForm()
        {
            InitializeComponent();

            cboCategory.Items.Add("All");
            foreach (MenuCategory category in Enum.GetValues<MenuCategory>())
            {
                cboCategory.Items.Add(category.ToString());
            }
            cboCategory.SelectedIndex = 0;   // this also shows the menu

            RefreshOrderList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            AccountForm accountForm = new AccountForm();
            if (accountForm.ShowDialog() == DialogResult.OK && accountForm.SignedInCustomer != null)
            {
                signedInCustomer = accountForm.SignedInCustomer;
                txtName.Text = signedInCustomer.FullName;
                txtPhone.Text = signedInCustomer.Phone;
                txtEmail.Text = signedInCustomer.Email;
                btnSignIn.Text = "Signed in: " + signedInCustomer.FullName;
            }
        }

        private void btnReviewOrder_Click(object sender, EventArgs e)
        {
            if (order.Items.Count == 0)
            {
                MessageBox.Show("Please add at least one item to your order.");
                return;
            }
            if (txtName.Text.Trim() == "" || txtPhone.Text.Trim() == "")
            {
                MessageBox.Show("Please type your name and phone number.");
                return;
            }
            if (!rbNoAllergy.Checked && !rbHasAllergy.Checked)
            {
                MessageBox.Show("Please tell us if there are any allergies.");
                return;
            }
            if (rbHasAllergy.Checked && txtAllergyDetails.Text.Trim() == "")
            {
                MessageBox.Show("Please describe the allergy.");
                return;
            }

            if (signedInCustomer != null)
            {
                order.Customer = signedInCustomer;
            }
            else
            {
                GuestCustomer guest = new GuestCustomer();
                guest.FullName = txtName.Text.Trim();
                guest.Phone = txtPhone.Text.Trim();
                guest.Email = txtEmail.Text.Trim();
                order.Customer = guest;
            }

            AllergyInfo allergy = new AllergyInfo();
            allergy.HasAllergy = rbHasAllergy.Checked;
            allergy.Details = txtAllergyDetails.Text.Trim();
            order.Allergy = allergy;
            order.PickupDate = dtpPickup.Value.Date;

            OrderSummaryForm summaryForm = new OrderSummaryForm(order, orderService);
            if (summaryForm.ShowDialog() == DialogResult.OK)
            {
                // the order is saved, start a new one
                order = new Order();
                RefreshOrderList();
            }
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowMenu();
        }

        private void dtpPickup_ValueChanged(object sender, EventArgs e)
        {
            RemoveHiddenItemsFromOrder();
            ShowMenu();
        }

        // makes one button for each item the customer can order on the pickup date
        private void ShowMenu()
        {
            MenuCategory? category = null;
            if (cboCategory.SelectedIndex > 0)
            {
                category = Enum.Parse<MenuCategory>(cboCategory.Text);
            }

            List<MenuItem> items = menuService.GetVisibleItems(dtpPickup.Value, category);

            selectedItem = null;
            flpItems.Controls.Clear();
            foreach (MenuItem item in items)
            {
                flpItems.Controls.Add(CreateItemButton(item));
            }

            if (items.Count == 0)
            {
                lblMenuHint.Text = "No items in this category for the pickup date you chose.";
            }
            else
            {
                lblMenuHint.Text = "Tap an item, choose how many, then tap Add to Order.";
            }
        }

        private Button CreateItemButton(MenuItem item)
        {
            Button button = new Button();
            button.BackColor = Color.FromArgb(255, 252, 245);
            button.Cursor = Cursors.Hand;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 2;
            button.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button.ForeColor = Color.FromArgb(74, 46, 26);
            button.Margin = new Padding(0, 0, 8, 10);
            button.Size = new Size(195, 85);
            button.Tag = item;

            // seasonal items have an orange border, like in the prototype
            string name = item.Name;
            if (item.IsSeasonal)
            {
                button.FlatAppearance.BorderColor = Color.FromArgb(196, 98, 45);
                name = name + " (Seasonal)";
            }
            else
            {
                button.FlatAppearance.BorderColor = Color.FromArgb(91, 107, 47);
            }
            button.Text = name + "\r\n$" + item.Price.ToString("0.00") + " / " + item.Description;

            button.Click += ItemButton_Click;
            return button;
        }

        private void ItemButton_Click(object? sender, EventArgs e)
        {
            Button clicked = (Button)sender!;
            selectedItem = clicked.Tag as MenuItem;

            foreach (Control control in flpItems.Controls)
            {
                control.BackColor = Color.FromArgb(255, 252, 245);
            }
            clicked.BackColor = Color.FromArgb(252, 239, 208);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (selectedItem == null)
            {
                MessageBox.Show("Please tap an item on the menu first.");
                return;
            }

            try
            {
                order.AddItem(selectedItem, (int)nudQty.Value);
                RefreshOrderList();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChangeQty_Click(object sender, EventArgs e)
        {
            if (lvOrder.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Please select an item in your order first.");
                return;
            }

            int index = lvOrder.SelectedIndices[0];
            try
            {
                order.ChangeQuantity(order.Items[index], (int)nudQty.Value);
                RefreshOrderList();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (lvOrder.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Please select an item in your order first.");
                return;
            }

            order.RemoveItem(order.Items[lvOrder.SelectedIndices[0]]);
            RefreshOrderList();
        }

        // fills the list from the order and shows the running subtotal
        private void RefreshOrderList()
        {
            lvOrder.Items.Clear();
            foreach (OrderItem line in order.Items)
            {
                string name = "";
                if (line.Item != null)
                {
                    name = line.Item.Name;
                }
                lvOrder.Items.Add(new ListViewItem(new string[]
                {
                    name,
                    line.Quantity.ToString(),
                    "$" + line.GetLineTotal().ToString("0.00")
                }));
            }
            lblTotal.Text = "Subtotal: $" + order.GetSubtotal().ToString("0.00");
        }

        // an item in the order may not be sold on the new pickup date
        private void RemoveHiddenItemsFromOrder()
        {
            List<string> removedNames = new List<string>();

            // go from the end so removing a line does not skip the next one
            for (int i = order.Items.Count - 1; i >= 0; i--)
            {
                MenuItem? item = order.Items[i].Item;
                if (item != null && !item.IsVisibleOn(dtpPickup.Value))
                {
                    removedNames.Add(item.Name);
                    order.RemoveItem(order.Items[i]);
                }
            }

            if (removedNames.Count > 0)
            {
                RefreshOrderList();
                MessageBox.Show(string.Join(", ", removedNames) +
                    " is not sold on that pickup date, so it was removed from your order.");
            }
        }
    }
}
