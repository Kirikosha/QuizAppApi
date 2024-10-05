using QuizAppApi.Database.Enums;
using QuizAppApi.Database.Models;

namespace QuizAppApi.Database
{
    public class DbSeeding
    {
        QuizDbContext _context;
        public DbSeeding(QuizDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            Quiz quiz = new Quiz()
            {
                Name = "some quiz 1",
                CreationTime = DateTime.Now,
                Questions = new List<Question>()
            };
            for (int i = 1; i < 5; i++)
            {
                Question question = new Question()
                {
                    Title = $"Question title {i}",
                    Type = QuestionType.Multiple,
                    Quiz = quiz,
                    Answers = new List<Answer>(),
                    QuizId = quiz.Id
                };
                for( int j = 0; j < 4; j++)
                {
                    question.Answers.Add(new Answer
                    {
                        AnswerText = $"answer {j + i}",
                        Correct = j % 2 == 0,
                        Question = question,
                        QuestionId = question.Id
                    });
                }
                quiz.Questions.Add(question);
            }
            _context.Quizes.Add(quiz);
            _context.SaveChanges();
        } 
    } 
}
