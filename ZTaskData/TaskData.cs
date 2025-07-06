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
        private DataTable _dt = new();
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["ZTaskConnection"].ConnectionString;

        public DataTable GetDepartmentsDt()
        {
            using (SqlConnection conn = new(_connectionString))
            {
                string query = "SELECT ID, DeptName FROM Departments";
                SqlDataAdapter adapter = new(query, conn);
                adapter.Fill(_dt);
            }
            return _dt;
        }

        public DataTable GetUsersDt()
        {
            using (SqlConnection conn = new(_connectionString))
            {
                string query = "SELECT ID, UserName, Name FROM Users";
                SqlDataAdapter adapter = new(query, conn);
                adapter.Fill(_dt);
            }
            return _dt;
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
            cmd.Parameters.AddWithValue("@AssignedToUser", (int?)task.AssignedToUser  == 0 ? DBNull.Value : task.AssignedToUser);
            cmd.Parameters.AddWithValue("@Department", (int?)task.Department == 0 ? DBNull.Value : task.Department);
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
            using (SqlConnection conn = new(_connectionString))
            {
                string query = "SELECT Code FROM Tasks";
                SqlDataAdapter adapter = new(query, conn);
                adapter.Fill(_dt);
            }
            return _dt;
        }
    }
}
