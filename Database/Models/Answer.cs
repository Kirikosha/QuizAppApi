using System.ComponentModel.DataAnnotations.Schema;

namespace QuizAppApi.Database.Models {
    public class Answer {
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("answer_text")]
        public required string AnswerText { get; set; }
        [Column("correct")]
        public bool Correct { get; set; }
        [Column("question_id")]
        public required int QuestionId { get; set; }
        public required Question Question { get; set; }
    }
}
