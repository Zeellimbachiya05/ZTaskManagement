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
using System.Text.RegularExpressions;

namespace ZTaskAccounts
{
    public partial class FUser : Form
    {
        public FUser()
        {
            InitializeComponent();
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text.Trim()))
            {
                MessageBox.Show("Please Enter UserName!");
                txtUserName.Focus();
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
INSERT INTO Users ([UserName],[Name],[Email],[MobileNo],[DeptID],[RoleID],[Notes])
Values (@UserName, @Name, @Email, @MobileNo, @DeptID, @RoleID, @Notes);
";
                    using SqlCommand cmd = new(sql, con);
                    cmd.Parameters.AddWithValue("@UserName", txtUserName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@MobileNo", txtMobile.Text.Trim());
                    cmd.Parameters.AddWithValue("@DeptID", cmbDepId.SelectedIndex != -1 ? Convert.ToInt32(cmbDepId.SelectedValue) : DBNull.Value);
                    cmd.Parameters.AddWithValue("@RoleID", cmbRoleId.SelectedIndex != -1 ? Convert.ToInt32(cmbRoleId.SelectedValue) : DBNull.Value);
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

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string emailPattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";

            if (!Regex.IsMatch(txtEmail.Text.Trim(), emailPattern))
            {
                MessageBox.Show("Enter Valid Email!");
                txtEmail.Focus();
            }

        }

        private void txtMobile_Leave(object sender, EventArgs e)
        {
            if (!(txtMobile.Text.Trim().Length == 10 && txtMobile.Text.Trim().All(Char.IsDigit)))
            {
                MessageBox.Show("Enter only 10 digit MobileNo!");
                txtMobile.Focus();
            }
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

        }
    }
}
