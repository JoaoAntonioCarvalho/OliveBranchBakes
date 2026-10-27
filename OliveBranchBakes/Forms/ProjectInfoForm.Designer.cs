namespace OliveBranchBakes.Forms
{
    partial class ProjectInfoForm
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
            tblInfo = new TableLayoutPanel();
            lblProjectName = new Label();
            lblProjectNameValue = new Label();
            lblStudentName = new Label();
            lblStudentNameValue = new Label();
            lblPhase = new Label();
            lblPhaseValue = new Label();
            lblClass = new Label();
            lblClassValue = new Label();
            lblDate = new Label();
            lblDateValue = new Label();
            lblDescription = new Label();
            lblDescriptionValue = new Label();
            btnClose = new Button();
            tblInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(91, 107, 47);
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Text = "Project Information";
            // 
            // tblInfo
            // 
            tblInfo.ColumnCount = 2;
            tblInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tblInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblInfo.Controls.Add(lblProjectName, 0, 0);
            tblInfo.Controls.Add(lblProjectNameValue, 1, 0);
            tblInfo.Controls.Add(lblStudentName, 0, 1);
            tblInfo.Controls.Add(lblStudentNameValue, 1, 1);
            tblInfo.Controls.Add(lblPhase, 0, 2);
            tblInfo.Controls.Add(lblPhaseValue, 1, 2);
            tblInfo.Controls.Add(lblClass, 0, 3);
            tblInfo.Controls.Add(lblClassValue, 1, 3);
            tblInfo.Controls.Add(lblDate, 0, 4);
            tblInfo.Controls.Add(lblDateValue, 1, 4);
            tblInfo.Controls.Add(lblDescription, 0, 5);
            tblInfo.Controls.Add(lblDescriptionValue, 1, 5);
            tblInfo.Location = new Point(20, 65);
            tblInfo.Name = "tblInfo";
            tblInfo.RowCount = 6;
            tblInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tblInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tblInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tblInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tblInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tblInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tblInfo.Size = new Size(540, 265);
            // 
            // lblProjectName
            // 
            lblProjectName.Dock = DockStyle.Fill;
            lblProjectName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblProjectName.Name = "lblProjectName";
            lblProjectName.Text = "Project Name:";
            lblProjectName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblProjectNameValue
            // 
            lblProjectNameValue.Dock = DockStyle.Fill;
            lblProjectNameValue.Name = "lblProjectNameValue";
            lblProjectNameValue.Text = "";
            lblProjectNameValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStudentName
            // 
            lblStudentName.Dock = DockStyle.Fill;
            lblStudentName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Text = "Student Name:";
            lblStudentName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStudentNameValue
            // 
            lblStudentNameValue.Dock = DockStyle.Fill;
            lblStudentNameValue.Name = "lblStudentNameValue";
            lblStudentNameValue.Text = "";
            lblStudentNameValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPhase
            // 
            lblPhase.Dock = DockStyle.Fill;
            lblPhase.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblPhase.Name = "lblPhase";
            lblPhase.Text = "Current Phase:";
            lblPhase.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPhaseValue
            // 
            lblPhaseValue.Dock = DockStyle.Fill;
            lblPhaseValue.Name = "lblPhaseValue";
            lblPhaseValue.Text = "";
            lblPhaseValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblClass
            // 
            lblClass.Dock = DockStyle.Fill;
            lblClass.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblClass.Name = "lblClass";
            lblClass.Text = "Class:";
            lblClass.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblClassValue
            // 
            lblClassValue.Dock = DockStyle.Fill;
            lblClassValue.Name = "lblClassValue";
            lblClassValue.Text = "";
            lblClassValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            lblDate.Dock = DockStyle.Fill;
            lblDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblDate.Name = "lblDate";
            lblDate.Text = "Date:";
            lblDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDateValue
            // 
            lblDateValue.Dock = DockStyle.Fill;
            lblDateValue.Name = "lblDateValue";
            lblDateValue.Text = "";
            lblDateValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDescription
            // 
            lblDescription.Dock = DockStyle.Fill;
            lblDescription.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblDescription.Name = "lblDescription";
            lblDescription.Text = "Description:";
            lblDescription.TextAlign = ContentAlignment.TopLeft;
            // 
            // lblDescriptionValue
            // 
            lblDescriptionValue.Dock = DockStyle.Fill;
            lblDescriptionValue.Name = "lblDescriptionValue";
            lblDescriptionValue.Text = "";
            lblDescriptionValue.TextAlign = ContentAlignment.TopLeft;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(460, 345);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 32);
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // ProjectInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 395);
            Controls.Add(lblTitle);
            Controls.Add(tblInfo);
            Controls.Add(btnClose);
            BackColor = Color.FromArgb(251, 246, 236);
            ForeColor = Color.FromArgb(74, 46, 26);
            Font = new Font("Segoe UI", 9.75F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ProjectInfoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Olive Branch Bakes - Project Information";
            tblInfo.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TableLayoutPanel tblInfo;
        private Label lblProjectName;
        private Label lblProjectNameValue;
        private Label lblStudentName;
        private Label lblStudentNameValue;
        private Label lblPhase;
        private Label lblPhaseValue;
        private Label lblClass;
        private Label lblClassValue;
        private Label lblDate;
        private Label lblDateValue;
        private Label lblDescription;
        private Label lblDescriptionValue;
        private Button btnClose;
    }
}
