using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Xml.Linq;
using ZTaskModels;

namespace ZTaskData
{
    public class DepartmentData
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["ZTaskConnection"].ConnectionString;

        public void SaveDepartment(DepartmentModel department)
        {
            using SqlConnection con = new(_connectionString);

            var sql = $@"
INSERT INTO Departments ([DeptName],[Notes])
Values (@DeptName,@Notes);
";
            using SqlCommand cmd = new(sql, con);
            cmd.Parameters.AddWithValue("@DeptName", department.Name);
            cmd.Parameters.AddWithValue("@Notes", department.Notes);

            con.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
