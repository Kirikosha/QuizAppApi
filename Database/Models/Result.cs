namespace QuizAppApi.Database.Models {
    public class Result {
        public Guid Id { get; set; }
        public decimal ResultPercentage { get; set; }
        public int Correct { get; set; }
        public Guid QuizId { get; set; }
        public required Quiz Quiz { get; set; }
        public required User User { get;set; }
        
    }
}
