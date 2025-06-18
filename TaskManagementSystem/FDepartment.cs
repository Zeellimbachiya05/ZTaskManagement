using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Configuration;


namespace ZTaskAccounts
{
    public partial class FDepartment : Form
    {
        public FDepartment()
        {
            InitializeComponent();
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text.Trim()))
            {
                MessageBox.Show("Please Enter UserName!");
                txtName.Focus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ZTaskConnection"].ConnectionString;

            try
            {
                using SqlConnection con = new SqlConnection(connectionString);
                {
                    var sql = $@"
INSERT INTO Departments ([DeptName],[Notes])
Values (@DeptName,@Notes);
";
                    using SqlCommand cmd = new(sql, con);
                    cmd.Parameters.AddWithValue("@DeptName", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Notes", txtNotes.Text.Trim());

                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show($"{rows} saved!");
                }
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
