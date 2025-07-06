namespace TaskManagementSystem
{
    partial class FMain
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
            menuStrip1 = new MenuStrip();
            masterToolStripMenuItem = new ToolStripMenuItem();
            accountToolStripMenuItem = new ToolStripMenuItem();
            departmentToolStripMenuItem = new ToolStripMenuItem();
            roleToolStripMenuItem = new ToolStripMenuItem();
            taskToolStripMenuItem = new ToolStripMenuItem();
            taskEntryToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { masterToolStripMenuItem, taskToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // masterToolStripMenuItem
            // 
            masterToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { accountToolStripMenuItem, departmentToolStripMenuItem, roleToolStripMenuItem });
            masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            masterToolStripMenuItem.Size = new Size(42, 20);
            masterToolStripMenuItem.Text = "&User";
            // 
            // accountToolStripMenuItem
            // 
            accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            accountToolStripMenuItem.Size = new Size(137, 22);
            accountToolStripMenuItem.Text = "&Account";
            accountToolStripMenuItem.Click += accountToolStripMenuItem_Click;
            // 
            // departmentToolStripMenuItem
            // 
            departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
            departmentToolStripMenuItem.Size = new Size(137, 22);
            departmentToolStripMenuItem.Text = "&Department";
            departmentToolStripMenuItem.Click += departmentToolStripMenuItem_Click;
            // 
            // roleToolStripMenuItem
            // 
            roleToolStripMenuItem.Name = "roleToolStripMenuItem";
            roleToolStripMenuItem.Size = new Size(137, 22);
            roleToolStripMenuItem.Text = "&Role";
            roleToolStripMenuItem.Click += roleToolStripMenuItem_Click;
            // 
            // taskToolStripMenuItem
            // 
            taskToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { taskEntryToolStripMenuItem });
            taskToolStripMenuItem.Name = "taskToolStripMenuItem";
            taskToolStripMenuItem.Size = new Size(41, 20);
            taskToolStripMenuItem.Text = "&Task";
            // 
            // taskEntryToolStripMenuItem
            // 
            taskEntryToolStripMenuItem.Name = "taskEntryToolStripMenuItem";
            taskEntryToolStripMenuItem.Size = new Size(180, 22);
            taskEntryToolStripMenuItem.Text = "Task &Entry";
            taskEntryToolStripMenuItem.Click += taskEntryToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(38, 20);
            exitToolStripMenuItem.Text = "&Exit";
            // 
            // FMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FMain";
            Text = "Task Manager";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem masterToolStripMenuItem;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem departmentToolStripMenuItem;
        private ToolStripMenuItem roleToolStripMenuItem;
        private ToolStripMenuItem taskToolStripMenuItem;
        private ToolStripMenuItem taskEntryToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}
