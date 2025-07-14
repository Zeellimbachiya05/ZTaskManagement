using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using ZTaskModels;

namespace ZTaskData
{
    public class TaskData
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["ZTaskConnection"].ConnectionString;

        public DataTable GetDepartmentsDt()
        {
            var sql = $@"
SELECT ID, DeptName FROM Departments
WHERE DeptName IS NOT NULL AND LTRIM(RTRIM(DeptName)) <> ''
";
            return GetDt(sql);
        }

        public DataTable GetUsersDt()
        {
            var sql = $@"
SELECT ID, UserName, Name FROM Users
WHERE Name IS NOT NULL AND LTRIM(RTRIM(Name)) <> ''
";
            return GetDt(sql);
        }

        public void SaveTaskInfo(TaskModel task)
        {
            using SqlConnection con = new(_connectionString);

            var sql = string.Empty;
            if (IsRecordExist(task.Code))
            {
                sql = $@"
UPDATE Tasks SET 
Code = @Code,
Title = @Title,
Description = @Description,
AssignedToUser = @AssignedToUser,
Department = @Department,
AssignedDate = @AssignedDate,
DueDate = @DueDate,
Priority = @Priority,
Status = @Status,
RemainderDate = @RemainderDate,
CompletionDate = @CompletionDate,
Notes = @Notes
Where Code = '{task.Code}';

";
            }
            else
            {
                sql = $@"
    INSERT INTO Tasks (Code, Title, Description, AssignedToUser, Department, AssignedDate, DueDate,
                       Priority, Status, RemainderDate, CompletionDate, Notes)
               VALUES (@Code, @Title, @Description, @AssignedToUser, @Department, @AssignedDate, @DueDate,
                       @Priority, @Status, @RemainderDate, @CompletionDate, @Notes)";
            }
                using SqlCommand cmd = new(sql, con);
                cmd.Parameters.AddWithValue("@Code", task.Code);
                cmd.Parameters.AddWithValue("@Title", task.Title);
                cmd.Parameters.AddWithValue("@Description", (object?)task.Description ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@AssignedToUser", (int?)task.AssignedToUser  == 0 ? DBNull.Value : (int)task.AssignedToUser);
                cmd.Parameters.AddWithValue("@Department", (int?)task.Department == 0 ? DBNull.Value : (int)task.Department);
                cmd.Parameters.AddWithValue("@AssignedDate", (object?)task.AssignedDate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@DueDate", (object?)task.DueDate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Priority", (object?)task.Priority ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Status", (object?)task.Status ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@RemainderDate", (object?)task.RemainderDate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CompletionDate", (object?)task.CompletionDate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Notes", task.Notes);

                con.Open();
                cmd.ExecuteNonQuery();

        }

        private bool IsRecordExist(string code)
        {
            var sql = $@"
Select Top 1 1 From Tasks Where Code = '{code}'
";
            using SqlConnection conn = new(_connectionString);
            using SqlCommand cmd = new(sql, conn);
            conn.Open();

            return Convert.ToBoolean(cmd.ExecuteScalar());

        }

        public DataTable GetTasksCodesDt()
        {
            var sql = "SELECT Code FROM Tasks";
            return GetDt(sql);
        }

        public DataTable GetTasks(string code)
        {
            var sql = $"SELECT * FROM Tasks Where Code = '{code}'";
            return GetDt(sql);
        }

        private DataTable GetDt(string query)
        {
            var dt = new DataTable();
            using (SqlConnection conn = new(_connectionString))
            {
                SqlDataAdapter adapter = new(query, conn);
                adapter.Fill(dt);
            }

            return dt;
        }
    }
}
