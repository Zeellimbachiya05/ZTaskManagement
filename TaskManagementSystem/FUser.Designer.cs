namespace ZTaskAccounts
{
    partial class FUser
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
            lblUserName = new Label();
            lblName = new Label();
            lblEmail = new Label();
            lblMobile = new Label();
            lblDepId = new Label();
            lblRoleId = new Label();
            lblNotes = new Label();
            txtUserName = new TextBox();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtMobile = new TextBox();
            txtNotes = new TextBox();
            cmbDepId = new ComboBox();
            cmbRoleId = new ComboBox();
            btnNew = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblUserName.Location = new Point(61, 61);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(106, 14);
            lblUserName.TabIndex = 17;
            lblUserName.Text = "User Name        :";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblName.Location = new Point(61, 108);
            lblName.Name = "lblName";
            lblName.Size = new Size(108, 14);
            lblName.TabIndex = 16;
            lblName.Text = "Name                :";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblEmail.Location = new Point(62, 159);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(110, 14);
            lblEmail.TabIndex = 15;
            lblEmail.Text = "Email                : ";
            // 
            // lblMobile
            // 
            lblMobile.AutoSize = true;
            lblMobile.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblMobile.Location = new Point(59, 210);
            lblMobile.Name = "lblMobile";
            lblMobile.Size = new Size(111, 14);
            lblMobile.TabIndex = 14;
            lblMobile.Text = "Mobile No          :";
            // 
            // lblDepId
            // 
            lblDepId.AutoSize = true;
            lblDepId.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblDepId.Location = new Point(59, 261);
            lblDepId.Name = "lblDepId";
            lblDepId.Size = new Size(111, 14);
            lblDepId.TabIndex = 13;
            lblDepId.Text = "Department ID  :";
            // 
            // lblRoleId
            // 
            lblRoleId.AutoSize = true;
            lblRoleId.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblRoleId.Location = new Point(58, 312);
            lblRoleId.Name = "lblRoleId";
            lblRoleId.Size = new Size(112, 14);
            lblRoleId.TabIndex = 12;
            lblRoleId.Text = "Role ID              :";
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblNotes.Location = new Point(62, 366);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(110, 14);
            lblNotes.TabIndex = 11;
            lblNotes.Text = "Notes                :";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(173, 58);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(406, 23);
            txtUserName.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(174, 105);
            txtName.Name = "txtName";
            txtName.Size = new Size(405, 23);
            txtName.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(173, 156);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(405, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(173, 207);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(405, 23);
            txtMobile.TabIndex = 3;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(173, 363);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(406, 23);
            txtNotes.TabIndex = 6;
            // 
            // cmbDepId
            // 
            cmbDepId.FormattingEnabled = true;
            cmbDepId.Location = new Point(173, 258);
            cmbDepId.Name = "cmbDepId";
            cmbDepId.Size = new Size(405, 23);
            cmbDepId.TabIndex = 4;
            // 
            // cmbRoleId
            // 
            cmbRoleId.FormattingEnabled = true;
            cmbRoleId.Location = new Point(173, 309);
            cmbRoleId.Name = "cmbRoleId";
            cmbRoleId.Size = new Size(405, 23);
            cmbRoleId.TabIndex = 5;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnNew.Location = new Point(62, 415);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 7;
            btnNew.Text = "&New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnSave.Location = new Point(218, 415);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 8;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnDelete.Location = new Point(381, 415);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnCancel.Location = new Point(540, 415);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // FUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(685, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnNew);
            Controls.Add(cmbRoleId);
            Controls.Add(cmbDepId);
            Controls.Add(txtNotes);
            Controls.Add(txtMobile);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(txtUserName);
            Controls.Add(lblNotes);
            Controls.Add(lblRoleId);
            Controls.Add(lblDepId);
            Controls.Add(lblMobile);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Controls.Add(lblUserName);
            KeyPreview = true;
            Name = "FUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User";
            Load += FUser_Load;
            KeyDown += FUser_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserName;
        private Label lblName;
        private Label lblEmail;
        private Label lblMobile;
        private Label lblDepId;
        private Label lblRoleId;
        private Label lblNotes;
        private TextBox txtUserName;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtMobile;
        private TextBox txtNotes;
        private ComboBox cmbDepId;
        private ComboBox cmbRoleId;
        private Button btnNew;
        private Button btnSave;
        private Button btnDelete;
        private Button btnCancel;
    }
}