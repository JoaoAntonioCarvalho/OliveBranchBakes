namespace OliveBranchBakes.Forms
{
    partial class OrderSummaryForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblHeader = new Label();
            pnlAccentLine = new Panel();
            lblCustomer = new Label();
            lblPickup = new Label();
            lvItems = new ListView();
            colItem = new ColumnHeader();
            colQty = new ColumnHeader();
            colPrice = new ColumnHeader();
            lblSubtotal = new Label();
            lblDiscount = new Label();
            lblTotal = new Label();
            lblAllergy = new Label();
            lblNote = new Label();
            btnBack = new Button();
            btnPlace = new Button();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            //
            // pnlHeader
            //
            pnlHeader.BackColor = Color.FromArgb(91, 107, 47);
            pnlHeader.Controls.Add(lblHeader);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(620, 64);
            pnlHeader.TabIndex = 0;
            //
            // lblHeader
            //
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(251, 246, 236);
            lblHeader.Location = new Point(20, 12);
            lblHeader.Name = "lblHeader";
            lblHeader.Text = "Order Summary";
            //
            // pnlAccentLine
            //
            pnlAccentLine.BackColor = Color.FromArgb(196, 98, 45);
            pnlAccentLine.Dock = DockStyle.Top;
            pnlAccentLine.Location = new Point(0, 64);
            pnlAccentLine.Name = "pnlAccentLine";
            pnlAccentLine.Size = new Size(620, 4);
            pnlAccentLine.TabIndex = 1;
            //
            // lblCustomer
            //
            lblCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCustomer.Location = new Point(30, 85);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(560, 28);
            lblCustomer.Text = "";
            //
            // lblPickup
            //
            lblPickup.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPickup.Location = new Point(30, 115);
            lblPickup.Name = "lblPickup";
            lblPickup.Size = new Size(560, 28);
            lblPickup.Text = "";
            //
            // lvItems
            //
            lvItems.BackColor = Color.FromArgb(255, 252, 245);
            lvItems.BorderStyle = BorderStyle.FixedSingle;
            lvItems.Columns.AddRange(new ColumnHeader[] { colItem, colQty, colPrice });
            lvItems.Font = new Font("Segoe UI", 11F);
            lvItems.ForeColor = Color.FromArgb(74, 46, 26);
            lvItems.FullRowSelect = true;
            lvItems.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvItems.Location = new Point(30, 152);
            lvItems.MultiSelect = false;
            lvItems.Name = "lvItems";
            lvItems.Size = new Size(560, 200);
            lvItems.TabIndex = 0;
            lvItems.View = View.Details;
            //
            // colItem
            //
            colItem.Text = "Item";
            colItem.Width = 330;
            //
            // colQty
            //
            colQty.Text = "Qty";
            colQty.Width = 70;
            //
            // colPrice
            //
            colPrice.Text = "Price";
            colPrice.Width = 130;
            //
            // lblSubtotal
            //
            lblSubtotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
            lblSubtotal.Location = new Point(30, 365);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(560, 28);
            lblSubtotal.Text = "";
            //
            // lblDiscount
            //
            lblDiscount.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
            lblDiscount.Location = new Point(30, 393);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(560, 28);
            lblDiscount.Text = "";
            //
            // lblTotal
            //
            lblTotal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTotal.Location = new Point(30, 421);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(560, 34);
            lblTotal.Text = "";
            //
            // lblAllergy
            //
            lblAllergy.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
            lblAllergy.Location = new Point(30, 465);
            lblAllergy.Name = "lblAllergy";
            lblAllergy.Size = new Size(560, 56);
            lblAllergy.Text = "";
            //
            // lblNote
            //
            lblNote.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblNote.Location = new Point(30, 525);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(560, 40);
            lblNote.Text = "Totals are only for Olivia to read. There is no online payment, you pay when you pick up.";
            //
            // btnBack
            //
            btnBack.BackColor = Color.FromArgb(251, 246, 236);
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(91, 107, 47);
            btnBack.FlatAppearance.BorderSize = 2;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBack.ForeColor = Color.FromArgb(74, 46, 26);
            btnBack.Location = new Point(30, 580);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(260, 50);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back to Order";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            //
            // btnPlace
            //
            btnPlace.BackColor = Color.FromArgb(217, 162, 58);
            btnPlace.Cursor = Cursors.Hand;
            btnPlace.FlatAppearance.BorderSize = 0;
            btnPlace.FlatStyle = FlatStyle.Flat;
            btnPlace.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPlace.ForeColor = Color.FromArgb(74, 46, 26);
            btnPlace.Location = new Point(330, 580);
            btnPlace.Name = "btnPlace";
            btnPlace.Size = new Size(260, 50);
            btnPlace.TabIndex = 2;
            btnPlace.Text = "Place Order";
            btnPlace.UseVisualStyleBackColor = false;
            btnPlace.Click += btnPlace_Click;
            //
            // OrderSummaryForm
            //
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(251, 246, 236);
            CancelButton = btnBack;
            ClientSize = new Size(620, 660);
            Controls.Add(btnPlace);
            Controls.Add(btnBack);
            Controls.Add(lblNote);
            Controls.Add(lblAllergy);
            Controls.Add(lblTotal);
            Controls.Add(lblDiscount);
            Controls.Add(lblSubtotal);
            Controls.Add(lvItems);
            Controls.Add(lblPickup);
            Controls.Add(lblCustomer);
            Controls.Add(pnlAccentLine);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 12F);
            ForeColor = Color.FromArgb(74, 46, 26);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OrderSummaryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Olive Branch Bakes - Order Summary";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblHeader;
        private Panel pnlAccentLine;
        private Label lblCustomer;
        private Label lblPickup;
        private ListView lvItems;
        private ColumnHeader colItem;
        private ColumnHeader colQty;
        private ColumnHeader colPrice;
        private Label lblSubtotal;
        private Label lblDiscount;
        private Label lblTotal;
        private Label lblAllergy;
        private Label lblNote;
        private Button btnBack;
        private Button btnPlace;
    }
}
