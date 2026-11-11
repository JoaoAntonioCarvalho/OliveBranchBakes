namespace OliveBranchBakes.Forms
{
    partial class AccountForm
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
            lblName = new Label();
            txtName = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblNote = new Label();
            btnCreate = new Button();
            btnSignIn = new Button();
            btnClose = new Button();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            //
            // pnlHeader
            //
            pnlHeader.BackColor = Color.FromArgb(91, 107, 47);
            pnlHeader.Controls.Add(lblHeader);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(500, 64);
            pnlHeader.TabIndex = 0;
            //
            // lblHeader
            //
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(251, 246, 236);
            lblHeader.Location = new Point(20, 12);
            lblHeader.Name = "lblHeader";
            lblHeader.Text = "Customer Account";
            //
            // pnlAccentLine
            //
            pnlAccentLine.BackColor = Color.FromArgb(196, 98, 45);
            pnlAccentLine.Dock = DockStyle.Top;
            pnlAccentLine.Location = new Point(0, 64);
            pnlAccentLine.Name = "pnlAccentLine";
            pnlAccentLine.Size = new Size(500, 4);
            pnlAccentLine.TabIndex = 1;
            //
            // lblName
            //
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblName.Location = new Point(30, 90);
            lblName.Name = "lblName";
            lblName.Text = "Full name";
            //
            // txtName
            //
            txtName.BackColor = Color.FromArgb(255, 252, 245);
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.ForeColor = Color.FromArgb(74, 46, 26);
            txtName.Location = new Point(30, 118);
            txtName.Name = "txtName";
            txtName.Size = new Size(440, 34);
            txtName.TabIndex = 0;
            //
            // lblPhone
            //
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPhone.Location = new Point(30, 165);
            lblPhone.Name = "lblPhone";
            lblPhone.Text = "Phone";
            //
            // txtPhone
            //
            txtPhone.BackColor = Color.FromArgb(255, 252, 245);
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Segoe UI", 12F);
            txtPhone.ForeColor = Color.FromArgb(74, 46, 26);
            txtPhone.Location = new Point(30, 193);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(440, 34);
            txtPhone.TabIndex = 1;
            //
            // lblEmail
            //
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEmail.Location = new Point(30, 240);
            lblEmail.Name = "lblEmail";
            lblEmail.Text = "Email";
            //
            // txtEmail
            //
            txtEmail.BackColor = Color.FromArgb(255, 252, 245);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.ForeColor = Color.FromArgb(74, 46, 26);
            txtEmail.Location = new Point(30, 268);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(440, 34);
            txtEmail.TabIndex = 2;
            //
            // lblNote
            //
            lblNote.Font = new Font("Segoe UI", 10.5F);
            lblNote.Location = new Point(30, 318);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(440, 44);
            lblNote.Text = "New here? Fill in all three boxes and tap Create Account. To sign in, type only your email.";
            //
            // btnCreate
            //
            btnCreate.BackColor = Color.FromArgb(217, 162, 58);
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCreate.ForeColor = Color.FromArgb(74, 46, 26);
            btnCreate.Location = new Point(30, 375);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(210, 50);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Create Account";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            //
            // btnSignIn
            //
            btnSignIn.BackColor = Color.FromArgb(91, 107, 47);
            btnSignIn.Cursor = Cursors.Hand;
            btnSignIn.FlatAppearance.BorderSize = 0;
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSignIn.ForeColor = Color.FromArgb(251, 246, 236);
            btnSignIn.Location = new Point(260, 375);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(210, 50);
            btnSignIn.TabIndex = 4;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            //
            // btnClose
            //
            btnClose.BackColor = Color.FromArgb(251, 246, 236);
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(91, 107, 47);
            btnClose.FlatAppearance.BorderSize = 2;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClose.ForeColor = Color.FromArgb(74, 46, 26);
            btnClose.Location = new Point(30, 440);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(440, 50);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            //
            // AccountForm
            //
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(251, 246, 236);
            CancelButton = btnClose;
            ClientSize = new Size(500, 515);
            Controls.Add(btnClose);
            Controls.Add(btnSignIn);
            Controls.Add(btnCreate);
            Controls.Add(lblNote);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(pnlAccentLine);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 12F);
            ForeColor = Color.FromArgb(74, 46, 26);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AccountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Olive Branch Bakes - Customer Account";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblHeader;
        private Panel pnlAccentLine;
        private Label lblName;
        private TextBox txtName;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblNote;
        private Button btnCreate;
        private Button btnSignIn;
        private Button btnClose;
    }
}
