using QuizAppApi.Database.Models;

namespace QuizAppApi.Database{
    public class Quiz {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public DateTime CreationTime { get; set; }
        public Result? Result { get; set; }
        public ICollection<Question> Questions { get; set; } = new List<Question>();
    }
}
