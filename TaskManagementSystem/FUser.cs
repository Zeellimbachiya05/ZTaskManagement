//using System.Data;
using System.Text.RegularExpressions;
using ZTaskModels;
using ZTaskServices;

namespace ZTaskAccounts
{
    public partial class FUser : Form
    {
        private readonly UserServices _userServices = new();
        public FUser()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_userServices.ValidName(txtUserName.Text.Trim()))
            {
                MessageBox.Show("Please Enter UserName!");
                txtUserName.Focus();
                return;
            }

            if (!_userServices.IsValidEmail(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Enter Valid Email!");
                txtEmail.Focus();
            }

            if (!_userServices.IsValidMobile(txtMobile.Text.Trim()))
            {
                MessageBox.Show("Enter only 10 digit MobileNo!");
                txtMobile.Focus();
            }
            try
            {
                var user = new UserModel
                {
                    UserName = txtUserName.Text.Trim(),
                    Name = txtName.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Mobile = txtMobile.Text.Trim(),
                    DepID = cmbDepId.SelectedIndex != -1 ? Convert.ToInt32(cmbDepId.SelectedValue) : (int?)null,
                    RoleID = cmbRoleId.SelectedIndex != -1 ? Convert.ToInt32(cmbRoleId.SelectedValue) : (int?)null,
                    Notes = txtNotes.Text.Trim()
                };

                _userServices.SaveUser(user);
                MessageBox.Show("User Saved!");
                ClearForm();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: Save Failed! {ex.Message} ");
            }
        }

        private void ClearForm()
        {
            txtUserName.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtMobile.Text = "";

            cmbDepId.SelectedIndex = -1;
            cmbRoleId.SelectedIndex = -1;

            txtNotes.Text = "";

            txtUserName.Focus();
        }

        private void FUser_KeyDown(object sender, KeyEventArgs e)
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
            if (IsFormDirty())
            {
                DialogResult result = MessageBox.Show("Do you want to save the current Entry?"
                                                      , "Save Confirmation"
                                                      , MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    btnSave.PerformClick();
                }
                else if (result == DialogResult.No)
                    ClearForm();
            }
            else
                ClearForm();
        }

        private bool IsFormDirty()
        {
            return !string.IsNullOrWhiteSpace(txtUserName.Text.Trim()) ||
                   !string.IsNullOrWhiteSpace(txtName.Text.Trim()) ||
                   !string.IsNullOrWhiteSpace(txtEmail.Text.Trim()) ||
                   !string.IsNullOrWhiteSpace(txtMobile.Text.Trim()) ||
                   !string.IsNullOrWhiteSpace(txtNotes.Text.Trim()) ||
                   cmbDepId.SelectedIndex != -1 ||
                   cmbRoleId.SelectedIndex != -1;
        }

        private void BindDepartments()
        {
            var dt = _userServices.GetDepartmentsDt();
            cmbDepId.DataSource = dt;
            cmbDepId.DisplayMember = "DeptName";
            cmbDepId.ValueMember = "ID";
            cmbDepId.SelectedIndex = -1;
        }

        private void BindRoles()
        {
            var dt = _userServices.GetRolesDt();
            cmbRoleId.DataSource = dt;
            cmbRoleId.DisplayMember = "RoleName";
            cmbRoleId.ValueMember = "ID";
            cmbRoleId.SelectedIndex = -1;
        }

        private void FUser_Load(object sender, EventArgs e)
        {
            BindDepartments();
            BindRoles();
        }

    }
}
