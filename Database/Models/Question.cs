﻿using QuizAppApi.Database.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizAppApi.Database.Models {
    public class Question {
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("title")]
        public required string Title { get; set; }
        [Column("type")]
        public QuestionType Type { get; set; } 
        public required ICollection<Answer> Answers { get; set; } = new List<Answer>();
        [Column("quiz_id")]
        public required int QuizId { get; set; }
        public required Quiz Quiz { get; set; }
    }

}
