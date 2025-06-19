using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using ZTaskModels;
using Microsoft.Data.SqlClient;
using System.Xml.Linq;

namespace ZTaskData
{
    public class RoleData
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["ZTaskConnection"].ConnectionString;
        public void SaveRole(RoleModel roleModel)
        {
            using SqlConnection con = new(_connectionString);

            var sql = $@"
INSERT INTO Roles ([RoleName],[Notes])
Values (@RoleName,@Notes);
";
            using SqlCommand cmd = new(sql, con);
            cmd.Parameters.AddWithValue("@RoleName", roleModel.Name);
            cmd.Parameters.AddWithValue("@Notes", roleModel.Notes);

            con.Open();
            int rows = cmd.ExecuteNonQuery();
        }
    }
}
