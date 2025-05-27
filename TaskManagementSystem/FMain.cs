using ZTaskAccounts;

namespace TaskManagementSystem
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FUser fUser = new()
            {
                MdiParent = this
            };
            fUser.Show();
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FDepartment fDepartment = new()
            {
                MdiParent = this
            };
            fDepartment.Show();
        }

        private void roleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRole fRole = new()
            {
                MdiParent = this
            };
            fRole.Show();
        }
    }
}
