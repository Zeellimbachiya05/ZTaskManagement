﻿namespace ZTaskAccounts
{
    partial class FTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCode = new Label();
            cmbCode = new ComboBox();
            lblTitle = new Label();
            txtTitle = new TextBox();
            lblDescription = new Label();
            rtxDescription = new RichTextBox();
            lblPriority = new Label();
            lblAssignedTo = new Label();
            lblStatus = new Label();
            lblDepartment = new Label();
            lblDueDate = new Label();
            lblAssignedDate = new Label();
            cmbPriority = new ComboBox();
            cmbStatus = new ComboBox();
            cmbAssignedTo = new ComboBox();
            cmbDepartment = new ComboBox();
            dtpAssignedDate = new DateTimePicker();
            dtpDueDate = new DateTimePicker();
            lblCompletionDate = new Label();
            lblRemainderDate = new Label();
            lblNotes = new Label();
            dtpCompletionDate = new DateTimePicker();
            dtpRemainderDate = new DateTimePicker();
            txtNotes = new TextBox();
            btnNew = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblCode.Location = new Point(30, 23);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(126, 14);
            lblCode.Text = "Code                     :";
            // 
            // cmbCode
            // 
            cmbCode.Font = new Font("Tahoma", 9F);
            cmbCode.FormattingEnabled = true;
            cmbCode.Location = new Point(159, 20);
            cmbCode.Name = "cmbCode";
            cmbCode.Size = new Size(755, 22);
            cmbCode.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblTitle.Location = new Point(30, 69);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(129, 14);
            lblTitle.Text = "Title                      : ";
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Tahoma", 9F);
            txtTitle.Location = new Point(159, 66);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(755, 22);
            txtTitle.TabIndex = 1;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblDescription.Location = new Point(33, 118);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(128, 14);
            lblDescription.Text = "Description           : ";
            // 
            // rtxDescription
            // 
            rtxDescription.Font = new Font("Tahoma", 9F);
            rtxDescription.Location = new Point(159, 118);
            rtxDescription.Name = "rtxDescription";
            rtxDescription.Size = new Size(755, 55);
            rtxDescription.TabIndex = 2;
            rtxDescription.Text = "";
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblPriority.Location = new Point(33, 286);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(124, 14);
            lblPriority.Text = "Priority                 :";
            // 
            // lblAssignedTo
            // 
            lblAssignedTo.AutoSize = true;
            lblAssignedTo.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblAssignedTo.Location = new Point(33, 202);
            lblAssignedTo.Name = "lblAssignedTo";
            lblAssignedTo.Size = new Size(125, 14);
            lblAssignedTo.Text = "Assigned To          :";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblStatus.Location = new Point(458, 286);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(140, 14);
            lblStatus.Text = "Status                      :";
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblDepartment.Location = new Point(458, 202);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(141, 14);
            lblDepartment.Text = "Department              :";
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblDueDate.Location = new Point(458, 244);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(140, 14);
            lblDueDate.Text = "Due Date                  :";
            // 
            // lblAssignedDate
            // 
            lblAssignedDate.AutoSize = true;
            lblAssignedDate.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblAssignedDate.Location = new Point(33, 244);
            lblAssignedDate.Name = "lblAssignedDate";
            lblAssignedDate.Size = new Size(123, 14);
            lblAssignedDate.Text = "Assigned Date      :";
            // 
            // cmbPriority
            // 
            cmbPriority.Font = new Font("Tahoma", 9F);
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Location = new Point(159, 283);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(258, 22);
            cmbPriority.TabIndex = 7;
            // 
            // cmbStatus
            // 
            cmbStatus.Font = new Font("Tahoma", 9F);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(602, 283);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(276, 22);
            cmbStatus.TabIndex = 8;
            // 
            // cmbAssignedTo
            // 
            cmbAssignedTo.Font = new Font("Tahoma", 9F);
            cmbAssignedTo.FormattingEnabled = true;
            cmbAssignedTo.Location = new Point(159, 199);
            cmbAssignedTo.Name = "cmbAssignedTo";
            cmbAssignedTo.Size = new Size(258, 22);
            cmbAssignedTo.TabIndex = 3;
            // 
            // cmbDepartment
            // 
            cmbDepartment.Font = new Font("Tahoma", 9F);
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(602, 199);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(276, 22);
            cmbDepartment.TabIndex = 4;
            // 
            // dtpAssignedDate
            // 
            dtpAssignedDate.Font = new Font("Tahoma", 9F);
            dtpAssignedDate.Location = new Point(159, 238);
            dtpAssignedDate.Name = "dtpAssignedDate";
            dtpAssignedDate.Size = new Size(164, 22);
            dtpAssignedDate.TabIndex = 5;
            // 
            // dtpDueDate
            // 
            dtpDueDate.Font = new Font("Tahoma", 9F);
            dtpDueDate.Location = new Point(602, 238);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(157, 22);
            dtpDueDate.TabIndex = 6;
            // 
            // lblCompletionDate
            // 
            lblCompletionDate.AutoSize = true;
            lblCompletionDate.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblCompletionDate.Location = new Point(458, 343);
            lblCompletionDate.Name = "lblCompletionDate";
            lblCompletionDate.Size = new Size(142, 14);
            lblCompletionDate.Text = "Completion Date       :";
            // 
            // lblRemainderDate
            // 
            lblRemainderDate.AutoSize = true;
            lblRemainderDate.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblRemainderDate.Location = new Point(33, 343);
            lblRemainderDate.Name = "lblRemainderDate";
            lblRemainderDate.Size = new Size(125, 14);
            lblRemainderDate.Text = "Remainder Date    :";
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblNotes.Location = new Point(33, 397);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(126, 14);
            lblNotes.Text = "Notes                    :";
            // 
            // dtpCompletionDate
            // 
            dtpCompletionDate.Font = new Font("Tahoma", 9F);
            dtpCompletionDate.Location = new Point(602, 337);
            dtpCompletionDate.Name = "dtpCompletionDate";
            dtpCompletionDate.Size = new Size(157, 22);
            dtpCompletionDate.TabIndex = 10;
            // 
            // dtpRemainderDate
            // 
            dtpRemainderDate.Font = new Font("Tahoma", 9F);
            dtpRemainderDate.Location = new Point(159, 337);
            dtpRemainderDate.Name = "dtpRemainderDate";
            dtpRemainderDate.Size = new Size(164, 22);
            dtpRemainderDate.TabIndex = 9;
            // 
            // txtNotes
            // 
            txtNotes.Font = new Font("Tahoma", 9F);
            txtNotes.Location = new Point(159, 394);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(743, 22);
            txtNotes.TabIndex = 11;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnNew.Location = new Point(106, 449);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 13;
            btnNew.Text = "&New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += BtnNew_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnSave.Location = new Point(342, 449);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 12;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnDelete.Location = new Point(566, 449);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnCancel.Location = new Point(796, 449);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += BtnCancel_Click;
            // 
            // FTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 481);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnNew);
            Controls.Add(txtNotes);
            Controls.Add(dtpRemainderDate);
            Controls.Add(dtpCompletionDate);
            Controls.Add(lblNotes);
            Controls.Add(lblRemainderDate);
            Controls.Add(lblCompletionDate);
            Controls.Add(dtpDueDate);
            Controls.Add(dtpAssignedDate);
            Controls.Add(cmbDepartment);
            Controls.Add(cmbAssignedTo);
            Controls.Add(cmbStatus);
            Controls.Add(cmbPriority);
            Controls.Add(lblAssignedDate);
            Controls.Add(lblDueDate);
            Controls.Add(lblDepartment);
            Controls.Add(lblStatus);
            Controls.Add(lblAssignedTo);
            Controls.Add(lblPriority);
            Controls.Add(rtxDescription);
            Controls.Add(lblDescription);
            Controls.Add(txtTitle);
            Controls.Add(lblTitle);
            Controls.Add(cmbCode);
            Controls.Add(lblCode);
            KeyPreview = true;
            Name = "FTask";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task Entry";
            Load += FTask_Load;
            KeyDown += FTask_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCode;
        private ComboBox cmbCode;
        private Label lblTitle;
        private TextBox txtTitle;
        private Label lblDescription;
        private RichTextBox rtxDescription;
        private Label lblPriority;
        private Label lblAssignedTo;
        private Label lblStatus;
        private Label lblDepartment;
        private Label lblDueDate;
        private Label lblAssignedDate;
        private ComboBox cmbPriority;
        private ComboBox cmbStatus;
        private ComboBox cmbAssignedTo;
        private ComboBox cmbDepartment;
        private DateTimePicker dtpAssignedDate;
        private DateTimePicker dtpDueDate;
        private Label lblCompletionDate;
        private Label lblRemainderDate;
        private Label lblNotes;
        private DateTimePicker dtpCompletionDate;
        private DateTimePicker dtpRemainderDate;
        private TextBox txtNotes;
        private Button btnNew;
        private Button btnSave;
        private Button btnDelete;
        private Button btnCancel;
    }
}