namespace OliveBranchBakes.Forms
{
    partial class MenuDataForm
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
            lblTitle = new Label();
            dgvMenu = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colAvailable = new DataGridViewCheckBoxColumn();
            colSeasonal = new DataGridViewCheckBoxColumn();
            lblSource = new Label();
            lblPath = new Label();
            btnSave = new Button();
            btnReset = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMenu).BeginInit();
            SuspendLayout();
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(91, 107, 47);
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Text = "Menu Data";
            //
            // dgvMenu
            //
            dgvMenu.AllowUserToAddRows = false;
            dgvMenu.AllowUserToDeleteRows = false;
            dgvMenu.AutoGenerateColumns = false;
            dgvMenu.BackgroundColor = Color.FromArgb(255, 252, 245);
            dgvMenu.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(91, 107, 47);
            dgvMenu.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvMenu.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(91, 107, 47);
            dgvMenu.ColumnHeadersHeight = 40;
            dgvMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvMenu.Columns.AddRange(new DataGridViewColumn[] { colName, colPrice, colAvailable, colSeasonal });
            dgvMenu.DefaultCellStyle.BackColor = Color.FromArgb(255, 252, 245);
            dgvMenu.DefaultCellStyle.ForeColor = Color.FromArgb(74, 46, 26);
            dgvMenu.DefaultCellStyle.SelectionBackColor = Color.FromArgb(252, 239, 208);
            dgvMenu.DefaultCellStyle.SelectionForeColor = Color.FromArgb(74, 46, 26);
            dgvMenu.EnableHeadersVisualStyles = false;
            dgvMenu.Font = new Font("Segoe UI", 12F);
            dgvMenu.Location = new Point(20, 65);
            dgvMenu.MultiSelect = false;
            dgvMenu.Name = "dgvMenu";
            dgvMenu.RowHeadersVisible = false;
            dgvMenu.RowTemplate.Height = 36;
            dgvMenu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMenu.Size = new Size(840, 300);
            dgvMenu.TabIndex = 0;
            //
            // colName
            //
            colName.DataPropertyName = "Name";
            colName.HeaderText = "Name";
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 320;
            //
            // colPrice
            //
            colPrice.DataPropertyName = "Price";
            colPrice.DefaultCellStyle.Format = "0.00";
            colPrice.HeaderText = "Price";
            colPrice.Name = "colPrice";
            colPrice.Width = 150;
            //
            // colAvailable
            //
            colAvailable.DataPropertyName = "IsAvailable";
            colAvailable.HeaderText = "Available";
            colAvailable.Name = "colAvailable";
            colAvailable.Width = 150;
            //
            // colSeasonal
            //
            colSeasonal.DataPropertyName = "IsSeasonal";
            colSeasonal.HeaderText = "Seasonal";
            colSeasonal.Name = "colSeasonal";
            colSeasonal.Width = 150;
            //
            // lblSource
            //
            lblSource.AutoSize = true;
            lblSource.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSource.ForeColor = Color.FromArgb(196, 98, 45);
            lblSource.Location = new Point(20, 380);
            lblSource.Name = "lblSource";
            lblSource.Text = "";
            //
            // lblPath
            //
            lblPath.Font = new Font("Segoe UI", 12F);
            lblPath.ForeColor = Color.FromArgb(74, 46, 26);
            lblPath.Location = new Point(20, 415);
            lblPath.Name = "lblPath";
            lblPath.Size = new Size(840, 50);
            lblPath.Text = "";
            //
            // btnSave
            //
            btnSave.BackColor = Color.FromArgb(91, 107, 47);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(20, 480);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(160, 50);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            //
            // btnReset
            //
            btnReset.BackColor = Color.FromArgb(217, 162, 58);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnReset.ForeColor = Color.FromArgb(74, 46, 26);
            btnReset.Location = new Point(200, 480);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(220, 50);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset to Seed Data";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            //
            // btnClose
            //
            btnClose.BackColor = Color.FromArgb(255, 252, 245);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F);
            btnClose.ForeColor = Color.FromArgb(74, 46, 26);
            btnClose.Location = new Point(700, 480);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(160, 50);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            //
            // MenuDataForm
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 246, 236);
            ClientSize = new Size(880, 550);
            Controls.Add(lblTitle);
            Controls.Add(dgvMenu);
            Controls.Add(lblSource);
            Controls.Add(lblPath);
            Controls.Add(btnSave);
            Controls.Add(btnReset);
            Controls.Add(btnClose);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MenuDataForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Olive Branch Bakes - Menu Data";
            ((System.ComponentModel.ISupportInitialize)dgvMenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private DataGridView dgvMenu;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewCheckBoxColumn colAvailable;
        private DataGridViewCheckBoxColumn colSeasonal;
        private Label lblSource;
        private Label lblPath;
        private Button btnSave;
        private Button btnReset;
        private Button btnClose;
    }
}
