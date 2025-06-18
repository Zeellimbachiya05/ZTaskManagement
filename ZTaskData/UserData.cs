using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using ZTaskModels;

namespace ZTaskData
{
    public class UserData
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["ZTaskConnection"].ConnectionString;

        public DataTable GetDepartmentsDt()
        {
            DataTable dt = new DataTable();
            string connectionString = ConfigurationManager.ConnectionStrings["ZTaskConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ID, DeptName FROM Departments";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            return dt;
        }

        public DataTable GetRolesDt()
        {
            var dt = new DataTable();
            string connectionString = ConfigurationManager.ConnectionStrings["ZTaskConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                var sql = "SELECT ID,RoleName FROM Roles";
                var adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(dt);
            }
            return dt;
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
