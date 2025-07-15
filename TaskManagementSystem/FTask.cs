using System.Data;
using ZTaskModels;
using ZTaskServices;

namespace ZTaskAccounts
{
    public partial class FTask : Form
    {
        private readonly TaskServices _taskServices = new();
        public FTask()
        {
            InitializeComponent();

            InitializeForm();
        }

        private void InitializeForm()
        {
            DelegateEventHandlers();
        }

        private void DelegateEventHandlers()
        {
            cmbCode.SelectedIndexChanged -= CmbCode_ValueSelected;
            cmbCode.SelectedIndexChanged += CmbCode_ValueSelected;
        }

        #region Event Handlers

        private void CmbCode_ValueSelected(object sender, EventArgs e)
        {
            if (IsFormLoading)
                return;

            var code = cmbCode.Text.Trim();

            if (string.IsNullOrWhiteSpace(code))
                return;

            var dt = _taskServices.GetTasks(code);

            if (dt.Rows.Count == 0)
                return;

            FillForm(dt.Rows[0]);
        }

        private void FillForm(DataRow dr)
        {
            txtTitle.Text = dr["Title"].ToString();
            rtxDescription.Text = dr["Description"].ToString();

            cmbAssignedTo.SelectedValue = dr["AssignedToUser"];
            cmbDepartment.SelectedValue = dr["Department"];
            cmbPriority.SelectedItem = Enum.Parse(typeof(TaskPriority), dr["Priority"].ToString());
            cmbStatus.SelectedItem = Enum.Parse(typeof(TaskStatus), dr["Status"].ToString());

            dtpAssignedDate.Value = Convert.ToDateTime(dr["AssignedDate"]);
            dtpDueDate.Value = Convert.ToDateTime(dr["DueDate"]);
            dtpRemainderDate.Value = Convert.ToDateTime(dr["RemainderDate"]);
            dtpCompletionDate.Value = Convert.ToDateTime(dr["CompletionDate"]);

            txtNotes.Text = dr["Notes"].ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {
                    var task = new TaskModel
                    {
                        Code = cmbCode.Text.Trim(),
                        Title = txtTitle.Text.Trim(),
                        Description = rtxDescription.Text.Trim(),
                        AssignedToUser = Convert.ToInt32(cmbAssignedTo.SelectedValue),
                        Department = Convert.ToInt32(cmbDepartment.SelectedValue),
                        AssignedDate = DateTime.Parse(dtpAssignedDate.Text),
                        DueDate = DateTime.Parse(dtpDueDate.Text),
                        Priority = cmbPriority.Text.Trim(),
                        Status = cmbStatus.Text.Trim(),
                        RemainderDate = DateTime.Parse(dtpRemainderDate.Text),
                        CompletionDate = DateTime.Parse(dtpCompletionDate.Text),
                        Notes = txtNotes.Text.Trim()
                    };
                    _taskServices.SaveTask(task);
                    MessageBox.Show("Task Saved!");
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: Save Failed! {ex.Message} ");
            }

        }

        private void FTask_KeyDown(object sender, KeyEventArgs e)
        {
            Control? ctl = ActiveControl;

            if (ctl is ComboBox cb)
            {
                if (cb.DroppedDown)
                {
                    return;
                }
            }

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

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnNew_Click(object sender, EventArgs e)
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

        bool IsFormLoading = true;
        private void FTask_Load(object sender, EventArgs e)
        {
            BindCodes();
            BindUser();
            BindDepartments();
            BindPriorityList();
            BindStatusList();

            IsFormLoading = false;
        }

        #endregion

        #region Private Members
        private void ClearForm()
        {
            cmbCode.Text = string.Empty;
            txtTitle.Text = string.Empty;
            rtxDescription.Text = string.Empty;

            cmbAssignedTo.Text = string.Empty;
            cmbDepartment.Text = string.Empty;
            dtpAssignedDate.Value = DateTime.Today;
            dtpDueDate.Value = DateTime.Today;
            cmbPriority.Text = string.Empty;
            cmbStatus.Text = string.Empty;

            dtpRemainderDate.Value = DateTime.Today;
            dtpCompletionDate.Value = DateTime.Today;
            txtNotes.Text = "";

            cmbCode.Focus();
        }

        private bool IsValid()
        {
            if (!_taskServices.IsValidData(cmbCode.Text.Trim()))
            {
                MessageBox.Show("Please Enter Code!");
                cmbCode.Focus();
                return false;
            }

            if (!_taskServices.IsValidData(txtTitle.Text.Trim()))
            {
                MessageBox.Show("Please Enter Title!");
                txtTitle.Focus();
                return false;
            }

            return true;
        }
        
        private bool IsFormDirty()
        {
            return !string.IsNullOrWhiteSpace(cmbCode.Text.Trim()) ||
                   !string.IsNullOrWhiteSpace(txtTitle.Text.Trim()) ||
                   !string.IsNullOrWhiteSpace(rtxDescription.Text.Trim()) ||
                   !string.IsNullOrWhiteSpace(cmbAssignedTo.Text.Trim()) ||
                   !string.IsNullOrWhiteSpace(cmbDepartment.Text.Trim()) ||
                   !string.IsNullOrWhiteSpace(cmbPriority.Text.Trim()) ||
                   !string.IsNullOrWhiteSpace(cmbStatus.Text.Trim()) ||
                   !string.IsNullOrWhiteSpace(txtNotes.Text.Trim());
        }

        private void BindCodes()
        {
            var dt = _taskServices.GetCodesDt();
            cmbCode.DataSource = dt;
            cmbCode.DisplayMember = "Code";
            cmbCode.ValueMember = "Code";
            cmbCode.SelectedIndex = -1;
        }

        private void BindStatusList()
        {
            cmbStatus.DataSource = Enum.GetValues(typeof(TaskStatus));
            cmbStatus.SelectedItem = TaskStatus.Pending;
        }

        private void BindPriorityList()
        {
            cmbPriority.DataSource = Enum.GetValues(typeof(TaskPriority));
            cmbPriority.SelectedItem = TaskPriority.Low;
        }

        private void BindUser()
        {
            cmbAssignedTo.DataSource = null;
            cmbAssignedTo.Items.Clear();
            var dt = _taskServices.GetUsersDt();
            cmbAssignedTo.DataSource = dt;
            cmbAssignedTo.DisplayMember = "Name";
            cmbAssignedTo.ValueMember = "ID";
            cmbAssignedTo.SelectedIndex = -1;
            cmbAssignedTo.DropDownHeight = cmbAssignedTo.ItemHeight * (cmbAssignedTo.Items.Count + 1);
        }

        private void BindDepartments()
        {
            cmbDepartment.DataSource = null;
            cmbDepartment.Items.Clear();
            var dt = _taskServices.GetDepartmentsDt();
            cmbDepartment.DataSource = dt;
            cmbDepartment.DisplayMember = "DeptName";
            cmbDepartment.ValueMember = "ID";
            cmbDepartment.SelectedIndex = -1;
            cmbDepartment.DropDownHeight = cmbDepartment.ItemHeight * (cmbDepartment.Items.Count + 1);
        }

        #endregion

        #region Enums
        public enum TaskPriority
        {
            Low,
            Medium,
            High
        }

        public enum TaskStatus
        {
            Pending,
            InProgress,
            Completed,
            OnHold,
            Cancelled
        }
        #endregion




    }
}
