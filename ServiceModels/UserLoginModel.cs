namespace QuizAppApi.ServiceModels
{
    public class UserLoginModel
    {
        public required string EmailOrUsername { get; set; }
        public required string Password { get; set; }
        public bool IsEmail { get; set; }
        public bool RememberMe { get; set; }
    }
}
