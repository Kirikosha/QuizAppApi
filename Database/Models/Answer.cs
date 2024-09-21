namespace QuizAppApi.Database.Models {
    public class Answer {
        public Guid Id { get; set; }
        public required string AnswerText { get; set; }
        public bool Correct { get; set; }
        public required Guid QuestionId { get; set; }
        public required Question Question { get; set; }
    }
}
