using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZTaskData;
using ZTaskModels;

namespace ZTaskServices
{
    public class TaskServices
    {
        private readonly TaskData _taskData = new();

        public DataTable GetCodesDt()
        {
            return _taskData.GetTasksCodesDt();
        }

        public DataTable GetDepartmentsDt()
        {
            return _taskData.GetDepartmentsDt();
        }

        public DataTable GetTasks()
        {
            return _taskData.GetTasks();
        }

        public DataTable GetUsersDt()
        {
            return _taskData.GetUsersDt();
        }

        public bool IsValidData(string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }

        public void SaveTask(TaskModel task)
        {
            _taskData.SaveTaskInfo(task);
        }
    }
}
