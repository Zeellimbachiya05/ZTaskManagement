namespace ZTaskModels
{
    public class UserModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public int? DepID { get; set; }
        public int? RoleID { get; set; }
        public string Notes { get; set; }

    }
}
