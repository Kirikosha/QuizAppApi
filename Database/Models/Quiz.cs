using QuizAppApi.Database.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizAppApi.Database{
    public class Quiz {
        [Column("id")]
        public Guid Id { get; set; }
        [Column("name")]
        public required string Name { get; set; }
        [Column("creation_time")]
        public DateTime CreationTime { get; set; }
        public Result? Result { get; set; }
        public ICollection<Question> Questions { get; set; } = new List<Question>();
    }
}
