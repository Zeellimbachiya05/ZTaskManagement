using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZTaskData;
using ZTaskModels;

namespace ZTaskServices
{
    public class RoleServices
    {
        private readonly RoleData _roleData = new();
        public bool IsNameValid(string roleName)
        {
            return !string.IsNullOrWhiteSpace(roleName);
        }

        public void SaveRole(RoleModel roleModel)
        {
            _roleData.SaveRole(roleModel);
        }
    }
}
