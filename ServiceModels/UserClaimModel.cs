using QuizAppApi.Database.Enums;
using QuizAppApi.Database.Models;

namespace QuizAppApi.ServiceModels
{
    public class UserClaimModel
    {
        public string Email { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; }
        public Role Role { get; set; }

        public UserClaimModel(User user)
        {
            Email = user.Email;
            UserName = user.UserName ?? "DefaultUserName";
            PhoneNumber = user.PhoneNumber ?? "Phone number was not specified";
            Role = user.Role;
        }
    }
}
