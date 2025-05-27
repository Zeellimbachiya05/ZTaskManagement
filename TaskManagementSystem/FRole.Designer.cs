namespace ZTaskAccounts
{
    partial class FRole
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
            btnNew = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            lblName = new Label();
            lblNotes = new Label();
            txtName = new TextBox();
            txtNotes = new TextBox();
            SuspendLayout();
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnNew.Location = new Point(16, 163);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 0;
            btnNew.Text = "&New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnSave.Location = new Point(107, 163);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 1;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnDelete.Location = new Point(198, 163);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnCancel.Location = new Point(291, 163);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblName.Location = new Point(39, 49);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 14);
            lblName.TabIndex = 4;
            lblName.Text = "Name  :";
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblNotes.Location = new Point(39, 104);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(54, 14);
            lblNotes.TabIndex = 5;
            lblNotes.Text = "Notes  :";
            // 
            // txtName
            // 
            txtName.Location = new Point(97, 46);
            txtName.Name = "txtName";
            txtName.Size = new Size(245, 23);
            txtName.TabIndex = 6;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(97, 101);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(245, 23);
            txtNotes.TabIndex = 7;
            // 
            // FRole
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 204);
            Controls.Add(txtNotes);
            Controls.Add(txtName);
            Controls.Add(lblNotes);
            Controls.Add(lblName);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnNew);
            Name = "FRole";
            Text = "Role";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNew;
        private Button btnSave;
        private Button btnDelete;
        private Button btnCancel;
        private Label lblName;
        private Label lblNotes;
        private TextBox txtName;
        private TextBox txtNotes;
    }
}