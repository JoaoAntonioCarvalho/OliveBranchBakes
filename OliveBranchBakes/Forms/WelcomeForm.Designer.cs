namespace OliveBranchBakes.Forms
{
    partial class WelcomeForm
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
            pnlTopStrip = new Panel();
            pnlSeasonalStrip = new Panel();
            picLogo = new PictureBox();
            lblWelcome = new Label();
            lblTagline = new Label();
            btnStartOrder = new Button();
            btnAccount = new Button();
            btnAdmin = new Button();
            lnkAbout = new LinkLabel();
            lnkMenuData = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlTopStrip
            // 
            pnlTopStrip.BackColor = Color.FromArgb(91, 107, 47);
            pnlTopStrip.Dock = DockStyle.Top;
            pnlTopStrip.Location = new Point(0, 0);
            pnlTopStrip.Name = "pnlTopStrip";
            pnlTopStrip.Size = new Size(1000, 12);
            pnlTopStrip.TabIndex = 10;
            // 
            // pnlSeasonalStrip
            // 
            pnlSeasonalStrip.BackColor = Color.FromArgb(196, 98, 45);
            pnlSeasonalStrip.Dock = DockStyle.Bottom;
            pnlSeasonalStrip.Location = new Point(0, 674);
            pnlSeasonalStrip.Name = "pnlSeasonalStrip";
            pnlSeasonalStrip.Size = new Size(1000, 6);
            pnlSeasonalStrip.TabIndex = 11;
            // 
            // picLogo
            // 
            picLogo.Location = new Point(410, 35);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(180, 180);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 12;
            picLogo.TabStop = false;
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(74, 46, 26);
            lblWelcome.Location = new Point(50, 225);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(900, 55);
            lblWelcome.TabIndex = 13;
            lblWelcome.Text = "Welcome to Olive Branch Bakes";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTagline
            // 
            lblTagline.Font = new Font("Segoe UI", 13F);
            lblTagline.ForeColor = Color.FromArgb(74, 46, 26);
            lblTagline.Location = new Point(50, 282);
            lblTagline.Name = "lblTagline";
            lblTagline.Size = new Size(900, 35);
            lblTagline.TabIndex = 14;
            lblTagline.Text = "Baked with love. What would you like to do today?";
            lblTagline.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnStartOrder
            // 
            btnStartOrder.BackColor = Color.FromArgb(91, 107, 47);
            btnStartOrder.Cursor = Cursors.Hand;
            btnStartOrder.FlatAppearance.BorderSize = 0;
            btnStartOrder.FlatStyle = FlatStyle.Flat;
            btnStartOrder.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnStartOrder.ForeColor = Color.FromArgb(251, 246, 236);
            btnStartOrder.Location = new Point(300, 345);
            btnStartOrder.Name = "btnStartOrder";
            btnStartOrder.Size = new Size(400, 70);
            btnStartOrder.TabIndex = 0;
            btnStartOrder.Text = "Start an Order";
            btnStartOrder.UseVisualStyleBackColor = false;
            btnStartOrder.Click += btnStartOrder_Click;
            // 
            // btnAccount
            // 
            btnAccount.BackColor = Color.FromArgb(217, 162, 58);
            btnAccount.Cursor = Cursors.Hand;
            btnAccount.FlatAppearance.BorderSize = 0;
            btnAccount.FlatStyle = FlatStyle.Flat;
            btnAccount.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnAccount.ForeColor = Color.FromArgb(74, 46, 26);
            btnAccount.Location = new Point(300, 430);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(400, 70);
            btnAccount.TabIndex = 1;
            btnAccount.Text = "Sign In / Create Account";
            btnAccount.UseVisualStyleBackColor = false;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.FromArgb(251, 246, 236);
            btnAdmin.Cursor = Cursors.Hand;
            btnAdmin.FlatAppearance.BorderColor = Color.FromArgb(74, 46, 26);
            btnAdmin.FlatAppearance.BorderSize = 2;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Segoe UI", 12F);
            btnAdmin.ForeColor = Color.FromArgb(74, 46, 26);
            btnAdmin.Location = new Point(375, 550);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(250, 52);
            btnAdmin.TabIndex = 2;
            btnAdmin.Text = "Staff Login";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // lnkAbout
            // 
            lnkAbout.ActiveLinkColor = Color.FromArgb(196, 98, 45);
            lnkAbout.AutoSize = true;
            lnkAbout.Font = new Font("Segoe UI", 11F);
            lnkAbout.LinkColor = Color.FromArgb(91, 107, 47);
            lnkAbout.Location = new Point(820, 635);
            lnkAbout.Name = "lnkAbout";
            lnkAbout.Size = new Size(140, 25);
            lnkAbout.TabIndex = 3;
            lnkAbout.TabStop = true;
            lnkAbout.Text = "About this project";
            lnkAbout.LinkClicked += lnkAbout_LinkClicked;
            //
            // lnkMenuData
            //
            lnkMenuData.ActiveLinkColor = Color.FromArgb(196, 98, 45);
            lnkMenuData.AutoSize = true;
            lnkMenuData.Font = new Font("Segoe UI", 11F);
            lnkMenuData.LinkColor = Color.FromArgb(91, 107, 47);
            lnkMenuData.Location = new Point(700, 635);
            lnkMenuData.Name = "lnkMenuData";
            lnkMenuData.Size = new Size(90, 25);
            lnkMenuData.TabIndex = 4;
            lnkMenuData.TabStop = true;
            lnkMenuData.Text = "Menu Data";
            lnkMenuData.LinkClicked += lnkMenuData_LinkClicked;
            // 
            // WelcomeForm
            // 
            AcceptButton = btnStartOrder;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(251, 246, 236);
            ClientSize = new Size(1000, 680);
            Controls.Add(lnkMenuData);
            Controls.Add(lnkAbout);
            Controls.Add(btnAdmin);
            Controls.Add(btnAccount);
            Controls.Add(btnStartOrder);
            Controls.Add(lblTagline);
            Controls.Add(lblWelcome);
            Controls.Add(picLogo);
            Controls.Add(pnlSeasonalStrip);
            Controls.Add(pnlTopStrip);
            Font = new Font("Segoe UI", 12F);
            ForeColor = Color.FromArgb(74, 46, 26);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "WelcomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Olive Branch Bakes - Welcome";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTopStrip;
        private Panel pnlSeasonalStrip;
        private PictureBox picLogo;
        private Label lblWelcome;
        private Label lblTagline;
        private Button btnStartOrder;
        private Button btnAccount;
        private Button btnAdmin;
        private LinkLabel lnkAbout;
        private LinkLabel lnkMenuData;
    }
}
