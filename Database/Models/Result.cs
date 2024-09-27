using System.ComponentModel.DataAnnotations.Schema;

namespace QuizAppApi.Database.Models {
    public class Result {
        [Column("id")]
        public Guid Id { get; set; }
        [Column("result_percentage")]
        public decimal ResultPercentage { get; set; }
        [Column("correct_answers")]
        public int Correct { get; set; }
        [Column("quiz_id")]
        public Guid QuizId { get; set; }
        public required Quiz Quiz { get; set; }
        public required User User { get;set; }
        
    }
}
