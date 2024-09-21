using Microsoft.EntityFrameworkCore;
using QuizAppApi.Database.Interfaces;
using QuizAppApi.Database.Models;

namespace QuizAppApi.Database.Repo
{
    public class QuestionRepository : IQuestionRepository
    {
        private QuizDbContext _context;
        public QuestionRepository(QuizDbContext context)
        {
            _context = context;
        }
        public async Task<bool> Add(Question question)
        {
            if (question == null) return false;
            await _context.Questions.AddAsync(question);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(Question question)
        {
            if (question == null) return false;
            _context.Questions.Remove(question);
            _context.SaveChanges();
            return true;
        }

        public async Task<bool> DeleteById(Guid questionId)
        {
            Question? question = await _context.Questions.FirstOrDefaultAsync(q => q.Id == questionId);
            if (question == null) return false;
            _context.Questions.Remove(question);
            _context.SaveChanges();
            return true;
        }

        public async Task<IEnumerable<Question>> GetAllByQuizId(Guid quizId)
        {
            bool quizIdIsValid = await _context.Quizes.AnyAsync(a => a.Id == quizId);
            if (!quizIdIsValid) return Enumerable.Empty<Question>();
            IEnumerable<Question> questions = _context.Questions.Where(a => a.QuizId == quizId);
            return questions;
        }

        public async Task<Question> GetByQuestionId(Guid questionId)
        {
            Question? question = await _context.Questions.FirstOrDefaultAsync(a => a.Id == questionId);
            if (question == null) throw new ArgumentNullException($"Question by id {questionId} does not exist", nameof(question));
            return question;
        }

        public async Task<bool> Update(Question question)
        {
            bool doesQuestionExist = await _context.Questions.AnyAsync(a => a.Id == question.Id);
            if (!doesQuestionExist) return false;
            _context.Questions.Update(question);
            _context.SaveChanges();
            return true;
        }
    }
}
