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
using ZTaskServices;
using ZTaskModels;

namespace ZTaskAccounts
{
    public partial class FRole : Form
    {
        private readonly RoleServices _roleServies = new();
        public FRole()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_roleServies.IsNameValid(txtName.Text.Trim()))
            {
                MessageBox.Show("Please Enter UserName!");
                txtName.Focus();
                return;
            }

            try
            {
                var roleModel = new RoleModel
                {
                    Name = txtName.Text,
                    Notes = txtNotes.Text
                };

                _roleServies.SaveRole(roleModel);
                MessageBox.Show("Role Saved!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message} Save Failed!");
            }
        }

        private void FRole_KeyDown(object sender, KeyEventArgs e)
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
