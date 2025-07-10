using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var dt = new DataTable();
            using (SqlConnection conn = new(_connectionString))
            {
                string query = $@"
SELECT ID, DeptName FROM Departments
WHERE DeptName IS NOT NULL AND LTRIM(RTRIM(DeptName)) <> ''
";
                SqlDataAdapter adapter = new(query, conn);
                adapter.Fill(dt);
            }
            return dt;
        }

        public DataTable GetUsersDt()
        {
            var dt = new DataTable();
            using (SqlConnection conn = new(_connectionString))
            {
                string query = $@"
SELECT ID, UserName, Name FROM Users
WHERE Name IS NOT NULL AND LTRIM(RTRIM(Name)) <> ''
";
                SqlDataAdapter adapter = new(query, conn);
                adapter.Fill(dt);
            }
            return dt;
        }

        public void SaveTaskInfo(TaskModel task)
        {
            using SqlConnection con = new(_connectionString);
            string sql = @"INSERT INTO Tasks (Code, Title, Description, AssignedToUser, Department, AssignedDate, DueDate,
                                              Priority, Status, RemainderDate, CompletionDate, Notes)
                               VALUES (@Code, @Title, @Description, @AssignedToUser, @Department, @AssignedDate, @DueDate,
                                              @Priority, @Status, @RemainderDate, @CompletionDate, @Notes)";

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

        public DataTable GetCodesDt()
        {
            var dt = new DataTable();
            using (SqlConnection conn = new(_connectionString))
            {
                string query = "SELECT Code FROM Tasks";
                SqlDataAdapter adapter = new(query, conn);
                adapter.Fill(dt);
            }
            return dt;
        }
    }
}
