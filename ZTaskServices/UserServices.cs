using System.Data;
using System.Reflection;
using System.Text.RegularExpressions;
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

        public bool IsValidEmail(string email)
        {
            if (!string.IsNullOrWhiteSpace(email))
            {
                string emailPattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";
                return Regex.IsMatch(email, emailPattern);
            }
            return true;
        }

        public bool IsValidMobile(string mobile)
        {
            if (!string.IsNullOrWhiteSpace(mobile))
                return mobile.Length == 10 && mobile.All(char.IsDigit);

            return true;
        }
    }
}
