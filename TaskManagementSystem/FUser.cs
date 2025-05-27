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
    public partial class FUser : Form
    {
        public FUser()
        {
            InitializeComponent();
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text.Trim()))
                MessageBox.Show("Please Enter UserName!");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ZTaskConnection"].ConnectionString;

            try
            {
                using SqlConnection con = new SqlConnection(connectionString);
            }
            catch
            {

            }
        }
    }
}
