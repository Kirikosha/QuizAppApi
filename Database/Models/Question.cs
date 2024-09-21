namespace QuizAppApi.Database.Models {
    public class Question {
        public Guid Id { get; set; }
        public required string Title { get; set; }
        public QuestionType Type { get; set; } 
        public required ICollection<Answer> Answers { get; set; } = new List<Answer>();
        public required Guid QuizId { get; set; }
        public required Quiz Quiz { get; set; }
    }

    public enum QuestionType {
        Single = 0,
        Multiple = 1,
        TextInput = 2,
    }
}
