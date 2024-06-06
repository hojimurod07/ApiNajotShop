using DataAccseslayer.Enums;

namespace DataAccseslayer.Entities
{
    public class User:BaseEntity
    {
        public string FullName {  get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool isVerify {  get; set; } = false;
        public Role Role { get; set; } = Role.User;


    }
}
