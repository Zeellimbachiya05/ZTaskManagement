using System.Data;
using ZTaskData;
using ZTaskModels;

namespace ZTaskServices
{
    public class UserServices
    {
        private readonly UserData _userData = new();

        public DataTable GetRolesDt()
        {
            return _userData.GetRolesDt();
        }

        public DataTable GetDepartmentsDt()
        {
            return _userData.GetDepartmentsDt();
        }

        public void SaveUser(UserModel user)
        {
            _userData.SaveUserInfo(user);
        }

        public bool ValidName(string userName)
        {
            return !string.IsNullOrWhiteSpace(userName);
        }
    }
}
