namespace QuizAppApi.Database.Models {
    public class User {
        public Guid Id { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
        public required string Email { get; set; }
        public List<Result>? Result { get; set; }

    }
}
