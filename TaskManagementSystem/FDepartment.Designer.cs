namespace ZTaskAccounts
{
    partial class FDepartment
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
            lblName = new Label();
            lblNotes = new Label();
            txtNotes = new TextBox();
            txtName = new TextBox();
            btnNew = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblName.Location = new Point(27, 47);
            lblName.Name = "lblName";
            lblName.Size = new Size(56, 14);
            lblName.TabIndex = 0;
            lblName.Text = "Name   :";
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblNotes.Location = new Point(27, 106);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(58, 14);
            lblNotes.TabIndex = 1;
            lblNotes.Text = "Notes   :";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(87, 103);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(259, 23);
            txtNotes.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(85, 44);
            txtName.Name = "txtName";
            txtName.Size = new Size(259, 23);
            txtName.TabIndex = 2;
            txtName.Leave += txtName_Leave;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnNew.Location = new Point(12, 166);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 4;
            btnNew.Text = "&New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnSave.Location = new Point(107, 166);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 5;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnDelete.Location = new Point(205, 166);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnCancel.Location = new Point(304, 166);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // FDepartment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 201);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnNew);
            Controls.Add(txtName);
            Controls.Add(txtNotes);
            Controls.Add(lblNotes);
            Controls.Add(lblName);
            Name = "FDepartment";
            Text = "Department";
            KeyDown += FDepartment_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblNotes;
        private TextBox txtNotes;
        private TextBox txtName;
        private Button btnNew;
        private Button btnSave;
        private Button btnDelete;
        private Button btnCancel;
    }
}