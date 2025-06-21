using ZTaskModels;
using ZTaskServices;



namespace ZTaskAccounts
{
    public partial class FDepartment : Form
    {
        private readonly DeptServices _deptServices = new();
        public FDepartment()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_deptServices.IsValidName(txtName.Text.Trim()))
            {
                MessageBox.Show("Please Enter UserName!");
                txtName.Focus();
                return;
            }
            try
            {
                var department = new DepartmentModel
                {
                    Name = txtName.Text.Trim(),
                    Notes = txtNotes.Text.Trim()
                };

                _deptServices.SaveDepartment(department);
                MessageBox.Show("Department Saved!");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message} Save Failed!");
            }
        }

        private void FDepartment_KeyDown(object sender, KeyEventArgs e)
        {
            Control? ctl = ActiveControl;

            if (ctl is not null)
            {
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                {
                    e.SuppressKeyPress = true;
                    SelectNextControl(ctl, true, true, true, true);
                }
                else if (e.KeyCode == Keys.Up)
                {
                    e.SuppressKeyPress = true;
                    SelectNextControl(ctl, false, true, true, true);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtNotes.Text = "";
            txtName.Focus();
        }
    }
}
