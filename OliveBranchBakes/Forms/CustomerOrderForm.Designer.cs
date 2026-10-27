namespace OliveBranchBakes.Forms
{
    partial class CustomerOrderForm
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
            btnSignIn = new Button();
            pnlAccentLine = new Panel();
            tlpMain = new TableLayoutPanel();
            pnlInfo = new Panel();
            pnlMenu = new Panel();
            pnlOrder = new Panel();
            lblInfoHeader = new Label();
            lblName = new Label();
            txtName = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPickup = new Label();
            dtpPickup = new DateTimePicker();
            pnlAllergy = new Panel();
            lblAllergyHeader = new Label();
            lblAllergyQuestion = new Label();
            rbNoAllergy = new RadioButton();
            rbHasAllergy = new RadioButton();
            txtAllergyDetails = new TextBox();
            lblMenuHeader = new Label();
            btnItem1 = new Button();
            btnItem2 = new Button();
            btnItem3 = new Button();
            btnItem4 = new Button();
            btnItem5 = new Button();
            btnItem6 = new Button();
            lblQty = new Label();
            nudQty = new NumericUpDown();
            btnAddItem = new Button();
            lblMenuHint = new Label();
            lblOrderHeader = new Label();
            lvOrder = new ListView();
            colItem = new ColumnHeader();
            colQty = new ColumnHeader();
            colPrice = new ColumnHeader();
            lblTotal = new Label();
            btnRemoveItem = new Button();
            lblPickupNote = new Label();
            pnlFooter = new Panel();
            btnBack = new Button();
            lblPrototypeNote = new Label();
            btnReviewOrder = new Button();
            pnlHeader.SuspendLayout();
            tlpMain.SuspendLayout();
            pnlInfo.SuspendLayout();
            pnlAllergy.SuspendLayout();
            pnlMenu.SuspendLayout();
            pnlOrder.SuspendLayout();
            pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQty).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(91, 107, 47);
            pnlHeader.Controls.Add(btnSignIn);
            pnlHeader.Controls.Add(lblHeader);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1200, 64);
            pnlHeader.TabIndex = 2;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(251, 246, 236);
            lblHeader.Location = new Point(20, 12);
            lblHeader.Name = "lblHeader";
            lblHeader.TabIndex = 1;
            lblHeader.Text = "Place Your Order";
            // 
            // btnSignIn
            // 
            btnSignIn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSignIn.BackColor = Color.FromArgb(217, 162, 58);
            btnSignIn.Cursor = Cursors.Hand;
            btnSignIn.FlatAppearance.BorderSize = 0;
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSignIn.ForeColor = Color.FromArgb(74, 46, 26);
            btnSignIn.Location = new Point(950, 8);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(230, 48);
            btnSignIn.TabIndex = 0;
            btnSignIn.Text = "Sign In to My Account";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // pnlAccentLine
            // 
            pnlAccentLine.BackColor = Color.FromArgb(196, 98, 45);
            pnlAccentLine.Dock = DockStyle.Top;
            pnlAccentLine.Location = new Point(0, 64);
            pnlAccentLine.Name = "pnlAccentLine";
            pnlAccentLine.Size = new Size(1200, 4);
            pnlAccentLine.TabIndex = 3;
            // 
            // tlpMain
            // 
            tlpMain.BackColor = Color.FromArgb(251, 246, 236);
            tlpMain.ColumnCount = 3;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpMain.Controls.Add(pnlInfo, 0, 0);
            tlpMain.Controls.Add(pnlMenu, 1, 0);
            tlpMain.Controls.Add(pnlOrder, 2, 0);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 68);
            tlpMain.Name = "tlpMain";
            tlpMain.Padding = new Padding(10);
            tlpMain.RowCount = 1;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Size = new Size(1200, 596);
            tlpMain.TabIndex = 0;
            // 
            // pnlInfo
            // 
            pnlInfo.AutoScroll = true;
            pnlInfo.BackColor = Color.FromArgb(255, 252, 245);
            pnlInfo.Controls.Add(pnlAllergy);
            pnlInfo.Controls.Add(dtpPickup);
            pnlInfo.Controls.Add(lblPickup);
            pnlInfo.Controls.Add(txtEmail);
            pnlInfo.Controls.Add(lblEmail);
            pnlInfo.Controls.Add(txtPhone);
            pnlInfo.Controls.Add(lblPhone);
            pnlInfo.Controls.Add(txtName);
            pnlInfo.Controls.Add(lblName);
            pnlInfo.Controls.Add(lblInfoHeader);
            pnlInfo.Dock = DockStyle.Fill;
            pnlInfo.Margin = new Padding(8);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.TabIndex = 0;
            // 
            // lblInfoHeader
            // 
            lblInfoHeader.AutoSize = true;
            lblInfoHeader.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblInfoHeader.ForeColor = Color.FromArgb(91, 107, 47);
            lblInfoHeader.Location = new Point(15, 12);
            lblInfoHeader.Name = "lblInfoHeader";
            lblInfoHeader.TabIndex = 10;
            lblInfoHeader.Text = "1. Your Information";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.ForeColor = Color.FromArgb(74, 46, 26);
            lblName.Location = new Point(15, 50);
            lblName.Name = "lblName";
            lblName.TabIndex = 11;
            lblName.Text = "Full Name";
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(255, 252, 245);
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.ForeColor = Color.FromArgb(74, 46, 26);
            txtName.Location = new Point(15, 74);
            txtName.Name = "txtName";
            txtName.Size = new Size(330, 34);
            txtName.TabIndex = 0;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.ForeColor = Color.FromArgb(74, 46, 26);
            lblPhone.Location = new Point(15, 114);
            lblPhone.Name = "lblPhone";
            lblPhone.TabIndex = 12;
            lblPhone.Text = "Phone Number";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.FromArgb(255, 252, 245);
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Segoe UI", 12F);
            txtPhone.ForeColor = Color.FromArgb(74, 46, 26);
            txtPhone.Location = new Point(15, 138);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "10 digits, example: 3345550123";
            txtPhone.Size = new Size(330, 34);
            txtPhone.TabIndex = 1;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.ForeColor = Color.FromArgb(74, 46, 26);
            lblEmail.Location = new Point(15, 178);
            lblEmail.Name = "lblEmail";
            lblEmail.TabIndex = 13;
            lblEmail.Text = "Email (optional for guests)";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(255, 252, 245);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.ForeColor = Color.FromArgb(74, 46, 26);
            txtEmail.Location = new Point(15, 202);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(330, 34);
            txtEmail.TabIndex = 2;
            // 
            // lblPickup
            // 
            lblPickup.AutoSize = true;
            lblPickup.ForeColor = Color.FromArgb(74, 46, 26);
            lblPickup.Location = new Point(15, 242);
            lblPickup.Name = "lblPickup";
            lblPickup.TabIndex = 14;
            lblPickup.Text = "Pickup Date (pickup only)";
            // 
            // dtpPickup
            // 
            dtpPickup.CalendarForeColor = Color.FromArgb(74, 46, 26);
            dtpPickup.Font = new Font("Segoe UI", 12F);
            dtpPickup.Format = DateTimePickerFormat.Long;
            dtpPickup.Location = new Point(15, 266);
            dtpPickup.Name = "dtpPickup";
            dtpPickup.Size = new Size(330, 34);
            dtpPickup.TabIndex = 3;
            // 
            // pnlAllergy
            // 
            pnlAllergy.BackColor = Color.FromArgb(252, 239, 208);
            pnlAllergy.BorderStyle = BorderStyle.FixedSingle;
            pnlAllergy.Controls.Add(txtAllergyDetails);
            pnlAllergy.Controls.Add(rbHasAllergy);
            pnlAllergy.Controls.Add(rbNoAllergy);
            pnlAllergy.Controls.Add(lblAllergyQuestion);
            pnlAllergy.Controls.Add(lblAllergyHeader);
            pnlAllergy.Location = new Point(15, 310);
            pnlAllergy.Name = "pnlAllergy";
            pnlAllergy.Size = new Size(335, 245);
            pnlAllergy.TabIndex = 4;
            // 
            // lblAllergyHeader
            // 
            lblAllergyHeader.AutoSize = true;
            lblAllergyHeader.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblAllergyHeader.ForeColor = Color.FromArgb(74, 46, 26);
            lblAllergyHeader.Location = new Point(10, 8);
            lblAllergyHeader.Name = "lblAllergyHeader";
            lblAllergyHeader.TabIndex = 10;
            lblAllergyHeader.Text = "2. Allergy Information (required)";
            // 
            // lblAllergyQuestion
            // 
            lblAllergyQuestion.Font = new Font("Segoe UI", 11F);
            lblAllergyQuestion.ForeColor = Color.FromArgb(74, 46, 26);
            lblAllergyQuestion.Location = new Point(10, 38);
            lblAllergyQuestion.Name = "lblAllergyQuestion";
            lblAllergyQuestion.Size = new Size(310, 46);
            lblAllergyQuestion.TabIndex = 11;
            lblAllergyQuestion.Text = "Does anyone who will eat this order have a food allergy?";
            // 
            // rbNoAllergy
            // 
            rbNoAllergy.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rbNoAllergy.ForeColor = Color.FromArgb(74, 46, 26);
            rbNoAllergy.Location = new Point(12, 86);
            rbNoAllergy.Name = "rbNoAllergy";
            rbNoAllergy.Size = new Size(300, 36);
            rbNoAllergy.TabIndex = 0;
            rbNoAllergy.TabStop = true;
            rbNoAllergy.Text = "No allergies";
            rbNoAllergy.UseVisualStyleBackColor = true;
            // 
            // rbHasAllergy
            // 
            rbHasAllergy.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rbHasAllergy.ForeColor = Color.FromArgb(74, 46, 26);
            rbHasAllergy.Location = new Point(12, 124);
            rbHasAllergy.Name = "rbHasAllergy";
            rbHasAllergy.Size = new Size(300, 36);
            rbHasAllergy.TabIndex = 1;
            rbHasAllergy.TabStop = true;
            rbHasAllergy.Text = "Yes - please describe below";
            rbHasAllergy.UseVisualStyleBackColor = true;
            // 
            // txtAllergyDetails
            // 
            txtAllergyDetails.BackColor = Color.FromArgb(255, 252, 245);
            txtAllergyDetails.BorderStyle = BorderStyle.FixedSingle;
            txtAllergyDetails.Font = new Font("Segoe UI", 12F);
            txtAllergyDetails.ForeColor = Color.FromArgb(74, 46, 26);
            txtAllergyDetails.Location = new Point(12, 164);
            txtAllergyDetails.Multiline = true;
            txtAllergyDetails.Name = "txtAllergyDetails";
            txtAllergyDetails.PlaceholderText = "Example: nut allergy";
            txtAllergyDetails.Size = new Size(308, 66);
            txtAllergyDetails.TabIndex = 2;
            // 
            // pnlMenu
            // 
            pnlMenu.AutoScroll = true;
            pnlMenu.BackColor = Color.FromArgb(255, 252, 245);
            pnlMenu.Controls.Add(lblMenuHint);
            pnlMenu.Controls.Add(btnAddItem);
            pnlMenu.Controls.Add(nudQty);
            pnlMenu.Controls.Add(lblQty);
            pnlMenu.Controls.Add(btnItem6);
            pnlMenu.Controls.Add(btnItem5);
            pnlMenu.Controls.Add(btnItem4);
            pnlMenu.Controls.Add(btnItem3);
            pnlMenu.Controls.Add(btnItem2);
            pnlMenu.Controls.Add(btnItem1);
            pnlMenu.Controls.Add(lblMenuHeader);
            pnlMenu.Dock = DockStyle.Fill;
            pnlMenu.Margin = new Padding(8);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.TabIndex = 1;
            // 
            // lblMenuHeader
            // 
            lblMenuHeader.AutoSize = true;
            lblMenuHeader.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblMenuHeader.ForeColor = Color.FromArgb(91, 107, 47);
            lblMenuHeader.Location = new Point(15, 12);
            lblMenuHeader.Name = "lblMenuHeader";
            lblMenuHeader.TabIndex = 10;
            lblMenuHeader.Text = "3. Choose From Our Menu";
            // 
            // btnItem1
            // 
            btnItem1.BackColor = Color.FromArgb(255, 252, 245);
            btnItem1.Cursor = Cursors.Hand;
            btnItem1.FlatAppearance.BorderColor = Color.FromArgb(91, 107, 47);
            btnItem1.FlatAppearance.BorderSize = 2;
            btnItem1.FlatStyle = FlatStyle.Flat;
            btnItem1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnItem1.ForeColor = Color.FromArgb(74, 46, 26);
            btnItem1.Location = new Point(15, 50);
            btnItem1.Name = "btnItem1";
            btnItem1.Size = new Size(195, 85);
            btnItem1.TabIndex = 0;
            btnItem1.Text = "Chocolate Chip Cookies\r\n$12.00 / dozen";
            btnItem1.UseVisualStyleBackColor = false;
            btnItem1.Click += PrototypeButton_Click;
            // 
            // btnItem2
            // 
            btnItem2.BackColor = Color.FromArgb(255, 252, 245);
            btnItem2.Cursor = Cursors.Hand;
            btnItem2.FlatAppearance.BorderColor = Color.FromArgb(91, 107, 47);
            btnItem2.FlatAppearance.BorderSize = 2;
            btnItem2.FlatStyle = FlatStyle.Flat;
            btnItem2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnItem2.ForeColor = Color.FromArgb(74, 46, 26);
            btnItem2.Location = new Point(218, 50);
            btnItem2.Name = "btnItem2";
            btnItem2.Size = new Size(195, 85);
            btnItem2.TabIndex = 1;
            btnItem2.Text = "Cinnamon Rolls\r\n$15.00 / 6 pack";
            btnItem2.UseVisualStyleBackColor = false;
            btnItem2.Click += PrototypeButton_Click;
            // 
            // btnItem3
            // 
            btnItem3.BackColor = Color.FromArgb(255, 252, 245);
            btnItem3.Cursor = Cursors.Hand;
            btnItem3.FlatAppearance.BorderColor = Color.FromArgb(91, 107, 47);
            btnItem3.FlatAppearance.BorderSize = 2;
            btnItem3.FlatStyle = FlatStyle.Flat;
            btnItem3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnItem3.ForeColor = Color.FromArgb(74, 46, 26);
            btnItem3.Location = new Point(15, 145);
            btnItem3.Name = "btnItem3";
            btnItem3.Size = new Size(195, 85);
            btnItem3.TabIndex = 2;
            btnItem3.Text = "Sourdough Bread\r\n$8.00 / loaf";
            btnItem3.UseVisualStyleBackColor = false;
            btnItem3.Click += PrototypeButton_Click;
            // 
            // btnItem4
            // 
            btnItem4.BackColor = Color.FromArgb(255, 252, 245);
            btnItem4.Cursor = Cursors.Hand;
            btnItem4.FlatAppearance.BorderColor = Color.FromArgb(91, 107, 47);
            btnItem4.FlatAppearance.BorderSize = 2;
            btnItem4.FlatStyle = FlatStyle.Flat;
            btnItem4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnItem4.ForeColor = Color.FromArgb(74, 46, 26);
            btnItem4.Location = new Point(218, 145);
            btnItem4.Name = "btnItem4";
            btnItem4.Size = new Size(195, 85);
            btnItem4.TabIndex = 3;
            btnItem4.Text = "Blueberry Muffins\r\n$14.00 / dozen";
            btnItem4.UseVisualStyleBackColor = false;
            btnItem4.Click += PrototypeButton_Click;
            // 
            // btnItem5
            // 
            btnItem5.BackColor = Color.FromArgb(255, 252, 245);
            btnItem5.Cursor = Cursors.Hand;
            btnItem5.FlatAppearance.BorderColor = Color.FromArgb(91, 107, 47);
            btnItem5.FlatAppearance.BorderSize = 2;
            btnItem5.FlatStyle = FlatStyle.Flat;
            btnItem5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnItem5.ForeColor = Color.FromArgb(74, 46, 26);
            btnItem5.Location = new Point(15, 240);
            btnItem5.Name = "btnItem5";
            btnItem5.Size = new Size(195, 85);
            btnItem5.TabIndex = 4;
            btnItem5.Text = "Birthday Cake (8 in)\r\n$35.00 each";
            btnItem5.UseVisualStyleBackColor = false;
            btnItem5.Click += PrototypeButton_Click;
            // 
            // btnItem6
            // 
            btnItem6.BackColor = Color.FromArgb(255, 252, 245);
            btnItem6.Cursor = Cursors.Hand;
            btnItem6.FlatAppearance.BorderColor = Color.FromArgb(196, 98, 45);
            btnItem6.FlatAppearance.BorderSize = 2;
            btnItem6.FlatStyle = FlatStyle.Flat;
            btnItem6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnItem6.ForeColor = Color.FromArgb(74, 46, 26);
            btnItem6.Location = new Point(218, 240);
            btnItem6.Name = "btnItem6";
            btnItem6.Size = new Size(195, 85);
            btnItem6.TabIndex = 5;
            btnItem6.Text = "Pumpkin Bread (Fall)\r\n$9.00 / loaf";
            btnItem6.UseVisualStyleBackColor = false;
            btnItem6.Click += PrototypeButton_Click;
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.ForeColor = Color.FromArgb(74, 46, 26);
            lblQty.Location = new Point(15, 340);
            lblQty.Name = "lblQty";
            lblQty.TabIndex = 11;
            lblQty.Text = "How many?";
            // 
            // nudQty
            // 
            nudQty.BackColor = Color.FromArgb(255, 252, 245);
            nudQty.Font = new Font("Segoe UI", 14F);
            nudQty.ForeColor = Color.FromArgb(74, 46, 26);
            nudQty.Location = new Point(15, 366);
            nudQty.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            nudQty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQty.Name = "nudQty";
            nudQty.Size = new Size(100, 39);
            nudQty.TabIndex = 6;
            nudQty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddItem
            // 
            btnAddItem.BackColor = Color.FromArgb(91, 107, 47);
            btnAddItem.Cursor = Cursors.Hand;
            btnAddItem.FlatAppearance.BorderSize = 0;
            btnAddItem.FlatStyle = FlatStyle.Flat;
            btnAddItem.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnAddItem.ForeColor = Color.FromArgb(251, 246, 236);
            btnAddItem.Location = new Point(130, 360);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(283, 52);
            btnAddItem.TabIndex = 7;
            btnAddItem.Text = "Add to Order";
            btnAddItem.UseVisualStyleBackColor = false;
            btnAddItem.Click += PrototypeButton_Click;
            // 
            // lblMenuHint
            // 
            lblMenuHint.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            lblMenuHint.ForeColor = Color.FromArgb(74, 46, 26);
            lblMenuHint.Location = new Point(15, 425);
            lblMenuHint.Name = "lblMenuHint";
            lblMenuHint.Size = new Size(398, 60);
            lblMenuHint.TabIndex = 12;
            lblMenuHint.Text = "Tap an item, choose how many, then tap Add to Order.";
            // 
            // pnlOrder
            // 
            pnlOrder.AutoScroll = true;
            pnlOrder.BackColor = Color.FromArgb(255, 252, 245);
            pnlOrder.Controls.Add(lblPickupNote);
            pnlOrder.Controls.Add(btnRemoveItem);
            pnlOrder.Controls.Add(lblTotal);
            pnlOrder.Controls.Add(lvOrder);
            pnlOrder.Controls.Add(lblOrderHeader);
            pnlOrder.Dock = DockStyle.Fill;
            pnlOrder.Margin = new Padding(8);
            pnlOrder.Name = "pnlOrder";
            pnlOrder.TabIndex = 2;
            // 
            // lblOrderHeader
            // 
            lblOrderHeader.AutoSize = true;
            lblOrderHeader.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblOrderHeader.ForeColor = Color.FromArgb(91, 107, 47);
            lblOrderHeader.Location = new Point(15, 12);
            lblOrderHeader.Name = "lblOrderHeader";
            lblOrderHeader.TabIndex = 10;
            lblOrderHeader.Text = "4. Your Order";
            // 
            // colItem
            // 
            colItem.Text = "Item";
            colItem.Width = 165;
            // 
            // colQty
            // 
            colQty.Text = "Qty";
            colQty.TextAlign = HorizontalAlignment.Center;
            colQty.Width = 50;
            // 
            // colPrice
            // 
            colPrice.Text = "Price";
            colPrice.TextAlign = HorizontalAlignment.Right;
            colPrice.Width = 85;
            // 
            // lvOrder
            // 
            lvOrder.BackColor = Color.FromArgb(255, 252, 245);
            lvOrder.BorderStyle = BorderStyle.FixedSingle;
            lvOrder.Columns.AddRange(new ColumnHeader[] { colItem, colQty, colPrice });
            lvOrder.Font = new Font("Segoe UI", 11F);
            lvOrder.ForeColor = Color.FromArgb(74, 46, 26);
            lvOrder.FullRowSelect = true;
            lvOrder.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvOrder.Location = new Point(15, 50);
            lvOrder.MultiSelect = false;
            lvOrder.Name = "lvOrder";
            lvOrder.Size = new Size(308, 290);
            lvOrder.TabIndex = 0;
            lvOrder.View = View.Details;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(74, 46, 26);
            lblTotal.Location = new Point(15, 352);
            lblTotal.Name = "lblTotal";
            lblTotal.TabIndex = 11;
            lblTotal.Text = "Total: $36.00";
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.BackColor = Color.FromArgb(255, 252, 245);
            btnRemoveItem.Cursor = Cursors.Hand;
            btnRemoveItem.FlatAppearance.BorderColor = Color.FromArgb(74, 46, 26);
            btnRemoveItem.FlatAppearance.BorderSize = 2;
            btnRemoveItem.FlatStyle = FlatStyle.Flat;
            btnRemoveItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRemoveItem.ForeColor = Color.FromArgb(74, 46, 26);
            btnRemoveItem.Location = new Point(15, 395);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(308, 50);
            btnRemoveItem.TabIndex = 1;
            btnRemoveItem.Text = "Remove Selected Item";
            btnRemoveItem.UseVisualStyleBackColor = false;
            btnRemoveItem.Click += PrototypeButton_Click;
            // 
            // lblPickupNote
            // 
            lblPickupNote.Font = new Font("Segoe UI", 10.5F);
            lblPickupNote.ForeColor = Color.FromArgb(74, 46, 26);
            lblPickupNote.Location = new Point(15, 460);
            lblPickupNote.Name = "lblPickupNote";
            lblPickupNote.Size = new Size(308, 65);
            lblPickupNote.TabIndex = 12;
            lblPickupNote.Text = "All orders are pickup only. You will check your order on the next screen before it is sent.";
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(243, 234, 217);
            pnlFooter.Controls.Add(btnReviewOrder);
            pnlFooter.Controls.Add(lblPrototypeNote);
            pnlFooter.Controls.Add(btnBack);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 664);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(1200, 76);
            pnlFooter.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(255, 252, 245);
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(74, 46, 26);
            btnBack.FlatAppearance.BorderSize = 2;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnBack.ForeColor = Color.FromArgb(74, 46, 26);
            btnBack.Location = new Point(20, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(160, 52);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblPrototypeNote
            // 
            lblPrototypeNote.AutoSize = true;
            lblPrototypeNote.Font = new Font("Segoe UI", 10.5F, FontStyle.Italic);
            lblPrototypeNote.ForeColor = Color.FromArgb(74, 46, 26);
            lblPrototypeNote.Location = new Point(200, 26);
            lblPrototypeNote.Name = "lblPrototypeNote";
            lblPrototypeNote.TabIndex = 2;
            lblPrototypeNote.Text = "Prototype: buttons are for design review only.";
            // 
            // btnReviewOrder
            // 
            btnReviewOrder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReviewOrder.BackColor = Color.FromArgb(217, 162, 58);
            btnReviewOrder.Cursor = Cursors.Hand;
            btnReviewOrder.FlatAppearance.BorderSize = 0;
            btnReviewOrder.FlatStyle = FlatStyle.Flat;
            btnReviewOrder.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnReviewOrder.ForeColor = Color.FromArgb(74, 46, 26);
            btnReviewOrder.Location = new Point(960, 12);
            btnReviewOrder.Name = "btnReviewOrder";
            btnReviewOrder.Size = new Size(220, 52);
            btnReviewOrder.TabIndex = 0;
            btnReviewOrder.Text = "Review Order";
            btnReviewOrder.UseVisualStyleBackColor = false;
            btnReviewOrder.Click += btnReviewOrder_Click;
            // 
            // CustomerOrderForm
            // 
            AcceptButton = btnReviewOrder;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(251, 246, 236);
            CancelButton = btnBack;
            ClientSize = new Size(1200, 740);
            Controls.Add(tlpMain);
            Controls.Add(pnlAccentLine);
            Controls.Add(pnlHeader);
            Controls.Add(pnlFooter);
            Font = new Font("Segoe UI", 12F);
            ForeColor = Color.FromArgb(74, 46, 26);
            MinimumSize = new Size(1024, 700);
            Name = "CustomerOrderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Olive Branch Bakes - Place Your Order";
            ((System.ComponentModel.ISupportInitialize)nudQty).EndInit();
            pnlFooter.ResumeLayout(false);
            pnlFooter.PerformLayout();
            pnlOrder.ResumeLayout(false);
            pnlOrder.PerformLayout();
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            pnlAllergy.ResumeLayout(false);
            pnlAllergy.PerformLayout();
            pnlInfo.ResumeLayout(false);
            pnlInfo.PerformLayout();
            tlpMain.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblHeader;
        private Button btnSignIn;
        private Panel pnlAccentLine;
        private TableLayoutPanel tlpMain;
        private Panel pnlInfo;
        private Panel pnlMenu;
        private Panel pnlOrder;
        private Label lblInfoHeader;
        private Label lblName;
        private TextBox txtName;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPickup;
        private DateTimePicker dtpPickup;
        private Panel pnlAllergy;
        private Label lblAllergyHeader;
        private Label lblAllergyQuestion;
        private RadioButton rbNoAllergy;
        private RadioButton rbHasAllergy;
        private TextBox txtAllergyDetails;
        private Label lblMenuHeader;
        private Button btnItem1;
        private Button btnItem2;
        private Button btnItem3;
        private Button btnItem4;
        private Button btnItem5;
        private Button btnItem6;
        private Label lblQty;
        private NumericUpDown nudQty;
        private Button btnAddItem;
        private Label lblMenuHint;
        private Label lblOrderHeader;
        private ListView lvOrder;
        private ColumnHeader colItem;
        private ColumnHeader colQty;
        private ColumnHeader colPrice;
        private Label lblTotal;
        private Button btnRemoveItem;
        private Label lblPickupNote;
        private Panel pnlFooter;
        private Button btnBack;
        private Label lblPrototypeNote;
        private Button btnReviewOrder;
    }
}
