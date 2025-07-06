using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using ZTaskModels;

namespace ZTaskData
{
    public class UserData
    {
        private DataTable _dt = new();
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["ZTaskConnection"].ConnectionString;

        public DataTable GetDepartmentsDt()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT ID, DeptName FROM Departments";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(_dt);
            }
            return _dt;
        }

        public DataTable GetRolesDt()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                var sql = "SELECT ID,RoleName FROM Roles";
                var adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(_dt);
            }
            return _dt;
        }

        public void SaveUserInfo(UserModel user)
        {
            using SqlConnection con = new(_connectionString);
            string sql = @"INSERT INTO Users (UserName, Name, Email, MobileNo, DeptID, RoleID, Notes)
                       VALUES (@UserName, @Name, @Email, @MobileNo, @DeptID, @RoleID, @Notes)";

            using SqlCommand cmd = new(sql, con);
            cmd.Parameters.AddWithValue("@UserName", user.UserName);
            cmd.Parameters.AddWithValue("@Name", user.Name);
            cmd.Parameters.AddWithValue("@Email", user.Email);
            cmd.Parameters.AddWithValue("@MobileNo", user.Mobile);
            cmd.Parameters.AddWithValue("@DeptID", (object?)user.DepID ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@RoleID", (object?)user.RoleID ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Notes", user.Notes);

            con.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
