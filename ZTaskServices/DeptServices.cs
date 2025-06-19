using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZTaskModels;
using ZTaskData;

namespace ZTaskServices
{
    public class DeptServices
    {
        private readonly DepartmentData _deptData = new();
        public bool IsValidName(string deptName)
        {
            return !string.IsNullOrWhiteSpace(deptName);
        }

        public void SaveDepartment(DepartmentModel department)
        {
            _deptData.SaveDepartment(department);
        }
    }
}
