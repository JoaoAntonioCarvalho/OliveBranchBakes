using OliveBranchBakes.Models;
using OliveBranchBakes.Services;

namespace OliveBranchBakes.Forms
{
    // shows the whole order with the discount before it is placed
    public partial class OrderSummaryForm : Form
    {
        private Order order;
        private OrderService orderService;
        private PricingService pricingService = new PricingService();

        public OrderSummaryForm(Order order, OrderService orderService)
        {
            InitializeComponent();
            this.order = order;
            this.orderService = orderService;
            ShowOrder();
        }

        private void ShowOrder()
        {
            string customerName = "";
            if (order.Customer != null)
            {
                customerName = order.Customer.FullName + " - " + order.Customer.Phone;
            }
            lblCustomer.Text = "Customer: " + customerName;
            lblPickup.Text = "Pickup date: " + order.PickupDate.ToString("dddd, MMMM d, yyyy");

            lvItems.Items.Clear();
            foreach (OrderItem line in order.Items)
            {
                string name = "";
                if (line.Item != null)
                {
                    name = line.Item.Name;
                }
                lvItems.Items.Add(new ListViewItem(new string[]
                {
                    name,
                    line.Quantity.ToString(),
                    "$" + line.GetLineTotal().ToString("0.00")
                }));
            }

            lblSubtotal.Text = "Subtotal: $" + order.GetSubtotal().ToString("0.00");
            lblDiscount.Text = "Discount: -$" + pricingService.GetDiscount(order).ToString("0.00");
            lblTotal.Text = "Total: $" + pricingService.GetTotal(order).ToString("0.00");

            if (order.Allergy != null && order.Allergy.HasAllergy)
            {
                lblAllergy.Text = "Allergy information: " + order.Allergy.Details;
            }
            else
            {
                lblAllergy.Text = "Allergy information: no allergies";
            }
        }

        private void btnPlace_Click(object sender, EventArgs e)
        {
            try
            {
                Order placed = orderService.PlaceOrder(order);
                MessageBox.Show("Thank you, " + placed.Customer!.FullName + "! Your order #" + placed.OrderId +
                    " was received.\r\nPickup: " + placed.PickupDate.ToString("dddd, MMMM d, yyyy") +
                    "\r\nTotal: $" + pricingService.GetTotal(placed).ToString("0.00"),
                    "Order Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
